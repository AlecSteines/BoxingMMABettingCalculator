using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class BettingEntriesUI
    {
        public ConsoleHelpers consoleHelper = new ConsoleHelpers();

        public Calculator calculator = new Calculator();
        public void run()
        {
            string name;
            string favorite;
            int odds;
            decimal bet;
            Console.WriteLine("Please enter the info for your first fighter");
            Console.WriteLine();
            name = consoleHelper.GetName();
            do
            {
                favorite = consoleHelper.GetFavorite();
            } while (favorite == "X");
            do
            {
                odds = consoleHelper.GetOdds();
            } while (odds == -1);
            Fighter fighterOne = new Fighter(name, favorite, odds);
            do
            {
                bet = consoleHelper.GetBet();
            } while (bet == -1);
            decimal fighterOneBet = bet;
            decimal fighterOnePayOut = calculator.GetPayOut(bet, fighterOne.PlusMinus, fighterOne.Odds);
            decimal fighterOneCalculatedOdds = calculator.GetOddsPercentage(fighterOne.PlusMinus, fighterOne.Odds);
            Console.Clear();
            Console.WriteLine("Please enter the info for your second fighter");
            Console.WriteLine();
            name = consoleHelper.GetName();
            do
            {
                favorite = consoleHelper.GetFavorite();
            } while (favorite == "X");
            do
            {
                odds = consoleHelper.GetOdds();
            } while (odds == -1);
            Fighter fighterTwo = new Fighter(name, favorite, odds);
            do
            {
                bet = consoleHelper.GetBet();
            } while (bet == -1);
            decimal fighterTwoBet = bet;
            decimal fighterTwoPayOut = calculator.GetPayOut(bet, fighterTwo.PlusMinus, fighterTwo.Odds);
            decimal fighterTwoCalculatedOdds = calculator.GetOddsPercentage(fighterTwo.PlusMinus, fighterTwo.Odds);
            Console.Clear();
            Console.WriteLine($"{fighterOne.Name}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Betting Odds: {fighterOne.PlusMinus}{fighterOne.Odds}");
            Console.WriteLine($"Possibility of Winning(Based on Odds): {fighterOneCalculatedOdds}%");
            Console.WriteLine($"Bet Placed: {fighterOneBet:C2}");
            Console.WriteLine($"Potential Winnings: {fighterOnePayOut:C2}");
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine("| Keep in mind the winning odds of both fighters may add up to over 100% |");
            Console.WriteLine("|                     The odds are purposefully unfair                   |");
            Console.WriteLine("|                          The House Always Wins                         |");
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"{fighterTwo.Name}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Betting Odds: {fighterTwo.PlusMinus}{fighterTwo.Odds}");
            Console.WriteLine($"Possibility of Winning(Based on Odds): {fighterTwoCalculatedOdds}%");
            Console.WriteLine($"Bet Placed: {fighterTwoBet:C2}");
            Console.WriteLine($"Potential Winnings: {fighterTwoPayOut:C2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to close program");
            Console.ReadLine();
        }
    }
}
