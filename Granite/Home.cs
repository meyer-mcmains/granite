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
        internal User user;
        internal Student stu;
        public Home()
        {
            InitializeComponent();
        }
        public Home(User u)
        {
            InitializeComponent();
            user = u;
        }
        

        private void giveTest_Click(object sender, EventArgs e)
        {
            Student stu = new Student(00000000, "Stu", "Dent");
            TakeTest mw = new TakeTest(user, stu);
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
    }
}
