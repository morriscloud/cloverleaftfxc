
using CloverleafTrack.Api.Models;

namespace CloverleafTrack.Api.Dtos
{
    public class EventDto
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int? SortOrder { get; set; }
        public string UrlName { get; set; }
    }
}
