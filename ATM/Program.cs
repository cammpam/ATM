using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Welcome to My Personal ATM.");
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");

            EnterPin();
            MainMenu();
            Console.Read();
        }
        static void EnterPin()
        {
            
            Console.WriteLine("Enter 4 digit Pin: ");
            string pin = Console.ReadLine();
            if (pin.ToCharArray().Length == 4)
            {

                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                EnterPin();
            }
        }
        static void MainMenu() 
        {
            Console.WriteLine("Make a Selection.");
            Console.WriteLine("1 - View Balance");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("You made it here.");
                Console.Read();
            }
        }
    }
}
