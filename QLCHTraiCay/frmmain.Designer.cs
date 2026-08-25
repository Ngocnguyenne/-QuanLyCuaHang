namespace QLCHTraiCay
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.picBoxNV = new System.Windows.Forms.PictureBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menNhapTC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoaDonXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBanTraiCay = new System.Windows.Forms.ToolStripMenuItem();
            this.menStripBCTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblXinChao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNV)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QLCHTraiCay.Properties.Resources.DangXuat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(10, 449);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(95, 45);
            this.btnDangXuat.TabIndex = 15;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // picBoxNV
            // 
            this.picBoxNV.Location = new System.Drawing.Point(10, 169);
            this.picBoxNV.Name = "picBoxNV";
            this.picBoxNV.Size = new System.Drawing.Size(95, 107);
            this.picBoxNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNV.TabIndex = 13;
            this.picBoxNV.TabStop = false;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(20, 331);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(45, 19);
            this.lblHoTen.TabIndex = 14;
            this.lblHoTen.Text = "label1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSanPham,
            this.btnNhaCungCap,
            this.btnNhanVien,
            this.btnKhachHang,
            this.hóaĐơnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // btnSanPham
            // 
            this.btnSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNhapTC});
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(162, 24);
            this.btnSanPham.Text = "Trái cây";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // menNhapTC
            // 
            this.menNhapTC.Name = "menNhapTC";
            this.menNhapTC.Size = new System.Drawing.Size(160, 24);
            this.menNhapTC.Text = "Nhập trái cây";
            this.menNhapTC.Click += new System.EventHandler(this.menNhapTC_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(162, 24);
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(162, 24);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(162, 24);
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHoaDonNhap,
            this.btnHoaDonXuat});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(164, 24);
            this.btnHoaDonNhap.Text = "Hóa đơn nhập";
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnHoaDonXuat
            // 
            this.btnHoaDonXuat.Name = "btnHoaDonXuat";
            this.btnHoaDonXuat.Size = new System.Drawing.Size(164, 24);
            this.btnHoaDonXuat.Text = "Hóa đơn xuất";
            this.btnHoaDonXuat.Click += new System.EventHandler(this.btnHoaDonXuat_Click);
            // 
            // btnBanTraiCay
            // 
            this.btnBanTraiCay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanTraiCay.Name = "btnBanTraiCay";
            this.btnBanTraiCay.Size = new System.Drawing.Size(129, 23);
            this.btnBanTraiCay.Text = "Bán trái cây";
            this.btnBanTraiCay.Click += new System.EventHandler(this.btnBanTraiCay_Click);
            // 
            // menStripBCTK
            // 
            this.menStripBCTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menStripBCTK.Name = "menStripBCTK";
            this.menStripBCTK.Size = new System.Drawing.Size(129, 23);
            this.menStripBCTK.Text = "Báo cáo-Thống kê";
            this.menStripBCTK.Click += new System.EventHandler(this.menStripBCTK_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.btnBanTraiCay,
            this.menStripBCTK});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(140, 533);
            this.menuStrip.TabIndex = 12;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblXinChao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(34, 317);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(63, 19);
            this.lblXinChao.TabIndex = 17;
            this.lblXinChao.Text = "Xin chào";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(735, 533);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.picBoxNV);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNV)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox picBoxNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSanPham;
        private System.Windows.Forms.ToolStripMenuItem btnNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem btnHoaDonXuat;
        private System.Windows.Forms.ToolStripMenuItem btnBanTraiCay;
        private System.Windows.Forms.ToolStripMenuItem menStripBCTK;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.ToolStripMenuItem menNhapTC;


    }
}

