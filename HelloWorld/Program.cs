using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);

            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");

            // This is a comment line.
            Console.WriteLine("this is a line");
            /* Console.Write("Hello World! ");
            Console.Write("I will print on the same line."); */

            string name = "John";
            Console.WriteLine(name);

            int myNum = 15;
            Console.WriteLine(myNum);

            int myNum1 = 15;
            myNum1 = 20; // myNum is now 20
            Console.WriteLine(myNum1);

            const int v = 21; // const use to store the same values as always 
            // v = 22;
            Console.WriteLine(v);

            string aname = "John";
            Console.WriteLine("Hello " + aname);

            string firstname = "Paing";
            string lastname = "Thet Ko";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            int x = 1;
            int y = 2;
            Console.WriteLine(x+y);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9


            int myInt1 = 10;
            double myDouble1 = 5.25;
            bool myBool1 = true;

            Console.WriteLine(Convert.ToString(myInt1));



            Console.ReadLine();
        }
    }
}
