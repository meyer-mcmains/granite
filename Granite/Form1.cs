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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectDatabase();
        }

        //center login labels and txtboxes on load
        private void Form1_Load(object sender, EventArgs e)
        {
            usrlabel.Left = (this.ClientSize.Width - username.Width)/2;
            usrlabel.Top = (this.ClientSize.Height - username.Height)/2;
            username.Left = this.usrlabel.Left;
            username.Top = (this.usrlabel.Top + usrlabel.Height);
            pswdLabel.Left = this.usrlabel.Left;
            pswdLabel.Top = (this.username.Top + username.Height);
            pswd.Left = this.usrlabel.Left;
            pswd.Top = (this.pswdLabel.Top + pswd.Height);
            loginButton.Left = this.usrlabel.Left;
            loginButton.Top = (this.pswd.Top + pswd.Height);
        }

        //recenter login labels and txtboxes if window is resized
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            usrlabel.Left = (this.ClientSize.Width - username.Width)/2;
            usrlabel.Top = (this.ClientSize.Height - username.Height)/2;
            username.Left = this.usrlabel.Left;
            username.Top = (this.usrlabel.Top + usrlabel.Height);
            pswdLabel.Left = this.usrlabel.Left;
            pswdLabel.Top = (this.username.Top + username.Height);
            pswd.Left = this.usrlabel.Left;
            pswd.Top = (this.pswdLabel.Top + pswd.Height);
            loginButton.Left = this.usrlabel.Left;
            loginButton.Top = (this.pswd.Top + pswd.Height);
        }

        //establish a connection to the database
        private void ConnectDatabase()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=einstein.etsu.edu;uid=bentleyp;pwd=12345;database=bentleyp";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                indicator.ForeColor = Color.Green;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                indicator.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=einstein.etsu.edu;uid=bentleyp;pwd=12345;database=bentleyp";
            string usrName = null;
            string password = null;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                indicator.ForeColor = Color.Green;

                MySqlDataReader reader = null;
                string selectUser = "SELECT username FROM user";

                MySqlCommand getUsername = new MySqlCommand(selectUser, conn);
                reader = getUsername.ExecuteReader();

                while (reader.Read())
                {
                    usrName = (string) reader["username"];
                }
                reader.Close();

                string selectPassword = "SELECT password FROM user";

                MySqlCommand getPassword = new MySqlCommand(selectPassword, conn);
                reader = getPassword.ExecuteReader();

                while (reader.Read())
                {
                    password = (string) reader["password"];
                }
                reader.Close();

                if (username.Text == usrName)
                {
                    if (pswd.Text == password)
                    {
                        username.Hide();
                        pswd.Hide();
                        pswdLabel.Hide();
                        usrlabel.Hide();
                        loginButton.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                indicator.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
