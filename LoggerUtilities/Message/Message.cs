using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Message
{
    public enum MessageType
    {
        MessageType_Info = 0,
        MessageType_Warning = 1,
        MessageType_Error = 2,
        MessageType_Positive = 3,
        MessageType_Unset = 4,
    }

    public class Message : IMessage
    {
        public string MessageTXT { get; set; }
        public DateTime MessageMoment { get; set; }

        private string _application = "";
        public string Application
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_application.Trim())) return StaticMessageUtilities.ApplicationName;
                } catch { return StaticMessageUtilities.ApplicationName; }

                return _application;
            }

            set { _application = value; }
        }
        public MessageType MessageType { get; private set; }

        public Message(string txt, MessageType type, DateTime moment)
        {
            MessageTXT = txt;
            MessageMoment = moment;
            MessageType = type;
        }

        public Message(string originalMsg)
        {
            DecodeMessage(originalMsg);
        }

        public string PrepareMessage()
        {
            string msg = MessageTXT;
            msg = msg.PadRight(1000);

            string moment = MessageMoment.ToString().PadRight(100);
            string application = StaticMessageUtilities.ApplicationName.PadRight(100);

            return "//M" + (int)(MessageType) + msg + moment + application;
        }

        public void DecodeMessage(string msg)
        {
            msg = msg.Remove(0, 3);

            string messageType = msg.Substring(0, 1);
            string message = msg.Substring(1, 1000);
            string moment = msg.Substring(1000, 100);
            string application = msg.Substring(1100, 100).Trim();

            MessageTXT = message.Trim();
            MessageMoment = DateTime.Parse(moment);
            MessageType = (MessageType)Enum.Parse(typeof(MessageType), messageType);
            Application = application;
        }

        public override string ToString()
        {
            string type = "";
            switch (MessageType)
            {
                case MessageType.MessageType_Info: type = "INFO"; break;
                case MessageType.MessageType_Error: type = "ERROR"; break;
                case MessageType.MessageType_Warning: type = "WARNING"; break;
                case MessageType.MessageType_Positive: type = "OK"; break;
            }

            return "[" + Application + " - " + MessageMoment.ToString() + "] " + type + " -> " + MessageTXT;
        }

        #region Static Methods

        /// <summary>
        /// Position of string = type as int
        /// </summary>
        public static string[] GetMessagesTypesAsStrings()
        {
            return new string[] { "Info", "Warning", "Errors", "Positive", "All" };
        }

        #endregion

    }
}
