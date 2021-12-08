using System.Collections.Generic;

namespace MMSS.Api.Models
{
    public class Category
    {
        public Category() { }

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<ShowCategory> ShowsCategories { get; set; }
    }
}