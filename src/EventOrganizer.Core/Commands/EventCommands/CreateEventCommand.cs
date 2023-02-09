﻿using AutoMapper;
using EventOrganizer.Core.DTO;
using EventOrganizer.Core.Repositories;
using EventOrganizer.Domain.Models;

namespace EventOrganizer.Core.Commands.EventCommands
{
    public class CreateEventCommand : ICommand<CreateEventCommandParameters, EventDetailDTO>
    {
        private readonly IEventRepository eventRepository;

        public readonly IMapper mapper;

        public CreateEventCommand(IEventRepository eventRepository, IMapper mapper)
        {
            this.eventRepository = eventRepository
                ?? throw new ArgumentNullException(nameof(eventRepository));
            this.mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public EventDetailDTO Execute(CreateEventCommandParameters parameters)
        {
            if (parameters == null) throw new ArgumentNullException(nameof(parameters));

            var eventModel = mapper.Map<EventModel>(parameters.EventDetailDTO);

            var result = eventRepository.Create(eventModel);

            return mapper.Map<EventDetailDTO>(result);
        }
    }
}
