using PromotionEngine.HelperClass;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class PromotionEngine
    {
        static void Main(string[] args)
        {
		//calculate total based on order detail, go to create order class to change the order scenario
            CalculateOrderTotal objCalculateOrderTotal = new CalculateOrderTotal();
            decimal total = objCalculateOrderTotal.CalculateTotal();
            //total amount after applying promotion
            Console.WriteLine("Total = " + total);
            Console.ReadKey();
        }
    }
    
   
    
    
   
    
}
