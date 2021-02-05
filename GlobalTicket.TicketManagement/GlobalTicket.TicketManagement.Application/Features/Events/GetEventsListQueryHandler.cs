using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistance;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVM>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            this._mapper = mapper;
            this._eventRepository = eventRepository;

        }
        public async Task<List<EventListVM>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(e => e.Date);
            return this._mapper.Map<List<EventListVM>>(allEvents);
        }
    }
}
