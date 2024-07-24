namespace Blog_Sitesi.Models.Entities
{
	public class Post
	{
        public int PostId { get; set; }
		public int UserId { get; set; }
		public int CategoryId { get; set; }
		public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public int ViewCount { get; set; }

        public Category Category{ get; set; }
        public User User { get; set; } 
        public ICollection<Comment> Comments{ get; set; } = new List<Comment>();
		public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

        public ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
