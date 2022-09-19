using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Logger
{
    public class ConsoleLogger : ILogger
    {
        public List<Message.Message> Messages { get; set; }
        public List<Message.MessageType> TypesToLog { get; set; }

        public ConsoleLogger()
        {
            Messages = new List<Message.Message>();

            TypesToLog = new List<Message.MessageType>();
            TypesToLog.Add(Message.MessageType.MessageType_Info);
            TypesToLog.Add(Message.MessageType.MessageType_Warning);
            TypesToLog.Add(Message.MessageType.MessageType_Error);
            TypesToLog.Add(Message.MessageType.MessageType_Fatal);
            TypesToLog.Add(Message.MessageType.MessageType_Positive);
        }

        public void Use()
        {
            if (!(TypesToLog.Contains(Messages[Messages.Count - 1].MessageType))) return;

            Console.ResetColor();
            switch (Messages[Messages.Count - 1].MessageType)
            {
                case Message.MessageType.MessageType_Warning: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case Message.MessageType.MessageType_Error: Console.ForegroundColor = ConsoleColor.Red; break;
                case Message.MessageType.MessageType_Fatal: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case Message.MessageType.MessageType_Positive: Console.ForegroundColor = ConsoleColor.Green; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            Console.WriteLine(Messages[Messages.Count - 1].ToString());
        }

        #region Unused

        public void Decode(string[] logs)
        {
            throw new NotImplementedException();
        }

        public void Decode(string logs)
        {
            throw new NotImplementedException();
        }

        public string GetLogsAsString()
        {
            throw new NotImplementedException();
        }

        public string[] GetLogsAsStringArray()
        {
            throw new NotImplementedException();
        }

        public void Save(string[] logs)
        {
            throw new NotImplementedException();
        }

        public void Save(string logs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
