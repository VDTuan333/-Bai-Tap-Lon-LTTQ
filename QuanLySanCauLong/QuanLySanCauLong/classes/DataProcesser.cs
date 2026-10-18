using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySanCauLong.Classes
{
    public class DataProcesser
    {
        private readonly string strConnect =
            @"Data Source=Admin-PC;
              Initial Catalog=QuanLySanCauLong;
              Integrated Security=True;
              TrustServerCertificate=True;";

        // Đọc dữ liệu từ SQL Server
        public DataTable DocBang(string sql)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Thực hiện câu lệnh thêm, sửa, xóa
        public int ThucThi(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Kiểm tra đăng nhập
        public DataTable KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sql = @"
                SELECT MaNV, TenNV
                FROM NhanVien
                WHERE TenDangNhap = @TenDangNhap
                  AND MatKhau = @MatKhau";

            using (SqlConnection conn = new SqlConnection(strConnect))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar, 50)
                    .Value = tenDangNhap;

                cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar, 100)
                    .Value = matKhau;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}