using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Promotion
    {
        public int PromotionID { get; set; }
        public Dictionary<string, int> ProductInfo { get; set; }
        public decimal PromoPrice { get; set; }

        public Promotion(int promotionId, Dictionary<string, int> productInfo, decimal promoPrice)
        {
            this.PromotionID = promotionId;
            this.ProductInfo = productInfo;
            this.PromoPrice = promoPrice;
        }
    }
}
