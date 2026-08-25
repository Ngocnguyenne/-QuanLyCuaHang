namespace QLCHTraiCay
{
    partial class ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.radtatcatraicay = new System.Windows.Forms.RadioButton();
            this.radtheotungnhanvien = new System.Windows.Forms.RadioButton();
            this.radtacanhanvien = new System.Windows.Forms.RadioButton();
            this.radtheohoadon = new System.Windows.Forms.RadioButton();
            this.cbonhanvien = new System.Windows.Forms.ComboBox();
            this.btnxembaocao = new System.Windows.Forms.Button();
            this.radsanphamhethang = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // radtatcatraicay
            // 
            this.radtatcatraicay.AutoSize = true;
            this.radtatcatraicay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtatcatraicay.Location = new System.Drawing.Point(149, 58);
            this.radtatcatraicay.Name = "radtatcatraicay";
            this.radtatcatraicay.Size = new System.Drawing.Size(113, 23);
            this.radtatcatraicay.TabIndex = 1;
            this.radtatcatraicay.TabStop = true;
            this.radtatcatraicay.Text = "Tất cả trái cây";
            this.radtatcatraicay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radtatcatraicay.UseVisualStyleBackColor = true;
            this.radtatcatraicay.CheckedChanged += new System.EventHandler(this.radtatcatraicay_CheckedChanged);
            // 
            // radtheotungnhanvien
            // 
            this.radtheotungnhanvien.AutoSize = true;
            this.radtheotungnhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtheotungnhanvien.Location = new System.Drawing.Point(149, 138);
            this.radtheotungnhanvien.Name = "radtheotungnhanvien";
            this.radtheotungnhanvien.Size = new System.Drawing.Size(149, 23);
            this.radtheotungnhanvien.TabIndex = 2;
            this.radtheotungnhanvien.TabStop = true;
            this.radtheotungnhanvien.Text = "Theo từng nhân viên";
            this.radtheotungnhanvien.UseVisualStyleBackColor = true;
            this.radtheotungnhanvien.CheckedChanged += new System.EventHandler(this.radtheotungnhanvien_CheckedChanged);
            // 
            // radtacanhanvien
            // 
            this.radtacanhanvien.AutoSize = true;
            this.radtacanhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtacanhanvien.Location = new System.Drawing.Point(149, 98);
            this.radtacanhanvien.Name = "radtacanhanvien";
            this.radtacanhanvien.Size = new System.Drawing.Size(125, 23);
            this.radtacanhanvien.TabIndex = 3;
            this.radtacanhanvien.TabStop = true;
            this.radtacanhanvien.Text = "Tất cả nhân viên";
            this.radtacanhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radtacanhanvien.UseVisualStyleBackColor = true;
            this.radtacanhanvien.CheckedChanged += new System.EventHandler(this.radtacanhanvien_CheckedChanged);
            // 
            // radtheohoadon
            // 
            this.radtheohoadon.AutoSize = true;
            this.radtheohoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtheohoadon.Location = new System.Drawing.Point(149, 218);
            this.radtheohoadon.Name = "radtheohoadon";
            this.radtheohoadon.Size = new System.Drawing.Size(118, 23);
            this.radtheohoadon.TabIndex = 4;
            this.radtheohoadon.TabStop = true;
            this.radtheohoadon.Text = "Tất cả hóa đơn";
            this.radtheohoadon.UseVisualStyleBackColor = true;
            this.radtheohoadon.CheckedChanged += new System.EventHandler(this.radtatcahoadon_CheckedChanged);
            // 
            // cbonhanvien
            // 
            this.cbonhanvien.FormattingEnabled = true;
            this.cbonhanvien.Location = new System.Drawing.Point(409, 141);
            this.cbonhanvien.Name = "cbonhanvien";
            this.cbonhanvien.Size = new System.Drawing.Size(267, 21);
            this.cbonhanvien.TabIndex = 5;
            this.cbonhanvien.SelectedIndexChanged += new System.EventHandler(this.cbonhanvien_SelectedIndexChanged);
            // 
            // btnxembaocao
            // 
            this.btnxembaocao.BackColor = System.Drawing.Color.Silver;
            this.btnxembaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxembaocao.Location = new System.Drawing.Point(409, 218);
            this.btnxembaocao.Name = "btnxembaocao";
            this.btnxembaocao.Size = new System.Drawing.Size(267, 58);
            this.btnxembaocao.TabIndex = 6;
            this.btnxembaocao.Text = "Xem Báo Cáo";
            this.btnxembaocao.UseVisualStyleBackColor = false;
            this.btnxembaocao.Click += new System.EventHandler(this.btnxembaocao_Click);
            // 
            // radsanphamhethang
            // 
            this.radsanphamhethang.AutoSize = true;
            this.radsanphamhethang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radsanphamhethang.Location = new System.Drawing.Point(149, 178);
            this.radsanphamhethang.Name = "radsanphamhethang";
            this.radsanphamhethang.Size = new System.Drawing.Size(166, 23);
            this.radsanphamhethang.TabIndex = 7;
            this.radsanphamhethang.TabStop = true;
            this.radsanphamhethang.Text = "Sản phẩm sắp hết hàng";
            this.radsanphamhethang.UseVisualStyleBackColor = true;
            this.radsanphamhethang.CheckedChanged += new System.EventHandler(this.radsanphamhethang_CheckedChanged);
            // 
            // ThongKe
            // 
            this.AcceptButton = this.btnxembaocao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(749, 321);
            this.Controls.Add(this.radsanphamhethang);
            this.Controls.Add(this.btnxembaocao);
            this.Controls.Add(this.cbonhanvien);
            this.Controls.Add(this.radtheohoadon);
            this.Controls.Add(this.radtacanhanvien);
            this.Controls.Add(this.radtheotungnhanvien);
            this.Controls.Add(this.radtatcatraicay);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radtatcatraicay;
        private System.Windows.Forms.RadioButton radtheotungnhanvien;
        private System.Windows.Forms.RadioButton radtacanhanvien;
        private System.Windows.Forms.RadioButton radtheohoadon;
        private System.Windows.Forms.ComboBox cbonhanvien;
        private System.Windows.Forms.Button btnxembaocao;
        private System.Windows.Forms.RadioButton radsanphamhethang;
    }
}