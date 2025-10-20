using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NT106_Lab2
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        string fileInput = "input1.txt";
        string fileOutput = "output1.txt";

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(fileInput))
                {
                    MessageBox.Show("Không tìm thấy file input1.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string content;
                using (StreamReader sr = new StreamReader(fileInput))
                {
                    content = sr.ReadToEnd();
                }

                result.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void write_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(result.Text))
                {
                    MessageBox.Show("Chưa có dữ liệu để ghi!", "Thông báo");
                    return;
                }

                using (StreamWriter sw = new StreamWriter(fileOutput))
                {
                    sw.Write(result.Text.ToUpper());
                }

                MessageBox.Show("Đã ghi nội dung sang file output1.txt!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }
    }
}
