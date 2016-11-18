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
    public partial class ChooseStudent : Form
    {
        private User user;
        private Connection conn; 
        public ChooseStudent()
        {
            InitializeComponent();
        }

        public ChooseStudent(User u)
        {
            user = u;
            InitializeComponent();
            ConnectDatabase();
            populatStudentCombo();
            populateCourseCombo();
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

        private void populateCourseCombo()
        {
            List<string> list = new List<string>();
            MySqlDataReader reader = null;
            string selectCourse = "SELECT * FROM course";

            MySqlCommand getCourse = new MySqlCommand(selectCourse, conn.getConn());
            reader = getCourse.ExecuteReader();

            while (reader.Read())
            {

                this.CourseBox.Items.Add(reader["courseID"].ToString() + " " + (string)reader["name"]);
                if (!reader.HasRows)
                    break;
            }
            reader.Close();
            return;
        }

        private void populatStudentCombo()
        {
            List<string> list = new List<string>();
            MySqlDataReader reader = null;
            string selectCourse = "SELECT * FROM student";

            MySqlCommand getCourse = new MySqlCommand(selectCourse, conn.getConn());
            reader = getCourse.ExecuteReader();

            while (reader.Read())
            {
                this.StudentBox.Items.Add(reader["firstname"].ToString() + " " + (string)reader["lastname"]);
                if (!reader.HasRows)
                    break;
            }
            reader.Close();
            return;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            try
            {
                string name = StudentBox.SelectedItem.ToString();
                string[] names = name.Split(' ');
                string getStudent = "SELECT * FROM student WHERE firstname=" + "'" + names[0] + "'" + " AND lastname=" + "'" + names[1] + "'";
                MySqlCommand get1Student = new MySqlCommand(getStudent, conn.getConn());
                reader = get1Student.ExecuteReader();
                Student student = new Student();
                while (reader.Read())
                {

                    student = new Student(reader["enum"].ToString(), reader["firstname"].ToString(), reader["lastname"].ToString());
                    if (!reader.HasRows)
                        break;
                }
                string strCourse = CourseBox.SelectedItem.ToString();
                strCourse = strCourse.Substring(0, 4);
                Course course =  new Course(strCourse);
                MainWindow main = new MainWindow(user, student); // add the Course afterwards!!
                main.Show();
                this.Close();
            }
            catch(Exception)
            {
                Home h = new Home(user); // add the Course afterwards!!
                h.Show();
                this.Close();
            }
            
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addStudent ad = new addStudent();
            this.Close();

        }
    }
}
