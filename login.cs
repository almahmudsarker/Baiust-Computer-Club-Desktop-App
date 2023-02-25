using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace BCC
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup frm1 = new signup();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string UserID = @"(?:\d.*){7,}";
            //string emailPattern = @" ^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            //string passwordPattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$"; // Password pattern
            string passwordPattern = "123";

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isUseridValid = Regex.IsMatch(textBox1.Text, UserID);
            //bool isEmailValid = Regex.IsMatch(textBox1.Text, emailPattern);
            bool isPasswordValid = Regex.IsMatch(textBox2.Text, passwordPattern);

            // Now you can check the result

            if (!isUseridValid && !isPasswordValid)
            {
                MessageBox.Show("Please enter a valid credentials");
            }
            else
            {
                if (textBox2.Text == passwordPattern)
                {
                    String Id = textBox1.Text;
                    string Password = textBox2.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-94S5E4P\\SQLEXPRESS; database = testdb ; integrated security =True";

                    try
                    {

                        String Query = "Select * from Persons where UserName = '" + Id + "' And Password ='" + Password + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                        DataTable Data_table = new DataTable();
                        sda.Fill(Data_table);

                        if (Data_table.Rows.Count > 0)
                        {
                            Id = textBox1.Text;
                            Password = textBox2.Text;
                        }
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }

                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid credentials");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            adminlogin home = new adminlogin();
            home.Show();
            this.Hide();
        }
    }
}
