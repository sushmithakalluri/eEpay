using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int withdrawAmount = 0;
            Calculation calculation = new Calculation();

            Console.Write("Please enter the amount you would like to withdraw: ");
            int.TryParse(Console.ReadLine(), out withdrawAmount);

            if (withdrawAmount >= 100)
            {
                calculation.DenominationHundereds(withdrawAmount);
            }
            else if (withdrawAmount >= 50)
            {
                calculation.DenominationFifties(withdrawAmount);
            }
            else if (withdrawAmount < 100 || withdrawAmount < 50)
            {
                calculation.DenominationTens(withdrawAmount);
            }

            Console.ReadKey();

        }
    }
}
