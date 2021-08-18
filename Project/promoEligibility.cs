using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class promoEligibility : Form
    {
        public promoEligibility()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int promo = DateTime.Today.Year - dateTimePicker1.Value.Year;
            textBox1.Text = promo.ToString();

           
            if (promo >= 0 && promo <1)
            {
                textBox2.Text = "Intern";
            }
            if (promo >=1 && promo <3)
            {
                textBox2.Text = "Jr. Engineer";
            }
            if (promo >= 3 && promo <5 )
            {
                textBox2.Text = "Sr. Engineer";
            }
            if (promo >= 5 && promo <8 )
            {
                textBox2.Text = "Team Leader";
            }

            if (promo >=8 )
            {
                textBox2.Text = "Chief Engineer";
            }

            if(promo<0)
            {
                textBox2.Text = "No";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDashboard().Show();
        }
    }
}
