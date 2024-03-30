using Nest_AspNet.Models;
using P237_Nest.Models;

namespace Nest_AspNet.ViewModels
{
    public class ProductVm
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
