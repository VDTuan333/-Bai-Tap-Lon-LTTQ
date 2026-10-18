using QuanLySanCauLong.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanCauLong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                DataProcesser db = new DataProcesser();
                DataTable dt = db.DocBang("SELECT MaSan, TenSan, DonGia, TrangThai FROM SanCauLong");
                MessageBox.Show(
                    "Ket noi thanh cong \nso san trong csdl: " + dt.Rows.Count,
                    "kiem tra ket noi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không đọc được dữ liệu SQL Server:\n" + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
