using System.Collections.Generic;
namespace MMSS.Api.Models
{
    public class ShowType
    {
        public ShowType() { }

        public ShowType(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Show> Shows { get; set; }

    }
}