﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniffel
{
    class Player
    {
        private int Rolls;

        public int NumberOfRolls
        {
            get { return Rolls; }
            set { Rolls = value; }
        }
        private string _PlayerName;
        private Score PlayerScore;
        public string PlayerName
        {
            get { return _PlayerName; }
        }
                
        public Player(string name)
        {
            PlayerScore = new Score();
            _PlayerName = name;
            Rolls = 0;
        }
        
        public void CalculateScoreThisThrow(AllDices Dices)
        {
            Console.WriteLine("Ones: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Ones));
            Console.WriteLine("Twos: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Twos));
            Console.WriteLine("Threes: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Threes));
            Console.WriteLine("Fours: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Fours));
            Console.WriteLine("Fives: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Fives));
            Console.WriteLine("Sixs: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Sixs));
            Console.WriteLine("3 of a kind: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.ThreeOfAKind));
            Console.WriteLine("4 of a kind: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.FourOfAKind));
            Console.WriteLine("5 of a kind: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.FiveOfAKind));
            Console.WriteLine("Little road: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.LittleRoad));
            Console.WriteLine("Big road: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.bigRoad));
            Console.WriteLine("Chance: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.Chance));
            Console.WriteLine("Full House: " + PlayerScore.CalculateScore(Dices, Score.ScoreType.FullHouse));

        }


    }
}
