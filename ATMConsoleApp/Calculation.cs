using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMConsoleApp
{
    public class Calculation
    {
        public int actualamount = 0;
        public void DenominationTens(int amount)
        {
            int quotient = 0;
            if (amount % 10 == 0)
            {
                quotient = amount / 10;
            }
            Console.Write("No of denominations of 10:" + quotient);
        }

        public void DenominationFifties(int amount)
        {
            int quotientFifties = 0;
            int tempremain = amount % 50;

            //Console.Write("Possibility 1 \n");
            if (amount < 100)
            {
                DenominationTens(amount);
            }

            if (actualamount < amount)
            {
                //Console.Write("\nPossibility 2 \n");
                if (tempremain == 0)
                {
                    quotientFifties = amount / 50;
                    Console.Write("No of denominations of 50:" + quotientFifties);
                }
                else
                {
                    quotientFifties = amount / 50;
                    Console.Write("No of denominations of 50:" + quotientFifties);
                    DenominationTens(tempremain);
                }
            }

        }


        public void DenominationHundereds(int amount)
        {
            actualamount = amount;
            int quotientHundereds = 0;
            int tempremain = amount % 100;

            Console.Write("+++++++++\n");
            int tempquotient = amount / 100;
            Console.WriteLine("No of denominations of 100:" + tempquotient);
            DenominationFifties(tempremain);


            Console.Write(" \n+++++++ \n");
            if (amount % 10 == 0)
            {
                DenominationTens(amount);
            }

            //Console.Write("Possibility 3 \n");
            if (amount % 50 == 0)
            {
                DenominationFifties(amount);
            }

            Console.Write("\n+++++++++ \n");
            if (tempremain == 0)
            {
                quotientHundereds = amount / 100;
                Console.Write("No of denominations of 100:" + quotientHundereds);
            }
            else
            {
                quotientHundereds = amount / 50;
                Console.Write("No of denominations of 50:" + quotientHundereds);

                tempremain = amount % 50;
                DenominationFifties(tempremain);
            }

        }
    }
}
