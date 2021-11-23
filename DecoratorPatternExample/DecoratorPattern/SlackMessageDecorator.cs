using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public class SlackMessageDecorator : MessageDecorator
    {
        public SlackMessageDecorator(MessageComponent component) : base(component)
        {
        }

        public override string PathMessage => _component.PathMessage + " SlackPath";

        public override string SendMessage()
        {
            // Do something to send the message through Slack
            Console.WriteLine("Slack Message Succesfully Sent");
            return $"ConcreteSlackDecorator({base.SendMessage()})";
        }
    }
}
