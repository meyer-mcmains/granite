using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Granite
{
    public partial class makeTest : Form
    {
        private Connection conn;

        public makeTest()
        {
            InitializeComponent();
            CenterToScreen();
            ConnectDatabase();
            populateCombo();
        }

        public void ConnectDatabase()
        {
            try
            {
                conn = new Connection();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void makeTest_Load(object sender, EventArgs e)
        {
        }

        private void saveQuestion_Click(object sender, EventArgs e)
        {
            MySqlDataReader rdr = null;
            try
            {
                string strCourse = comboBox2.SelectedItem.ToString();
                string strAdmin = "admin";
                strCourse = strCourse.Substring(0, 4);
                //richTextBox1.Text = strCourse;
                string strQuery = "INSERT INTO question(questiontext, answertext, creator, course) VALUES('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + strAdmin + "'," + strCourse + ")";
                MySqlCommand addQuestion = new MySqlCommand(strQuery, conn.getConn());
                rdr = addQuestion.ExecuteReader();
                rdr.Close();
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                MessageBox.Show("Question and Answer Saved!", "Saving...", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
            }
        }

        private void finishCreating_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Did you save your question?", "Finished Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Taking you home!", "Finished", MessageBoxButtons.OK);
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

        private void populateCombo()
        {
            List<string> list = new List<string>();
            MySqlDataReader reader = null;
            string selectCourse = "SELECT * FROM course";

            MySqlCommand getCourse = new MySqlCommand(selectCourse, conn.getConn());
            reader = getCourse.ExecuteReader();

            while (reader.Read())
            {
                //String test = (string)reader["name"];
                //label3.Text = (string)reader["name"];

                this.comboBox2.Items.Add(reader["courseID"].ToString() + " " + (string)reader["name"]);
                if (!reader.HasRows)
                    break;
            }
            reader.Close();
            return;
        }

        private void makeTest_FormClosing(object sender, FormClosingEventArgs e)
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

        private void makeTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}