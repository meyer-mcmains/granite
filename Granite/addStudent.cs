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
    public partial class addStudent : Form
    {

        private Connection conn;
        private Student s;

        private int eChanged;
        private int firstChanged;
        private int lastChanged;
        private int conChanged;

        public addStudent()
        {
            InitializeComponent();
            this.eNumberTxt.KeyPress += new KeyPressEventHandler(eNumberTxt_KeyPress);
            CreateStudent();
        }
        
        private void CreateStudent()
        {
            concentratoinCombo.Items.Add("CS");
            concentratoinCombo.Items.Add("IT");
        }

        private void eNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void eNumberTxt_TextChanged(object sender, EventArgs e)
        {
            eChanged = 1;
            checkedChanged();
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

        private void concentratoinCombo_TextChanged(object sender, EventArgs e)
        {
            conChanged = 1;
            checkedChanged();
        }

        private void checkedChanged()
        {
            if(eChanged == 1 && firstChanged == 1 && lastChanged == 1 && conChanged == 1)
            {
                submit.Visible = true;
                submit.Enabled = true;
                s = new Student(eNumberTxt.Text, firstTxt.Text, lastTxt.Text, concentratoinCombo.Text);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            conn = new Connection();

            try
            {
                string inStudent = "INSERT INTO student (enum, firstname, lastname, concentration) VALUES (@enumber, @first, @last, @con);";

                using (MySqlCommand cmd = new MySqlCommand(inStudent, conn.getConn()))
                {
                    cmd.Parameters.AddWithValue("@enumber", s.enumber);
                    cmd.Parameters.AddWithValue("@first", s.first);
                    cmd.Parameters.AddWithValue("@last", s.last);
                    cmd.Parameters.AddWithValue("@con", s.concentration);

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
    }
}
