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
<<<<<<< HEAD
=======
            OpponentOne = FighterOne();
            OpponentOneBet = OpponentOneWinnings();
            OpponentTwo = FighterTwo();
            OpponentTwoBet = OpponentTwoWinnings();
        }
        public Fighter FighterOne()
        {
            Fighter opponentOne = new Fighter("null","null",0);
>>>>>>> d7882888eea4bee894a24fb836e53972598b0e84
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
<<<<<<< HEAD
            //bet
            decimal fighterOneBet = bet;
            //opponentonewins.winnings
            decimal fighterOnePayOut = calculator.GetPayOut(bet, fighterOne.PlusMinus, fighterOne.Odds);
            //oddscalculated
            decimal fighterOneCalculatedOdds = calculator.GetOddsPercentage(fighterOne.PlusMinus, fighterOne.Odds);
            Console.Clear();
=======
            OpponentOneWins.Bet = bet;
            OpponentOneWins.Winnings = OpponentOneWins.GetPayOut(bet, OpponentOne.PlusMinus, OpponentOne.Odds);
            OpponentOneWins.OddsCalculated = OpponentOneWins.GetOddsPercentage(OpponentOne.PlusMinus, OpponentOne.Odds);
            return OpponentOneWins;
        }
        public Fighter FighterTwo()
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Fighter opponentTwo = new Fighter("null", "null", 0);
            string name;
            string favorite;
            int odds;
>>>>>>> d7882888eea4bee894a24fb836e53972598b0e84
            Console.WriteLine("Please enter the info for your second fighter");
            name = consoleHelper.GetName();
            do
            {
                favorite = consoleHelper.GetFavorite();
            } while (favorite == "X");
            do
            {
                odds = consoleHelper.GetOdds();
            } while (odds == -1);
<<<<<<< HEAD
            Fighter fighterTwo = new Fighter(name, favorite, odds);
=======
            opponentTwo.Name = name;
            opponentTwo.PlusMinus = favorite;
            opponentTwo.Odds = odds;
            return opponentTwo;
        }
        public Calculator OpponentTwoWinnings()
        {
            Calculator OpponentTwoWins = new Calculator(0, 0, 0M);
            decimal bet;
>>>>>>> d7882888eea4bee894a24fb836e53972598b0e84
            do
            {
                bet = consoleHelper.GetBet();
            } while (bet == -1);
<<<<<<< HEAD
            decimal fighterTwoBet = bet;
            decimal fighterTwoPayOut = calculator.GetPayOut(bet, fighterTwo.PlusMinus, fighterTwo.Odds);
            decimal fighterTwoCalculatedOdds = calculator.GetOddsPercentage(fighterTwo.PlusMinus, fighterTwo.Odds);
       
=======
            OpponentTwoWins.Bet = bet;
            OpponentTwoWins.Winnings = OpponentTwoWins.GetPayOut(bet, OpponentTwo.PlusMinus, OpponentTwo.Odds);
            OpponentTwoWins.OddsCalculated = OpponentTwoWins.GetOddsPercentage(OpponentTwo.PlusMinus, OpponentTwo.Odds);
            return OpponentTwoWins;
        }
        public void Final()
        {
>>>>>>> d7882888eea4bee894a24fb836e53972598b0e84
            Console.WriteLine();
            Console.WriteLine();
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
             //Copyright [2021] [Alec Steines]
        }
    }
}
