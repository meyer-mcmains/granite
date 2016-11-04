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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            populateFields();
        }

        private void TakeTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home(user);
            home.Show();
        }

        

    }
}
