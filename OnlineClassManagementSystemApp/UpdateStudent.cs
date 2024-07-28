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
    public partial class UpdateStudent : Form
    {
        Function function = new Function();

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
            this.Dispose();
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
            textBox9.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE Student SET fullname='" + textBox2.Text + "', fathername='" + textBox3.Text + "', mothername='" + textBox4.Text + "', gender='" + textBox5.Text + "', dob='" + textBox6.Text + "', phoneno='" + textBox7.Text + "', email='" + textBox8.Text + "', password='" + textBox9.Text + "' WHERE student_id='" + textBox1.Text + "' ";
            MessageBox.Show(function.Update(UPDATE), "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
