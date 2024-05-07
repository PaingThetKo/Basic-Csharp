using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ    ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);


            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            string firstName1 = "John";
            string lastName1 = "Doe";
            string name1 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name1);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            string myString1 = "Hello";
            Console.WriteLine(myString1.IndexOf("e"));  // Outputs "1"


            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);

            int myAge1 = 25;
            int votingAge1 = 18;

            if (myAge1 >= votingAge1)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            Console.ReadLine();
        }
    }
}
