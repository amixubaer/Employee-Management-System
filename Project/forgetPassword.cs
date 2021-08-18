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
    public partial class forgetPassword : Form
    {
        public forgetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
        private void button1_Click(object sender, EventArgs e) //forget pass
        {
            if ((textBox1.Text != "" || textBox1.Text != null) && (textBox1.Text != "" || textBox1.Text != null))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " update Admins set password = '" + textBox3.Text + "' Where user_id = '" + textBox1.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);
                

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Login().Show();
                    sq.Close();
                   
                }


            }


            if ((textBox1.Text != "" || textBox1.Text != null) && (textBox1.Text != "" || textBox1.Text != null))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " update Managers set password = '" + textBox3.Text + "' Where user_id = '" + textBox1.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);
                

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Login().Show();
                    sq.Close();

                }


            }


           if ((textBox1.Text != "" || textBox1.Text != null) && (textBox1.Text != "" || textBox1.Text != null))
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");
                string query = " update Employees set password = '" + textBox3.Text + "' Where user_id = '" + textBox1.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);
                


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Login().Show();
                    sq.Close();

                }


            }


            MessageBox.Show("Password Updated.\nReturn & login with new password");


        }
    }
}
