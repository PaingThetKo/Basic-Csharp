using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:  ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string ageiput = Console.ReadLine();
            int age = Convert.ToInt32(ageiput);
            Console.WriteLine(username + " is " + age + " years old.");

            Console.ReadLine();
        }
    }
}
