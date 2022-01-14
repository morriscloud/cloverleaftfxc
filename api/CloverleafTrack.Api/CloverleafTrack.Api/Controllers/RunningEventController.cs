using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Models;
using CloverleafTrack.Api.Models.TrackEvents;

using Microsoft.AspNetCore.Mvc;

namespace CloverleafTrack.Api.Controllers
{
    [Route("api/events/running")]
    [ApiController]
    public class RunningEventController : ControllerBase
    {
        private readonly RunningEventManager manager;

        public RunningEventController(RunningEventManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IEnumerable<RunningEvent>> GetAllAsync()
        {
            return await manager.GetAllAsync();
        }

        [HttpGet("{gender}")]
        public async Task<IEnumerable<RunningEvent>> GetAllForGenderAsync(Gender gender)
        {
            return await manager.GetAllForGenderAsync(gender);
        }

        [HttpPost]
        public async Task CreateAsync(EventDto runningEvent)
        {
            await manager.CreateAsync(runningEvent);
        }
    }
}
