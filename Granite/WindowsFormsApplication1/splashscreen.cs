using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Timer time;
        private void splashscreen_Shown(object sender, EventArgs e)
        {
            time = new Timer();
            time.Interval = 2500;
            time.Start();
            time.Tick += time_Tick;
        }
        void time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
