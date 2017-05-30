﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniffel
{
    class Dice
    {
        public enum DiceValue
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6
        }
        private DiceValue value = DiceValue.One;
        private bool RollingEn = true;

        public Dice()
        {

        }

        public void RollDice(Random rnd)
        {
            if (RollingEn == true)
            {
                value = (DiceValue)(rnd.Next(100, 600) / 100);
            }
        }

        internal DiceValue Value
        {
            get { return this.value; }
        }

        public bool RollingEnabled
        {
            get { return RollingEn; }
            set { RollingEn = value; }
        }
    }
}