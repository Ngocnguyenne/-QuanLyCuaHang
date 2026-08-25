namespace QLCHTraiCay
{
    partial class QLHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHoaDonNhap));
            this.btnXoaHDN = new System.Windows.Forms.Button();
            this.btnXoaCTHDNhap = new System.Windows.Forms.Button();
            this.dgvCTHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.colMaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmatraicay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.colmahoadonnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaTraiCay = new System.Windows.Forms.TextBox();
            this.chkTrangThai1 = new System.Windows.Forms.CheckBox();
            this.lblTrangThai1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtCTHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobTenNhanVien = new System.Windows.Forms.ComboBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHDNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaHDN
            // 
            this.btnXoaHDN.BackColor = System.Drawing.Color.Silver;
            this.btnXoaHDN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaHDN.BackgroundImage")));
            this.btnXoaHDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaHDN.Location = new System.Drawing.Point(378, 165);
            this.btnXoaHDN.Name = "btnXoaHDN";
            this.btnXoaHDN.Size = new System.Drawing.Size(103, 41);
            this.btnXoaHDN.TabIndex = 34;
            this.btnXoaHDN.UseVisualStyleBackColor = false;
            this.btnXoaHDN.Click += new System.EventHandler(this.btnXoaHDN_Click);
            // 
            // btnXoaCTHDNhap
            // 
            this.btnXoaCTHDNhap.BackColor = System.Drawing.Color.Silver;
            this.btnXoaCTHDNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCTHDNhap.BackgroundImage")));
            this.btnXoaCTHDNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaCTHDNhap.Location = new System.Drawing.Point(901, 165);
            this.btnXoaCTHDNhap.Name = "btnXoaCTHDNhap";
            this.btnXoaCTHDNhap.Size = new System.Drawing.Size(103, 41);
            this.btnXoaCTHDNhap.TabIndex = 30;
            this.btnXoaCTHDNhap.UseVisualStyleBackColor = false;
            this.btnXoaCTHDNhap.Click += new System.EventHandler(this.btnXoaCTHDNhap_Click);
            // 
            // dgvCTHoaDonNhap
            // 
            this.dgvCTHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCT,
            this.colmatraicay,
            this.colgianhap,
            this.colsoluong,
            this.colTrangThai1});
            this.dgvCTHoaDonNhap.Location = new System.Drawing.Point(487, 314);
            this.dgvCTHoaDonNhap.Name = "dgvCTHoaDonNhap";
            this.dgvCTHoaDonNhap.RowHeadersVisible = false;
            this.dgvCTHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHoaDonNhap.Size = new System.Drawing.Size(517, 150);
            this.dgvCTHoaDonNhap.TabIndex = 27;
            this.dgvCTHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDonNhap_CellContentClick);
            // 
            // colMaCT
            // 
            this.colMaCT.DataPropertyName = "MaCTHoaDonNhap";
            this.colMaCT.HeaderText = "Mã chi tiết HĐ nhập";
            this.colMaCT.Name = "colMaCT";
            // 
            // colmatraicay
            // 
            this.colmatraicay.DataPropertyName = "MaTraiCay";
            this.colmatraicay.HeaderText = "Mã trái cây";
            this.colmatraicay.Name = "colmatraicay";
            // 
            // colgianhap
            // 
            this.colgianhap.DataPropertyName = "GiaNhap";
            this.colgianhap.HeaderText = "Giá nhập";
            this.colgianhap.Name = "colgianhap";
            // 
            // colsoluong
            // 
            this.colsoluong.DataPropertyName = "SoLuong";
            this.colsoluong.HeaderText = "Số lượng";
            this.colsoluong.Name = "colsoluong";
            // 
            // colTrangThai1
            // 
            this.colTrangThai1.DataPropertyName = "TrangThai";
            this.colTrangThai1.HeaderText = "Trạng thái";
            this.colTrangThai1.Name = "colTrangThai1";
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmahoadonnhap,
            this.colmanhanvien,
            this.colngaynhap,
            this.coltongtien,
            this.colTrangThai});
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(17, 314);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(464, 150);
            this.dgvHoaDonNhap.TabIndex = 26;
            this.dgvHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellContentClick);
            // 
            // colmahoadonnhap
            // 
            this.colmahoadonnhap.DataPropertyName = "MaHoaDonNhap";
            this.colmahoadonnhap.HeaderText = "Mã hóa đơn nhập";
            this.colmahoadonnhap.Name = "colmahoadonnhap";
            // 
            // colmanhanvien
            // 
            this.colmanhanvien.DataPropertyName = "MaNhanVien";
            this.colmanhanvien.HeaderText = "Tên nhân viên";
            this.colmanhanvien.Name = "colmanhanvien";
            // 
            // colngaynhap
            // 
            this.colngaynhap.DataPropertyName = "NgayNhap";
            this.colngaynhap.HeaderText = "Ngày nhập";
            this.colngaynhap.Name = "colngaynhap";
            // 
            // coltongtien
            // 
            this.coltongtien.DataPropertyName = "TongTien";
            this.coltongtien.HeaderText = "Tổng tiền";
            this.coltongtien.Name = "coltongtien";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtMaTraiCay);
            this.groupBox2.Controls.Add(this.chkTrangThai1);
            this.groupBox2.Controls.Add(this.lblTrangThai1);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtCTHD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(487, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 293);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn nhập";
            // 
            // txtMaTraiCay
            // 
            this.txtMaTraiCay.Location = new System.Drawing.Point(195, 87);
            this.txtMaTraiCay.Name = "txtMaTraiCay";
            this.txtMaTraiCay.Size = new System.Drawing.Size(171, 26);
            this.txtMaTraiCay.TabIndex = 11;
            // 
            // chkTrangThai1
            // 
            this.chkTrangThai1.AutoSize = true;
            this.chkTrangThai1.Location = new System.Drawing.Point(195, 250);
            this.chkTrangThai1.Name = "chkTrangThai1";
            this.chkTrangThai1.Size = new System.Drawing.Size(15, 14);
            this.chkTrangThai1.TabIndex = 10;
            this.chkTrangThai1.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai1
            // 
            this.lblTrangThai1.AutoSize = true;
            this.lblTrangThai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai1.Location = new System.Drawing.Point(22, 248);
            this.lblTrangThai1.Name = "lblTrangThai1";
            this.lblTrangThai1.Size = new System.Drawing.Size(78, 17);
            this.lblTrangThai1.TabIndex = 9;
            this.lblTrangThai1.Text = "Trạng Thái";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(195, 196);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(171, 26);
            this.txtSoLuong.TabIndex = 0;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(195, 140);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(171, 26);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // txtCTHD
            // 
            this.txtCTHD.Location = new System.Drawing.Point(195, 38);
            this.txtCTHD.Name = "txtCTHD";
            this.txtCTHD.Size = new System.Drawing.Size(171, 26);
            this.txtCTHD.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã trái cây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã CT hóa đơn nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cobTenNhanVien);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaHDNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 293);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn nhập";
            // 
            // cobTenNhanVien
            // 
            this.cobTenNhanVien.FormattingEnabled = true;
            this.cobTenNhanVien.Location = new System.Drawing.Point(143, 120);
            this.cobTenNhanVien.Name = "cobTenNhanVien";
            this.cobTenNhanVien.Size = new System.Drawing.Size(171, 27);
            this.cobTenNhanVien.TabIndex = 10;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(143, 262);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(15, 14);
            this.chkTrangThai.TabIndex = 9;
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(6, 260);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(66, 15);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(143, 198);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(171, 26);
            this.txtTongTien.TabIndex = 7;
            // 
            // txtMaHDNhap
            // 
            this.txtMaHDNhap.Location = new System.Drawing.Point(143, 45);
            this.txtMaHDNhap.Name = "txtMaHDNhap";
            this.txtMaHDNhap.ReadOnly = true;
            this.txtMaHDNhap.Size = new System.Drawing.Size(171, 26);
            this.txtMaHDNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // QLHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1013, 478);
            this.Controls.Add(this.btnXoaHDN);
            this.Controls.Add(this.btnXoaCTHDNhap);
            this.Controls.Add(this.dgvCTHoaDonNhap);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLHoaDonNhap";
            this.Text = "QLHoaDonNhap";
            this.Load += new System.EventHandler(this.QLHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoaHDN;
        private System.Windows.Forms.Button btnXoaCTHDNhap;
        private System.Windows.Forms.DataGridView dgvCTHoaDonNhap;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTrangThai1;
        private System.Windows.Forms.Label lblTrangThai1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtCTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaHDNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTenNhanVien;
        private System.Windows.Forms.TextBox txtMaTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahoadonnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmatraicay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai1;

    }
}