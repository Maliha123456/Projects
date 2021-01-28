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
    public partial class Owner : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        SqlCommand cmd;
        public Owner()
        {
            InitializeComponent();
        }

        private void Owner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            GetEmployeeInformation();
            GetCustomerInformation();
            GetInventoryInformation();
        }

        private void GetInventoryInformation()
        {
            cmd = new SqlCommand("select * from InventoryTable", con);
            DataTable DT = new DataTable();
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            DT.Load(DR);
            dataGridView2.DataSource = DT;
            con.Close();
            
        }

        private void GetCustomerInformation()
        {
            cmd = new SqlCommand("select * from CustomerTable", con);
            DataTable DT3 = new DataTable();
            con.Open();
            SqlDataReader DR3 = cmd.ExecuteReader();
            DT3.Load(DR3);
            dataGridView1.DataSource = DT3;
            con.Close();
           
        }

        private void GetEmployeeInformation()
        {
            
            cmd = new SqlCommand("select * from EmployeeTable", con);
            DataTable DT2 = new DataTable();
            con.Open();
            SqlDataReader DR2 = cmd.ExecuteReader();
            DT2.Load(DR2);
            dataGridView4.DataSource = DT2;
            con.Close();
            

        }

      

   

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee EF = new AddEmployee();
            EF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryInfo I = new InventoryInfo();
            I.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from CustomerTable where Id='" + textBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetCustomerInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from EmployeeTable where Id='" + textBox2.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetEmployeeInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from InventoryTable where Id='" + textBox3.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetInventoryInformation();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
