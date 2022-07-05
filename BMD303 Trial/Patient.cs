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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);

            string Query = "select * from patient";
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("success");
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Appointment Obj = new Appointment();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Prescription Obj = new Prescription();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }
    }
}
