using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Logger
{
    public interface ILogger
    {
        /// <summary>
        /// The messages of the logger
        /// </summary>
        List<Message.Message> Messages { get; set; }

        /// <summary>
        /// Types of logs to process
        /// </summary>
        List<Message.MessageType> TypesToLog { get; set; }

        /// <summary>
        /// Called by the client every time we need to log something new.
        /// </summary>
        void Use();

        /// <summary>
        /// Save the logs
        /// </summary>
        void Save(string[] logs);

        /// <summary>
        /// Save the logs
        /// </summary>
        void Save(string logs);

        /// <summary>
        /// Returns the logs prepared to be saved.
        /// </summary>
        /// <returns>Every index of returned array is a log.</returns>
        string[] GetLogsAsStringArray();

        /// <summary>
        /// Returns the logs prepared to be saved. Separated by \n
        /// </summary>
        string GetLogsAsString();

        /// <summary>
        /// Decode an array of logs.
        /// </summary>
        void Decode(string[] logs);

        /// <summary>
        /// Decode the log.
        /// </summary>
        void Decode(string logs);
    }
}
