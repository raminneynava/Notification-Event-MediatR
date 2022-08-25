using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace Notification_Event_MediatR.Event
{
    public class MessageNotification:INotification
    {
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
