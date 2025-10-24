using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file để đọc";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;
                string fileContent = string.Empty;

                try
                {
                    this.readFileName.Text = ofd.SafeFileName;

                    string filePath = ofd.FileName;

                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        this.readURL.Text = fs.Name;

                        double fileSizeKB = (double)fs.Length / 1024;
                        this.readSize.Text = $"{fileSizeKB:0.##} KB";

                        using (StreamReader sr = new StreamReader(fs))
                        {
                            fileContent = sr.ReadToEnd();
                        }
                    }

                    this.content.Text = fileContent;

                    charCount = fileContent.Length;
                    this.readCharacterCount.Text = charCount.ToString();

                    string[] lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    lineCount = lines.Length;
                    this.readLineCount.Text = lineCount.ToString();

                    wordCount = Regex.Matches(fileContent, @"\b\w+\b").Count;
                    this.readWordCount.Text = wordCount.ToString();

                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Lỗi I/O khi đọc file: {ex.Message}", "Lỗi Đọc File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
