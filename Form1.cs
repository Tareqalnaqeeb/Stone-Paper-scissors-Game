using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Stone_Sissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum EnChoices { Stone = 1, Paper = 2, Scisseros = 3 };
        enum EnWinner { Plyer = 1, Computer = 2, Drawing = 3 };

        struct StRoundInfo
        {
            public int RoundNumber;
            public EnChoices PlyerChocie;
            public EnChoices PcChoices;
            public EnWinner Winner;
        }

        struct StGameResult
        {
            public int NumbersOfRounds;
            public int PlyerWins;
            public int PcWins;
            public int Drawing;
            public EnWinner WhoWinner;

        }


        public int NumbersOfRound = 5;

        StGameResult GameResult = new StGameResult();

        Random random = new Random();
        StRoundInfo RoundInfo = new StRoundInfo();

        Button btnClick = new Button();


        int RandomNumber(int From, int To)
        {
            return random.Next(From, To+1  );
        }

        EnChoices ComputerChoices()
        {


            return (EnChoices)RandomNumber(1, 3);


        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        EnWinner WhoWinRound()
        {


            if (RoundInfo.PcChoices == RoundInfo.PlyerChocie)
            {
                return EnWinner.Drawing;

            }

            switch (RoundInfo.PlyerChocie)
            {
                case EnChoices.Stone:
                    {
                        if (RoundInfo.PcChoices == EnChoices.Paper)

                            return EnWinner.Computer;

                    }
                   
                    break;


                case EnChoices.Paper:
                    if (RoundInfo.PcChoices == EnChoices.Scisseros)
                    {
                        return EnWinner.Computer;


                    }


                    break;

                case EnChoices.Scisseros:

                    if (RoundInfo.PcChoices == EnChoices.Stone)
                    {
                        return EnWinner.Computer;


                    }


                    break;

                



            }
            return EnWinner.Plyer;


        }

        void WinnerTimes()
        {
            if (RoundInfo.Winner == EnWinner.Plyer)
            {
                GameResult.PlyerWins++;
            }
            else if (RoundInfo.Winner == EnWinner.Computer)
            {
                GameResult.PcWins++;
            }
            else
            {
                GameResult.Drawing++;
            }
        }
        EnWinner WhoWinnerGame()
        {
            if (GameResult.PcWins == GameResult.PlyerWins)
            {
                return EnWinner.Drawing;
            }
            else if (GameResult.PlyerWins > GameResult.PcWins)
            {
                return EnWinner.Plyer;
            }
            else
                return EnWinner.Computer;

        }

        



       
        void SetWhoWinnerTheGame()
        {
            if (WhoWinnerGame() == EnWinner.Computer)
            {
                MessageBox.Show(" Winner is Computer", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                MessageBox.Show($"Winner id  { GameResult.WhoWinner.ToString()} ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void SetResult()
        {
            lbRoundNumber.Text = RoundInfo.RoundNumber.ToString();
            lbComputerWins.Text = GameResult.PcWins.ToString();
            lbOfPlyerWins.Text = GameResult.PlyerWins.ToString();
        }

       
     
        void changeBackColorBtnComputer()
        {
            

        }

       

        
       

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            btnClick = (Button)sender;

            if (btnClick.BackColor == Color.Teal)
            {
                btnClick.BackColor = Color.White;
            }

        }

        private void btnPlyerClick_Click(object sender, EventArgs e)
        {
            btnClick = (Button)sender;

            RoundInfo.PlyerChocie = (EnChoices)Convert.ToInt32(btnClick.Tag);
            RoundInfo.PcChoices = ComputerChoices();
            lbComputerChoice.Text = RoundInfo.PcChoices.ToString();
            lbPlyerChoice.Text = RoundInfo.PlyerChocie.ToString();
            changeBackColorBtnComputer();
            btnClick.BackColor = Color.Teal;

            RoundInfo.RoundNumber++;
            GameResult.NumbersOfRounds++;

            
            RoundInfo.Winner = WhoWinRound();

            lbWhoWinner.Text = RoundInfo.Winner.ToString();
            WinnerTimes();

            SetResult();

            GameResult.WhoWinner = WhoWinnerGame();

            if (GameResult.NumbersOfRounds == 10)
            {
                SetWhoWinnerTheGame();
            }

        }

        
    }
}
