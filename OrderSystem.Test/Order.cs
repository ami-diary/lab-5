using System.Collections.Generic;
using System.Linq;

namespace OrderSystem
{
    public class Order
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            return Products.Sum(p => p.Price);
        }
    }
}
