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
    public partial class makeTest : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;
        public makeTest()
        {
            InitializeComponent();
            ConnectDatabase();
            populateCombo();
        }

        public void ConnectDatabase()
        {
            string myConnectionString;
            myConnectionString = "server=einstein.etsu.edu;uid=bentleyp;pwd=12345;database=bentleyp";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
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

        }

        private void finishCreating_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }



        private void populateCombo()
        {
            List<string> list = new List<string>();
            MySqlDataReader reader = null;
            string selectCourse = "SELECT * FROM course";

            MySqlCommand getCourse = new MySqlCommand(selectCourse, conn);
            reader = getCourse.ExecuteReader();
            
            while (reader.Read())
            {
                //String test = (string)reader["name"];
                //label3.Text = (string)reader["name"];
                this.comboBox2.Items.Add(reader["courseID"].ToString() + " " + (string)reader["name"]);
                if (!reader.HasRows)
                    return;
            }
            reader.Close();
        }
    }
}
