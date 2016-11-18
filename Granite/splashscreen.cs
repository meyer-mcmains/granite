using Granite;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private Timer time;

        private void splashscreen_Shown(object sender, EventArgs e)
        {
            time = new Timer();
            time.Interval = 2500;
            time.Start();
            time.Tick += time_Tick;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
    }
}