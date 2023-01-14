using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class flying : Form
    {
        public flying()
        {
            InitializeComponent();
        }

        String[] CURRENT, CACHE;
        int POS, Pos1, BARRIER;  
        /*POS主角位置
         *BARRIER障礙物高度
         *CURRENT目前地圖 CACHE地圖緩存
         * 
        */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
/*            switch (e.KeyCode)
            {
                case Keys.Up:
                    
                    break;
            }
*/        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rBarrier_Tick(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    POS = POS + 1;
                    break;
                case Keys.Down:
                    POS = POS + -1;
                    break;
            }
            //textBox1.Text += "OUO";
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        private void welcome_Tick(object sender, EventArgs e)
        {
            if (iw5 != 0)
            {
                if (iw1 != 0)
                {
                    s1 = "";
                    for(int a = iw1; a > 0; a--)
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
                O_TF = true;
                O1 = " ";
                O2 = ">";
                O3 = " ";
                O4 = " ";
                O5 = " ";
                O = 2;
                textBox1.Text = O1 + s1 + "\r\n" + O2 + s2 + "\r\n" + O3 + s3 + "\r\n" + O4 + s4 + "\r\n" + O5 + s5;
            }
        }
    }
}//痾  傳出去啊!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!