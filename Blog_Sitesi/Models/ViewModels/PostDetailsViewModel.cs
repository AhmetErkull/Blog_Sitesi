namespace Blog_Sitesi.Models.ViewModels
{
    public class PostDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<string> TagNames { get; set; }
    }
}
