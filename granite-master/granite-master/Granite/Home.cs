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
        User person;
        public Home()
        {
            InitializeComponent();
        }
        public Home(User u)
        {
            InitializeComponent();
            person = u;
        }

        

        private void giveTest_Click(object sender, EventArgs e)
        {
            TestWindow mw = new TestWindow(person);
            mw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeTest mt = new makeTest(person);
            mt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
