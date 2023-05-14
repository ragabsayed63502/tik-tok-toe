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
    public partial class Form1 : Form
    {
        int l1 = 0, l2 = 0, cnt = 0;
        Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        bool player1 = true,player2=false;
        bool check = false;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //to play computer
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
              
                Form2 f1 = new Form2(this);
                f1.ShowDialog();
                one.Enabled = true; two.Enabled =true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                player1 = true; player2 = false;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
               
            }
                

        }
        //to play another player  
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form3 f3 = new Form3(this);
                f3.ShowDialog();
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                player1 = true; player2 = false;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";

            }

        }
       


        //click 1
        private void one_Click(object sender, EventArgs e){
            if (one.Text == "" && cnt<9 && player1) {
                one.Text = "x";
                one.ForeColor = System.Drawing.Color.Red;
                check = true;
                cnt++;
                one.Enabled = false;
            }

           //when player 1 win
           if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text!="") ||
                (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                (three.Text == five.Text && five.Text == seven.Text && seven.Text!=""))
            {       
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, "+label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

           //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                one.Text = "o";
                cnt++;
                one.ForeColor = System.Drawing.Color.Red;
                one.Enabled = false;
            }

            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o"; 
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled =false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }
                    
                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }

        }



        //click 2
        private void two_Click(object sender, EventArgs e)
        {
            if (two.Text == "" && cnt < 9 && player1 == true)
            {
                two.Text = "x";
                check = true;
                cnt++;
                two.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2 )
            {
                    two.Text = "o";
                    cnt++;
                    two.Enabled = false;
            }

            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked == true && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);

                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 3
        private void three_Click(object sender, EventArgs e)
        {
            if (three.Text == "" && cnt < 9 && player1)
            {
                three.Text = "x";
                check = true;
                cnt++;
                three.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                three.Text = "o";
                cnt++;
                three.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 4
        private void four_Click(object sender, EventArgs e)
        {
            if (four.Text == "" && cnt < 9 && player1)
            {
                four.Text = "x";
                check = true;
                cnt++;
                four.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                four.Text = "o";
                cnt++;
                four.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 5
        private void five_Click(object sender, EventArgs e)
        {
            if (five.Text == "" && cnt < 9 && player1)
            {
                five.Text = "x";
                check = true;
                cnt++;
                five.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                five.Text = "o";
                cnt++;
                five.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 6
        private void sex_Click(object sender, EventArgs e)
        {
            if (sex.Text == "" && cnt < 9 && player1)
            {
                sex.Text = "x";
                check = true;
                cnt++;
                sex.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //another player
            if (radioButton2.Checked == true && player2)
            {
                sex.Text = "o";
                cnt++;
                sex.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 7
        private void seven_Click(object sender, EventArgs e)
        {
            if ( cnt < 9 && player1)
            {
                seven.Text = "x";
                check = true;
                cnt++;
                seven.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //another player
            if (radioButton2.Checked == true && player2)
            {
                seven.Text = "o";
                cnt++;
                seven.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 8
        private void eight_Click(object sender, EventArgs e)
        {
            if (eight.Text == "" && cnt < 9 && player1)
            {
                eight.Text = "x";
                check = true;
                cnt++;
                eight.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                eight.Text = "o";
                cnt++;
                eight.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }
        }
        //click 9
        private void nine_Click(object sender, EventArgs e)
        {
            if (nine.Text == "" && cnt < 9 && player1)
            {
                nine.Text = "x";
                check = true;
                cnt++;
                nine.Enabled = false;
            }

            //when player 1 win
            if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
            {
                l1++; label1.Text = Convert.ToString(l1); cnt = 0;
                MessageBox.Show("Win, " + label4.Text);
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }

            //when Draw and finsh game
            if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                cnt = 0;
                MessageBox.Show("Draw");
                one.Enabled = true; two.Enabled = true; three.Enabled = true;
                four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
            }


            //another player
            if (radioButton2.Checked == true && player2)
            {
                nine.Text = "o";
                cnt++;
                nine.Enabled = false;
            }


            // condition to choose round player
            if (player1 == true && radioButton2.Checked == true)
            {
                player2 = true;
                player1 = false;
            }
            else if (radioButton2.Checked == true)
            {
                player2 = false;
                player1 = true;
            }

            //play computer
            if (radioButton1.Checked && check == true && cnt < 9)
            {
                cnt++;

                //to continue choose random number is not choose before
                while (true)
                {
                    int n = r.Next(1, 9);
                    if (n == 1 && one.Text == "")
                    {
                        one.Text = "o";
                        one.Enabled = false;
                        break;
                    }
                    else if (n == 2 && two.Text == "")
                    {
                        two.Text = "o";
                        two.Enabled = false;
                        break;
                    }
                    else if (n == 3 && three.Text == "")
                    {
                        three.Text = "o";
                        three.Enabled = false;
                        break;
                    }
                    else if (n == 4 && four.Text == "")
                    {
                        four.Text = "o";
                        four.Enabled = false;
                        break;
                    }
                    else if (n == 5 && five.Text == "")
                    {
                        five.Text = "o";
                        five.Enabled = false;
                        break;
                    }
                    else if (n == 6 && sex.Text == "")
                    {
                        sex.Text = "o";
                        sex.Enabled = false;
                        break;
                    }
                    else if (n == 7 && seven.Text == "")
                    {
                        seven.Text = "o";
                        seven.Enabled = false;
                        break;
                    }
                    else if (n == 8 && eight.Text == "")
                    {
                        eight.Text = "o";
                        eight.Enabled = false;
                        break;
                    }
                    else if (n == 9 && nine.Text == "")
                    {
                        nine.Text = "o";
                        nine.Enabled = false;
                        break;
                    }

                }


                // computer win
                if ((one.Text == two.Text && two.Text == three.Text && three.Text != "") || (four.Text == five.Text && sex.Text == four.Text && five.Text != "") ||
                 (seven.Text == eight.Text && nine.Text == seven.Text && seven.Text != "") || (one.Text == four.Text && one.Text == seven.Text && seven.Text != "") || (two.Text == five.Text && eight.Text == two.Text && two.Text != "") || (three.Text == sex.Text && three.Text == nine.Text && three.Text != "") || (one.Text == five.Text && five.Text == nine.Text && nine.Text != "") ||
                 (three.Text == five.Text && five.Text == seven.Text && seven.Text != ""))
                {
                    l2++; label2.Text = Convert.ToString(l2); cnt = 0;
                    MessageBox.Show("Lose");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                //when Draw and finsh game
                if (one.Text != "" && two.Text != "" && three.Text != "" && four.Text != "" && five.Text != "" && sex.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
                {
                    cnt = 0;
                    MessageBox.Show("Draw");
                    one.Enabled = true; two.Enabled = true; three.Enabled = true;
                    four.Enabled = true; five.Enabled = true; sex.Enabled = true;
                    seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
                    one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
                }

                check = false;
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            one.Enabled = false; two.Enabled = false; three.Enabled = false;
            four.Enabled = false; five.Enabled = false; sex.Enabled = false;
            seven.Enabled = false; eight.Enabled = false; nine.Enabled = false;
            player1 = true; player2 = false;
            label4.Text = "first player"; label5.Text = "second player";
            label1.Text = "0"; label2.Text = "0";
            one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
               
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            player1 = true; player2 = false;
            label1.Text = "0"; label2.Text = "0";
            one.Text = two.Text = three.Text = four.Text = five.Text = sex.Text = seven.Text = eight.Text = nine.Text = "";
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
   }

