using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class ConsoleHelpers
    {
        public string GetName()
        {
            Console.Write("What is the name of your fighter: ");
            string fighterName = Console.ReadLine();

            return fighterName;
        }

        public string GetFavorite()
        {

            Console.Write("Is your fighter the favorite(enter '+') or underdog(enter '-'): ");
            string favored = Console.ReadLine();

            if (favored.Trim() == "+")
            {
                return "+";
            }
            else if (favored.Trim() == "-")
            {
                return "-";
            }
            else
            {
                Console.WriteLine("That input is not accepted, please try again!");
                return "X";
            }
        }

        public int GetOdds()
        {
            Console.Write("What are the numbered odds for your fighter(excluding + or -, ex: 300): ");
            string oddsString = Console.ReadLine();
            int oddInt;
            try
            {
                oddInt = int.Parse(oddsString);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number for the odds, without + or -");
                return -1;
            }
            return oddInt;
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
            catch (Exception)
            {
                Console.WriteLine("That is not an acceptable bet, try again");
                return -1;
            }
            if (betDecimal < 0)
            {
                Console.WriteLine("Bet must be at least 0(zero if you're not betting)");
                return -1;
            }
            return betDecimal;
        }
    }
}
