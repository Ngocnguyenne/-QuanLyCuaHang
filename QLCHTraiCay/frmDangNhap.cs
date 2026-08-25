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
    public partial class frmDangNhap : Form
    {
        NhanVienBUS NhanVienBUS = new NhanVienBUS();
        List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
        NhanVienDTO NhanVienDangNhap = null;
        

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lstNhanVien = NhanVienBUS.DanhSachNhanVien();
            cobTenTaiKhoan.DataSource = lstNhanVien;
            cobTenTaiKhoan.DisplayMember = "HoTenNhanVien";
            cobTenTaiKhoan.ValueMember = "MaNhanVien";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NhanVienDangNhap = (NhanVienDTO)cobTenTaiKhoan.SelectedItem;
            if (NhanVienDangNhap == null || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản và nhập mật khẩu !!!");
            }
            else
            {
                if (NhanVienDangNhap.MatKhau != txtMatKhau.Text)
                {
                    MessageBox.Show("Sai mật khẩu !!!");
                }
                else
                {
                    (this.MdiParent as frmMain).SetTrangThaiDangNhap(NhanVienDangNhap);
                    this.Close();
                }
            }
        }
    }
}
