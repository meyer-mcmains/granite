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
    public partial class Login : Form
    {
        private Connection c;
        public static string userName;
        public Login()
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
        }

        //establish a connection to the database
        private void ConnectDatabase()
        {


            try
            {
                c = new Connection();
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
            Connection c = new Connection();
            string usrName = null;
            string password = null;
            try
            {
                indicator.ForeColor = Color.Green;

                MySqlDataReader reader = null;
                string selectUser = "SELECT username FROM user WHERE username='" + username.Text + "'";

                MySqlCommand getUsername = new MySqlCommand(selectUser, c.getConn());
                reader = getUsername.ExecuteReader();

                while (reader.Read())
                {
                    usrName = (string) reader["username"];
                }
                reader.Close();

                string selectPassword = "SELECT password FROM user WHERE username='" + username.Text + "'";

                MySqlCommand getPassword = new MySqlCommand(selectPassword, c.getConn());
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
                        User u = new User(username.Text);
                        userName = username.Text;
                        c.Close();
                        Home hw = new Home();
                        hw.Show();
                        this.Hide();
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

        private void exit_Click(object sender, EventArgs e)
        {
            c.Close();
            Application.Exit();
        }
    }
}
