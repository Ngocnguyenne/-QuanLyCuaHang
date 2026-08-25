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

namespace QLCHTraiCay
{
    public partial class frmMain : Form
    {
        public NhanVienDTO NVDangNhap = null;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Visible = false;
            menuStrip.Visible = false;
            picBoxNV.Visible = false;
            lblHoTen.Visible = false;
            btnDangXuat.Visible = false;

            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Dock = DockStyle.Fill;
            frmDangNhap.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                QLNhanVien nhanvien = new QLNhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Dock = DockStyle.Fill;
                nhanvien.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                QLSanPham frmTraiCay = new QLSanPham();
                frmTraiCay.MdiParent = this;
                frmTraiCay.Dock = DockStyle.Fill;
                frmTraiCay.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }
        }

        public void SetPanel(bool kq)
        {
            menuStrip.Visible = kq;
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
           
                QLKhachHang khachang = new QLKhachHang();
                khachang.MdiParent = this;
                khachang.Dock = DockStyle.Fill;
                khachang.Show();

        }

        private void btnBanTraiCay_Click(object sender, EventArgs e)
        {
                BanTraiCay bantraicay = new BanTraiCay();
                bantraicay.MdiParent = this;
                bantraicay.Dock = DockStyle.Fill;
                bantraicay.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                QLNhaCungCap nhacungcap = new QLNhaCungCap();
                nhacungcap.MdiParent = this;
                nhacungcap.Dock = DockStyle.Fill;
                nhacungcap.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }
        }

        public void SetTrangThaiDangNhap(NhanVienDTO nv)
        {
            NVDangNhap = nv;
            if (NVDangNhap != null)
            {
                lblXinChao.Visible = true;
                menuStrip.Visible = true;
                picBoxNV.Visible = true;
                lblHoTen.Visible = true;
                btnDangXuat.Visible = true;
                picBoxNV.Image = Image.FromFile(NVDangNhap.HinhAnh);
                lblHoTen.Text ="\n" +  NVDangNhap.HoTenNhanVien;
            }
            else
            {
                lblXinChao.Visible = false;
                menuStrip.Visible = false;
                picBoxNV.Visible = false;
                lblHoTen.Visible = false;
                btnDangXuat.Visible = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            NVDangNhap = null;
            SetTrangThaiDangNhap(NVDangNhap);
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.WindowState = FormWindowState.Maximized;
            frmDangNhap.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                QLHoaDonNhap hoadonnhap = new QLHoaDonNhap();
                hoadonnhap.MdiParent = this;
                hoadonnhap.Dock = DockStyle.Fill;
                hoadonnhap.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }
        }

        private void btnHoaDonXuat_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                QLHoaDonXuat hoadonxuat = new QLHoaDonXuat();
                hoadonxuat.MdiParent = this;
                hoadonxuat.Dock = DockStyle.Fill;
                hoadonxuat.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }
        }

        private void menStripBCTK_Click(object sender, EventArgs e)
        {
            if (NVDangNhap.MaLoaiNhanVien != "LNV0002")
            {
                ThongKe thongke = new ThongKe();
                thongke.MdiParent = this;
                thongke.Dock = DockStyle.Fill;
                thongke.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được vào", "Thông báo");
            }
        }

        private void menNhapTC_Click(object sender, EventArgs e)
        {
            NhapHang nhapsp = new NhapHang();
            nhapsp.MdiParent = this;
            nhapsp.Dock = DockStyle.Fill;
            nhapsp.Show();
        }
    }
}
