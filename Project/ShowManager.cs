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
    public partial class ShowManager : Form
    {
        public ShowManager()
        {
            InitializeComponent();
            ShowMe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDashboard().Show();
        }


        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-I5533B5\\SQLEXPRESS;Initial Catalog=EMS;User ID=sa;Password=root");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select user_id, name, phone, email, address from Managers ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
