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
    }
}
