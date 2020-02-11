using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    static class Calculator
    {
        public static double CalculateMoney()
        {
            int fifty = 0;
            int one = 0;
            int two = 0;
            double sum = 0;

            Console.WriteLine("Fifty Cent: ");
            fifty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("One Euro: ");
            one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Two Euro: ");
            two = Convert.ToInt32(Console.ReadLine());

            sum = fifty * 0.5;
            sum += one;
            sum += two * 2;

            return sum;
        }
    }
}
