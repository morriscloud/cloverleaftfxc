using System.Collections.Generic;

namespace CloverleafTrack.Api.Dtos
{
    public class LeaderboardDto
    {
        public IEnumerable<PerformanceDto> RunningPerformances { get; set; }
        public IEnumerable<RelayPerformanceDto> RunningRelayPerformances { get; set; }
        public IEnumerable<PerformanceDto> FieldPerformances { get; set; }
        public IEnumerable<RelayPerformanceDto> FieldRelayPerformances { get; set; }
    }
}
