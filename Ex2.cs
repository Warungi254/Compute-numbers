using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the sum of two numbers
            int num1, num2, sum;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The sume of {0} and {1} is {2}", num1, num2, sum);
            
        }
    }
}
