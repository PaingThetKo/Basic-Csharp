using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

            int studentCount = students.Length;

            Console.WriteLine("The final name is: " + students[studentCount - 1]);

            Console.ReadLine();
        }

        
    }
}
