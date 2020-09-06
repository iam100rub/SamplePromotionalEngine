using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.HelperClass
{
    public class CreateOrder
    {
        public Order CreateOrders()
        {
            Order order = new Order(1, new List<Product>() { new Product("A"),  new Product("B"), new Product("C") });
            //Order order = new Order(1, new List<Product>() { new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("C") });
           // Order order = new Order(1, new List<Product>() { new Product("A"), new Product("A"), new Product("A"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("C"), new Product("D") });

            return order;

        }
    }
}
