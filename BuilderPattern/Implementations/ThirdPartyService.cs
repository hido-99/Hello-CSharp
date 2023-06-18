using BuilderPattern.Contracts;
using System;

namespace BuilderPattern.Implementations
{
    class ThirdPartyService : INotificationBuilder
    {
        public void SendEmail()
        {
            Console.WriteLine("Email sent through third party service.");
        }

        public void SendSms()
        {
            Console.WriteLine("SMS sent through third party service.");
        }
    }
}
