using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program that takes a number as input and print its multiplication table.

            int t, resultOne, resultTwo, resultThree;

            Console.Write("Enter your number: ");
            t = Convert.ToInt32(Console.ReadLine());

            resultOne= t * 1;
            resultTwo = t * 2;
            resultThree = t * 3;

            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
            Console.WriteLine(resultThree);


        }
    }
}
