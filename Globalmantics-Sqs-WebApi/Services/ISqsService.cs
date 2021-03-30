using System.Threading.Tasks;
using Amazon.SQS.Model;
using Globalmantics_Sqs_WebApi.Models;

namespace Globalmantics_Sqs_WebApi.Services
{
    public interface ISqsService
    {
        Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request);
    }
}