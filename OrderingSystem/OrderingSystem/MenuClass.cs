using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class MenuClass
    {
        public static void Menu()
        {
            OrderingSystem orderingsystem = new OrderingSystem();
           // OrderingSystem orderingSystem = new OrderingSystem();
            Console.WriteLine("(1)Order (2)Checkout (3)Display Order (4)Clear Order (5)Exit");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    OrderingSystem.Order();
                    break;
                case 2:
                    OrderingSystem.Checkout();
                    break;
                case 3:
                    OrderingSystem.DisplayOrder();
                    break;
                case 4:
                    OrderingSystem.ClearOrder();
                    break;
                case 5:
                    Console.WriteLine("Are you sure you want to exit? y/n");
                    string Return = Console.ReadLine();
                    if (Return == "y")
                    {
                        Environment.Exit(0);
                        break;
                    }
                    else if (Return == "n")
                    {
                        MenuClass.Menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("*** Select from 1-5 only ***");
                        MenuClass.Menu();
                    }
                    break;
            }
            
            

            
        }
        
    }
}
    

