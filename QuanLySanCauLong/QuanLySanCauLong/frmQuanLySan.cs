using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySanCauLong.Classes;


namespace QuanLySanCauLong
{
    public partial class frmQuanLySan : Form
    {

        public frmQuanLySan()
        {
            InitializeComponent();
        }

        private void HienThiDanhSachSan()
        {
            try
            {
                DataProcesser db = new DataProcesser();

                DataTable dt = db.DocBang(
                    "SELECT MaSan, TenSan, LoaiSan, DonGia, TrangThai " +
                    "FROM SanCauLong ORDER BY MaSan");

                dgvSanCauLong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách sân:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmQuanLySan_Load(object sender, EventArgs e)
        {
            cboLoaiSan.Items.Clear();
            cboLoaiSan.Items.Add("Sân tiêu chuẩn");
            cboLoaiSan.Items.Add("Sân thi đấu");

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đã đặt");
            cboTrangThai.Items.Add("Đang sử dụng");

            HienThiDanhSachSan();
        }
    }
}
