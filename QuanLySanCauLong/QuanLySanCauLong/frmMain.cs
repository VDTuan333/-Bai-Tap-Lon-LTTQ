using QuanLySanCauLong.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySanCauLong;

namespace QuanLySanCauLong
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = "Nhân viên: " + PhienDangNhap.MaNV + " - " + PhienDangNhap.TenNV;
        }

        private void btnQuanLySan_Click(object sender, EventArgs e)
        {
            frmQuanLySan frm = new frmQuanLySan();
            frm.ShowDialog();
        }
    }
}
