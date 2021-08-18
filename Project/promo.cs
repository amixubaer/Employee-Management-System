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
    public partial class promo : Form
    {
        public promo()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");

      
        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("update Employees set  designation= '" + comboBox1.Text + "' where user_id = '" + textBox1.Text + "' ", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Promoted!");
            sq.Close();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerDashboard().Show();
        }
    }
}
