using SMSProviderExample_refactore;

namespace SmsProviderExample_refactore
{
    internal class Program
    {
        private static string smsText = "Hello anower , You'r Order complete !!";
        private static string phoneNo = "01822339363";
        static void Main(string[] args)
        {
            SmsProvider smsProvider = new BLSmsService();
            smsProvider.SendSMS(smsText, phoneNo);
        }
    }
}
