using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print Hello and your name in a separate line.
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello");
            Console.WriteLine("{0}",name);
            
        }
    }
}
