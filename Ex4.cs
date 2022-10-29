using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to swap two numbers

            int firstNum, secondNum, temp;

            Console.Write("Enter the first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("The first number is {0} and the second number is {1}", firstNum, secondNum);

        }
    }
}
