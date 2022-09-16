using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtilities.Message
{
    public interface IMessage
    {
        /// <summary>
        /// Prepare the message to be sent, returns the message prepared
        /// </summary>
        string PrepareMessage();

        /// <summary>
        /// Decode a message and initialize the caller class with message parameters
        /// </summary>
        void DecodeMessage(string msg);
    }
}
