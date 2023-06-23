using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class OrderNumberClass
    {
        public static object randomNumber;

        public static void OrderNumber()
        {
            generateOrderNo();
            Console.ReadKey();
        }

        public static void generateOrderNo()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 100);
            Console.WriteLine("Order Number:" + randomNumber);

        }


    }
}

