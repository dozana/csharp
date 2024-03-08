using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var i = 0;

            while(i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
            */


            /*
            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("@echo: " + input);
            }
            */

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@echo: " + input);
                    continue;
                }

                break;
            }
        }
    }
}
