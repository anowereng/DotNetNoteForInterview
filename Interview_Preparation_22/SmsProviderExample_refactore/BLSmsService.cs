using SmsProviderExample_refactore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMSProviderExample_refactore
{
    public class BLSmsService: SmsProvider
    {
        public void SendSMS(string text , string number)
        {
            Console.WriteLine("============ SMS Provider BL ================");  
            Console.WriteLine($"SMS Text : {text}");
            Console.WriteLine($"SMS Number : {number}");
            Console.WriteLine("============ SMS Provider Done ================");
        }
    }
}
