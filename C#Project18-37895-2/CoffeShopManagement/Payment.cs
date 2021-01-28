using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Payment to the waiter/cash counter");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Lg = new Login();
            Lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bkash number:01875054995");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("e-5506/f-847843");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rocket number:01875365994");
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
