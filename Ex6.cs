using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user

            int num1, num2, add, subtract, multiply, divide;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            subtract = num1 - num2;
            multiply = num1 * num2;
            divide = num1 / num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, add);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, subtract);
            Console.WriteLine("{0} * {1} = {2} ",num1, num2, multiply);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, divide);

        }
    }
}
