using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineClassManagementSystemApp
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherRegistration = new TeacherRegistration();
            teacherRegistration.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture();
            lecture.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Event events = new Event();
            events.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Holiday holiday = new Holiday();
            holiday.Show();
            this.Hide();
        }
    }
}
