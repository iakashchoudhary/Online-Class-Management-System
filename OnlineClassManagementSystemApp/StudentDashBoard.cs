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
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSchedule showSchedule = new ShowSchedule();
            showSchedule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowBooks showBooks = new ShowBooks();
            showBooks.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowEvents showEvents = new ShowEvents();
            showEvents.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowHoliday showHoliday = new ShowHoliday();
            showHoliday.Show();
            this.Hide();
        }
    }
}
