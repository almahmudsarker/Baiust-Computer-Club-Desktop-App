using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Profile to Home

            this.Hide();
            Home frm1 = new Home();
            frm1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
