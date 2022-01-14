using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace CloverleafTrack.Api.Models
{
    public struct Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [NotMapped] public string UrlName => $"{HttpUtility.UrlEncode(Name.ToLower())}";
    }
}