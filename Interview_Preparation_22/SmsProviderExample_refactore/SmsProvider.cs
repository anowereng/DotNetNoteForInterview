using System;
using System.Collections.Generic;
using System.Text;

namespace SmsProviderExample_refactore
{
    internal interface SmsProvider
    {
        void SendSMS(string text, string phone);
    }
}
