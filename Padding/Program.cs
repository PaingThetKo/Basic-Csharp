using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));


            string paymentId = "769C";
            var formattedLine = paymentId.PadRight(6);
            Console.WriteLine(formattedLine);


            string M_paymentId = "769C";
            string M_payeeName = "Mr. Stephen Ortega";
            var FormatLine = M_paymentId.PadRight(6);
            FormatLine += M_payeeName.PadRight(24);
            Console.WriteLine(FormatLine);

            string S_paymentId = "769C";
            string S_payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";
            var S_formattedLine = S_paymentId.PadRight(6);
            S_formattedLine += S_payeeName.PadRight(24);
            S_formattedLine += paymentAmount.PadLeft(10);
            Console.WriteLine(S_formattedLine);




            //To the sales and marketing company's newest investment products
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);


            Console.ReadLine();
        }
    }
}
