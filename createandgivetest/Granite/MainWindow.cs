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
    public partial class MainWindow : Form
    {
        private Connection conn;
        public MainWindow()
        {
            InitializeComponent();
            conn = new Connection();
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
                //String test = (string)reader["name"];
                //label3.Text = (string)reader["name"];
                richTextBox1.Text = rdr["questiontext"].ToString();
                richTextBox2.Text = rdr["answertext"].ToString();
                //this.comboBox2.Items.Add(reader["courseID"].ToString() + " " + (string)reader["name"]);
                if (!rdr.HasRows)
                  break;
           }

            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateFields();
        }
    }
}
