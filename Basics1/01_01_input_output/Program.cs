using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            */

            Console.WriteLine("Person Registration Form: ");

            Console.Write("Your name: ");
            string firstName = Console.ReadLine();

            Console.Write("Your surname: ");
            string lastName = Console.ReadLine();

            Console.Write("Your email: ");
            string email = Console.ReadLine();

            Console.Write("Your mobile: ");
            string mobile = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine("Your email: " + email);
            Console.WriteLine("Your mobile: " + mobile);
        }
    }
}
