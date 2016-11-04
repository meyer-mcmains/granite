using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granite
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CenterToScreen();
        }

        

        private void giveTest_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeTest mt = new makeTest();
            mt.Show();
            this.Hide();
        }
        


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void editUsr_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The program has been closed.", "Program Closed!", MessageBoxButtons.OK);

            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
