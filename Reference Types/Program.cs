using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");

            Console.ReadLine();
        }
    }
}
