using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_type_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */

            /*
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);
            */

            /*
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
            */

            /*
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            */


            /*
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            */


            /*
            string str = "5";
            int parseStr = int.Parse(str);
            int convertedStr = Convert.ToInt32(str);

            Console.WriteLine(parseStr);
            Console.WriteLine(convertedStr);
            */


            /*
            string str = "5";

            try
            {
                int parsedStr = int.Parse(str);
                Console.WriteLine("Succesfull Parse");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unseccesfull Parse");
            }
            */



            /* */
            // TryParse exeption-ის ნაცვლად აბრუნებს 0

            string str = "dsafasd1";
            int a;

            bool isParsed = int.TryParse(str, out a);

            Console.WriteLine(a);
           


        }
    }
}
