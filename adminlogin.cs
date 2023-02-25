using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace BCC
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            login home = new login();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            //string passwordPattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$"; // Password pattern
            string passwordPattern = "admin";

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isEmailValid = Regex.IsMatch(textBox1.Text, emailPattern);
            bool isPasswordValid = Regex.IsMatch(textBox2.Text, passwordPattern);

            // Now you can check the result

            if (!isEmailValid && !isPasswordValid)
            {
                MessageBox.Show("Please enter a valid credentials");
            }
            else
            {
                if (textBox2.Text == passwordPattern)
                {
                    adminpanel home = new adminpanel();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid credentials");
                }
            }
        }
    }
}
