using System.Collections.Generic;

namespace MMSS.Api.Models
{
    public class PlatformShow
    {
        public PlatformShow() { }

        public PlatformShow(int showId, string platformId)
        {
            this.ShowId = showId;
            this.PlatformId = platformId;
        }

        public int ShowId { get; set; }
        public Show Show { get; set; }
        public string PlatformId { get; set; }
        public Platform Platform { get; set; }

   }
}