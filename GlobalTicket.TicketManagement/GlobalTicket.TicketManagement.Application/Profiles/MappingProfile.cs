using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Events;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVM>().ReverseMap();
        }
    }
}
