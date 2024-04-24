using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                                  //INFORMATION\\
            // Cirno Calculator is based off flash games from the 2000's \\
        // 500 x 500 size is intentional, maximizing the window breaks a lot. \\

             // Created for school assessment, Character (Cirno) by ZUN \\

        private void Form1_Load(object sender, EventArgs e)
        {
            // When Calculator is being loaded

            // These fixes the order of interface layers

            label1.BringToFront(); //Title
            label3.BringToFront(); //Cirno's Answer Box
            pictureBox2.Hide(); //Cirno's Thought Image
            pictureBox3.Show(); //Cirno Idle
            pictureBox4.Hide(); //Confused Cirno
            button1.BringToFront(); //Calculate
            button2.BringToFront(); //Clear
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // From checkBox 1-5 will uncheck all other checkBox
        // if new checkBox is selected while other checkBox is still checked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
    
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
  
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
    
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false; 
            checkBox5.Checked = false;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Old "check for int or char" script was here, It's moved to button1_Click
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate Button Scripts

            int c; // Variable "c" will be used to store the result of calculations.
            

            if (Int32.TryParse(textBox1.Text, out int value))
            {
                // Get checkBox's assigned operators

                int a = int.Parse(textBox1.Text);

                if (Int32.TryParse(textBox2.Text, out _))
                {
                    int b = int.Parse(textBox2.Text);

                    //Convert textBox to Integer
                    //only if number is found...


                    // DOES THE CALCULATION ONCE 1ST AND 2ND TEXTBOXES ARE FILLED
                    if (checkBox1.Checked)
                    {
                        c = a + b;
                        label3.Text = "The total is..." + c.ToString() + "!";
                    }

                    if (checkBox2.Checked)
                    {
                        c = a - b;
                        label3.Text = "The number left is..." + c.ToString() + "!";
                    }

                    if (checkBox3.Checked)
                    {
                        c = a * b;
                        label3.Text = "The cloned number is..." + c.ToString();
                    }

                    if (checkBox4.Checked)
                    {
                        c = a / b;
                        label3.Text = "The slices left are..." + c.ToString();
                    }

                    if (checkBox5.Checked)
                    {
                        c = a % b;
                        label3.Text = "Uhh Let's see. I think it's..." + c.ToString() + "?";
                    }
                    // These run no matter what checkBox is active
                    pictureBox2.Show();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                }
                else
                {
                    //Run if 2nd textbox is missing.

                      // If you add words or algebra. Cirno gets very confused!!!

                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        label3.Text = "Uh... Please type 2nd value.";
                        pictureBox4.Show();

                        pictureBox2.Hide();
                        pictureBox3.Hide();
                    }
                    else
                    {
                        label3.Text = "Uh... What do those mean?";
                        pictureBox4.Show();

                        pictureBox2.Hide();
                        pictureBox3.Hide();
                    }


                }
                else
                {
                    label3.Text = "Give me an operator first!";
                }
                }


                   
            
           
            }
            else
            {
                //Pasted code for the 1st textbox if textbox1 is missing

                // If you add words or algebra. Cirno gets very confused!!!

                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        label3.Text = "Uh... Please type 1st value.";
                        pictureBox4.Show();

                        pictureBox2.Hide();
                        pictureBox3.Hide();
                    }
                    else
                    {
                    
                            label3.Text = "Uh... What do those mean?";
                            pictureBox4.Show();

                            pictureBox2.Hide();
                            pictureBox3.Hide();
                    }


                }
                else
                {
                    label3.Text = "Give me an operator first!";
                }
             
            }

            // These constantly fixes interface layers

            label3.BringToFront();
            button1.BringToFront();
            button2.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Button Script

            textBox1.Clear(); textBox2.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            //As if form is loaded

            label1.BringToFront(); //Title
            label3.BringToFront(); //Cirno's Answer
            pictureBox2.Hide(); //Cirno's Thought Image
            pictureBox4.Hide(); //Confused Cirno
            button1.BringToFront(); //These buttons
            button2.BringToFront();

            pictureBox3.Show();
            label3.Text = "Give me an answer!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
