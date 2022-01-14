using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace CloverleafTrack.Api.Controllers
{
    [Route("api/leaderboard")]
    [ApiController]
    public class LeaderboardController : ControllerBase
    {
        private readonly LeaderboardManager manager;

        public LeaderboardController(LeaderboardManager manager)
        {
            this.manager = manager;
        }

        [HttpGet("{gender}")]
        public async Task<LeaderboardDto> GetForGenderAsync(Gender gender)
        {
            return await manager.GetForGenderAsync(gender);
        }
    }
}
