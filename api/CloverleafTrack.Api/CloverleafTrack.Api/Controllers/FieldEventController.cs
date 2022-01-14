using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Models;
using CloverleafTrack.Api.Models.TrackEvents;

using Microsoft.AspNetCore.Mvc;

namespace CloverleafTrack.Api.Controllers
{
    [Route("api/events/field")]
    [ApiController]
    public class FieldEventController : ControllerBase
    {
        private readonly FieldEventManager manager;

        public FieldEventController(FieldEventManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IEnumerable<FieldEvent>> GetAllAsync()
        {
            return await manager.GetAllAsync();
        }

        [HttpGet("{gender}")]
        public async Task<IEnumerable<FieldEvent>> GetAllForGenderAsync(Gender gender)
        {
            return await manager.GetAllForGenderAsync(gender);
        }

        [HttpPost]
        public async Task CreateAsync(EventDto fieldEvent)
        {
            await manager.CreateAsync(fieldEvent);
        }
    }
}
