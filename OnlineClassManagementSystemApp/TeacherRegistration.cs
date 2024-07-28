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
    public partial class TeacherRegistration : Form
    {
        Function function = new Function();

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTeacher updateTeacher = new UpdateTeacher();
            updateTeacher.Show();
            this.Hide();
        }

        public TeacherRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.Show();
            this.Hide();
        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            string FILL = "SELECT * FROM Teacher";
            function.FillGridView(FILL, dataGridView1);
        }
    }
}
