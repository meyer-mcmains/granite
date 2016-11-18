using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Granite
{
    public partial class MainWindow : Form
    {
        internal User user;
        internal Student stu;
        internal Course courseid;
        private Connection conn;
        private int score;
        private int questions;

        public MainWindow()
        {
            InitializeComponent();
            CenterToScreen();
            conn = new Connection();
            //populateFields();
        }

        public MainWindow(User u, Student s, Course c)
        {
            InitializeComponent();
            conn = new Connection();
            stu = s;
            user = u;
            courseid = c;
            textBox1.Text = stu.first + " " + stu.last;

            populateFields(courseid);
            
        }

        private void doStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            m.Show();
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void populateFields(Course courseid)
        {
            String priorid = courseid.getId();
            MySqlDataReader rdr = null;
            string strQuery = "SELECT * FROM question JOIN course ON  (question.course = course.courseID) WHERE course.courseid = " + priorid + " ORDER BY RAND() LIMIT 3";
            
            MySqlCommand populateFields = new MySqlCommand(strQuery, conn.getConn());

            rdr = populateFields.ExecuteReader();

            while (rdr.Read())
            {
                richTextBox1.Text = rdr["questiontext"].ToString();
                richTextBox2.Text = rdr["answertext"].ToString();
                if (!rdr.HasRows)
                    break;      
            }

            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += trackBar1.Value;   //add trackbar value to the score
            questions++;             //increment the number of questions asked
            trackBar1.Value = 0;
            //populateFields();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
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
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To go back to home press the home button in the options bar.", "Help", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to finish the test?", "Finish Test", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The Test has been closed.", "Test Closed!", MessageBoxButtons.OK);
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                //e.Cancel = true;
                this.Activate();
            }
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {

        }
    }
}
