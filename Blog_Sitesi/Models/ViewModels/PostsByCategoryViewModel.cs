namespace Blog_Sitesi.Models.ViewModels
{
    public class PostsByCategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> TagNames { get; set; }
    }
}
