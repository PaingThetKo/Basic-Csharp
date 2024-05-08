using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World!";
            string third = "Nice";
            string fourth = "to";
            string fifth = "meet";
            string sixth = "you";
            string seventh = "all!";
            Console.WriteLine("{0} {1}!", first, second);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}!", first, second, third, fourth, fifth, sixth, seventh);

            Console.ReadLine();
        }
    }
}
