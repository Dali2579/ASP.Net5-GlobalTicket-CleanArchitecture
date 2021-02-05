using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    class GetEventsListQuery:IRequest<List<EventListVM>>
    {
    }
}
