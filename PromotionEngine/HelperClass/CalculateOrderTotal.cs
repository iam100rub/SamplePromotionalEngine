using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.HelperClass
{
    public class CalculateOrderTotal
    {
        public decimal CalculateTotal()
        {
            CreatePromotion objCreatePromotion = new CreatePromotion();
            decimal Total = 0;
            List<Promotion> lstPromotion = new List<Promotion>();
            lstPromotion = objCreatePromotion.CreatePromotions();
            
            CreateOrder objCreateOrder = new CreateOrder();
            Order objOrder = objCreateOrder.CreateOrders();


            foreach (Promotion promotion in lstPromotion)
            {
            checkPromotion:
                int prodInfoCount = promotion.ProductInfo.Count();
                Dictionary<string, int> appProd = new Dictionary<String, int>();
                string CheckProdId = string.Empty;
                foreach (KeyValuePair<string, int> keyValuePair in promotion.ProductInfo)
                {

                    int count = objOrder.Products.Where(x => x.Id == keyValuePair.Key).Count();
                    if (count >= keyValuePair.Value)
                    {
                        CheckProdId = keyValuePair.Key;
                        appProd.Add(keyValuePair.Key, keyValuePair.Value);
                    }
                    else
                    {
                        CheckProdId = string.Empty;
                        appProd.Clear();
                        break;
                    }
                }
                if (appProd.Count > 0)
                {
                    var prodid = string.Empty;
                    Total = Total + promotion.PromoPrice;
                    foreach (KeyValuePair<string, int> keyValuePair in appProd)
                    {
                        for (int i = 0; i < keyValuePair.Value; i++)
                        {
                            int index = objOrder.Products.FindIndex(x => x.Id == keyValuePair.Key);
                            objOrder.Products.RemoveAt(index);
                        }
                    }
                }
                if (objOrder.Products.Where(x => x.Id == CheckProdId).Count() > 0 && !string.IsNullOrEmpty(CheckProdId))
                {
                    goto checkPromotion;
                }
            }
            if (objOrder.Products.Count() > 0)
            {
                foreach (var item in objOrder.Products)
                {
                    Total = Total + item.Price;
                }
            }

            return Total;
        }
    }
}
