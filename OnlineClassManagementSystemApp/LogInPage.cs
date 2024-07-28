using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineClassManagementSystemApp
{
    public partial class LogInPage : Form
    {
        Function function = new Function();
        public SqlConnection sqlConnection { get; private set; }
        public SqlDataReader sqlDataReader { get; private set; }

        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itsak\source\repos\AWPMiniProject\OnlineClassManagementSystemApp\OnlineClassManagementSystemApp\OCMSdatabase.mdf;Integrated Security=True");
            sqlConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashBoard adminDashBoard = new AdminDashBoard();
                adminDashBoard.Show();
                this.Hide();
            }
            else if(textBox1.Text == "student" && textBox2.Text == "student")
            {
                StudentDashBoard studentDashBoard = new StudentDashBoard();
                studentDashBoard.Show();
                this.Hide();
            }
            else if(textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student WHERE email='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    sqlDataReader.Close();
                    StudentDashBoard studentDashBoard = new StudentDashBoard();
                    studentDashBoard.Show();
                    this.Hide();
                }
                else
                {
                    sqlDataReader.Close();
                    MessageBox.Show("Account Not Available, Ask ADMIN to Register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
