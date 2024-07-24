namespace Blog_Sitesi.Models.ViewModels
{
    public class PostsWithImageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
