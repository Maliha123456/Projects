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
    public partial class AddEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        SqlCommand cmd;
        string gender;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into EmployeeTable values('" + txtName.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "','" + gender + "','" + richTextBox1.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Employee Added");
            con.Close();
          
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
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
            Owner o = new Owner();
            o.Show();
        }
    }
}
