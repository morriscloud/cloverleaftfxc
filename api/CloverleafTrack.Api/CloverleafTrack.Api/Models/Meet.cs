using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using CloverleafTrack.Api.Models.Performances;

namespace CloverleafTrack.Api.Models
{
    public struct Meet
    {
        public Guid Id { get; set; }
        [DataType(DataType.Date)] public DateTime Date { get; set; }
        public string Name { get; set; }
        public MeetType MeetType { get; set; }
        public bool Complete { get; set; }
        public bool HandTimed { get; set; }


        public Guid LocationId { get; set; }
        public Guid SeasonId { get; set; }

        public Location Location { get; set; }
        public Season Season { get; set; }
        public List<RunningPerformance> RunningPerformances { get; set; }
        public List<FieldPerformance> FieldPerformances { get; set; }
        public List<RunningRelayPerformance> RunningRelayPerformances { get; set; }
        public List<FieldRelayPerformance> FieldRelayPerformances { get; set; }
    }
}