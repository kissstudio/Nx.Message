﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nx.Message
{
    public interface IEmailSendChannel : IMessageChannel
    {
        void SendEmail(string mailTo, string subject, string content);
        void SendEmail(IEnumerable<string> mailTo, string subject, string content);
    }
}
