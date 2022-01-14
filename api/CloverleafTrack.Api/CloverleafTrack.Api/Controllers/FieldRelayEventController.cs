using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Models;
using CloverleafTrack.Api.Models.TrackEvents;

using Microsoft.AspNetCore.Mvc;

namespace CloverleafTrack.Api.Controllers
{
    [Route("api/events/field/relay")]
    [ApiController]
    public class FieldRelayEventController : ControllerBase
    {
        private readonly FieldRelayEventManager manager;

        public FieldRelayEventController(FieldRelayEventManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IEnumerable<FieldRelayEvent>> GetAllAsync()
        {
            return await manager.GetAllAsync();
        }

        [HttpGet("{gender}")]
        public async Task<IEnumerable<FieldRelayEvent>> GetAllForGenderAsync(Gender gender)
        {
            return await manager.GetAllForGenderAsync(gender);
        }

        [HttpPost]
        public async Task CreateAsync(EventDto fieldRelayEvent)
        {
            await manager.CreateAsync(fieldRelayEvent);
        }
    }
}
