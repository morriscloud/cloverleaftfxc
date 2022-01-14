using System.Collections.Generic;

namespace CloverleafTrack.Api.Dtos
{
    public class RelayPerformanceDto
    {
        public EventDto Event { get; set; }
        public List<AthleteDto> Athletes { get; set; } = new();
        public string FormattedPerformance { get; set; }
        public string Date { get; set; }
        public bool SchoolRecord { get; set; }
        public bool SeasonBest { get; set; }
        public bool PersonalBest { get; set; }
        public int SortOrder { get; set; }
    }
}
