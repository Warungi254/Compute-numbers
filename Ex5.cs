using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user

            int num1, num2, num3, product;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            product = num1 * num2 * num3;

            Console.WriteLine("The multiplication of the three numbers is {0}", product);

            
        }
    }
}
