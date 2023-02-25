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
    public partial class adminpanel : Form
    {
        bool sidebarExpand;
        public adminpanel()
        {
            InitializeComponent();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

            deletePanel.Visible = false;
            updatePanel.Visible = false;
            searchPanel.Visible = true;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-94S5E4P\\SQLEXPRESS; database = testdb ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * From Student";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer1.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Expression Check for Search panel

        private void button1_Click(object sender, EventArgs e)
        {

            // Create string variables that contain the patterns   
            string UserID = @"(?:\d.*){7,}";

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isUseridValid = Regex.IsMatch(textBox1.Text, UserID);

            // Now you can check the result

            if (!isUseridValid)
            {
                MessageBox.Show("Please enter a valid credentials");
            }
            else
            {
                Int64 UniqueID = Int64.Parse(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-94S5E4P\\SQLEXPRESS; database = testdb ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * From Student Where UniqueID =" + UniqueID + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void deletePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        // Expression check for delete panel

        private void button5_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string UserIDdel = @"(?:\d.*){7,}";

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isUseridValiddel = Regex.IsMatch(textBox3.Text, UserIDdel);

            // Now you can check the result

            if (!isUseridValiddel)
            {
                MessageBox.Show("Please enter a valid credentials");
            }

            else
            {
                Int64 UniqueID = Int64.Parse(textBox3.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-94S5E4P\\SQLEXPRESS; database = testdb ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Student where UniqueID =" + UniqueID + " ";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = true;
            updatePanel.Visible = false;
            searchPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
            updatePanel.Visible = true;
            searchPanel.Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
            updatePanel.Visible = false;
            searchPanel.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
