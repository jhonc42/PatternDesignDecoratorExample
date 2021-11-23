using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public abstract class MessageComponent
    {
        public abstract string PathMessage { get; }

        public MessageComponent()
        {
        }
        public abstract string SendMessage();
    }
}
