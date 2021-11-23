using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorPatternExample.DecoratorPattern;
using DecoratorPatternExample.Models;
using DecoratorPatternExample.Transversal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPatternExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageService _serviceMessage;

        public MessageController(MessageService ServiceMessage)
        {
            _serviceMessage = ServiceMessage;
        }

        [HttpPost]
        public ActionResult Post(RequestObject request)
        {
            MessageComponent sendEmail = new EmailMessageDecorator();
            //sendEmail.SendMessage();
            sendEmail = new SMSMessageDecorator(sendEmail);
            //sendEmail.SendMessage();
            //sendEmail = new SlackMessageDecorator(sendEmail);
            sendEmail = new FacebookMessageDecorator(sendEmail);

            var result = sendEmail.SendMessage();
            return Ok(result);
        }
    }
}