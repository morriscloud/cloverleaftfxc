using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using CloverleafTrack.Api.Models.TrackEvents;

namespace CloverleafTrack.Api.Models.Performances
{
    public class FieldRelayPerformance
    {
        public Guid Id { get; set; }
        public Distance Distance { get; set; }
        public bool SchoolRecord { get; set; }
        public bool SeasonBest { get; set; }
        public bool PersonalBest { get; set; }

        public Guid RunningEventId { get; set; }
        public Guid MeetId { get; set; }

        [NotMapped]
        public Distance TotalDistance
        {
            get
            {
                if (!FieldPerformances.Any()) return Distance;

                var totalDistance = new Distance(0, 0);
                return FieldPerformances.Aggregate(totalDistance, (current, fieldPerformance) => current + fieldPerformance.Distance);

            }
        }

        public FieldRelayEvent FieldRelayEvent { get; set; }
        public Meet Meet { get; set; }
        public List<Athlete> Athletes { get; set; }
        public List<FieldPerformance> FieldPerformances { get; set; }
    }
}