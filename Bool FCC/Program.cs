using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_FCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                Console.WriteLine($"Inside the code block: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");

            Console.ReadLine();

        }
    }
}
