using project_4_memory_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4_memory_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        byte count = 0;
        Button btn1 = null;
        Button btn2 = null;

        byte score = 0;
        byte timergame = 20;
        byte timer = 3;

        private bool CheckifRight(Button btn1,Button btn2)
        {
           
            if(btn1.Tag==btn2.Tag)
            {
                score += 5;
                label3.Text = score.ToString();
                return true;
            }

            return false;
        }

        private void SaveChoise(Button btn)
        {
            if(count>2)
            {
                return;
            }

            if((count==0)&&(btn1==null))
            {
                btn1 = btn;
               
            }

            if((count==1)&&(btn2==null))
            {
                btn2 = btn;
            }


            if ((btn1 != null) && (btn2 != null))
            {
                if (btn2.Name.ToString() == btn1.Name.ToString())
                {
                    MessageBox.Show("You cannot choose the same picture", "Choose Anther Picture");
                    btn2 = null;
                    return;
                }

            }
            count++;
           
        }

        void checktimeandscoor()
        {
            if(timergame==0)
            {
                MessageBox.Show(" Time game End","A Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (score == 30)
            {
                timer2.Enabled = false;
                MessageBox.Show("you won", "final result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void convertemage(Button btn)
        {
            if(btn.Tag=="X")
            {
                btn.Image = Resources.X;
                return;
            }
            if (btn.Tag == "O")
            {
                btn.Image = Resources.O;
                return;
            }
            if (btn.Tag == "?")
            {
                btn.Image = Resources.question_mark_96;
                return;
            }
            if (btn.Tag == "Girl")
            {
                btn.Image = Resources.Girl;
                return;
            }
            if (btn.Tag == "Boy")
            {
                btn.Image = Resources.Boy;
                return;
            }
            if (btn.Tag == "Book")
            {
                btn.Image = Resources.Book;
                return;
            }

        }

        private void finalrisalt( Button btn)
        { 
       

            SaveChoise(btn);
            convertemage(btn);

            if (count == 2)
            {
                if (CheckifRight(btn1, btn2))
                {
                    btn1.Visible = false;
                    btn2.Visible = false;

                    btn1 = null;
                    btn2 = null;
                    count = 0;
                    checktimeandscoor();
                }
                else
                {
                        btn1.Image = Resources.Pen;
                        btn2.Image = Resources.Pen;

                        btn1 = null;
                        btn2 = null;
                        count = 0;
                    
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Refresh();
            label1.Text = timergame.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            finalrisalt((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            timer = 3;
            timer1.Enabled = true;
        }

        void startGame()
        {

            score = 0;
            count = 0;
            btn1 = null;
            btn2 = null;

            if (timer == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                button3.Image = Resources.Pen;
                button4.Image = Resources.Pen;
                button5.Image = Resources.Pen;
                button6.Image = Resources.Pen;
                button7.Image = Resources.Pen;
                button8.Image = Resources.Pen;
                button9.Image = Resources.Pen;
                button10.Image = Resources.Pen;
                button11.Image = Resources.Pen;
                button12.Image = Resources.Pen;
                button13.Image = Resources.Pen;
                button14.Image = Resources.Pen;
                timer = 0;
            }

        }
    
        private void timer1_Tick(object sender, EventArgs e)
        { 
             timer--;
            label2.Text = timer.ToString();
            startGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
                timergame--;
                label1.Text = timergame.ToString();

            if (timergame == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show(" Time game End", "A Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timergame = 30;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timergame = 20;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timergame = 10;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Refresh();
            label2.Text = timer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button6.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            button4.Visible = true;
            button3.Visible = true;
            button13.Visible = true;
            button10.Visible = true;
            button14.Visible = true;
            button12.Visible = true;
            button11.Visible = true;
            button8.Visible = true;

            timer = 3;
            timer1.Enabled = true;
            timer2.Enabled = false;
            timergame = 20;

            label1.Text="20";
            label2.Text="0";

        }

    
    }
}
