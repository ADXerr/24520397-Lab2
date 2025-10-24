using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NT106_Lab2
{
    
    public partial class bai4 : Form
    {
        public class SinhVien
        {
            public string HoTen { get; set; }
            public string MSSV { get; set; }
            public string DienThoai { get; set; }
            public float Diem1 { get; set; }
            public float Diem2 { get; set; }
            public float Diem3 { get; set; }
            public float DiemTB { get; set; }
        }

        private List<SinhVien> ds = new List<SinhVien>();
        private int index = 0;

        public bai4()
        {
            InitializeComponent();
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text) ||
                    string.IsNullOrWhiteSpace(idBox.Text) ||
                    string.IsNullOrWhiteSpace(phoneNumberBox.Text) ||
                    string.IsNullOrWhiteSpace(point1.Text) ||
                    string.IsNullOrWhiteSpace(point2.Text) ||
                    string.IsNullOrWhiteSpace(point3.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }

                float d1 = float.Parse(point1.Text);
                float d2 = float.Parse(point2.Text);
                float d3 = float.Parse(point3.Text);

                SinhVien sv = new SinhVien()
                {
                    HoTen = nameBox.Text.Trim(),
                    MSSV = idBox.Text.Trim(),
                    DienThoai = phoneNumberBox.Text.Trim(),
                    Diem1 = d1,
                    Diem2 = d2,
                    Diem3 = d3
                };

                ds.Add(sv);
                content.AppendText(
                    $"{sv.HoTen}\r\n" +
                    $"{sv.MSSV}\r\n" +
                    $"{sv.DienThoai}\r\n" +
                    $"{sv.Diem1}\r\n" +
                    $"{sv.Diem2}\r\n" +
                    $"{sv.Diem3}\r\n\r\n"
                );

                nameBox.Clear();
                idBox.Clear();
                phoneNumberBox.Clear();
                point1.Clear();
                point2.Clear();
                point3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập dữ liệu");
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("input4.txt"))
                {
                    foreach (var sv in ds)
                    {
                        sw.WriteLine($"{sv.HoTen},{sv.MSSV},{sv.DienThoai},{sv.Diem1},{sv.Diem2},{sv.Diem3}");
                    }
                }
                MessageBox.Show("Đã ghi file input4.txt thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi ghi file");
            }
        }

        private void ShowStudent(int i)
        {
            if (ds.Count == 0) return;
            var sv = ds[i];
            nameBox2.Text = sv.HoTen;
            idBox2.Text = sv.MSSV;
            phoneNumberBox2.Text = sv.DienThoai;
            point1Read.Text = sv.Diem1.ToString();
            point2Read.Text = sv.Diem2.ToString();
            point3Read.Text = sv.Diem3.ToString();
            avgPointRead.Text = sv.DiemTB.ToString("0.00");
            num.Text = $"{i + 1}/{ds.Count}";
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                string[] lines = File.ReadAllLines("input4.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        SinhVien sv = new SinhVien()
                        {
                            HoTen = parts[0],
                            MSSV = parts[1],
                            DienThoai = parts[2],
                            Diem1 = float.Parse(parts[3]),
                            Diem2 = float.Parse(parts[4]),
                            Diem3 = float.Parse(parts[5])
                        };
                        sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3;
                        ds.Add(sv);
                    }
                }

                using (StreamWriter sw = new StreamWriter("output4.txt"))
                {
                    foreach (var sv in ds)
                    {
                        sw.WriteLine($"{sv.HoTen},{sv.MSSV},{sv.DienThoai},{sv.Diem1},{sv.Diem2},{sv.Diem3},{sv.DiemTB:F2}");
                    }
                }

                index = 0;
                ShowStudent(index);
                MessageBox.Show("Đọc file và tính điểm trung bình thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc file");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                ShowStudent(index);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (index < ds.Count - 1)
            {
                index++;
                ShowStudent(index);
            }
        }
    }
}
