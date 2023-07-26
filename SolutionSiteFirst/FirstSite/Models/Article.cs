namespace FirstSite.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title  { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public Article(long id, string title, string description, string img)
        {
            Id = id;
            Title = title;
            Description = description;
            Img = img;
        }
    }

}