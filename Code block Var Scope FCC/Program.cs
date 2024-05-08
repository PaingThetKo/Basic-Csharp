﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_block_Var_Scope_FCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = { 4, 8, 15, 16, 23, 42 };
            foreach (int number in numbers)
            {
                int total;

                total += number;

                if (number == 42)
                {
                    bool found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Set contains 42");
            }
            Console.WriteLine($"Total: {total}"); */

            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers) 
            { 
                total += number;
                if (number == 42)
                {
                    found = true;
                }

            }
            if (found) 
            {
                Console.WriteLine("Set Contain 42");
            }

            Console.WriteLine($"Total :  {total}");

            Console.ReadLine();
        }
    }
}
