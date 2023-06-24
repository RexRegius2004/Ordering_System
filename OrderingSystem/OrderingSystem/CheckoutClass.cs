using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class CheckoutClass
    {
        public static int TotalPrice;
        public static int Change;
        public static int i;
        
        public static void Checkout()
        {
            Console.Clear();
            Console.WriteLine("------------Receipt-----------");            
            Console.WriteLine("Order:");
            int[] PriceArray = OrderingSystem.Price.ToArray();
            
            foreach (string item in OrderingSystem.OrderItems)
            {
                Console.Write($"{item} {PriceArray[i]}");
                Console.WriteLine("");
                i++;
            }

            foreach (int item in OrderingSystem.Price)
            {
                TotalPrice += item;
            }
            Console.WriteLine($"\nThe Total Price is {TotalPrice}");
            Console.WriteLine("Please Enter Payment: ");
            int Payment = Convert.ToInt32(Console.ReadLine());
            Change = Payment-TotalPrice ;
            Console.WriteLine($"Your Change is Php {Change}");
            ReferenceNumberClass referenceNumberClass = new ReferenceNumberClass();
            ReferenceNumberClass.generateRefNo();
            DateClass dateClass = new DateClass();
            DateClass.Date_Time();
            Console.WriteLine("----------THANK YOU---------");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
           

    }
}
