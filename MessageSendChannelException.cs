using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nx.Message
{
    public class MessageSendChannelException : Exception
    {
        public MessageSendChannelException(int errorCode, string message, Exception innerException = null)
            : base(message, innerException)
        {
            this.ErrorCode = errorCode;
        }
        public int ErrorCode { get; set; }
    }
}
