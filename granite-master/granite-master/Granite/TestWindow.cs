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
    public partial class TestWindow : Form
    {
        User person;
        public TestWindow()
        {
            InitializeComponent();
            test.Text = QuestionScore.Value.ToString();
        }
        public TestWindow(User u)
        {
            InitializeComponent();
            test.Text = QuestionScore.Value.ToString();
            person = u;
        }

        private void doStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            m.Show();
            Close();
        }

        private void TestWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('1'))
            {
                QuestionScore.Value = 1;
            }
            else if (e.KeyChar.Equals('2'))
            {
                QuestionScore.Value = 2;
            }
            else if (e.KeyChar.Equals('3'))
            {
                QuestionScore.Value = 3;
            }
            else if (e.KeyChar.Equals('4'))
            {
                QuestionScore.Value = 4;
            }
            else if (e.KeyChar.Equals('5'))
            {
                QuestionScore.Value = 5;
            }
            else if (e.KeyChar.Equals('0'))
            {
                QuestionScore.Value = 0;
            }
            else
            {
                test.Text = "you fucked up";
            }
            test.Text = "dick";//QuestionScore.Value.ToString();
        }

    }
}
