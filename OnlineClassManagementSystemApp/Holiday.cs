using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineClassManagementSystemApp
{
    public partial class Holiday : Form
    {
        Function function = new Function();

        public Holiday()
        {
            InitializeComponent();
        }

        private void Holiday_Load(object sender, EventArgs e)
        {
            string FILL = "SELECT * FROM Holiday";
            function.FillGridView(FILL, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO Holiday (holiday_id, name, duration, start_date, end_date) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            MessageBox.Show(function.Insert(INSERT), "Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE Holiday SET name='" + textBox2.Text + "', duration='" + textBox3.Text + "', start_date='" + textBox4.Text + "', end_date='" + textBox5.Text + "' WHERE holiday_id='" + textBox1.Text + "' ";
            MessageBox.Show(function.Update(UPDATE), "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
