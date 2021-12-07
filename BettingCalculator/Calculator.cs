using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class Calculator
    {

        

        public decimal GetOddsPercentage(string plusMinus, int odds)
        {
            decimal finalOdds = 0;
            finalOdds = odds / (odds + 100M);
            if(plusMinus == "-")
            {
                finalOdds = Math.Round((finalOdds * 100), 2);
                return finalOdds;
            }
            else
            {
                finalOdds = 100 - Math.Round((finalOdds * 100), 2);
                return finalOdds;
            }
        }

        public decimal GetPayOut(decimal bet, string favorite, int odds)
        {
            decimal finalBet = 0M;
            if (favorite == "-")
            {
                finalBet = bet + (bet / (odds / 100M));
                return Math.Round(finalBet, 2);
            }
            else
            {
                finalBet = bet + (bet * (odds / 100M));
                return Math.Round(finalBet, 2);
            }
        }
    }
}
