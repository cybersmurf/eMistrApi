using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int? NotificationType { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Body { get; set; }
        public DateTime? TsProcessed { get; set; }
        public int? Status { get; set; }
        public string StatusText { get; set; }
        public string Subject { get; set; }
    }
}
