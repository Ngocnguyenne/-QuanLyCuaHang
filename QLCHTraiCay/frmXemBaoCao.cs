using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHTraiCayDTO;
using QLCHTraiCayBUS;
using Microsoft.Reporting.WinForms;

namespace QLCHTraiCay
{
    public partial class frmXemBaoCao : Form
    {
        HoaDonXuatBUS hdxBUS = new HoaDonXuatBUS();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        HoaDonXuatDTO hdxDTO = new HoaDonXuatDTO();
        TraiCayBUS traicayBUS = new TraiCayBUS();
        LoaiTraiCayBUS loaitraicayBus = new LoaiTraiCayBUS();

        
        

        public frmXemBaoCao()
        {
            
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {
            //lsHD();
            
        }
        
        public void TatCaTraiCay()
        {
            //List<TraiCayDTO> lsttraicayDTO = traicayBUS.DanhSachTraiCay();
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.rpttatcatraicay.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSTraiCay",lsttraicayDTO));
            List<TraiCayDTO> lsthd = traicayBUS.DanhSachTraiCay();
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.rptAllTraiCay.rdlc";
            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsTraiCay",lsthd));

            this.rpvBaoCao.RefreshReport();
        }

        public void TheoLoaiTraiCay(LoaiTraiCayDTO loai)
        {
            //List<TraiCayDTO> lsttraicayDTO = traicayBUS.DanhSachTraiCay();
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.rpttatcatraicay.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSTraiCay",lsttraicayDTO));

            //List<TraiCayDTO> lsttraicay = traicayBUS.DanhSachLoaiTraiCay(loai.MaLoaiTraiCay);
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.TheoLoai.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("TheoLoai", lsttraicay));

            //this.rpvBaoCao.RefreshReport();
        }

        public void TatCaNhanVien()
        {
            //List<TraiCayDTO> lsttraicayDTO = traicayBUS.DanhSachTraiCay();
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.rpttatcatraicay.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSTraiCay",lsttraicayDTO));

            List<NhanVienDTO> lstnv = nhanvienBUS.DanhSachNhanVien();
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.ALLNhanVien.rdlc";
            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("ALLNhanVien", lstnv));

            this.rpvBaoCao.RefreshReport();
        }

        public void TatCaHoaDon()
        {
            //List<TraiCayDTO> lsttraicayDTO = traicayBUS.DanhSachTraiCay();
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.rpttatcatraicay.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSTraiCay",lsttraicayDTO));

            List<HoaDonXuatDTO> lsthoadon = hdxBUS.DanhSachHoaDonXuat();
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.TheoHoaDon.rdlc";
            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", lsthoadon));

            this.rpvBaoCao.RefreshReport();
        }

        public void HoaDon()
        {
            //List<TraiCayDTO> lsttraiCay = traicayBUS.DanhSachTraiCay();
            //this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.HoaDon.rdlc";
            //this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", lsttraiCay));
            //this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paNguoiLap", "<Tên người lập>"));
            //this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Today.AddDays(-7).ToString()));
            //this.rpvBaoCao.RefreshReport();
        }

        public void TheoNhanVien(NhanVienDTO nhanvien)
        {
            List<HoaDonXuatDTO> lsthoadon = hdxBUS.DSCTHDBTheoMa(nhanvien.MaNhanVien);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.TheoNhanVien.rdlc";
            //this.rpvBaoCao.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHDX", lsthoadon));
            List<ReportParameter> parars = new List<ReportParameter>();
            parars.Add(new ReportParameter("paTenNhanVien",nhanvien.TenNhanVien));
            parars.Add(new ReportParameter("paTongTien", hdxBUS.LayTongTienTheoMa(nhanvien.MaNhanVien).ToString()));
            //this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paTenNhanVien", nhanvien.TenNhanVien));
            this.rpvBaoCao.LocalReport.SetParameters(parars);
            
            this.rpvBaoCao.RefreshReport();
        }

         void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //throw new NotImplementedException();
            string manhanvien = e.Parameters["paMaNhanVien"].Values[0];
            e.DataSources.Add(new ReportDataSource("TheoNhanVien", hdxBUS.DSCTHDBTheoMa(manhanvien)));
        }

        //public void TheoHoaDon(NhanVienDTO nv)
        // {
        //     List<HoaDonXuatDTO> lsthoadon = hdxBUS.DSCTHDBTheoMa(nv.MaNhanVien);
        //     this.rpvBaoCao.LocalReport.ReportEmbeddedResource="QLCHTraiCay.TheoHoaDon.rdlc";
        //     this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", lsthoadon));
        //     List<ReportParameter> parars = new List<ReportParameter>();
        //     parars.Add(new ReportParameter("paTenNhanVien", nv.MaNhanVien));
        //     this.rpvBaoCao.LocalReport.SetParameters(parars);

        //     this.rpvBaoCao.RefreshReport();
        // }

         public void Xemsp()
         {
             System.Collections.Generic.List<TraiCayDTO> sphethang = traicayBUS.LayDSHangHoaSapHet();
             this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.TraiSapHetHang.rdlc";
             this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("SPHetHang", sphethang));
             this.rpvBaoCao.RefreshReport();
         }

         //public void lsHD()
         //{
         //    HoaDonXuatBUS cthd = new HoaDonXuatBUS();
         //    List<HoaDonXuatDTO> lsttc = cthd.DanhSachHoaDonXuat();

         //    this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QLCHTraiCay.InHoaDon.rdlc";
         //    this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("TongDoanhThu", lsttc));
         //    //List<ReportParameter> parars = new List<ReportParameter>();
         //    //parars.Add(new ReportParameter("paTongTien", hdxBUS.TongHoaDon(hdx.MaHoaDonXuat).ToString()));
         //    this.rpvBaoCao.RefreshReport();

         //    // Setparameter(dateTimePicker1.Value, dateTimePicker2.Value);
         //    this.rpvBaoCao.RefreshReport();
         //}

        //private void Setparameter(DateTime From, DateTime To)
        //{
        //    ReportParameter[] rp = new ReportParameter[2];
        //    rp[0] = new ReportParameter("FromYear");
        //    rp[1] = new ReportParameter("ToYear");
        //    rp[0].Values.Add(From.ToString());
        //    rp[1].Values.Add(To.ToString());
        //}

        
    }
}
