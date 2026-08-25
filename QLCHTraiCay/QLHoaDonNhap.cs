using QLCHTraiCayBUS;
using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLCHTraiCay
{
    public partial class QLHoaDonNhap : Form
    {

        HoaDonNhapDTO HoaDonNhapDTO = new HoaDonNhapDTO();
        HoaDonNhapBUS HoaDonNhapBUS = new HoaDonNhapBUS();

        ChiTietHDNhapBUS CTHoaDonNhapBUS = new ChiTietHDNhapBUS();
        ChiTietHDNhapDTO CTHoaDonNhapDTO = new ChiTietHDNhapDTO();

        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        TraiCayBUS traicayBUS = new TraiCayBUS();

        NhaCungCapBUS ncc = new NhaCungCapBUS();
        List<ChiTietHDNhapDTO> cthd = new List<ChiTietHDNhapDTO>();

        string Ngay = System.DateTime.Now.ToString("dd/MM/yyyy");
        
        public QLHoaDonNhap()
        {
            InitializeComponent();
            
        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDonNhap.Rows[e.RowIndex];

                dgvCTHoaDonNhap.DataSource = CTHoaDonNhapBUS.DanhSachChiTietHoaDonNhap(row.Cells["colmahoadonnhap"].Value.ToString());
                txtMaHDNhap.Text = row.Cells["colmahoadonnhap"].Value.ToString();
                txtTongTien.Text = row.Cells["coltongtien"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["colTrangThai"].Value) == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
                txtCTHD.Text = row.Cells["colmahoadonnhap"].Value.ToString();
            }
        }

        private void QLHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = HoaDonNhapBUS.DanhSachHoaDonNhap();

            txtMaHDNhap.Text = HoaDonNhapBUS.TangHD();
            ChiTietHDNhapBUS chitiet = new ChiTietHDNhapBUS();

            cobTenNhanVien.DataSource = nhanvienBUS.DanhSachNhanVien();
            cobTenNhanVien.DisplayMember = "TenNhanVien";
            cobTenNhanVien.ValueMember = "MaNhanVien";
        }

        private void dgvCTHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDonNhap.Rows[e.RowIndex];
                txtCTHD.Text = row.Cells["colMaCT"].Value.ToString();
                txtGiaNhap.Text = row.Cells["colgianhap"].Value.ToString();
                txtSoLuong.Text = row.Cells["colsoluong"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["colTrangThai1"].Value) == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            //HoaDonNhapDTO.MaHoaDonNhap = HoaDonNhapBUS.TangHD();
            //HoaDonNhapDTO.MaNhanVien = cobTenNhanVien.SelectedValue.ToString();
            //HoaDonNhapDTO.NgayNhap = DateTime.Parse(date.Text);
            //HoaDonNhapDTO.TongTien = int.Parse(txtTongTien.Text);
            //HoaDonNhapDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            //if (HoaDonNhapBUS.ThemHoaDonNhap(HoaDonNhapDTO))
            //{
            //    MessageBox.Show("Thêm thành công!");
            //    dgvHoaDonNhap.DataSource = HoaDonNhapBUS.DanhSachHoaDonNhap();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại!");
            //}
        }


        private void btnSuaHDN_Click(object sender, EventArgs e)
        {
            HoaDonNhapDTO.TongTien = int.Parse(txtTongTien.Text);
            HoaDonNhapDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            if (HoaDonNhapBUS.SuaHoaDonNhap(HoaDonNhapDTO))
            {
                MessageBox.Show("Sửa thành công!");
                dgvHoaDonNhap.DataSource = HoaDonNhapBUS.DanhSachHoaDonNhap();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            
            if (HoaDonNhapBUS.XoaHoaDonNhap(txtMaHDNhap.Text))
            {
                MessageBox.Show("Xóa thành công!");
                dgvHoaDonNhap.DataSource = HoaDonNhapBUS.DanhSachHoaDonNhap();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnHuyHDN_Click(object sender, EventArgs e)
        {
            txtMaHDNhap.Text = null;
            cobTenNhanVien.SelectedValue = null;
            txtTongTien.Text = null;
            chkTrangThai.Checked = false;
        }
        
        private void btnTHemCTHDNhap_Click(object sender, EventArgs e)
        {
            CTHoaDonNhapDTO.MaCTHoaDonNhap = txtCTHD.Text;
            CTHoaDonNhapDTO.MaTraiCay = txtMaTraiCay.Text;
            CTHoaDonNhapDTO.GiaNhap = int.Parse(txtGiaNhap.Text);
            CTHoaDonNhapDTO.SoLuong = int.Parse(txtSoLuong.Text);
            CTHoaDonNhapDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            if (CTHoaDonNhapBUS.ThemCTHoaDonNhap(CTHoaDonNhapDTO))
            {
                MessageBox.Show("Thêm thành công!");
                dgvCTHoaDonNhap.DataSource = CTHoaDonNhapBUS.DanhSachChiTietHoaDonNhap(txtMaHDNhap.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }

        private void btnSuaCTHDNhap_Click(object sender, EventArgs e)
        {
            CTHoaDonNhapDTO.GiaNhap = int.Parse(txtGiaNhap.Text);
            CTHoaDonNhapDTO.SoLuong = int.Parse(txtSoLuong.Text);
            CTHoaDonNhapDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            if (CTHoaDonNhapBUS.SuaCTHoaDonNhap(CTHoaDonNhapDTO))
            {
                MessageBox.Show("Sửa thành công!");
                dgvCTHoaDonNhap.DataSource = CTHoaDonNhapBUS.DanhSachChiTietHoaDonNhap(txtMaHDNhap.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaCTHDNhap_Click(object sender, EventArgs e)
        {
            if (CTHoaDonNhapBUS.XoaCTHoaDonNhap(CTHoaDonNhapDTO))
            {
                MessageBox.Show("Xóa thành công!");
                dgvCTHoaDonNhap.DataSource = CTHoaDonNhapBUS.DanhSachChiTietHoaDonNhap(txtMaHDNhap.Text);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnHuyCTHDNhap_Click(object sender, EventArgs e)
        {
            txtCTHD.Text = "";
            txtGiaNhap.Text = "";
            txtMaTraiCay.Text = "";
            txtSoLuong.Text = ""; 
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
