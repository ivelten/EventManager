using System;
using EventManager.Domain;
using EventManager.Web.Api.Models;
using EventManager.Web.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;

        public EventsController(IEventService eventService, IMapper mapper)
        {
            _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public ActionResult<GetEventModel> Get(int id)
        {
            var evt = _eventService.Retrieve(id);

            if (evt == null)
                return NotFound();

            return _mapper.Map<Event, GetEventModel>(evt);
        }

        [HttpPost]
        public ActionResult Register([FromBody] RegisterEventModel model)
        {
            var evt = _mapper.Map<RegisterEventModel, Event>(model);

            _eventService.Create(evt);

            return Ok();
        }

        [HttpPost("{eventId}")]
        public ActionResult Subscribe(int eventId, [FromBody] EventSubscriptionModel model)
        {
            // O ideal aqui é verificar se existem tanto o evento quanto o subscriber na base
            // e retornar BadRequest explicando caso um dos dois não exista
            _eventService.Subscribe(model.SubscriberId, eventId);

            return Ok();
        }
    }
}
