using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
     class OrderingSystem
    {
        public static Stack<string> OrderItems = new Stack<string>();
        public static List<int> Price = new List<int>();
        MenuClass menuClass = new MenuClass();
        
        public static void Order()
        {
            Console.WriteLine("(1)Spagett - 55 (2)Carbanara - 55 (3)Baget - 30 (4)Borgor Stek - 65 (5)Menu");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    OrderItems.Push("Spagett");
                    Console.WriteLine("Spagett is added to the order.");
                    Price.Add(55);                   
                    Order();
                    break;
                case 2:
                    Console.Clear();
                    OrderItems.Push("Carbanarra");
                    Console.WriteLine("Carbanarra is added to the order.");
                    Price.Add(55);
                    Order();
                    break;
                case 3:
                    Console.Clear();
                    OrderItems.Push("Baget");
                    Console.WriteLine("Baget is added to the order.");
                    Price.Add(30);
                    Order();
                    break;
                case 4:
                    Console.Clear();
                    OrderItems.Push("Borgor Stek");
                    Console.WriteLine("Borgor Stek is added to the order.");
                    Price.Add(65);
                    Order();
                    break;
                case 5:
                    Console.Clear();
                    MenuClass menuClass = new MenuClass();
                    MenuClass.Menu(); 
                    break; 

            }
        }
        
        
        public static void Checkout()
        {
            Console.WriteLine("Are you sure you want to Checkout? y/n");
            string Return = Console.ReadLine();
            if (Return == "y")
            {                
                OrderNumberClass orderNumberClass = new OrderNumberClass();
                OrderNumberClass.generateOrderNo();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                CheckoutClass.Checkout();
            }
            else if (Return == "n")
            {
                MenuClass.Menu();
            }
            else 
            {
                Checkout();
            }
            CheckoutClass checkoutClass = new CheckoutClass();
            CheckoutClass.Checkout();
         
        }

        public static void DisplayOrder()
        {
            Console.Clear();
            Console.WriteLine("Order:");
            foreach (string item in OrderItems)
            {

                Console.WriteLine($"Item: {item}");

            }
            MenuClass.Menu();
        }

        public static void ClearOrder()
        {
            Console.WriteLine("Are you sure you want to clear order? y/n");
            string Return = Console.ReadLine();
            if (Return == "y")
            {
                OrderItems.Clear();
                CheckoutClass.TotalPrice = 0;
                Console.WriteLine("Order cleared \nPress Enter to continue");
                Console.ReadLine();
                MenuClass.Menu();
            }
            else if (Return == "n")
            {
                MenuClass.Menu();
            }
            else
            {
                ClearOrder();
            } 
                

        }
    } 
}
