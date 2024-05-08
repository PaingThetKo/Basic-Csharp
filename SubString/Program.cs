using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);
            openingPosition += 1;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            Console.ReadLine();




        }
    }
}
