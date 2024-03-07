namespace Nest_AspNet.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public IFormFile File { get; set; }
    }
}
