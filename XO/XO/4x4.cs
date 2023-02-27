using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form2 : Form
    {
        Thread th;
        private int player;
        private Button[,] buttons = new Button[4, 4];
        private int score1;
        private int score2;
        private int Result1 = 0;
        public int resulTest = 0;
        public string win = "";

        public Form2()
        {
            InitializeComponent();
            score1 = 0;
            score2 = 0;
            player = 1;
            label1.Text = "Current Move: Player 1";
            label2.Text = "Player 1 Score:";
            label3.Text = "Player 2 Score:";
            label4.Text = "0";
            label5.Text = "0";

            for (int i = 0; i < buttons.Length / 4; i++)
            {
                for (int j = 0; j < buttons.Length / 4; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(100, 100);
                    Result1 = 4;
                }

            }
            setButtons();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
           
        }

        private void setButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j].Location = new Point(37 + 120 * j, 37 + 120 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 40);
                    buttons[i, j].Text = "";
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    label1.Text = "Current Move: Player 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label1.Text = "Current Move: Player 1";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
            
        }

        private void checkWin()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }



            //4x4


            if (buttons[1, 0].Text == buttons[2, 0].Text && buttons[2, 0].Text == buttons[3,0].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 1].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[3, 1].Text)
            {
                if (buttons[1, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 2].Text == buttons[2, 2].Text && buttons[2, 2].Text == buttons[3, 2].Text)
            {
                if (buttons[1, 2].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 3].Text == buttons[2, 3].Text && buttons[2, 3].Text == buttons[3, 3].Text)
            {
                if (buttons[1, 3].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 3].Text == buttons[1, 3].Text && buttons[1, 3].Text == buttons[2, 3].Text)
            {
                if (buttons[0, 3].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 0].Text == buttons[2, 0].Text && buttons[2, 0].Text == buttons[3, 0].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[3, 0].Text == buttons[3, 1].Text && buttons[3, 1].Text == buttons[3, 2].Text)
            {
                if (buttons[3, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[3, 1].Text == buttons[3, 2].Text && buttons[3, 2].Text == buttons[3, 3].Text)
            {
                if (buttons[3, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[2, 1].Text == buttons[2, 2].Text && buttons[2, 2].Text == buttons[2, 3].Text)
            {
                if (buttons[2, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 1].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[1, 3].Text)
            {
                if (buttons[1, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 1].Text == buttons[0, 2].Text && buttons[0, 2].Text == buttons[0, 3].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 0].Text == buttons[2, 0].Text && buttons[2, 0].Text == buttons[3, 0].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[3, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 1].Text == buttons[2, 2].Text && buttons[2, 2].Text == buttons[3, 3].Text)
            {
                if (buttons[1, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 1].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 3].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[0, 3].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 3].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 2].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[3, 0].Text)
            {
                if (buttons[1, 2].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }
            if (buttons[1, 3].Text == buttons[2, 2].Text && buttons[2, 2].Text == buttons[3, 1].Text)
            {
                if (buttons[1, 3].Text != "")
                {
                    if (label1.Text == "Current Move: Player 2")
                    {
                        score1 += 1;
                        label4.Text = score1.ToString();
                        MessageBox.Show("Player 1 Win");
                    }
                    else
                    {
                        score2 += 1;
                        label5.Text = score2.ToString();
                        MessageBox.Show("Player 2 Win");
                    }
                }

            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1(object obj)
        {
            Application.Run(new _5x5());
        }

        //tests
        public string BoardTest(int resulTest)
        {


            setButtons();
            string result = "";
            if (Result1 == resulTest)
            {
                result = "4x4";
            }
            else
            {
                result = "Fault";
            }
            return result;
        }

        public string Check(string win)
        {
            string result = "";
           
           
            setButtons();

            buttons[0, 0].Text = win;

            buttons[0, 1].Text = win;

            buttons[0, 2].Text = win;

            checkWin();

            if(score1==1 || score2==1)
            {
                result = "true";
            }
            else
            {
                result = "false";
            }
            return result;
        }
    }
}
