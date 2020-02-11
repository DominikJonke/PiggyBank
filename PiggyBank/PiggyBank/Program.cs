using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t Piggy Bank");
            Console.WriteLine();
            Console.WriteLine($"You have {Calculator.CalculateMoney()} Euro");
        }
    }
}
