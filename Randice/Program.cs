﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll); */


            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (total > 15)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
                
                

            Console.ReadLine();

        }

    }
}