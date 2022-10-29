using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit

            double celsius,kelvin, farenheit;

            Console.Write("Enter your amount in celsius: ");
            celsius= Convert.ToDouble(Console.ReadLine());

            kelvin = celsius + 273;
            farenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("Your amount in Kelvin is {0} and in Farenheit is {1}", kelvin, farenheit);
            
        }
    }
}
