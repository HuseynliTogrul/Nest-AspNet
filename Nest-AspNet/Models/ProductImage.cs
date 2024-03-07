using System.ComponentModel.DataAnnotations.Schema;

namespace Nest_AspNet.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } = null!;
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
