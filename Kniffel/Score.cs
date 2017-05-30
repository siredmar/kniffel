using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniffel
{
    class Score
    {
        public enum SpecialScore
        {
            DigitsExtraBonus = 25,
            FullHouse = 25,
            LittleRoad = 25,
            BigRoad = 35,
            ThreeOfAKind = 20,
            FourOfAKind = 30,
            FiveOfAKind = 50,
        }

        public enum ElementScore
        {
            NotFilledYet = 0,
            Filled,
            Slashed
        }

        struct SingleScoreElement
        {
            int Value;
            ElementScore Status;
        }

        public enum ScoreType
        {
            Ones = 0,
            Twos,
            Threes,
            Fours,
            Fives,
            Sixs,
            DigitsExtra,
            FullHouse,
            LittleRoad,
            bigRoad,
            ThreeOfAKind,
            FourOfAKind,
            Chance,
            FiveOfAKind,
            NumberOfScores
        }

        SingleScoreElement[] ScoreArray = new SingleScoreElement[(int)ScoreType.NumberOfScores];

        public int GetSameDiceWithValue(AllDices AllDices, Dice.DiceValue value)
        {
            int NumberOfSameDice = 0;
            for (int i = 0; i < AllDices.NumberOfDices; i++)
            {
                if (AllDices.GetSingleDiceValue(i) == value)
                    NumberOfSameDice++;
            }
            return NumberOfSameDice;
        }

        public int CalculateAllDiceEyes(AllDices Dices)
        {
            int CalculateScore = 0;
            for (int i = 0; i < 5; i++)
            {
                CalculateScore += (int)Dices.GetSingleDiceValue(i);
            }
            return CalculateScore;
        }

        public bool AllDicesSameSide(AllDices Dices)
        {
            bool ret = false;
            for (Dice.DiceValue i = Dice.DiceValue.One; i < Dice.DiceValue.Six; i++)
            {
                if (CalculateSameSideScore(Dices, AllDices.NumberOfDices) == (int)AllDices.NumberOfDices * (int)i)
                {
                    ret = true;
                    break;
                }
            }
                return ret;
        }

        public bool DicesAdjacent(AllDices Dices, int len)
        {
            bool ret = false;
            bool DontRepeat = false;
            int[] values = new int[AllDices.NumberOfDices];
            int valueIndex = 0;

            for(int i = 0; i < AllDices.NumberOfDices; i++)
            {
                values[valueIndex] = (int)Dices.GetSingleDiceValue(i);
                valueIndex++;
            }
            Array.Sort(values);
            values = values.Distinct().ToArray();

            if (values.Length >= len)
            {
                if (len == 5)
                {
                    for (int i = 0; i < len - 1; i++)
                    {
                        if (values[i] == values[i + 1] - 1)
                        {
                            ret = true;
                        }
                        else
                        {
                            ret = false;
                            break;
                        }
                    }
                }
                else
                {
                    for (int rep = 0; rep <= 1; rep++)
                    {
                        if (DontRepeat == false)
                        {
                            if (values.Length >= (len + rep))
                            {
                                for (int i = rep; i < len + rep - 1; i++)
                                {
                                    if (values[i] == values[i + 1] - 1)
                                    {
                                        ret = true;
                                        DontRepeat = true;
                                    }
                                    else
                                    {
                                        ret = false;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                ret = false;
                                break;
                            }
                        }
                    }
                }
            }
            return ret;
        }

        public int CalculateSameSideScore(AllDices Dices, int value)
        {
            int CalculatedScore = 0;
            if (GetSameDiceWithValue(Dices, Dice.DiceValue.One) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.One;
            }
            else if (GetSameDiceWithValue(Dices, Dice.DiceValue.Two) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.Two;
            }
            else if (GetSameDiceWithValue(Dices, Dice.DiceValue.Three) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.Three;
            }
            else if (GetSameDiceWithValue(Dices, Dice.DiceValue.Four) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.Four;
            }
            else if (GetSameDiceWithValue(Dices, Dice.DiceValue.Five) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.Five;
            }
            else if (GetSameDiceWithValue(Dices, Dice.DiceValue.Six) >= value)
            {
                CalculatedScore += value * (int)Dice.DiceValue.Six;
            }
            else
            {

            }
            return CalculatedScore;
        }

        public bool CalculateFullHouse(AllDices Dices)
        {
            bool ret = false;
            int[] values = new int[AllDices.NumberOfDices];
            int valueIndex = 0;

            for (int i = 0; i < AllDices.NumberOfDices; i++)
            {
                values[valueIndex] = (int)Dices.GetSingleDiceValue(i);
                valueIndex++;
            }
            Array.Sort(values);

            if ((((values[0] == values[1]) && (values[0] == values[2])) && ((values[3] == values[4]))) || ((values[0] == values[1]) && ((values[2] == values[3]) && (values[3] == values[4]))))
            {
                ret = true;
            }
            return ret;
        }

        public int CalculateScore(AllDices Dices, ScoreType type)
        {
            int CalculatedScore = 0;

            switch(type)
            {
                case ScoreType.Ones:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.One)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.Twos:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.Two)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.Threes:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.Three)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.Fours:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.Four)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.Fives:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.Five)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.Sixs:
                    for (int i = 0; i < 5; i++)
                    {
                        if (Dices.GetSingleDiceValue(i) == Dice.DiceValue.Six)
                            CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;

                case ScoreType.ThreeOfAKind:
                    CalculatedScore = CalculateSameSideScore(Dices, 3);
                    break;
                case ScoreType.FourOfAKind:
                    CalculatedScore = CalculateSameSideScore(Dices, 4);
                    break;
                case ScoreType.FullHouse:
                    if (CalculateFullHouse(Dices) == true)
                    {
                        CalculatedScore = (int)SpecialScore.FullHouse;
                    }
                    break;
                case ScoreType.LittleRoad:
                    if ((DicesAdjacent(Dices, 4) == true) || (DicesAdjacent(Dices, 4) == true))
                    {
                        CalculatedScore += (int)SpecialScore.LittleRoad;
                    }
                    break;
                case ScoreType.bigRoad:
                    if ((DicesAdjacent(Dices, 5) == true))//  || (DicesAdjacent(Dices, 1, 5) == true))
                    {
                        CalculatedScore += (int)SpecialScore.BigRoad;
                    }
                    break;
                case ScoreType.Chance:
                    for (int i = 0; i < 5; i++)
                    {
                        CalculatedScore += (int)Dices.GetSingleDiceValue(i);
                    }
                    break;
                case ScoreType.FiveOfAKind:
                    if (AllDicesSameSide(Dices) == true)
                    {
                        CalculatedScore = (int)SpecialScore.FiveOfAKind;
                    }
                    break;
                default:

                    break;
            }
            return CalculatedScore;
        }
    }

}
