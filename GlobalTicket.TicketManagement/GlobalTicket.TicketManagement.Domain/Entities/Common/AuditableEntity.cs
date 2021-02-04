using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Domain.Entities.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedby { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
