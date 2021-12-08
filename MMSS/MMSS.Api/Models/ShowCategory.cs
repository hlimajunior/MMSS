using System.Collections.Generic;

namespace MMSS.Api.Models
{
    public class ShowCategory
    {
        public ShowCategory() { }
        public ShowCategory(int showId, int categoryId)
        {
            this.ShowId = showId;
            this.CategoryId = categoryId;
        }

        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}