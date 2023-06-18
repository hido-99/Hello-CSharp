namespace BuilderPattern.Contracts
{
    interface INotificationBuilder
    {
        void SendEmail();
        void SendSms();
    }
}
