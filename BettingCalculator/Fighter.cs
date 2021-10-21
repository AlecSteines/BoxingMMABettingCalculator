using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class Fighter
    {
        public string Name { get; set; }

        public string PlusMinus { get; set; }

        public int Odds { get; set; }

        public Fighter(string name, string plusMinus, int odds)
        {
            Name = name;
            PlusMinus = plusMinus;
            Odds = odds;
        }

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
                Console.WriteLine("Please enter a whole number for the odds, without + or -!");
                return -1;
            }
            return oddInt;
        }        
    }
}
