using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public class SMSMessageDecorator : MessageDecorator
    {
        public SMSMessageDecorator(MessageComponent component) : base(component)
        {
        }

        public override string PathMessage => _component.PathMessage + " SMSPath";

        public override string SendMessage()
        {
            // Do something to send the message trhough SMS
            Console.WriteLine("SMS Message Succesfully Sent");
            return $"ConcreteSMSDecorator({base.SendMessage()})";
        }
    }
}
