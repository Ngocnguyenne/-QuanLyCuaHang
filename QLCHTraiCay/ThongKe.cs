using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHTraiCayBUS;
using QLCHTraiCayDTO;


namespace QLCHTraiCay
{
    public partial class ThongKe : Form
    {
        TraiCayBUS traicayBUS = new TraiCayBUS();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        List<TraiCayDTO> traicayDTO = new List<TraiCayDTO>();
        List<NhanVienDTO> nhanvienDTO = new List<NhanVienDTO>();
        HoaDonXuatBUS hdxBUS = new HoaDonXuatBUS();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbonhanvien.DataSource = nhanvienBUS.DanhSachNhanVien();
            cbonhanvien.DisplayMember = "TenNhanVien";
            cbonhanvien.ValueMember = "MaNhanVien";

            
        }

        private void btnxembaocao_Click(object sender, EventArgs e)
        {
            if(radsanphamhethang.Checked)
            {
                frmXemBaoCao frm = new frmXemBaoCao();
                frm.Xemsp();
                frm.ShowDialog();
            }

           if(radtheohoadon.Checked)
           {
               frmXemBaoCao frm = new frmXemBaoCao();
               frm.TatCaHoaDon();
               frm.ShowDialog();
           }
           

            if(radtatcatraicay.Checked)
            {
                frmXemBaoCao frm = new frmXemBaoCao();
                frm.TatCaTraiCay();
                frm.ShowDialog();
            }

            if(radtacanhanvien.Checked)
            {
                frmXemBaoCao frm=new frmXemBaoCao();
                frm.TatCaNhanVien();
                frm.ShowDialog();
            }

            if(radtheohoadon.Checked)
            {
                frmXemBaoCao frm = new frmXemBaoCao();
                frm.HoaDon();
                frm.ShowDialog();
            }

            if(radtheotungnhanvien.Checked)
            {
                frmXemBaoCao frm = new frmXemBaoCao();
                frm.TheoNhanVien((NhanVienDTO)cbonhanvien.SelectedItem);
                frm.ShowDialog();
            }

            //if(radtongdoanhthu.Checked)
            //{
            //    frmXemBaoCao frm = new frmXemBaoCao();
            //    frm.lsHD();
            //    frm.ShowDialog();
            //}

        }

        private void radtatcatraicay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radtacanhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radtheotungnhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radsanphamhethang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radtatcahoadon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbonhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
