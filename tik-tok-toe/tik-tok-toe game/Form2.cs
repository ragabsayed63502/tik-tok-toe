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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 frm){
        
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.f1 = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.label4.Text = textBox1.Text;
            f1.label5.Text = "Computer";
            
            if (textBox1.Text == "") {
                f1.label4.Text = "first player";
            }
            f1.label6.Text = "Rules:\nPlayer1 symbol=\"X\" and Computer symbol=\"O\"  ";
            f1.label6.Font = new Font("Tahoma", 12.25F);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
