using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace CloverleafTrack.Api.Models
{
    public struct Season
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [NotMapped] public string UrlName => $"{HttpUtility.HtmlEncode(Name.ToLower())}";
    }
}