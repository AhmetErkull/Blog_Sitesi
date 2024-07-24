namespace Blog_Sitesi.Models.Entities
{
	public class Category
	{
        public int CategoryId { get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
