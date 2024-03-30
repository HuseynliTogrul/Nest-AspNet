namespace Nest_AspNet.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ProductSize> ProductSize { get; set; }
        public Size()
        {
            ProductSize = new HashSet<ProductSize>();
        }
    }
}
