using System;
namespace DecoratorPatternExample.DecoratorPattern
{
    public abstract class MessageDecorator : MessageComponent
    {
        protected MessageComponent _component;

        public MessageDecorator(MessageComponent component)
        {
            _component = component;
        }

        public void SetComponent(MessageComponent component)
        {
            _component = component;
        }

        public override string SendMessage()
        {
            if (_component != null)
            {
                return _component.SendMessage();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
