using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniffel
{
    class AllDices
    {
        public const int NumberOfDices = 5;
        private Dice[] DiceArray;
        Dice Dice1;
        Dice Dice2;
        Dice Dice3;
        Dice Dice4;
        Dice Dice5;
        private Dice.DiceValue[] DiceValues;

        public AllDices()
        {
            DiceArray = new Dice[5];
            Dice1 = new Dice();
            Dice2 = new Dice();
            Dice3 = new Dice();
            Dice4 = new Dice();
            Dice5 = new Dice();
            DiceArray[0] = Dice1;
            DiceArray[1] = Dice2;
            DiceArray[2] = Dice3;
            DiceArray[3] = Dice4;
            DiceArray[4] = Dice5;
            DiceValues = new Dice.DiceValue[NumberOfDices];
        }

        public void RollAll()
        {
            Random rnd = new Random();
            int i = 0;
            foreach(Dice d in DiceArray)
            {
                d.RollDice(rnd);
                DiceValues[i] = d.Value;
                i++;
            }
        }

        public Dice.DiceValue[] GetAllDicesValues()
        {
            return DiceValues;
        }

        public Dice.DiceValue GetSingleDiceValue(int index)
        {
            return DiceArray[index].Value;
        }

        public bool DiceRollable(int index)
        {
            return DiceArray[index].RollingEnabled;
        }

        public void SetDiceRollable(int index, bool en)
        {
            DiceArray[index].RollingEnabled = en;
        }
    }
}
