namespace MMSS.Api.Models
{
    public class Show
    {
        public Show() { }

        public Show(int id, string title, int year, string briefing, int categoryId, int showTypeId, int platformId)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Briefing = briefing;
            this.CategoryId = categoryId;
            this.ShowTypeId = showTypeId;
            this.PlatformId = platformId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Briefing { get; set; }

        // categories
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // showtype
        public int ShowTypeId { get; set; }

        public ShowType ShowType { get; set; }

        // platforms
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}