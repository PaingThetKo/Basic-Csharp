using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "The quick fox jumps over the lazy dog";
            bool result = message.Contains("dog");

            if (result)
            {
                Console.WriteLine("What does the fox say?");
            }

            Console.ReadLine();
        }
    }
}
