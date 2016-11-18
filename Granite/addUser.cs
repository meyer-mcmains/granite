using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Granite
{
    public partial class addUser : Form
    {
        private Connection conn;
        private User u;

        private int userChanged = 0,
                    emailChanged = 0,
                    firstChanged = 0,
                    lastChanged = 0;

        public addUser()
        {
            InitializeComponent();
        }

        private void firstTxt_TextChanged(object sender, EventArgs e)
        {
            firstChanged = 1;
            checkedChanged();
        }

        private void lastTxt_TextChanged(object sender, EventArgs e)
        {
            lastChanged = 1;
            checkedChanged();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            conn = new Connection();

            try
            {
                string inUser = "INSERT INTO user (username, password, email, firstname, lastname, level) VALUES (@username, @password, @email, @first, @last, @level);";

                using (MySqlCommand cmd = new MySqlCommand(inUser, conn.getConn()))
                {
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@email", u.email);
                    cmd.Parameters.AddWithValue("@first", u.first);
                    cmd.Parameters.AddWithValue("@last", u.last);
                    cmd.Parameters.AddWithValue("@level", u.role);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            Close();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            userChanged = 1;
            checkedChanged();
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            emailChanged = 1;
            checkedChanged();
        }

        private void checkedChanged()
        {
            if (userChanged == 1 && firstChanged == 1 && lastChanged == 1 && emailChanged == 1)
            {
                submit.Visible = true;
                submit.Enabled = true;
                u = new User(usernameTxt.Text, firstTxt.Text, lastTxt.Text, emailTxt.Text, "0", "password");
            }
        }
    }
}