using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Models;

namespace CloverleafTrack.Api.Managers
{
    public class LeaderboardManager
    {
        private readonly RunningEventManager runningEventManager;
        private readonly RunningRelayEventManager runningRelayEventManager;
        private readonly FieldEventManager fieldEventManager;
        private readonly FieldRelayEventManager fieldRelayEventManager;

        public LeaderboardManager(RunningEventManager runningEventManager, RunningRelayEventManager runningRelayEventManager, FieldEventManager fieldEventManager, FieldRelayEventManager fieldRelayEventManager)
        {
            this.runningEventManager = runningEventManager;
            this.runningRelayEventManager = runningRelayEventManager;
            this.fieldEventManager = fieldEventManager;
            this.fieldRelayEventManager = fieldRelayEventManager;
        }

        public async Task<LeaderboardDto> GetForGenderAsync(Gender gender)
        {
            var runningEvents = await runningEventManager.GetAllForGenderAsync(gender);
            var runningRelayEvents = await runningRelayEventManager.GetAllForGenderAsync(gender);
            var fieldEvents = await fieldEventManager.GetAllForGenderAsync(gender);
            var fieldRelayEvents = await fieldRelayEventManager.GetAllForGenderAsync(gender);

            var runningPerformances = new List<PerformanceDto>();
            var runningRelayPerformances = new List<RelayPerformanceDto>();
            var fieldPerformances = new List<PerformanceDto>();
            var fieldRelayPerformances = new List<RelayPerformanceDto>();

            foreach (var runningEvent in runningEvents)
            {
            }

            foreach (var runningRelayEvent in runningRelayEvents)
            {
            }

            foreach (var fieldEvent in fieldEvents)
            {
            }

            foreach (var fieldRelayEvent in fieldRelayEvents)
            {
            }

            var dto = new LeaderboardDto
            {
                RunningPerformances = runningPerformances,
                RunningRelayPerformances = runningRelayPerformances,
                FieldPerformances = fieldPerformances,
                FieldRelayPerformances = fieldRelayPerformances
            };

            return dto;
        }
    }
}
