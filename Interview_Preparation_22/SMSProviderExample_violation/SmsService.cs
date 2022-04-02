using System;
using System.Collections.Generic;
using System.Text;

namespace SMSProviderExample_violation
{
    public class BLSmsService: BLProvider
    {
        public void SendSMS(string text, string number)
        {
            Console.WriteLine("============ SMS Provider GP ================");
            Console.WriteLine($"SMS Text : {text}");
            Console.WriteLine($"SMS Number : {number}");
            Console.WriteLine("============ SMS Provider Done ================");
        }
    }
}
