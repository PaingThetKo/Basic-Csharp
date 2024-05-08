using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCircleArea(12);
            void PrintCircleArea(int radius)
            {
                double pi = 3.14159;
                double area = pi * (radius * radius);
                Console.WriteLine($"Area = {area}");
            } 

            Console.ReadLine();
        }
    }
}
