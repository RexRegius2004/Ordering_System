using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class LoginClass
    {
        public static int attempts = 0;
        public static int pin = 1111;
        
        public static void Login()
        {
            Console.WriteLine("Welcome to Improved A&As");
            Pinum();
        }
        public static void Pinum()
        {
            Console.WriteLine("Enter your PIN:");

            int enterpin = Convert.ToInt32(Console.ReadLine());
            if (enterpin == pin)
            {
                Console.Clear();
                MenuClass menuClass = new MenuClass();
                MenuClass.Menu();

            }
            else if (attempts <= 1)
            {
                Console.WriteLine("Wrong Pin. Please try again");
                attempts++;
                Pinum();
            }
            else
            {
                Console.WriteLine("Account locked |Exiting");
                Console.WriteLine("|Press enter to exit|");
                Console.ReadLine();

            }
        }
    }
}
