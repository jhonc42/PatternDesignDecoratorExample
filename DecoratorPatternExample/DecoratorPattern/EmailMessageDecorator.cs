using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public class EmailMessageDecorator : MessageComponent
    {
        public EmailMessageDecorator()
        {
        }

        public override string SendMessage()
        {
            // Do something to send the message through Email
            Console.WriteLine("Email Message Succesfully Sent");
            return "Email Message Component";
        }
    }
}
