using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai6 : Form
    {
        private Random random = new Random();

        public bai6()
        {
            InitializeComponent();
            Database.Initialize(); 
            LoadMonAn();
        }

        private void LoadMonAn()
        {
            ListMonAn.Clear();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT MonAn.TenMonAn, NguoiDung.HoVaTen 
                               FROM MonAn 
                               JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC;";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tenMon = reader["TenMonAn"].ToString();
                        string nguoi = reader["HoVaTen"].ToString();
                        ListMonAn.AppendText($"{tenMon} - ({nguoi})" + Environment.NewLine);
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string tenMon = MonAn.Text.Trim();
            string tenNguoi = name.Text.Trim();
            string hinhAnh = picURL.Text.Trim();

            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(tenNguoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên món ăn và họ tên người đóng góp!");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string checkNguoi = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @ten";
                int idNguoi;
                using (var cmd = new SQLiteCommand(checkNguoi, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", tenNguoi);
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        string insertNguoi = "INSERT INTO NguoiDung (HoVaTen) VALUES (@ten)";
                        using (var cmd2 = new SQLiteCommand(insertNguoi, conn))
                        {
                            cmd2.Parameters.AddWithValue("@ten", tenNguoi);
                            cmd2.ExecuteNonQuery();
                        }
                        idNguoi = (int)(long)new SQLiteCommand("SELECT last_insert_rowid()", conn).ExecuteScalar();
                    }
                    else idNguoi = Convert.ToInt32(result);
                }

                string sql = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@ten, @hinh, @id)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", tenMon);
                    cmd.Parameters.AddWithValue("@hinh", string.IsNullOrEmpty(hinhAnh) ? DBNull.Value : (object)hinhAnh);
                    cmd.Parameters.AddWithValue("@id", idNguoi);
                    cmd.ExecuteNonQuery();
                }
            }

            MonAn.Clear();
            name.Clear();
            picURL.Clear();
            LoadMonAn();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách món ăn không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                new SQLiteCommand("DELETE FROM MonAn", conn).ExecuteNonQuery();
            }

            ListMonAn.Clear();
            MonAnHomNay.Clear();
            picHinh.Image = null;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen
                               FROM MonAn
                               JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC;";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var ds = new List<(string ten, string hinh, string nguoi)>();

                    while (reader.Read())
                    {
                        ds.Add((
                            reader["TenMonAn"].ToString(),
                            reader["HinhAnh"]?.ToString(),
                            reader["HoVaTen"].ToString()
                        ));
                    }

                    if (ds.Count == 0)
                    {
                        MessageBox.Show("Danh sách món ăn đang rỗng!");
                        return;
                    }

                    var chon = ds[random.Next(ds.Count)];
                    MonAnHomNay.Text = $"{chon.ten} - (Đóng góp bởi: {chon.nguoi})";

                    if (!string.IsNullOrEmpty(chon.hinh) && File.Exists(chon.hinh))
                    {
                        try
                        {
                            picHinh.Image = Image.FromFile(chon.hinh);
                        }
                        catch
                        {
                            picHinh.Image = null;
                        }
                    }
                    else
                    {
                        picHinh.Image = null;
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picURLButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh món ăn";
                ofd.Filter = "File hình (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picURL.Text = ofd.FileName;

                    try
                    {
                        picHinh.Image = Image.FromFile(ofd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể mở hình ảnh này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
