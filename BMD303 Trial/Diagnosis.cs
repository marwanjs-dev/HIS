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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);

            // INSERT INTO `doctor` VALUES (null,"marwan",NULL,'oncologist',NULL,1010304619,123);

            string Query = "Select * from Diagnosis";
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO Diagnosis VALUES (null,'{textBox3.Text}','{textBox6.Text}','{textBox1.Text}','{textBox8.Text}');", con);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("success");
            con.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Appointment Obj = new Appointment();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Prescription Obj = new Prescription();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
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
