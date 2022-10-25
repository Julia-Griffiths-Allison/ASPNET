using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
