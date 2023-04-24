using Microsoft.AspNetCore.Mvc;
using RabbitMqApp.Business;

namespace RabbitMqApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RabbitMqController : ControllerBase
    {
        private readonly IRabbitMqOperation _rabbitMqOperation;
        public RabbitMqController(IRabbitMqOperation rabbitMqOperation)
        {
            _rabbitMqOperation = rabbitMqOperation;
        }

        [HttpPost(Name = "SendQueueToMessage")]
        public IActionResult SendMessageToQueue(string message)
        {
            _rabbitMqOperation.SendMessageToQueue(message);

            return Ok();
        }

        [HttpGet(Name = "GetMessage")]
        public IActionResult GetMessage()
        {
            string retVal = _rabbitMqOperation.GetMessage();

            return Ok(retVal);
        }
    }
}