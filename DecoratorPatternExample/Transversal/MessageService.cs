using System;
using DecoratorPatternExample.DecoratorPattern;

namespace DecoratorPatternExample.Transversal
{
    // At the begining this class didn't inherit from MessageComponent, this happened after when there was the need to extend functionalities.
    // This class was the first service that only let users to send Messages through email, then users needed to send message through other services like SMS, Slack, etc.
    public class MessageService
    {
        public MessageService()
        {
        }

        public string SendMessage(MessageComponent component)
        {
            // In order to extend the functionality, this function about send email was turned into a new decorator class apart.
            // And now, this method recieve a MessageComponent decorated or no, but with the functionalities that the client needs.

            // Do work to send the message to email
            //return "Email Message Succesfully Sent";

            return "Result: " + component.SendMessage();
        }
    }
}
