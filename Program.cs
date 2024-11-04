using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System;

namespace CCAD16_Assignment1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple console application and store your name, age (should take decimal), and address in a string variable.
            //Print out each one
            //Prompt the user each time to enter name, age and address.
           
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name + "!. You are " + age + " years old, and your address is " + address);

            //Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.


            //Write a C# Sharp program to print the sum of two numbers.
            
            //Console.WriteLine("Please choose two numbers");
            //double num1 = Convert.ToInt32(Console.ReadLine());
            //double num2 = Convert.ToInt32(Console.ReadLine());

            //double sum = Convert.ToInt32(num1 + num2);
            //Console.WriteLine("The sum of your two numbers is " + sum);

            //Write a C# Sharp program to print the result of dividing two numbers.
            //Console.WriteLine("Please choose two numbers");
            //double num1 = Convert.ToInt32(Console.ReadLine());
            //double num2 = Convert.ToInt32(Console.ReadLine());

            //double diff = Convert.ToInt32(num1 / num2);
            //Console.WriteLine("The sum of your two numbers is " + diff);
        }
    }
}
