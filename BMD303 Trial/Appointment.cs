using MySql.Data.MySqlClient;
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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);

            string Query = "select * from appointment";
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("success");
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Appointment Obj = new Appointment();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Prescription Obj = new Prescription();
            Obj.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }
    }
}
