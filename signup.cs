using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using BCC;

namespace test
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //signup form to login form

            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();

            //signup form codes

            string Unique_id = uniqueID.Text;
            String Levels = levels.Text;
            String Terms = terms.Text;
            String LastName = lastname.Text;
            String FirstName = firstname.Text;
            String Email = email.Text;
            String Passwords = password.Text;
            String Department = dept.Text;

            //connection codes

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-94S5E4P\\SQLEXPRESS; database = testdb ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //database to frontpage connection
            cmd.CommandText = "INSERT INTO Student (UniqueID,Levels,Terms,LastName,FirstName,Email,Passwords,Department) Values ('" + Unique_id + "','" + Levels + "','" + Terms + "','" + LastName + "','" + FirstName + "','" + Email + "','" + Passwords + "','" + Department + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved", "Information", MessageBoxButtons.OK);
        }
    }
}
