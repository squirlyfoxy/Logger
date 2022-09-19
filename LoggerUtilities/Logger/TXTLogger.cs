using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Logger
{
    public class TXTLogger : ILogger
    {
        public List<Message.Message> Messages { get; set; }
        public List<Message.MessageType> TypesToLog { get; set; }
        public string FilePath { get; private set; }

        public TXTLogger()
        {
            TypesToLog = new List<Message.MessageType>();

            // Log everything
            TypesToLog.Add(Message.MessageType.MessageType_Info);
            TypesToLog.Add(Message.MessageType.MessageType_Warning);
            TypesToLog.Add(Message.MessageType.MessageType_Error);
            TypesToLog.Add(Message.MessageType.MessageType_Positive);
        }

        public TXTLogger(string file, List<Message.Message> msgs) : this()
        {
            Messages = msgs;
            FilePath = file;
        }

        public TXTLogger(string file) : this()
        {
            Messages = new List<Message.Message>();
            FilePath = file;
        }

        public void Use()
        {
            Save(GetLogsAsStringArray());
        }

        public void Save(string[] logs)
        {
            File.Create(FilePath).Close();

            File.WriteAllLines(FilePath, logs);
        }

        public void Decode(string[] logs)
        {
            Messages = new List<Message.Message>();

            // TODO
        }

        public string[] GetLogsAsStringArray()
        {
            string[] toReturn = new string[Messages.Count];

            for (int i = 0; i < toReturn.Length; i++)
            {
                if (!(TypesToLog.Contains(Messages[i].MessageType))) continue;

                toReturn[i] = Messages[i].ToString();
            }

            return toReturn;
        }

        #region Unused

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Decode(string logs)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public string GetLogsAsString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Save(string logs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
