using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using CloverleafTrack.Api.Models.TrackEvents;

namespace CloverleafTrack.Api.Models.Performances
{
    public class RunningRelayPerformance
    {
        public Guid Id { get; set; }
        public Time Time { get; set; }
        public bool SchoolRecord { get; set; }
        public bool SeasonBest { get; set; }
        public bool PersonalBest { get; set; }

        public Guid RunningEventId { get; set; }
        public Guid MeetId { get; set; }

        [NotMapped]
        public Time TotalTime
        {
            get
            {
                if (!RunningPerformances.Any()) return Time;

                var totalTime = new Time(0, 0);
                return RunningPerformances.Aggregate(totalTime, (current, runningPerformance) => current + runningPerformance.Time);

            }
        }

        public RunningRelayEvent RunningRelayEvent { get; set; }
        public Meet Meet { get; set; }
        public List<Athlete> Athletes { get; set; }
        public List<RunningPerformance> RunningPerformances { get; set; }
    }
}