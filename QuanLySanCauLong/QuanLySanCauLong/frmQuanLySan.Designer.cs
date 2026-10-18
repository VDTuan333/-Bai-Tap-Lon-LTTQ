namespace QuanLySanCauLong
{
    partial class frmQuanLySan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaSan = new System.Windows.Forms.Label();
            this.lblTenSan = new System.Windows.Forms.Label();
            this.lblLoaiSan = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboLoaiSan = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvSanCauLong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanCauLong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSan
            // 
            this.lblMaSan.AutoSize = true;
            this.lblMaSan.Location = new System.Drawing.Point(103, 35);
            this.lblMaSan.Name = "lblMaSan";
            this.lblMaSan.Size = new System.Drawing.Size(51, 16);
            this.lblMaSan.TabIndex = 0;
            this.lblMaSan.Text = "Mã sân";
            // 
            // lblTenSan
            // 
            this.lblTenSan.AutoSize = true;
            this.lblTenSan.Location = new System.Drawing.Point(98, 78);
            this.lblTenSan.Name = "lblTenSan";
            this.lblTenSan.Size = new System.Drawing.Size(56, 16);
            this.lblTenSan.TabIndex = 1;
            this.lblTenSan.Text = "Tên sân";
            // 
            // lblLoaiSan
            // 
            this.lblLoaiSan.AutoSize = true;
            this.lblLoaiSan.Location = new System.Drawing.Point(96, 127);
            this.lblLoaiSan.Name = "lblLoaiSan";
            this.lblLoaiSan.Size = new System.Drawing.Size(58, 16);
            this.lblLoaiSan.TabIndex = 2;
            this.lblLoaiSan.Text = "Loại sân";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(101, 173);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(53, 16);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(87, 224);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(67, 16);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtMaSan
            // 
            this.txtMaSan.Location = new System.Drawing.Point(234, 29);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(100, 22);
            this.txtMaSan.TabIndex = 5;
            // 
            // txtTenSan
            // 
            this.txtTenSan.Location = new System.Drawing.Point(234, 72);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(100, 22);
            this.txtTenSan.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(234, 170);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia.TabIndex = 7;
            // 
            // cboLoaiSan
            // 
            this.cboLoaiSan.FormattingEnabled = true;
            this.cboLoaiSan.Location = new System.Drawing.Point(234, 119);
            this.cboLoaiSan.Name = "cboLoaiSan";
            this.cboLoaiSan.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiSan.TabIndex = 8;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(234, 216);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cboTrangThai.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 491);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 39);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(233, 491);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 39);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(396, 491);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 39);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(559, 491);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(101, 39);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(721, 491);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 39);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dgvSanCauLong
            // 
            this.dgvSanCauLong.AllowUserToAddRows = false;
            this.dgvSanCauLong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanCauLong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanCauLong.Location = new System.Drawing.Point(70, 274);
            this.dgvSanCauLong.MultiSelect = false;
            this.dgvSanCauLong.Name = "dgvSanCauLong";
            this.dgvSanCauLong.ReadOnly = true;
            this.dgvSanCauLong.RowHeadersWidth = 51;
            this.dgvSanCauLong.RowTemplate.Height = 24;
            this.dgvSanCauLong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanCauLong.Size = new System.Drawing.Size(752, 170);
            this.dgvSanCauLong.TabIndex = 15;
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvSanCauLong);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.cboLoaiSan);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSan);
            this.Controls.Add(this.txtMaSan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblLoaiSan);
            this.Controls.Add(this.lblTenSan);
            this.Controls.Add(this.lblMaSan);
            this.Name = "frmQuanLySan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SÂN CẦU LÔNG";
            this.Load += new System.EventHandler(this.frmQuanLySan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanCauLong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSan;
        private System.Windows.Forms.Label lblTenSan;
        private System.Windows.Forms.Label lblLoaiSan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvSanCauLong;
    }
}