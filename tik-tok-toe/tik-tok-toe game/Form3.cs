using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tik_tok_toe_game
{
    public partial class Form3 : Form
    {
        Form1 f;
        public Form3(Form1 frm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.f = frm;
        }

        private void button1_Click(object sender, EventArgs e)  {
            f.label4.Text = textBox1.Text;
            f.label5.Text = textBox2.Text;
            if (textBox1.Text == "")
            {
                f.label4.Text = "first player";
            }
            if (textBox2.Text == "")
            {
                f.label5.Text = "second player";
            }
            f.label6.Text = "Rules:\nPlayer1 symbol=\"X\" and Player2 symbol=\"O\"  ";
            f.label6.Font = new Font("Tahoma", 12.25F);
            //f.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
