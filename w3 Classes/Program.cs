using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_Classes
{
    class Car
    {
        public string model = "Mustang";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);

            Console.ReadLine();
        }

        
    }

    
}
