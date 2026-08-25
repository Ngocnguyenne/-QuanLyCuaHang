namespace QLCHTraiCay
{
    partial class QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVien));
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblloainhanvien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colmanhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhonhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.picBoxNV = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.ofdHinhAnh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(18, 64);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(93, 17);
            this.lblmanhanvien.TabIndex = 0;
            this.lblmanhanvien.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // lblloainhanvien
            // 
            this.lblloainhanvien.AutoSize = true;
            this.lblloainhanvien.Location = new System.Drawing.Point(18, 145);
            this.lblloainhanvien.Name = "lblloainhanvien";
            this.lblloainhanvien.Size = new System.Drawing.Size(101, 17);
            this.lblloainhanvien.TabIndex = 3;
            this.lblloainhanvien.Text = "Loại nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lương";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(125, 66);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(155, 23);
            this.txtMaNhanVien.TabIndex = 10;
            // 
            // txtHoNhanVien
            // 
            this.txtHoNhanVien.Location = new System.Drawing.Point(125, 92);
            this.txtHoNhanVien.Name = "txtHoNhanVien";
            this.txtHoNhanVien.Size = new System.Drawing.Size(155, 23);
            this.txtHoNhanVien.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(124, 118);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(155, 23);
            this.txtTenNhanVien.TabIndex = 12;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(417, 61);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(156, 23);
            this.dateNgaySinh.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(417, 90);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(156, 23);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(418, 116);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 23);
            this.txtSDT.TabIndex = 17;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(418, 142);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(156, 23);
            this.txtLuong.TabIndex = 18;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanhanvien,
            this.colhonhanvien,
            this.coltennhanvien,
            this.colLoaiNhanVien,
            this.colgioitinh,
            this.colngaysinh,
            this.coldiachi,
            this.colsdt,
            this.colmatkhau,
            this.colluong,
            this.colhinhanh,
            this.coltinhtrang});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 283);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(744, 150);
            this.dgvNhanVien.TabIndex = 23;
            this.dgvNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvnhanvien_CellMouseClick);
            // 
            // colmanhanvien
            // 
            this.colmanhanvien.DataPropertyName = "MaNhanVien";
            this.colmanhanvien.HeaderText = "Mã nhân viên";
            this.colmanhanvien.Name = "colmanhanvien";
            this.colmanhanvien.ReadOnly = true;
            // 
            // colhonhanvien
            // 
            this.colhonhanvien.DataPropertyName = "HoNhanVien";
            this.colhonhanvien.HeaderText = "Họ nhân viên";
            this.colhonhanvien.Name = "colhonhanvien";
            this.colhonhanvien.ReadOnly = true;
            // 
            // coltennhanvien
            // 
            this.coltennhanvien.DataPropertyName = "TenNhanVien";
            this.coltennhanvien.HeaderText = "Tên nhân viên";
            this.coltennhanvien.Name = "coltennhanvien";
            this.coltennhanvien.ReadOnly = true;
            // 
            // colLoaiNhanVien
            // 
            this.colLoaiNhanVien.DataPropertyName = "MaLoaiNhanVien";
            this.colLoaiNhanVien.HeaderText = "Loại nhân viên";
            this.colLoaiNhanVien.Name = "colLoaiNhanVien";
            this.colLoaiNhanVien.ReadOnly = true;
            // 
            // colgioitinh
            // 
            this.colgioitinh.DataPropertyName = "GioiTinh";
            this.colgioitinh.HeaderText = "Giới tính";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.ReadOnly = true;
            this.colgioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colgioitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colngaysinh
            // 
            this.colngaysinh.DataPropertyName = "NgaySinh";
            this.colngaysinh.HeaderText = "Ngày sinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "DiaChi";
            this.coldiachi.HeaderText = "Địa chỉ";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // colsdt
            // 
            this.colsdt.DataPropertyName = "SDT";
            this.colsdt.HeaderText = "Số điện thoại";
            this.colsdt.Name = "colsdt";
            this.colsdt.ReadOnly = true;
            // 
            // colmatkhau
            // 
            this.colmatkhau.DataPropertyName = "MatKhau";
            this.colmatkhau.HeaderText = "Mật khẩu";
            this.colmatkhau.Name = "colmatkhau";
            this.colmatkhau.ReadOnly = true;
            // 
            // colluong
            // 
            this.colluong.DataPropertyName = "Luong";
            this.colluong.HeaderText = "Lương";
            this.colluong.Name = "colluong";
            this.colluong.ReadOnly = true;
            // 
            // colhinhanh
            // 
            this.colhinhanh.DataPropertyName = "HinhAnh";
            this.colhinhanh.HeaderText = "Hình ảnh";
            this.colhinhanh.Name = "colhinhanh";
            this.colhinhanh.ReadOnly = true;
            // 
            // coltinhtrang
            // 
            this.coltinhtrang.DataPropertyName = "TrangThai";
            this.coltinhtrang.HeaderText = "Tình trạng";
            this.coltinhtrang.Name = "coltinhtrang";
            this.coltinhtrang.ReadOnly = true;
            this.coltinhtrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coltinhtrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cobLoaiNhanVien
            // 
            this.cobLoaiNhanVien.FormattingEnabled = true;
            this.cobLoaiNhanVien.Location = new System.Drawing.Point(123, 144);
            this.cobLoaiNhanVien.Name = "cobLoaiNhanVien";
            this.cobLoaiNhanVien.Size = new System.Drawing.Size(156, 24);
            this.cobLoaiNhanVien.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Tìm kiếm";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(88, 30);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(400, 23);
            this.txtTimTen.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblDuongDan);
            this.groupBox1.Controls.Add(this.picBoxNV);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtgioitinh);
            this.groupBox1.Controls.Add(this.lblloainhanvien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblmanhanvien);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cobLoaiNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtHoNhanVien);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 265);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí nhân viên";
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.AutoSize = true;
            this.lblDuongDan.Location = new System.Drawing.Point(633, 208);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(0, 17);
            this.lblDuongDan.TabIndex = 58;
            // 
            // picBoxNV
            // 
            this.picBoxNV.Location = new System.Drawing.Point(591, 27);
            this.picBoxNV.Name = "picBoxNV";
            this.picBoxNV.Size = new System.Drawing.Size(147, 132);
            this.picBoxNV.TabIndex = 57;
            this.picBoxNV.TabStop = false;
            this.picBoxNV.Click += new System.EventHandler(this.picBoxNV_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(417, 175);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(156, 23);
            this.txtMatKhau.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mật khẩu";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(696, 175);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(15, 14);
            this.chkTrangThai.TabIndex = 54;
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Trạng thái";
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(123, 172);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(156, 23);
            this.txtgioitinh.TabIndex = 52;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Image = global::QLCHTraiCay.Properties.Resources.SearchIcon;
            this.btnTimKiem.Location = new System.Drawing.Point(507, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(48, 22);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Location = new System.Drawing.Point(477, 208);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 37);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(345, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 37);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(213, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 37);
            this.btnSua.TabIndex = 25;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(86, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 37);
            this.btnThem.TabIndex = 24;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ofdHinhAnh
            // 
            this.ofdHinhAnh.FileName = "openFileDialog1";
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(770, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLNhanVien";
            this.Text = "Quản Lí Nhân Viên";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblloainhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtHoNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cobLoaiNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhonhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltinhtrang;
        private System.Windows.Forms.OpenFileDialog ofdHinhAnh;
        private System.Windows.Forms.Label lblDuongDan;
    }
}