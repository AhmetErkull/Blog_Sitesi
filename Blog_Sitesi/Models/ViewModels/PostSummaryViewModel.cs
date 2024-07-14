namespace Blog_Sitesi.Models.ViewModels
{
    public class PostSummaryViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> TagNames{ get; set; }
    }
}
