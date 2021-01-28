using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CoffeShopManagement
{
    public partial class MenuList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        SqlCommand cmd;
        string menu ="";
        public MenuList()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox1.Text;
            menu = menu + " " + menu1;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox2.Text;
            menu = menu + " " + menu1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox3.Text;
            menu = menu + " " + menu1;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox4.Text;
            menu = menu + " " + menu1;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox5.Text;
            menu = menu + " " + menu1;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu1 = comboBox6.Text;
            menu = menu + " " + menu1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into OrderTable(OrderList) values('"+ menu + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Order Placed");
            con.Close();
            this.Hide();
            Payment p = new Payment();
            p.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void MenuList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = new Customer();
            c.Show();
        }

        private void MenuList_Load(object sender, EventArgs e)
        {

        }
    }
}
