namespace QuanLySanCauLong
{
    partial class frmMain
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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnQuanLySan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(570, 37);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(44, 16);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "label1";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(283, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(241, 16);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ SÂN CẦU LÔNG";
            // 
            // btnQuanLySan
            // 
            this.btnQuanLySan.Location = new System.Drawing.Point(223, 132);
            this.btnQuanLySan.Name = "btnQuanLySan";
            this.btnQuanLySan.Size = new System.Drawing.Size(103, 38);
            this.btnQuanLySan.TabIndex = 2;
            this.btnQuanLySan.Text = "&Quản lý sân";
            this.btnQuanLySan.UseVisualStyleBackColor = true;
            this.btnQuanLySan.Click += new System.EventHandler(this.btnQuanLySan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(223, 176);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(103, 38);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLySan);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhanVien);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ SÂN CẦU LÔNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnQuanLySan;
        private System.Windows.Forms.Button btnDangXuat;
    }
}