using System;
using System.Windows.Forms;

namespace Granite
{
    public partial class Home : Form
    {
        internal User user;
        internal Student stu;
        private Connection conn;

        public Home()
        {
            InitializeComponent();
            CenterToScreen();
            conn = new Connection();
        }

        public Home(User u)
        {
            InitializeComponent();
            conn = new Connection();
            user = u;
        }

        private void giveTest_Click(object sender, EventArgs e)
        {
            ChooseStudent cs = new ChooseStudent(user);
            cs.Show();
            conn.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeTest mt = new makeTest();
            mt.Show();
            this.Hide();
        }

        private void editUsr_Click(object sender, EventArgs e)
        {
            addUser eu = new addUser();
            eu.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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

        private void addStudent_Click(object sender, EventArgs e)
        {
            addStudent ass = new addStudent();
            ass.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            button2.Top = (this.ClientSize.Height - button2.Height) / 2;
            editUsr.Left = (button2.Left + button2.Width + 4);
            editUsr.Top = button2.Top;
            addStudent.Left = (editUsr.Left + button2.Width + 4);
            addStudent.Top = button2.Top;
            button1.Left = (button2.Left - button2.Width - 4);
            button1.Top = button2.Top;
            giveTest.Left = (button1.Left - button2.Width - 4);
            giveTest.Top = button2.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analytics at = new Analytics();
            at.Show();
            this.Hide();
        }

        private void editAccount_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.Show();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            button2.Top = (this.ClientSize.Height - button2.Height) / 2;
            editUsr.Left = (button2.Left + button2.Width + 4);
            editUsr.Top = button2.Top;
            addStudent.Left = (editUsr.Left + button2.Width + 4);
            addStudent.Top = button2.Top;
            button1.Left = (button2.Left - button2.Width - 4);
            button1.Top = button2.Top;
            giveTest.Left = (button1.Left - button2.Width - 4);
            giveTest.Top = button2.Top;
        }
    }
}