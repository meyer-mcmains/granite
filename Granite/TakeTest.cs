using MySql.Data.MySqlClient;
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
    public partial class TakeTest : Form
    {
        internal User user;
        internal Student stu;
        private Connection conn;
        private int score;
        private int questions;
        public TakeTest()
        {
            InitializeComponent();
            conn = new Connection();
            populateFields();
        }
        public TakeTest(User u, Student s)
        {
            InitializeComponent();
            conn = new Connection();
            stu = s;
            user = u;
            stuNameBox.Text = stu.first + " " + stu.last;
            populateFields();
        }

        private void doStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            m.Show();
            Close();
        }

        private void populateFields()
        {
            MySqlDataReader rdr = null;
            string strQuery = "SELECT * FROM question ORDER BY RAND() LIMIT 1";
            
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            score += trackBar1.Value;   //add trackbar value to the score
            questions++;             //increment the number of questions asked
            trackBar1.Value = 0;
            populateFields();
        }

        private void TakeTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home(user);
            home.Show();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ScoreBox.Text = trackBar1.Value.ToString();
        }

        

    }
}
