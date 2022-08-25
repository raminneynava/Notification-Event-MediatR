using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

using Notification_Event_MediatR.Event;

namespace Notification_Event_MediatR.Handlers
{
    public class SendEmail : INotificationHandler<MessageNotification>
    {
        public  Task Handle(MessageNotification notification, CancellationToken cancellationToken)
        {
            // EmailAddress = notification.Email
            // Message = notification.Message
            // SendEmail();
            Console.WriteLine($"Send Email To: {notification.Email}");
           return Task.CompletedTask;
        }
    }
}
