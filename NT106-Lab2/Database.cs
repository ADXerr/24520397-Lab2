using System.Data.SQLite;
using System.IO;

namespace NT106_Lab2
{
    internal class Database
    {
        private static string dbPath = "monan.db";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        public static void Initialize()
        {
            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            using (var conn = GetConnection())
            {
                conn.Open();

                string sqlNguoi = @"CREATE TABLE IF NOT EXISTS NguoiDung(
                                    IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                    HoVaTen TEXT NOT NULL)";

                string sqlMonAn = @"CREATE TABLE IF NOT EXISTS MonAn(
                                    IDMon INTEGER PRIMARY KEY AUTOINCREMENT,
                                    TenMonAn TEXT NOT NULL,
                                    HinhAnh TEXT,
                                    IDNCC INTEGER,
                                    FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC))";

                new SQLiteCommand(sqlNguoi, conn).ExecuteNonQuery();
                new SQLiteCommand(sqlMonAn, conn).ExecuteNonQuery();
            }
        }
    }
}
