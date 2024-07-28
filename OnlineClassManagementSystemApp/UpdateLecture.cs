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
    public partial class UpdateLecture : Form
    {
        Function function = new Function();

        public UpdateLecture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture();
            lecture.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE Lecture SET subject='" + textBox2.Text + "', start_date='" + textBox3.Text + "', end_date='" + textBox4.Text + "', start_time='" + textBox5.Text + "', end_time='" + textBox6.Text + "', duration='" + textBox7.Text + "', days='" + textBox8.Text + "' WHERE lecture_id='" + textBox1.Text + "' ";
            MessageBox.Show(function.Update(UPDATE), "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
