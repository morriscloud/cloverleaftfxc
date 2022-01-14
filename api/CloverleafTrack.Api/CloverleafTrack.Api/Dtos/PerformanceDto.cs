namespace CloverleafTrack.Api.Dtos
{
    public class PerformanceDto
    {
        public EventDto Event { get; set; }
        public AthleteDto Athlete { get; set; }
        public string FormattedPerformance { get; set; }
        public string Date { get; set; }
        public bool SchoolRecord { get; set; }
        public bool SeasonBest { get; set; }
        public bool PersonalBest { get; set; }
        public int SortOrder { get; set; }
    }
}
