using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Message
    {
        public Message()
        {
            MessageEmployees = new HashSet<MessageEmployee>();
        }

        public Guid MessageId { get; set; }
        public int StoreId { get; set; }
        public string MessageName { get; set; } = null!;
        public bool IsRepetitive { get; set; }
        public bool ShowAtClockIn { get; set; }
        public bool ShowAtSignOn { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; } = null!;
        public DateTime MessageStartDate { get; set; }
        public int EmployeeCount { get; set; }
        public bool SendTextEmail { get; set; }
        public bool TextEmailSent { get; set; }

        public virtual ICollection<MessageEmployee> MessageEmployees { get; set; }
    }
}
