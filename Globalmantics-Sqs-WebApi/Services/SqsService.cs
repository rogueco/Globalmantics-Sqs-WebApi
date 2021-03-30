using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;
using Globalmantics_Sqs_WebApi.Models;

namespace Globalmantics_Sqs_WebApi.Services
{
    public class SqsService : ISqsService
    {
        private readonly IAmazonSQS _amazonSqsClient;

        public SqsService(IAmazonSQS amazonSqsClient)
        {
            _amazonSqsClient = amazonSqsClient;
        }

        public async Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request)
        {
            SendMessageRequest sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = "https://sqs.eu-west-1.amazonaws.com/891123523376/TicketRequest",
                MessageBody = request.Serialize(request)
            };
            return await _amazonSqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}