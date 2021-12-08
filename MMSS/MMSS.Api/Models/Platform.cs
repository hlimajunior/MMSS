using System.Collections.Generic;

namespace MMSS.Api.Models
{
    public class Platform
    {
        public Platform() { }
        public Platform(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<PlatformShow> PlatformsShows { get; set; }
    }
}