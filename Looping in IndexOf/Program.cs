using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_in_IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note the overload of the Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);

                Console.ReadLine();
            }
        }
    }
}
