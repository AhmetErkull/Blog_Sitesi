namespace Blog_Sitesi.Models.Entities
{
    public class Image
    {
        public int ImageId { get; set; }

        public int PostId { get; set; }
        public string Url { get; set; }
        public Post Post{ get; set; }
    }
}
