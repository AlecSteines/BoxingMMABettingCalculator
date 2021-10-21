using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class Calculator
    {

        public decimal Winnings { get; set; }

        public decimal Bet { get; set; }

        public decimal OddsCalculated { get; set; }

        public Calculator(decimal bet, decimal winnings, decimal oddsCalculated)
        {
            Bet = bet;
            Winnings = winnings;
            OddsCalculated = oddsCalculated;
        }

        public decimal GetBet()
        {
            string bet;
            decimal betDecimal;
            Console.Write("How much would you like to bet on this fighter(USD): ");
            bet = Console.ReadLine();
            try
            {
                betDecimal = decimal.Parse(bet.Trim('$', ' '));
            }
            catch(Exception)
            {
                Console.WriteLine("That is not an acceptable bet, try again");
                return -1;
            }
            if(betDecimal < 0)
            {
                Console.WriteLine("Bet must be at least 0(zero if you're not betting)");
                return -1;
            }
            return betDecimal;
        }

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
