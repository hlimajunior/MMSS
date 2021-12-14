using System.Collections.Generic;

namespace MMSS.Api.Models
{
    public class PlatformShow
    {
        public PlatformShow() { }

        public PlatformShow(int showId, int platformId)
        {
            this.ShowId = showId;
            this.PlatformId = platformId;
        }

        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }

   }
}