using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ManageManager : Form
    {
        public ManageManager()
        {
            InitializeComponent();
            ShowMe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Managers ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e) //add
        {
            
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Managers values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Text + "','" + textBox10.Text + "', '" + dateTimePicker1.Text + "', '" + textBox12.Text + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("User Inserted");
                ShowMe();
           
        }

        private void button2_Click(object sender, EventArgs e) //edit
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("update Managers set user_id = '" +textBox1.Text + "',name = '" + textBox2.Text + "',address= '" + textBox3.Text + "',age= '" + textBox4.Text + "',gender= '" + comboBox1.Text + "',phone= '" + textBox5.Text + "',email= '" + textBox6.Text + "',religion= '" + textBox7.Text + "',bg= '" + textBox8.Text + "',nationality= '" + textBox9.Text + "',dob= '" + dateTimePicker1.Text + "',salary= '" + textBox10.Text + "',joindate=  '" + dateTimePicker1.Text + "',password= '" + textBox12.Text + "' where user_id = '" + textBox1.Text + "' ", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("User has been Updated");
            sq.Close();
            ShowMe();
        }

        private void button3_Click(object sender, EventArgs e) //delete
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Managers where user_id = '" + textBox1.Text + "' ", sq);

            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                sC.ExecuteNonQuery();
                sq.Close();
                ShowMe();
            }
            if (res == DialogResult.No)
            {
                sq.Close();
                ShowMe();
            }
        }

        private void button4_Click(object sender, EventArgs e) //search
        {
            SqlCommand sC = new SqlCommand("select * from Managers where user_id = '" + textBox11.Text + "' ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
