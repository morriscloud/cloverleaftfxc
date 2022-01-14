using System;

using CloverleafTrack.Api.Models.TrackEvents;

namespace CloverleafTrack.Api.Models.Performances
{
    public class RunningPerformance
    {
        public Guid Id { get; set; }
        public Time Time { get; set; }
        public bool SchoolRecord { get; set; }
        public bool SeasonBest { get; set; }
        public bool PersonalBest { get; set; }

        public Guid FieldEventId { get; set; }
        public Guid AthleteId { get; set; }
        public Guid MeetId { get; set; }
        public Guid RunningRelayPerformanceId { get; set; }

        public RunningEvent RunningEvent { get; set; }
        public Athlete Athlete { get; set; }
        public Meet Meet { get; set; }
        public RunningRelayPerformance RunningRelayPerformance { get; set; }
    }
}