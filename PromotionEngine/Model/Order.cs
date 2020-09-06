using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Product> Products { get; set; }
        public Order(int orderId, List<Product> products)
        {
            this.OrderID = orderId;
            this.Products = products;
        }
    }
}
