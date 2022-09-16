using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Logger
{
    public class DebugLogger : ILogger
    {
        public List<Message.Message> Messages { get; set; }
        public List<Message.MessageType> TypesToLog { get; set; }

        public DebugLogger()
        {
            Messages = new List<Message.Message>();

            TypesToLog = new List<Message.MessageType>();
            TypesToLog.Add(Message.MessageType.MessageType_Error);
        }

        public void Use()
        {
            if (!(TypesToLog.Contains(Messages[Messages.Count - 1].MessageType))) return;

            Debug.WriteLine(Messages[Messages.Count - 1].ToString());
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
