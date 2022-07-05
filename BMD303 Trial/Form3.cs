using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMD303_Trial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "anabatman")
            {
                if (textBox2.Text == "30101312300139")
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: please try again");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }
    }
}