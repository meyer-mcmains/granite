using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

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
            string studentfname;
            string studentlname;
            //string en = Interaction.InputBox("Enter Student eNumber (without the 'e'):", "GOAT", "enter");
            string en = "00000000";
            MySqlDataReader rdr = null;
            string strQuery = "SELECT * FROM student WHERE enum = " + en;

            MySqlCommand populateFields = new MySqlCommand(strQuery, conn.getConn());            
                
            rdr = populateFields.ExecuteReader();
            if (!rdr.HasRows)
            {
                if(MessageBox.Show("Student not found.  Would you like to add student?", "GOAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //enter the student into the database
                }
                else
                {
                    return;
                }
            }
            rdr.Read();
            studentfname = rdr["firstname"].ToString();
            studentlname = rdr["lastname"].ToString();
            

            rdr.Close();

            Student stu = new Student(en, studentfname,studentlname);
            TakeTest mw = new TakeTest(user, stu);
            mw.Show();
            conn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeTest mt = new makeTest();
            mt.Show();
            this.Close();
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
