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
    public partial class Analytics : Form
    {
        private Connection conn;
        public Analytics()
        {
            InitializeComponent();
            conn = new Connection();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxEnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = richTextBoxEnum.Text;
            MySqlDataReader rdr = null;
            string strQuery = "SELECT AVG(ans.Score), c.name, c.courseID, att.date FROM attempt att JOIN student s ON(att.studentID = s.enum) JOIN answer ans ON(att.attemptID = ans.AttemptID) JOIN course c ON(att.courseID = c.courseID) WHERE att.studentID = " + id + " GROUP BY att.attemptID";

            MySqlCommand populateFields = new MySqlCommand(strQuery, conn.getConn());

            rdr = populateFields.ExecuteReader();
            while (rdr.Read())
            {
                String a = "Course ID: ";
                String b = "Course Name: ";
                String c = "Attempt Date: ";
                String d = "Score: ";
                a += rdr["courseID"].ToString();
                b += rdr["name"].ToString();
                c += rdr["date"].ToString();
                d += rdr["AVG(ans.Score)"].ToString();

                richTextBox1.Text = a + "\n" + b + "\n" + c + "\n" + d + "\n";

          
                if (!rdr.HasRows)
                    break;
            }
            rdr.Close();
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlDataReader rdr = null;
            string strQuery = "SELECT q.questionID, q.questiontext, AVG(a.score) FROM answer a JOIN question q ON(a.QuestionID = q.questionID) GROUP BY q.questionID; ";

            MySqlCommand populateFields = new MySqlCommand(strQuery, conn.getConn());
            rdr = populateFields.ExecuteReader();
            //richTextBox2.Text = rdr.ToString();

            while (rdr.Read())
            {
                String h = "Question ID: ";
                h += rdr["questionID"].ToString();
                String s = "Question: " + rdr["questionText"].ToString();
                String t = "Score: " + rdr["AVG(a.score)"].ToString();
                richTextBox2.Text += h + "\n" + s + "\n" + t + "\n\n";

                if (!rdr.HasRows)
                    break;
            }

            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you done with analytics?", "Finish Analytics", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The analytics have been closed.", "Analytics Closed!", MessageBoxButtons.OK);
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
        private void Analytics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Analytics_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
