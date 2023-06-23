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
       public static int[] OrderQuantity;
        public static int[] Prices = {55, 55, 30, 65};
        MenuClass menuClass = new MenuClass();
        
        public static void Order()
        {
            
            OrderItems = new Stack<string>();
            Console.WriteLine("(1)Spagett - 55 (2)Carbanara - 55 (3)Baget - 30 (4)Borgor Stek - 65 (5)Menu");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Quantity: ");
                    LoginClass.quantity = Convert.ToInt32(Console.ReadLine());
                    OrderItems.Push("Spagett");
                    Console.WriteLine("Spagett is added to the order.");
                    OrderQuantity[0] += LoginClass.quantity;
                    Order();
                    break;
                case 2:
                    Console.WriteLine("Quantity: ");
                    LoginClass.quantity = Convert.ToInt32(Console.ReadLine());
                    OrderItems.Push("Carbanarra");
                    Console.WriteLine("Carbanarra is added to the order.");
                    OrderQuantity[1] += LoginClass.quantity;
                    Order();
                    break;
                case 3:
                    Console.WriteLine("Quantity: ");
                    LoginClass.quantity = Convert.ToInt32(Console.ReadLine());
                    OrderItems.Push("Baget");
                    Console.WriteLine("Baget is added to the order.");
                    OrderQuantity[2] += LoginClass.quantity;
                    Order();
                    break;
                case 4:
                    Console.WriteLine("Quantity: ");
                    LoginClass.quantity = Convert.ToInt32(Console.ReadLine());
                    OrderItems.Push("Borgor Stek");
                    Console.WriteLine("Borgor Stek is added to the order.");
                    OrderQuantity[3] += LoginClass.quantity;
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
                OrderItems.Clear();
                Array.Clear(OrderQuantity, 0, OrderQuantity.Length);
                OrderNumberClass orderNumberClass = new OrderNumberClass();
                OrderNumberClass.generateOrderNo();
                Console.WriteLine("Press Enter to continue");
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
                Array.Clear(OrderQuantity, 0, OrderQuantity.Length);
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
