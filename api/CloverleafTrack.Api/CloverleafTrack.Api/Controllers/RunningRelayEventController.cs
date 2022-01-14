using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Models;
using CloverleafTrack.Api.Models.TrackEvents;

using Microsoft.AspNetCore.Mvc;

namespace CloverleafTrack.Api.Controllers
{
    [Route("api/events/running/relay")]
    [ApiController]
    public class RunningRelayEventController : ControllerBase
    {
        private readonly RunningRelayEventManager manager;

        public RunningRelayEventController(RunningRelayEventManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IEnumerable<RunningRelayEvent>> GetAllAsync()
        {
            return await manager.GetAllAsync();
        }

        [HttpGet("{gender}")]
        public async Task<IEnumerable<RunningRelayEvent>> GetAllForGenderAsync(Gender gender)
        {
            return await manager.GetAllForGenderAsync(gender);
        }

        [HttpPost]
        public async Task CreateAsync(EventDto runningRelayEvent)
        {
            await manager.CreateAsync(runningRelayEvent);
        }
    }
}
