using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile_FCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);
        }
    }
}
