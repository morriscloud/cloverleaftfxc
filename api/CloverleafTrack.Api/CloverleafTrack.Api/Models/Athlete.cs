using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace CloverleafTrack.Api.Models
{
    public struct Athlete
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int GraduationYear { get; set; }

        [NotMapped] public string DisplayName => $"{FirstName} {LastName}";
        [NotMapped] public string UrlName => $"{HttpUtility.UrlEncode(FirstName.ToLower())}-{HttpUtility.UrlEncode(LastName.ToLower())}";
    }
}