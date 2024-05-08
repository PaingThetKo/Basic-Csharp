using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_FCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeelvl = 200;
            string employeeName = "John Smith";

            string title = "";

            switch(employeelvl)
            {
                case 100: title = "Junior Associate";
                    break;

                case 200: title = "Senior Associate";
                    break;

                case 300: title = "Manager";
                    break;

                case 400: title = "Senior Manager";
                    break;

                default: title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName} , {title}");

            Console.ReadLine();
        }
    }
}
