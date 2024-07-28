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
    public partial class Lecture : Form
    {
        Function function = new Function();

        public Lecture()
        {
            InitializeComponent();
        }

        private void Lecture_Load(object sender, EventArgs e)
        {
            string FILL = "SELECT * FROM Lecture";
            function.FillGridView(FILL, dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLecture addLecture = new AddLecture();
            addLecture.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateLecture updateLecture = new UpdateLecture();
            updateLecture.Show();
            this.Hide();
        }
    }
}
