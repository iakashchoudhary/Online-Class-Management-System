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
    public partial class ShowBooks : Form
    {
        Function function = new Function();

        public ShowBooks()
        {
            InitializeComponent();
        }

        private void ShowBooks_Load(object sender, EventArgs e)
        {
            string FILL = "SELECT * FROM Book";
            function.FillGridView(FILL, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashBoard studentDashBoard = new StudentDashBoard();
            studentDashBoard.Show();
            this.Dispose();
        }
    }
}
