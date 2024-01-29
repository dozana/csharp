using _04_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04_classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Introduce();

            var calculator = new Calculator();
            var addition = calculator.Add(5, 10);
            var subtraction = calculator.Subtract(10, 5);
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
        }
    }
}
