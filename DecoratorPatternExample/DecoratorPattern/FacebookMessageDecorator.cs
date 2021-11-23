using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public class FacebookMessageDecorator : MessageDecorator
    {
        public FacebookMessageDecorator(MessageComponent component) : base(component)
        {
        }

        public override string SendMessage()
        {
            // Do something to send the message through Facebook
            Console.WriteLine("Facebook Message Succesfully Sent");
            return $"ConcreteFacebookDecorator({base.SendMessage()})";
        }
    }
}
