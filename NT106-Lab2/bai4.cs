using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai4 : Form
    {
        [Serializable]
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

        private readonly Regex reMSSV = new Regex(@"^\d{8}$");
        private readonly Regex rePhone = new Regex(@"^0\d{9}$");

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
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hoten = nameBox.Text.Trim();
                string mssv = idBox.Text.Trim();
                string phone = phoneNumberBox.Text.Trim();

                if (!reMSSV.IsMatch(mssv))
                {
                    MessageBox.Show("MSSV phải gồm đúng 8 chữ số.", "Lỗi MSSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idBox.Focus();
                    return;
                }

                if (!rePhone.IsMatch(phone))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bởi 0.", "Lỗi SĐT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneNumberBox.Focus();
                    return;
                }

                if (!float.TryParse(point1.Text.Trim(), out float d1) ||
                    !float.TryParse(point2.Text.Trim(), out float d2) ||
                    !float.TryParse(point3.Text.Trim(), out float d3))
                {
                    MessageBox.Show("Điểm phải là số hợp lệ.", "Lỗi Điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10.", "Lỗi Điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SinhVien sv = new SinhVien()
                {
                    HoTen = hoten,
                    MSSV = mssv,
                    DienThoai = phone,
                    Diem1 = d1,
                    Diem2 = d2,
                    Diem3 = d3,
                    DiemTB = 0 
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

                num.Text = $"{ds.Count}/{ds.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên để ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (StreamWriter sw = new StreamWriter("input4.txt", false, Encoding.UTF8))
                {
                    foreach (var sv in ds)
                    {
                        sw.WriteLine($"{sv.HoTen},{sv.MSSV},{sv.DienThoai},{sv.Diem1},{sv.Diem2},{sv.Diem3}");
                    }
                }

                MessageBox.Show("Đã ghi file input4.txt thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowStudent(int i)
        {
            if (ds.Count == 0) return;
            if (i < 0 || i >= ds.Count) return;

            var sv = ds[i];
            nameBox2.Text = sv.HoTen;
            idBox2.Text = sv.MSSV;
            phoneNumberBox2.Text = sv.DienThoai;
            point1Read.Text = sv.Diem1.ToString("0.##");
            point2Read.Text = sv.Diem2.ToString("0.##");
            point3Read.Text = sv.Diem3.ToString("0.##");
            avgPointRead.Text = sv.DiemTB.ToString("0.00");
            num.Text = $"{i + 1}/{ds.Count}";
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ds.Clear();
                var errors = new List<string>();
                var lines = File.ReadAllLines("input4.txt");
                int lineNo = 0;
                foreach (var line in lines)
                {
                    lineNo++;
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(',');
                    if (parts.Length != 6)
                    {
                        errors.Add($"Dòng {lineNo}: Sai định dạng (cần 6 trường).");
                        continue;
                    }

                    string hoten = parts[0].Trim();
                    string mssv = parts[1].Trim();
                    string phone = parts[2].Trim();
                    if (!float.TryParse(parts[3].Trim(), out float d1) ||
                        !float.TryParse(parts[4].Trim(), out float d2) ||
                        !float.TryParse(parts[5].Trim(), out float d3))
                    {
                        errors.Add($"Dòng {lineNo}: Điểm không hợp lệ.");
                        continue;
                    }

                    if (!reMSSV.IsMatch(mssv))
                    {
                        errors.Add($"Dòng {lineNo}: MSSV không hợp lệ ({mssv}).");
                        continue;
                    }
                    if (!rePhone.IsMatch(phone))
                    {
                        errors.Add($"Dòng {lineNo}: SĐT không hợp lệ ({phone}).");
                        continue;
                    }
                    if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
                    {
                        errors.Add($"Dòng {lineNo}: Điểm ngoài khoảng 0-10.");
                        continue;
                    }

                    var sv = new SinhVien()
                    {
                        HoTen = hoten,
                        MSSV = mssv,
                        DienThoai = phone,
                        Diem1 = d1,
                        Diem2 = d2,
                        Diem3 = d3
                    };
                    sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3.0f;
                    ds.Add(sv);
                }

                using (StreamWriter sw = new StreamWriter("output4.txt", false, Encoding.UTF8))
                {
                    foreach (var sv in ds)
                    {
                        sw.WriteLine($"{sv.HoTen},{sv.MSSV},{sv.DienThoai},{sv.Diem1},{sv.Diem2},{sv.Diem3},{sv.DiemTB:F2}");
                    }
                }

                index = 0;
                if (ds.Count > 0) ShowStudent(index);

                if (errors.Count > 0)
                {
                    var msg = "Đọc file hoàn tất, nhưng có một số bản ghi bị bỏ qua:\n" + string.Join("\n", errors);
                    MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Đọc file và tính điểm trung bình thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
