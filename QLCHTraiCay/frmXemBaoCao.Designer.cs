namespace QLCHTraiCay
{
    partial class frmXemBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TraiCayDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonXuatDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TraiCayDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonXuatDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TraiCayDTOBindingSource
            // 
            this.TraiCayDTOBindingSource.DataSource = typeof(QLCHTraiCayDTO.TraiCayDTO);
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TheoNhanVien";
            reportDataSource1.Value = this.HoaDonXuatDTOBindingSource;
            this.rpvBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.TheoNhanVien.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.Size = new System.Drawing.Size(778, 349);
            this.rpvBaoCao.TabIndex = 0;
            // 
            // HoaDonXuatDTOBindingSource
            // 
            this.HoaDonXuatDTOBindingSource.DataSource = typeof(QLCHTraiCayDTO.HoaDonXuatDTO);
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 349);
            this.Controls.Add(this.rpvBaoCao);
            this.Name = "frmXemBaoCao";
            this.Text = "frmXemBaoCao";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TraiCayDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonXuatDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.BindingSource TraiCayDTOBindingSource;
        private System.Windows.Forms.BindingSource HoaDonXuatDTOBindingSource;
    }
}