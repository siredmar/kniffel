using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kniffel
{
    public partial class Form1 : Form
    {
        AllDices Dices;
        PictureBox[] picDiceArray = new PictureBox[5];
        Player[] PlayerArray = new Player[4];
        Player Player1;
        Player Player2;
        Player Player3;
        Player Player4;
        public Form1()
        {
            InitializeComponent();

            Dices = new AllDices();
            picDiceArray[0] = picDice1;
            picDiceArray[1] = picDice2;
            picDiceArray[2] = picDice3;
            picDiceArray[3] = picDice4;
            picDiceArray[4] = picDice5;
            for (int i = 0; i < AllDices.NumberOfDices; i++)
            {
                picDiceArray[i].Enabled = false;
            }

            Player1 = new Player("Edmar");
            Player2 = new Player("Wollnik");
            Player3 = new Player("Player 3");
            Player4 = new Player("Player 4");
            PlayerArray[0] = Player1;
            PlayerArray[1] = Player2;
            PlayerArray[2] = Player3;
            PlayerArray[3] = Player4;
            Dices.ResetDices();
            //Dices.RollAll();
            UpdateDiceImages();
            
            tabPlayer1.Text = Player1.PlayerName;
            tabPlayer2.Text = Player2.PlayerName;
            tabPlayer3.Text = Player3.PlayerName;
            tabPlayer4.Text = Player4.PlayerName;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if(Player1.NumberOfRolls == 0)
            {
                for (int i = 0; i < AllDices.NumberOfDices; i++)
                {
                    picDiceArray[i].Enabled = true;
                }
            }
            Dices.RollAll();
            UpdateDiceImages();
            Player1.CalculateScoreThisThrow(Dices);
            Player1.NumberOfRolls++;
            if(Player1.NumberOfRolls >= 3)
            {
                btnRoll.Enabled = false;
                for (int i = 0; i < AllDices.NumberOfDices; i++)
                {
                    picDiceArray[i].Enabled = false;
                }
            }
        }

        public void UpdateDiceImages()
        {
            Dice.DiceValue[] DiceValues = Dices.GetAllDicesValues();
            for (int i = 0; i < AllDices.NumberOfDices; i++)
            {
                switch(DiceValues[i])
                {
                    case Dice.DiceValue.One:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.one;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.one_shaded;
                        }
                        break;
                    case Dice.DiceValue.Two:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.two;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.two_shaded;
                        }
                        break;
                    case Dice.DiceValue.Three:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.three;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.three_shaded;
                        }
                        break;
                    case Dice.DiceValue.Four:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.four;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.four_shaded;
                        }
                        break;
                    case Dice.DiceValue.Five:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.five;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.five_shaded;
                        }
                        break;
                    case Dice.DiceValue.Six:
                        if (Dices.DiceRollable(i) == false)
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.six;
                        }
                        else
                        {
                            picDiceArray[i].Image = Kniffel.Properties.Resources.six_shaded;
                        }
                        break;
                    case Dice.DiceValue.Empty:
                        picDiceArray[i].Image = Kniffel.Properties.Resources.empty;
                        break;
                }
            }
        }

        private void picDiceClicked(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            int index = Int32.Parse(obj.Tag.ToString());
            if(Dices.DiceRollable(index) == true)
            {
                Dices.SetDiceRollable(index, false);
            } 
            else
            {
                Dices.SetDiceRollable(index, true);
            }
            UpdateDiceImages();
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllDices.NumberOfDices; i++)
            {
                Dices.SetDiceRollable(i, true);
                picDiceArray[i].Enabled = false;
            }
            Dices.ResetDices();
            Player1.NumberOfRolls = 0;
            //Dices.RollAll();
            UpdateDiceImages();
            btnRoll.Enabled = true;
            
        }
    }
}
