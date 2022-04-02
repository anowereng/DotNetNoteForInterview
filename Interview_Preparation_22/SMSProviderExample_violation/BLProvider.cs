namespace SMSProviderExample_violation
{
    public interface BLProvider
    {
        void SendSMS(string text, string number);
    }
}