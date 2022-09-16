using System;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace LoggerUtilities
{
    public class LoggerServer
    {
        private UdpClient _listener;
        public UdpClient Listener { get { return _listener; } set { _listener = value; } }

        private bool Running { get; set; }
        private Thread ServerThread { get; set; }

        private List<Message.Message> Messages { get; set; }

        public LoggerServer(int port)
        {
            Listener = new UdpClient(port, AddressFamily.InterNetwork);
            Messages = new List<Message.Message>();
        }

        public void Run()
        {
            Running = true;

            ServerThread = new Thread(RunThread);
            ServerThread.Start();
        }

        public void Close()
        {
            Running = false;

            Listener.Close();
        }

        private void RunThread()
        {
            if (Listener == null) return;

            string data = null;
            byte[] buffer = new byte[2048];
            while (Running)
            {
                try
                {
                    int i = 0;
                    try
                    {
                        IPEndPoint end = null;
                        buffer = Listener.Receive(ref end);

                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                    } catch { }

                    if (data != null)
                    {
                        lock (Messages)
                        {

                            if (data.StartsWith("REM"))
                            {
                                string applicationName = data.Remove(0, 3);
                                /*
                                List<Message.Message> msgBackup = Messages;
                                foreach (Message.Message m in Messages)
                                {
                                    if (m.Application == applicationName)
                                    {
                                        msgBackup.Remove(m);
                                    }
                                }
                                Messages = msgBackup;*/
                            }
                            else
                            {
                                Messages.Add(new Message.Message(data));
                            }
                        }

                    }
                } catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        public List<Message.Message> GetMessages()
        {
            List<Message.Message> toret;
            lock (Messages)
            {
                toret = Messages;
            }

            return toret;
        }
    }
}