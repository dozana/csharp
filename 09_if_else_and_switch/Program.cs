using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_if_else_and_switch
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            /*
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 0 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }
            */


            /*
            bool isGoldCustomer = true;
            float price;

            if(isGoldCustomer)
            {
                price = 19.96f;
            }
            else
            {
                price = 29.95f;
            }
            */

            /*
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
            */


            /*
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("We've got promotion.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
            */



            /*
                Task 1: Write a program and ask the user to enter a number. 
                The number should be between 1 to 10. If the user enters 
                a valid number, display "Valid" on the console. Otherwise, 
                display "Invalid". (This logic is used a lot in applications 
                where values entered into input boxes need to be validated.)
             */
            /*
            Console.WriteLine("Enter a number. between 1 to 10 ");

            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);


            if(number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            */



            /*
                Task 2: Write a program which takes two numbers from the 
                console and displays the maximum of the two.
            */

            /*
            Console.Write("Enter Number1: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number2: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
            */




            /*
                Task 3: Write a program and ask the user to enter the 
                width and height of an image. Then tell if the image is landscape or portrait.
            */
            /*
            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
            */



            /*
                Your job is to write a program for a speed camera. For simplicity, ignore the details 
                such as camera, sensors, etc and focus purely on the logic. Write a program that asks 
                the user to enter the speed limit. Once set, the program asks for the speed of a car. 

                If the user enters a value less than the speed limit, program should display Ok on the 
                console. 
            
                If the value is above the speed limit, the program should calculate the number 
                of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be 
                incurred and displayed on the console. If the number of demerit points is above 12, 
                the program should display License Suspended.
             */

            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

                if(demeritPoints > 12)
                {
                    Console.WriteLine("License suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
            }

        }
    }
}
