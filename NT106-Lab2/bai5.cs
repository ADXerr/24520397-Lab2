using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai5 : Form
    {
        Dictionary<string, (int giaVe, List<int> phong)> dsPhim = new Dictionary<string, (int, List<int>)>();
        HashSet<string> gheDaDat = new HashSet<string>();
        List<(string ten, string phim, string phong, string ghe, double gia)> danhSachVe = new List<(string, string, string, string, double)>();

        public bai5()
        {
            InitializeComponent();
            Data();
        }

        void Data()
        {
            string[] lines = File.ReadAllLines("input5.txt");
            for (int i = 0; i < lines.Length; i += 3)
            {
                string phim = lines[i].Trim();
                int gia = int.Parse(lines[i + 1]);
                List<int> phong = lines[i + 2].Split(' ').Select(int.Parse).ToList();
                dsPhim[phim] = (gia, phong);
            }

            FilmName.Items.AddRange(dsPhim.Keys.ToArray());
            Room.Items.AddRange(new object[] { "1", "2", "3" });
            Seat.Items.AddRange(new object[]
            {
                "A1","A2","A3","A4","A5",
                "B1","B2","B3","B4","B5",
                "C1","C2","C3","C4","C5"
            });
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            string ten = CustomName.Text.Trim();
            string phim = FilmName.Text;
            string phong = Room.Text;
            string ghe = Seat.Text;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(phim) ||
                string.IsNullOrEmpty(phong) || string.IsNullOrEmpty(ghe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (gheDaDat.Contains(phim + phong + ghe))
            {
                MessageBox.Show("Ghế này đã được đặt cho phim này!");
                return;
            }

            var info = dsPhim[phim];
            int phongSo = int.Parse(phong);
            if (!info.phong.Contains(phongSo))
            {
                MessageBox.Show("Phim này không chiếu ở phòng đã chọn!");
                return;
            }

            double gia = info.giaVe;

            if (new[] { "A1", "A5", "C1", "C5" }.Contains(ghe))
                gia *= 0.25;
            else if (new[] { "B2", "B3", "B4" }.Contains(ghe))
                gia *= 2;

            gheDaDat.Add(phim + phong + ghe);
            danhSachVe.Add((ten, phim, phong, ghe, gia));

            InfoCustomer.Text = ten;
            InfoFilm.Text = phim;
            InfoRoom.Text = phong;
            InfoSeat.Text = ghe;
            Cost.Text = gia.ToString("N0") + " đ";

            await GhiFileThongKe();
        }

        private async Task GhiFileThongKe()
        {
            progressBar1.Value = 0;
            string path = "output5.txt";

            var thongke = danhSachVe
                .GroupBy(v => v.phim)
                .Select(g => new
                {
                    TenPhim = g.Key,
                    SoLuongBan = g.Count(),
                    SoLuongToiDa = 15 * dsPhim[g.Key].phong.Count, 
                    DoanhThu = g.Sum(x => x.gia)
                })
                .Select(t => new
                {
                    t.TenPhim,
                    t.SoLuongBan,
                    VeTon = t.SoLuongToiDa - t.SoLuongBan,
                    TyLe = (double)t.SoLuongBan / t.SoLuongToiDa * 100,
                    t.DoanhThu
                })
                .OrderByDescending(x => x.DoanhThu)
                .ToList();

            using (StreamWriter sw = new StreamWriter(path))
            {
                int rank = 1;
                foreach (var item in thongke)
                {
                    sw.WriteLine($"Phim: {item.TenPhim}");
                    sw.WriteLine($"Số vé bán: {item.SoLuongBan}");
                    sw.WriteLine($"Số vé tồn: {item.VeTon}");
                    sw.WriteLine($"Tỉ lệ bán: {item.TyLe:F2}%");
                    sw.WriteLine($"Doanh thu: {item.DoanhThu:N0} đ");
                    sw.WriteLine($"Xếp hạng doanh thu: {rank}");
                    sw.WriteLine();
                    rank++;
                }
            }

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10); 
            }

            MessageBox.Show("Đã ghi file output5.txt và cập nhật thống kê!");
        }
    }
}
