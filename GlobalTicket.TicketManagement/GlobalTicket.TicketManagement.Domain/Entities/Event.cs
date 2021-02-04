﻿using GlobalTicket.TicketManagement.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EneventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
