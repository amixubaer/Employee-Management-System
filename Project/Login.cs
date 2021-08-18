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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "" || textBox1.Text != null) && (textBox2.Text != "" || textBox2.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " Select * from Admins Where user_id = '" + textBox1.Text + "' and password ='" + textBox2.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new AdminDashboard().Show();
                    sq.Close();
                }


            }


            if ((textBox1.Text != "" || textBox1.Text != null) && (textBox2.Text != "" || textBox2.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " Select * from Employees Where user_id = '" + textBox1.Text + "' and password ='" + textBox2.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new EmployeeDashboard().Show();
                    sq.Close();
                }


            }


            if ((textBox1.Text != "" || textBox1.Text != null) && (textBox2.Text != "" || textBox2.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " Select * from Managers Where user_id = '" + textBox1.Text + "' and password ='" + textBox2.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new ManagerDashboard().Show();
                    sq.Close();
                }


            }

            else
            {
                MessageBox.Show("Please Insert valid credential");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new forgetPassword().Show();
        }
    }
}
