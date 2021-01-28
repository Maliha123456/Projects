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
    public partial class Login : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QNHQSFJ;Initial Catalog=CoffeShopManagement;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup su = new Signup();
            su.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Owner")
            {
                con.Open();
                string cmd = "select * from OwnerTable where Email='" + textBox1.Text.Trim() + "'and Password ='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter SD = new SqlDataAdapter(cmd, con);
                DataTable DT = new DataTable();
                SD.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    this.Hide();
                    Owner o = new Owner();
                    o.Show();


                }
                else
                {
                    MessageBox.Show("Invalid email or password");

                }
                con.Close();

            }
            if (comboBox1.Text == "Customer")
            {
                con.Open();
                string cmd = "select * from CustomerTable where Email='" + textBox1.Text.Trim() + "'and Password ='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter SD = new SqlDataAdapter(cmd, con);
                DataTable DT = new DataTable();
                SD.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    this.Hide();
                    Customer C = new Customer();
                    C.Show();

                }
                else
                {
                    MessageBox.Show("Invalid email or password");

                }
                con.Close();
            }

                else if(comboBox1.Text== "Employee")
                {
                    con.Open();
                    string cmd = "select * from EmployeeTable where Email='" + textBox1.Text.Trim() + "'and Password ='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter SD = new SqlDataAdapter(cmd, con);
                    DataTable DT = new DataTable();
                    SD.Fill(DT);
                    if (DT.Rows.Count == 1)
                    {
                        this.Hide();
                        Employee E = new Employee();
                        E.Show();

                    }
                     else
                     {
                         MessageBox.Show("Invalid email or password");

                     }
                    con.Close();
                }
            }
        }
    }

