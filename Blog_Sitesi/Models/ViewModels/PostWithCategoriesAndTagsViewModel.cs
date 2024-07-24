using Blog_Sitesi.Models.Entities;

namespace Blog_Sitesi.Models.ViewModels
{
    public class PostWithCategoriesAndTagsViewModel
    {
        public int PostId { get; set; }
        public string CategoryName { get; set; }
        public List<string> TagNames { get; set; }
    }
}
