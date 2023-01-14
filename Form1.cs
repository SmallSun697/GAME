using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GAME
{
    public partial class flying : Form
    {
        public flying()
        {
            InitializeComponent();
        }
        //show
        string s1 = "", s2 = "", s3 = "", s4 = "", s5 = "";
        //for welcome
        int iw1 = 25, iw2 = 28, iw3 = 31, iw4 = 34, iw5 = 37;
        int W;
        //選擇
        int menu;
        //for 0 move
        bool O_TF;
        int O = 2;
        string O1 = " ", O2 = " ", O3 = " ", O4 = " ", O5 = " ";
        //8判定
        bool b81, b82, b83, b84, b85;
        //8樣式
        string s8 = "0";
        //8生成
        Random R8 = new Random();
        int p8;
        //字串提取
        string sg1 = "", sg2 = "", sg3 = "", sg4 = "", sg5 = "";
        int sgt;
        //顯示修正
        int sf0;
        //死亡
        bool dead;
        int Gs = 25;

        private void speed_Tick(object sender, EventArgs e)
        {
            if (sgt < 200)
            {
                speed.Interval = 200;
            }
            else if (sgt < 400)
            {
                speed.Interval = 150;
            }
            else if (sgt < 600)
            {
                speed.Interval = 100;
            }
            else if (sgt > 800)
            {
                speed.Interval = 50;
            }
            if (dead == true)
            {
                O1 = " ";
                O2 = " ";
                O3 = " ";
                O4 = " ";
                O5 = " ";
                s1 = "";
                s2 = "";
                s3 = "";
                s4 = "";
                s5 = "";
                if (Gs > 0)
                {
                    textBox1.BackColor = Color.Black;
                    textBox1.ForeColor = Color.Red;
                    for (int a = Gs; a > 0; a--)
                    {
                        s1 += " ";
                        s3 += " ";
                    }
                    s1 += "      score " + (sgt - 31);
                    s3 += "      YOU  DIED";
                    textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
                    Gs--;
                    if (Gs != 0)
                    {
                        return;
                    }
                    Gs = 25;
                    Thread.Sleep(5000);
                    dead = false;
                    O1 = " ";
                    O2 = " ";
                    O3 = " ";
                    O4 = " ";
                    O5 = " ";
                    s1 = "";
                    s2 = "";
                    s3 = "";
                    s4 = "";
                    s5 = "";
                    sg1 = "";
                    sg2 = "";
                    sg3 = "";
                    sg4 = "";
                    sg5 = "";
                    iw1 = 25;
                    iw2 = 28;
                    iw3 = 31;
                    iw4 = 34;
                    iw5 = 37;
                    speed.Enabled = false;
                    welcome.Enabled = true;
                    return;
                }
            }
            p8 = R8.Next(-1, 8);
            if (menu == 22)
            {
                //"                             "
                sg1 = "                             ";
                sg2 = "                             ";
                sg3 = "                             ";
                sg4 = "                             ";
                sg5 = "                             ";
                menu = 1;
            }
            if (p8 == 1)
            {
                sg1 += s8;
                sg2 += " ";
                sg3 += " ";
                sg4 += " ";
                sg5 += " ";
            }
            if (p8 == 2)
            {
                sg1 += " ";
                sg2 += s8;
                sg3 += " ";
                sg4 += " ";
                sg5 += " ";
            }
            if (p8 == 3)
            {
                sg1 += " ";
                sg2 += " ";
                sg3 += s8;
                sg4 += " ";
                sg5 += " ";
            }
            if (p8 == 4)
            {
                sg1 += " ";
                sg2 += " ";
                sg3 += " ";
                sg4 += s8;
                sg5 += " ";
            }
            if (p8 == 5)
            {
                sg1 += " ";
                sg2 += " ";
                sg3 += " ";
                sg4 += " ";
                sg5 += s8;
            }
            sg1 += " ";
            sg2 += " ";
            sg3 += " ";
            sg4 += " ";
            sg5 += " ";
            s1 = sg1.Substring(sgt, 30);
            s2 = sg2.Substring(sgt, 30);
            s3 = sg3.Substring(sgt, 30);
            s4 = sg4.Substring(sgt, 30);
            s5 = sg5.Substring(sgt, 30);
            if (b81 == true)
            {
                if (O1 == ">")
                {
                    dead = true;
                }
                else
                {
                    O1 = s8;
                }
            }
            else if (b81 == false && O != 1)
            {
                O1 = " ";
            }
            if (b82 == true)
            {
                if (O2 == ">")
                {
                    dead = true;
                }
                else
                {
                    O2 = s8;
                }
            }
            else if (b82 == false && O != 2)
            {
                O2 = " ";
            }
            if (b83 == true)
            {
                if (O3 == ">")
                {
                    dead = true;
                }
                else
                {
                    O3 = s8;
                }
            }
            else if (b83 == false && O != 3)
            {
                O3 = " ";
            }
            if (b84 == true)
            {
                if (O4 == ">")
                {
                    dead = true;
                }
                else
                {
                    O4 = s8;
                }
            }
            else if (b84 == false && O != 4)
            {
                O4 = " ";
            }
            if (b85 == true)
            {
                if (O5 == ">")
                {
                    dead = true;
                }
                else
                {
                    O5 = s8;
                }
            }
            else if (b85 == false && O != 5)
            {
                O5 = " ";
            }
            b81 = s1.StartsWith(s8);
            b82 = s2.StartsWith(s8);
            b83 = s3.StartsWith(s8);
            b84 = s4.StartsWith(s8);
            b85 = s5.StartsWith(s8);
            textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
            sgt++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TabStop = false;
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
            speed.Enabled = false;
            dead = false;
            O_TF = false;
            menu = 0;
            welcome.Enabled = true;
        }

        private void welcome_Tick(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            if (iw5 != 0)
            {
                if (iw1 != 0)
                {
                    s1 = "";
                    for (int a = iw1; a > 0; a--)
                    {
                        s1 += " ";
                    }
                    iw1--;
                    s1 += "         welcome";
                }
                if (iw2 != 0)
                {
                    s2 = "";
                    for (int a = iw2; a > 0; a--)
                    {
                        s2 += " ";
                    }
                    iw2--;
                    s2 += "          start";
                }
                if (iw3 != 0)
                {
                    s3 = "";
                    for (int a = iw3; a > 0; a--)
                    {
                        s3 += " ";
                    }
                    iw3--;
                    s3 += "       how to play";
                }
                if (iw4 != 0)
                {
                    s4 = "";
                    for (int a = iw4; a > 0; a--)
                    {
                        s4 += " ";
                    }
                    iw4--;
                    s4 += "         setting";
                }
                if (iw5 != 0)
                {
                    s5 = "";
                    for (int a = iw5; a > 0; a--)
                    {
                        s5 += " ";
                    }
                    iw5--;
                    s5 += "          about";
                }
                textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
            }
            else
            {
                welcome.Enabled = false;
                menu = 0;
                O_TF = true;
                O1 = " ";
                O2 = ">";
                O3 = " ";
                O4 = " ";
                O5 = " ";
                O = 2;
                W = 2;
                textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (O_TF == true)
            {
                sf0 = O;
                if (dead == false)
                {
                    switch (keyData)
                    {
                        case Keys.Up:
                            if (O > W)
                            {
                                O--;
                            }
                            break;
                        case Keys.Down:
                            if (O < 5)
                            {
                                O++;
                            }
                            break;
                    }
                    switch (O)
                    {
                        case 1:
                            if (O1 == s8)
                            {
                                dead = true;
                            }
                            else
                            {
                                O1 = ">";
                            }
                            break;
                        case 2:
                            if (O2 == s8)
                            {
                                dead = true;
                            }
                            else
                            {
                                O2 = ">";
                            }
                            break;
                        case 3:
                            if (O3 == s8)
                            {
                                dead = true;
                            }
                            else
                            {
                                O3 = ">";
                            }
                            break;
                        case 4:
                            if (O4 == s8)
                            {
                                dead = true;
                            }
                            else
                            {
                                O4 = ">";
                            }
                            break;
                        case 5:
                            if (O5 == s8)
                            {
                                dead = true;
                            }
                            else
                            {
                                O5 = ">";
                            }
                            break;
                    }
                }
                if (sf0 != O)
                {
                    switch (sf0)
                    {
                        case 1:
                            if (O1 != s8 || s1.StartsWith(s8) == false)
                            {
                                O1 = " ";
                            }
                            break;
                        case 2:
                            if (O2 != s8 || s2.StartsWith(s8) == false)
                            {
                                O2 = " ";
                            }
                            break;
                        case 3:
                            if (O3 != s8 || s3.StartsWith(s8) == false)
                            {
                                O3 = " ";
                            }
                            break;
                        case 4:
                            if (O4 != s8 || s4.StartsWith(s8) == false)
                            {
                                O4 = " ";
                            }
                            break;
                        case 5:
                            if (O5 != s8 || s5.StartsWith(s8) == false)
                            {
                                O5 = " ";
                            }
                            break;
                    }
                }
                textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
                if (menu == 0)
                {
                    switch (keyData)
                    {
                        case Keys.Space:
                            menu = O;
                            break;
                    }
                }
                if (menu != 0)
                {
                    switch (menu)
                    {
                        case 2:
                            sg1 = "";
                            sg2 = "";
                            sg3 = "";
                            sg4 = "";
                            sg5 = "";
                            s1 = "";
                            s2 = "";
                            s3 = "";
                            s4 = "";
                            s5 = "";
                            O = 3;
                            O1 = " ";
                            O2 = " ";
                            O3 = ">";
                            O4 = " ";
                            O5 = " ";
                            W = 1;
                            textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
                            menu = 22;
                            sgt = 0;
                            speed.Enabled = true;
                            break;
                        case 3:
                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}