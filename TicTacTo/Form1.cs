using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTo
{
    public partial class Form1 : Form
    {
        string playerTurn = "YOUR TURN";
        string pcSign;
        string userSign;

        //For Stroing Buttons
        List<Button> btnList = new List<Button>(); 
        List<Button> availableBtns = new List<Button>();


        public Form1()
        {
            InitializeComponent();
            gamePanel.Visible = false;

            //Adding Avalible Buttons
            btnList.Add(btn1_1);
            btnList.Add(btn1_2);
            btnList.Add(btn1_3);
            btnList.Add(btn2_1);
            btnList.Add(btn2_2);
            btnList.Add(btn2_3);
            btnList.Add(btn3_1);
            btnList.Add(btn3_2);
            btnList.Add(btn3_3);
        }
       

        private void cbXO_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assign the Signs
            string res = cbXO.Text;
            if(res == "X")
            {
                lblXO.Text = "O";
                pcSign = "O";
                userSign = "X";
            }
            else
            {
                lblXO.Text = "X";
                pcSign = "X";
                userSign = "O";
            }
            cbXO.Enabled = false;
            gamePanel.Visible = true;
            userTurn();
        }

        public void userTurn()
        {
            lblPlayer.Text = playerTurn;
            lbl1.Text = userSign;
        }
        
        //Checking for the Winning Status
        public bool checkWinner(string sign)
        {
            if ((btn1_1.Text == sign && btn1_2.Text == sign && btn1_3.Text == sign) ||
                (btn2_1.Text == sign && btn2_2.Text == sign && btn2_3.Text == sign) ||
                (btn3_1.Text == sign && btn3_2.Text == sign && btn3_3.Text == sign) ||
                (btn1_1.Text == sign && btn2_1.Text == sign && btn3_1.Text == sign) ||
                (btn1_2.Text == sign && btn2_2.Text == sign && btn3_2.Text == sign) ||
                (btn1_3.Text == sign && btn2_3.Text == sign && btn3_3.Text == sign) ||
                (btn1_1.Text == sign && btn2_2.Text == sign && btn3_3.Text == sign) ||
                (btn1_3.Text == sign && btn2_2.Text == sign && btn3_1.Text == sign))
            {
                return true;
            }
            return false;
        }
        
        //Stroing Avalible Buttons
        public List<Button> avaliablebtnAdding(List<Button> list)
        {
            foreach(Button btn in list)
            {
                if(btn.Text.Equals(""))
                {
                    availableBtns.Add(btn);
                }
            }
            return availableBtns;
        }

        //"PC's" turn logic
        public void pcTurnLogic()
        {
            List<Button> list =  avaliablebtnAdding(btnList);
            Random random = new Random();
            if (list.Count > 0)
            {
                //Randomly Selecting button
                int randIndex = random.Next(0, list.Count);
                Button btn = list[randIndex];

                btn.Text = pcSign;
                btn.BackColor = Color.BlueViolet;
                btn.Enabled = false;
                if (checkWinner(pcSign))
                {
                    MessageBox.Show("PC WON");
                    refreshGame();
                }
                availableBtns.Clear();
            }
            else
            {
                MessageBox.Show("It's a draw.");
                refreshGame();
            }

        }

        //User's Turn Logic
        public void userGameLogic(Button btn)
        {
            btn.Text = userSign;
            btn.BackColor = Color.White;
            btn.Enabled = false;
            pcTurnLogic();

            if (checkWinner(userSign))
            {
                MessageBox.Show("YOU WON");
                refreshGame();
            }

        }

        //Reseting game variables
        public void refreshGame()
        {
            availableBtns.Clear();
            foreach(Button b in btnList)
            {
                b.Text = "";
                b.Enabled = true;
                b.BackColor = Color.DarkGray;
            }
            cbXO.Enabled = true;

            gamePanel.Visible = false;
            





        }
        //Implmenting Game Logic When User Click Button
        private void btn1_1_Click(object sender, EventArgs e)
        {
            userGameLogic(btn1_1);
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            userGameLogic(btn1_2);
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            userGameLogic(btn1_3);
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            userGameLogic(btn2_1);
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            userGameLogic(btn2_2);
        }

        private void btn2_3_Click(object sender, EventArgs e)
        {
            userGameLogic(btn2_3);
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            userGameLogic(btn3_1);
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            userGameLogic(btn3_2);
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            userGameLogic(btn3_3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshGame();
        }
    }
}
