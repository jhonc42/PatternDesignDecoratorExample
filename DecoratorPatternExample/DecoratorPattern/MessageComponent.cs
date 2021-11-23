using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public abstract class MessageComponent
    {
        public MessageComponent()
        {
        }
        public abstract string SendMessage();
    }
}
