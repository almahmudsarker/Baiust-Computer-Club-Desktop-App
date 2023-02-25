using BCC;
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
    public partial class Home : Form
    {
        bool sidebarExpand;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panelHistory.Visible = false;
            galleryPanel.Visible = false;
            executivesPanel.Visible = false;
            contactPanel.Visible = false;

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            panelHistory.Visible = true;
            galleryPanel.Visible = false;
            executivesPanel.Visible = false;
            contactPanel.Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Hide();
            panelHistory.Visible = false;
        }

        private void panelHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Hide();
            galleryPanel.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = false;
            galleryPanel.Visible = false;
            executivesPanel.Visible = true;
            contactPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = false;
            galleryPanel.Visible = false;
            executivesPanel.Visible = false;
            contactPanel.Visible = true;
        }

        private void contactPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            //Home to User profile

            this.Hide();
            user frm4 = new user();
            frm4.Show();
        }
    }
}
