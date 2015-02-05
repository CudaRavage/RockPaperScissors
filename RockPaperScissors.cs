using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdffjfsf

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int opponentThrow;
            opponentThrow = random.Next(1, 4);
            string opponentString = "";
            string gameResult = "";

       
            if (radioButtonRock.Checked == true) //player throws rock
            {
                if (opponentThrow == 1)
                {
                    gameResult = "tied!";
                }

                else if (opponentThrow == 2)
                {
                    gameResult = "lose!";
                }

                else if (opponentThrow == 3)
                {
                    gameResult = "win!";
                }

            }

            if (radioButtonPaper.Checked == true) //player throws paper
            {
                if (opponentThrow == 2)
                {
                    gameResult = "tied!";
                }

                else if (opponentThrow == 3)
                {
                    gameResult = "lose!";
                }

                else if (opponentThrow == 1)
                {
                    gameResult = "win!";
                }

            }

            if (radioButtonScissors.Checked == true) //player throws scissors
            {
                if (opponentThrow == 3)
                {
                    gameResult = "tied!";
                }

                else if (opponentThrow == 1)
                {
                    gameResult = "lose!";
                }

                else if (opponentThrow == 2)
                {
                    gameResult = "win!";
                }

            }


             switch (opponentThrow) // converts random int to string for opponents throw
             {
                 case 1:
                         opponentString = "rock";
                         break;
                 case 2:
                         opponentString = "paper";
                         break;
                 case 3:
                         opponentString = "scissors";
                         break;
             }


            
            textBox1.Text = ("Computer threw " + opponentString + ". You " + gameResult); //update text box with game results


        }
    }
}
