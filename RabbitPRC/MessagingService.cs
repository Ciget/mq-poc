using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabbitPRC
{
    public class MessagingService
    {
        public MessageResponse Execute()
        {
            return null;
        }
    }

    public class MessageResponse
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
    }
}