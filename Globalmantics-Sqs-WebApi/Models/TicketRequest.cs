using System;
using System.Text.Json;

namespace Globalmantics_Sqs_WebApi.Models
{
    public class TicketRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public string Serialize(TicketRequest value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(value, options);
        }
    }
}