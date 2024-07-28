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
    public partial class UpdateTeacher : Form
    {
        Function function = new Function();

        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherRegistration = new TeacherRegistration();
            teacherRegistration.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE Teacher SET fullname='" + textBox2.Text + "', gender='" + textBox3.Text + "', phoneno='" + textBox4.Text + "', email='" + textBox5.Text + "', salary='" + textBox6.Text + "', subject='" + textBox7.Text + "', password='" + textBox8.Text + "' WHERE teacher_id='" + textBox1.Text + "' ";
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
