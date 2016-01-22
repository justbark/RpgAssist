using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgAssist
{
    class Roll
    {
        int _dieNumber;   //number of die
        int _dieType;     // the type of die to be rolled ex: d20
        int _modifier;    // +2 to the sum of die 1 and 2 or 3 etc etc...
        public int[] dieRes;

        Random rand = new Random();

        public Roll(int dieNumber, int dieType, int modifier)
        {
            this._dieNumber = dieNumber;
            this._dieType = dieType;
            this._modifier = modifier;
        }

        public int rollDice()
        {
            dieRes = new int[_dieNumber];
            for (int i = 0; i < this._dieNumber; i++)
            {
                dieRes[i] = rand.Next(1, _dieType + 1);
            }
            int sum = dieRes.Sum() + _modifier;
            return sum;
        }
    }
}
