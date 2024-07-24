using Blog_Sitesi.Models.Entities;

namespace Blog_Sitesi.Models.ViewModels
{
    public class CommentCountViewModel
    {
        public List<Comment> Comments{ get; set; }
        public int Count{ get; set; }
    }
}
