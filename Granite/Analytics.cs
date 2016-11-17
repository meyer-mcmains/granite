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
            string strQuery = "SELECT AVG(ans.score), c.name, c.courseID, att.date FROM attempt att JOIN student s ON (att.studentID = s.enum) JOIN answer ans ON(att.attemptID = ans.AttemptID) JOIN course c ON(att.courseID = c.courseID) WHERE s.enum = " + id + " GROUP BY att.date, c.courseID, c.name ORDER BY att.date ASC";

            MySqlCommand populateFields = new MySqlCommand(strQuery, conn.getConn());

            rdr = populateFields.ExecuteReader();
            richTextBoxEnum.Text = rdr.ToString();
            /*
            while (rdr.Read())
            {
                richTextBox1.Text = rdr["questiontext"].ToString();
                if (!rdr.HasRows)
                    break;
            }*/
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
            richTextBox2.Text = rdr.ToString();
        }
    }
}
