using System;
using System.Collections.Generic;
using System.Text;

namespace BettingCalculator
{
    public class BettingEntriesUI
    {
        private Fighter OpponentOne { get; set; }

        private Calculator OpponentOneBet { get; set; }

        private Fighter OpponentTwo { get; set; }

        private Calculator OpponentTwoBet { get; set; }

        public BettingEntriesUI()
        {
            OpponentOne = FighterOne();
            OpponentOneBet = OpponentOneWinnings();
            OpponentTwo = FighterTwo();
            OpponentTwoBet = OpponentTwoWinnings();
        }
        
        public Fighter FighterOne()
        {
            Fighter opponentOne = new Fighter("null","null",0);
            string name;
            string favorite;
            int odds;
            Console.WriteLine("Please enter the info for your first fighter");
            Console.WriteLine();
            name = opponentOne.GetName();
            do
            {
                favorite = opponentOne.GetFavorite();
            } while (favorite == "X");
            do
            {
                odds = opponentOne.GetOdds();
            } while (odds == -1);
            opponentOne.Name = name;
            opponentOne.PlusMinus = favorite;
            opponentOne.Odds = odds;

            return opponentOne; 
        }
        public Calculator OpponentOneWinnings()
        {
            Calculator OpponentOneWins = new Calculator(0, 0, 0M);
            decimal bet;
            do
            {
                bet = OpponentOneWins.GetBet();
            } while (bet == -1);
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
            Console.WriteLine("Please enter the info for your second fighter");
            Console.WriteLine();
            name = opponentTwo.GetName();
            do
            {
                favorite = opponentTwo.GetFavorite();
            } while (favorite == "X");
            do
            {
                odds = opponentTwo.GetOdds();
            } while (odds == -1);
            opponentTwo.Name = name;
            opponentTwo.PlusMinus = favorite;
            opponentTwo.Odds = odds;
            return opponentTwo;
        }

        public Calculator OpponentTwoWinnings()
        {
            Calculator OpponentTwoWins = new Calculator(0, 0, 0M);
            decimal bet;
            do
            {
                bet = OpponentTwoWins.GetBet();
            } while (bet == -1);
            OpponentTwoWins.Bet = bet;
            OpponentTwoWins.Winnings = OpponentTwoWins.GetPayOut(bet, OpponentTwo.PlusMinus, OpponentTwo.Odds);
            OpponentTwoWins.OddsCalculated = OpponentTwoWins.GetOddsPercentage(OpponentTwo.PlusMinus, OpponentTwo.Odds);
            return OpponentTwoWins;
        }

        public void Final()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{OpponentOne.Name}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Betting Odds: {OpponentOne.PlusMinus}{OpponentOne.Odds}");
            Console.WriteLine($"Possibility of Winning(Based on Odds): {OpponentOneBet.OddsCalculated}%");
            Console.WriteLine($"Bet Placed: {OpponentOneBet.Bet:C2}");
            Console.WriteLine($"Potential Winnings: {OpponentOneBet.Winnings:C2}");
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine("| Keep in mind the winning odds of both fighters may add up to over 100% |");
            Console.WriteLine("|                     The odds are purposefully unfair                   |");
            Console.WriteLine("|                          The House Always Wins                         |");
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"{OpponentTwo.Name}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Betting Odds: {OpponentTwo.PlusMinus}{OpponentTwo.Odds}");
            Console.WriteLine($"Possibility of Winning(Based on Odds): {OpponentTwoBet.OddsCalculated}%");
            Console.WriteLine($"Bet Placed: {OpponentTwoBet.Bet:C2}");
            Console.WriteLine($"Potential Winnings: {OpponentTwoBet.Winnings:C2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to close program");
            Console.ReadLine();
        }
    }
}
