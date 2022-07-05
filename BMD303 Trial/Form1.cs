using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BMD303_Trial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
    
        {
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);
            
            // INSERT INTO `doctor` VALUES (null,"marwan",NULL,'oncologist',NULL,1010304619,123);

            string Query = "Select * from doctor";
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO doctor VALUES (null,'{textBox3.Text}',NULL,'{gunaComboBox2.Text}','{textBox4.Text}',{textBox6.Text},123);", con);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("success");
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //textBox1.Text
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);

            con.Open();
            MySqlCommand cmd = new MySqlCommand($"delete from doctor where doctor_ID = {textBox1.Text};", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("success");
            con.Close();
        }

        private void textBox8_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;database=hospital;password=MyNewPass";
            MySqlConnection con = new MySqlConnection(ConnectString);

            // INSERT INTO `doctor` VALUES (null,"marwan",NULL,'oncologist',NULL,1010304619,123);

            string Query = "Select * from doctor";
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("success");
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Appointment Obj = new Appointment();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
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
