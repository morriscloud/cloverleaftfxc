using System;
using System.Collections.Generic;
using System.Web;

using CloverleafTrack.Api.Models.Performances;

using Dapper.Contrib.Extensions;

namespace CloverleafTrack.Api.Models.TrackEvents
{
    public class FieldEvent
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int SortOrder { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        [Write(false)]
        public string DisplayName => Gender == Gender.Female ? $"Girls {Name}" : $"Boys {Name}";
        [Write(false)]
        public string UrlName => Gender == Gender.Female ? $"girls-{HttpUtility.UrlEncode(Name.Replace(" ", "-").ToLower())}" : $"boys-{HttpUtility.UrlEncode(Name.Replace(" ", "-").ToLower())}";

        [Write(false)]
        public List<FieldPerformance> Performances { get; set; }
    }
}