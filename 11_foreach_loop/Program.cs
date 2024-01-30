using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "John Doe";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("------");

            // Rewrite above loop
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("------");

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------");

            var j = 0;

            while (j < 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }


        }
    }
}
