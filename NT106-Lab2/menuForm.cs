using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            bai1 f = new bai1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {

        }

        private void bai3_Click(object sender, EventArgs e)
        {

        }

        private void bai4_Click(object sender, EventArgs e)
        {

        }

        private void bai5_Click(object sender, EventArgs e)
        {

        }

        private void bai6_Click(object sender, EventArgs e)
        {

        }

        private void bai7_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
