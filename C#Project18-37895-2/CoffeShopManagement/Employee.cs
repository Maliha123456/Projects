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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        SqlCommand cmd;
        public int Id;
        public Employee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetOrderListInfo();
            GetInventoryInfo();

        }

        private void GetInventoryInfo()
        {
            cmd = new SqlCommand("select * from InventoryTable", con);
            DataTable DT = new DataTable();
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            DT.Load(DR);
            con.Close();
            dataGridView2.DataSource = DT;
        }

        private void GetOrderListInfo()
        {
            cmd = new SqlCommand("select * from OrderTable", con);
            DataTable DT = new DataTable();
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            DT.Load(DR);
            con.Close();
            dataGridView1.DataSource = DT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       // private void button2_Click(object sender, EventArgs e)
       // {

            //cmd = new SqlCommand("update set InventoryTable where Id='" + textBox1.Text + "'", con);
            
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            ////GetInventoryInfo();

           
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from OrderTable where Id='" + textBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetOrderListInfo();
        }
    }
}
