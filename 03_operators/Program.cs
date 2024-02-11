using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));
            */


            /*
                // ორი რიცხვის საშუალო არითმეტიკული
            
                Console.Write("Enter Number 1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int result = (n1 + n2) / 2;
                Console.WriteLine("Result is: " + result);
            */

            try
            {
                Console.Write("Enter Number 1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 3: ");
                int n3 = Convert.ToInt32(Console.ReadLine());

                int addition = n1 + n2 + n3;
                int subraction = n1 - n2 - n3;
                int multiplication = n1 * n2 * n3;

                Console.WriteLine("n1 + n2 + n3 = " + addition);
                Console.WriteLine("n1 - n2 - n3 = " + subraction);
                Console.WriteLine("n1 * n2 * n3 = " + multiplication);

            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong.");
            }




        }
    }
}
