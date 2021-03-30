using System.Threading.Tasks;
using Amazon.SQS.Model;
using Globalmantics_Sqs_WebApi.Models;
using Globalmantics_Sqs_WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Globalmantics_Sqs_WebApi.Controllers
{
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly ISqsService _sqsService;

        public QueueController(ISqsService sqsService)
        {
            _sqsService = sqsService;
        }

        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(TicketRequest request)
        {
            SendMessageResponse response = await _sqsService.SendMessageToSqsQueue(request);
            if (response == null)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}