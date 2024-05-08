using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Exchange_USD2VND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdAmount = 23.73; // Renamed the variable to usdAmount
            int vndValue = UsdToVnd(usdAmount);

            int UsdToVnd(double usd) // Updated the parameter name to usd
            {
                int rate = 23500;
                return (int)(rate * usd);
            }

            double VndToUsd(int vnd) // Updated the parameter name to vnd
            {
                double rate = 23500;
                return vnd / rate;
            }

            Console.ReadLine();
        }
    }
}