namespace Blog_Sitesi.Models.Entities
{
	public class Tag
	{
        public int TagId { get; set; }
        public string TagName { get; set; }



        public ICollection<PostTag> Posts { get; set; } =  new List<PostTag>();
    }
}
