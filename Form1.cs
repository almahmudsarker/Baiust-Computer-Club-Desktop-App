using Microsoft.VisualBasic.Logging;

namespace BCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 5;
            progressBar1.Value = startpos;
            label2.Text = startpos + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }
    }
}
//Copyright © 2023 | All right reserved by Al Mahmud Sarker