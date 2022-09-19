using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using LoggerUtilities.Logger;

namespace LoggerUtilities
{
    public class LoggerClient
    {
        public string Application { get; private set; }
        public ILogger[] Loggers { get; private set; }

        private UdpClient Client { get; set; }
        private System.Threading.Semaphore SendSemaphore { get; set; }
        private System.Threading.Semaphore Semaphore { get; set; }

        private System.Threading.Semaphore LoggerSemaphore { get; set; }
        private System.Threading.Semaphore LoggerSemaphore2 { get; set; }

        public LoggerClient(string application, string hostname, int port, ILogger[] loggers = null)
        {
            Client = new UdpClient(hostname, port);
            Application = application;
            Message.StaticMessageUtilities.ApplicationName = application;

            SendSemaphore = new System.Threading.Semaphore(1, 1);
            Semaphore = new System.Threading.Semaphore(1, 1);

            LoggerSemaphore = new System.Threading.Semaphore(1, 1);
            LoggerSemaphore2 = new System.Threading.Semaphore(1, 1);

            Loggers = loggers;
        }

        public void SendInfo(string msg)
        {
            Send(new Message.Message(
                msg, Message.MessageType.MessageType_Info, DateTime.Now
                ));
        }

        public void SendWarning(string msg)
        {
            Send(new Message.Message(
                msg, Message.MessageType.MessageType_Warning, DateTime.Now
                ));
        }

        public void SendError(string msg)
        {
            Send(new Message.Message(
                msg, Message.MessageType.MessageType_Error, DateTime.Now
                ));
        }

        public void SendFatal()
        {
            StackTrace trace = new StackTrace(true);
            Send(new Message.Message(trace.GetFrame(trace.GetFrames().Length - 1).ToString(), Message.MessageType.MessageType_Fatal, DateTime.Now
                ));
        }

        public void SendFatal(string msg)
        {
            StackTrace trace = new StackTrace(true);
            Send(new Message.Message(trace.GetFrame(trace.GetFrames().Length - 1).ToString() + "\nMESSAGE: " + msg, Message.MessageType.MessageType_Fatal, DateTime.Now
                ));
        }

        public void SendPositive(string msg)
        {
            Send(new Message.Message(
                msg, Message.MessageType.MessageType_Positive, DateTime.Now
                ));
        }

        private void Send(string msg)
        {
            byte[] dataToSend = Encoding.ASCII.GetBytes(msg);
            Client.SendAsync(dataToSend, dataToSend.Length);
        }

        public void Send(Message.Message message)
        {
            Semaphore.WaitOne();
            SendSemaphore.WaitOne();

            Send(message.PrepareMessage());

            // Call every logger in a different thread
            Thread thread = new Thread(() =>
            {
                LoggerSemaphore.WaitOne();
                LoggerSemaphore2.WaitOne();

                if (Loggers != null)
                {
                    foreach (var logger in Loggers)
                    {
                        logger.Messages.Add(message);

                        logger.Use();
                    }
                }

                LoggerSemaphore.Release();
                LoggerSemaphore2.Release();
            });
            thread.Start();

            SendSemaphore.Release();
            Semaphore.Release();
        }

        public void Close()
        {
            Send("REM" + Application);

            Client.Close();
        }
    }
}
