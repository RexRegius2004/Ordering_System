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
        public static void Checkout()
        {
            Console.WriteLine("------------Receipt-----------");
            Console.Clear();
            Console.WriteLine("Order:");
            foreach (string item in OrderingSystem.OrderItems)
            {
                Console.Write($"{item}  ");
            }
            foreach (int item in OrderingSystem.OrderQuantity)
            {
                Console.Write($"{item}  ");
            }
            for (int i = 0; i == 3; i++)
            {
                Console.Write($"{OrderingSystem.OrderQuantity[i]*OrderingSystem.Prices[i]}  ");
                TotalPrice += OrderingSystem.OrderQuantity[i] * OrderingSystem.Prices[i];
            }
            Console.WriteLine($"The Total price is {TotalPrice}");
            int Payment = Convert.ToInt32(Console.ReadLine());
            Change = TotalPrice - Payment;
            ReferenceNumberClass referenceNumberClass = new ReferenceNumberClass();
            ReferenceNumberClass.generateRefNo();
            DateClass dateClass = new DateClass();
            DateClass.Date_Time();


            //Console.WriteLine(/*call USER ORDER*/ + /*call ITEM PRICE*/ + /*call MULTIPLIER*/);//list of user order + stated price + how many was ordered ny the customer
            // Console.WriteLine(/*Your total is: */ + /*item Total*/);//total amount to be payed
            //Console.WriteLine(/*call PAYMENT*/);//amount given by user 
            // Console.WriteLine(/*call CHANGE*/ ); //change(total price - amount given by user)
            // Console.WriteLine(/*call REFERENCE*/);
            //Console.WriteLine(/*call DATE*/ );
            Console.WriteLine("----------THANK YOU---------");
    
        }
           

    }
}
