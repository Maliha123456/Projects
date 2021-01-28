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

namespace CoffeShopManagement
{
    public partial class InventoryInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        SqlCommand cmd;
        public InventoryInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Lg = new Login();
            Lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner O = new Owner();
            O.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd = new SqlCommand("insert into InventoryTable values('" + textBox2.Text + "', '" + dateTimePicker1.Value + "' ,'"+textBox1.Text+"')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inventory Item Added");
            con.Close();
           
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Owner o = new Owner();
            o.Show();
        }

       

        

       
    }
}
