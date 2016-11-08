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
    public partial class EditUser : Form
    {
        private Connection conn;
        private User u;
        private int passwordChanged = 0;
        private int emailChanged = 0;
        private int firstChanged = 0;
        private int lastChanged = 0;
        

        public EditUser()
        {
            InitializeComponent();
            CenterToScreen();
            conn = new Connection();
            GetUserInfo();
        }

        public void GetUserInfo()
        {
            u = new User();
            u.username = Form1.userName;
            MySqlDataReader reader = null;
            string selectUserName = "SELECT username FROM user WHERE username = '" + u.username + "'";
            string selectPassword = "SELECT password FROM user WHERE username = '" + u.username + "'";
            string selectEmail = "SELECT email FROM user WHERE username = '" + u.username + "'";
            string selectFirstName = "SELECT firstname FROM user WHERE username = '" + u.username + "'";
            string selectLastName = "SELECT lastname FROM user WHERE username = '" + u.username + "'";
            string selectLevel = "SELECT level FROM user WHERE username = '" + u.username + "'";

            MySqlCommand getUsername = new MySqlCommand(selectUserName, conn.getConn());
            reader = getUsername.ExecuteReader();

            while (reader.Read())
            {
               u.username = (string)reader["username"];
            }
            reader.Close();

            MySqlCommand getPassword = new MySqlCommand(selectPassword, conn.getConn());
            reader = getPassword.ExecuteReader();

            while (reader.Read())
            {
                u.password = (string) reader["password"];
            }
            reader.Close();

            MySqlCommand getEmail = new MySqlCommand(selectEmail, conn.getConn());
            reader = getEmail.ExecuteReader();

            while (reader.Read())
            {
                u.email = (string)reader["email"];
            }
            reader.Close();

            MySqlCommand getFirstName= new MySqlCommand(selectFirstName, conn.getConn());
            reader = getFirstName.ExecuteReader();

            while (reader.Read())
            {
                u.first = (string)reader["firstname"];
            }
            reader.Close();

            MySqlCommand getLastName = new MySqlCommand(selectLastName, conn.getConn());
            reader = getLastName.ExecuteReader();

            while (reader.Read())
            {
                u.last = (string)reader["lastname"];
            }
            reader.Close();

            MySqlCommand getLevel = new MySqlCommand(selectLevel, conn.getConn());
            reader = getLevel.ExecuteReader();

            while (reader.Read())
            {
                u.role = (string)reader["level"].ToString();
            }
            reader.Close();

            usernameTxt.Text = u.username;
            passwordTxt.Text = u.password;
            emailTxt.Text = u.email;
            firstTxt.Text = u.first;
            lastTxt.Text = u.last;
            lvlTxt.Text = u.role;
        }

        private void chngPswd_Click(object sender, EventArgs e)
        {
            passwordTxt.ReadOnly = false;
            changePswdTxt.ReadOnly = false;
            passwordTxt.Text = "New Password";
            passwordTxt.UseSystemPasswordChar = false;
            changePswdTxt.Text = "Confirm Password";
            chngPswd.Visible = false;
            passwordChanged = 1;
            submit.Visible = true;
            enterPassword.Visible = true;
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text != u.email)
            {
                emailChanged = 1;
                submit.Visible = true;
                enterPassword.Visible = true;
            }
        }

        private void firstTxt_TextChanged(object sender, EventArgs e)
        {
            if (firstTxt.Text != u.first)
            {
                firstChanged = 1;
                submit.Visible = true;
                enterPassword.Visible = true;
            }
        }

        private void lastTxt_TextChanged(object sender, EventArgs e)
        {
            if (lastTxt.Text != u.last)
            {
                lastChanged = 1;
                submit.Visible = true;
                enterPassword.Visible = true;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (passwordChanged == 1)
            {
                UpdatePassword();
            }
            else if (emailChanged == 1)
            {
                UpdateEmail();
            }
            else if (firstChanged == 1)
            {
                UpdateFirst();
            }
            else if (lastChanged == 1)
            {
                UpdateLast();
            }
            conn.Close();
            this.Close();
        }

        private void enterPassword_Enter(object sender, EventArgs e)
        {
            enterPassword.Text = "";
            enterPassword.UseSystemPasswordChar = true;
        }

        private void changePswdTxt_Leave(object sender, EventArgs e)
        {
            if (passwordTxt.Text != changePswdTxt.Text)
            {
                changePswdTxt.ForeColor = Color.Red;
                changePswdTxt.Text = "Does Not Match";
                changePswdTxt.UseSystemPasswordChar = false;
                submit.Visible = false;
            }
            else if (passwordTxt.Text == changePswdTxt.Text)
            {
                submit.Visible = true;
            }
        }

        private void changePswdTxt_Enter(object sender, EventArgs e)
        {
            changePswdTxt.ForeColor = Color.Black;
            changePswdTxt.Text = "";
            changePswdTxt.UseSystemPasswordChar = true;
        }

        private void enterPassword_TextChanged(object sender, EventArgs e)
        {
            if (enterPassword.Text == u.password)
            {
                submit.Enabled = true;
            }
        }

        private void UpdatePassword()
        {
            string query = "UPDATE user SET password = '" + passwordTxt.Text + "' WHERE username= '" + u.username + "'";
            MySqlCommand updatePassword = new MySqlCommand(query, conn.getConn());
            updatePassword.ExecuteNonQuery();
        }

        private void UpdateEmail()
        {
            string query = "UPDATE user SET email = '" + emailTxt.Text + "' WHERE username= '" + u.username + "'";
            MySqlCommand updateEmail = new MySqlCommand(query, conn.getConn());
            updateEmail.ExecuteNonQuery();
        }

        private void UpdateFirst()
        {
            string query = "UPDATE user SET firstname = '" + firstTxt.Text + "' WHERE username= '" + u.username + "'";
            MySqlCommand updateFirst = new MySqlCommand(query, conn.getConn());
            updateFirst.ExecuteNonQuery();
        }

        private void UpdateLast()
        {
            string query = "UPDATE user SET lastname = '" + lastTxt.Text + "' WHERE username= '" + u.username + "'";
            MySqlCommand updateLast = new MySqlCommand(query, conn.getConn());
            updateLast.ExecuteNonQuery();
        }

        private void EditUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
