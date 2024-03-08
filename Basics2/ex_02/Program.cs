using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Note: for all these exercises, ignore input validation unless otherwise directed. 
                Assume the user enters a value in the format that the program expects. For example, 
                if the program expects the user to enter a number, don't worry about validating if 
                the input is a number or not. When testing your program, simply enter a number.
            */

            /*
                1) Write a program to count how many numbers between 1 and 100 are divisible by 3 with 
                no remainder. Display the count on the console.
            */

            /*
            var count = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
            */



            /*
                2) Write a program and continuously ask the user to enter a number or "ok" to exit. 
                Calculate the sum of all the previously entered numbers and display it on the console.
             */


            /*
            int sum = 0;

            while (true)
            {
                Console.Write("Write a number: ");

                string input = Console.ReadLine();
                
                if(input.ToLower() == "ok")
                {
                    break;
                }

                int number = Convert.ToInt32(input);

                sum += number;

                Console.WriteLine(sum);
            }
            */

            /*
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);

                Console.WriteLine("Sum of all numbers is: " + sum);
            }
            */






            /*
                3) Write a program and ask the user to enter a number. Compute the factorial of the 
                number and print it on the console. For example, if the user enters 5, the program 
                should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */

            /*
            Console.Write("Enter a number: ");

            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (var i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
            */


            /*
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1); ;
            }

            long result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
            */



            /*
                4)

                Write a program that picks a random number between 1 and 10. Give the user 4 chances 
                to guess the number. If the user guesses the number, display “You won"; otherwise, 
                display “You lost". (To make sure the program is behaving correctly, you can display 
                the secret number on the console first.)
             */

            /*
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is: " + number);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Gues the secret number: ");

                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
            */


            /*
            var number = new Random().Next(1, 10);
            Console.WriteLine("Secret is " + number);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
            */




            /*
                5) Write a program and ask the user to enter a series of numbers separated by comma. 
                Find the maximum of the numbers and display it on the console. For example, if the 
                user enters “5, 3, 8, 1, 4", the program should display 8.
             */
            Console.WriteLine("Enter comma separated numbers: ");

            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);

                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max is " + max);

        }
    }
}
