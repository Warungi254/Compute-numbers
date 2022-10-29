using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z

            int num1, num2, num3;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output of (x+y).z is {0} and the output for x.y + y.z is {1}",((num1 + num2)*num3), ((num1*num2) + (num2*num3)) );
        }
    }
}
