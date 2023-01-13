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

        int POS;  //POS主角位置


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
            textBox1.Text = POS.ToString();
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
