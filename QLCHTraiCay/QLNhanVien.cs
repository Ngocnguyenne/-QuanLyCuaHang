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
    public partial class QLNhanVien : Form
    {
        List<NhanVienDTO> lsNhanVien = new List<NhanVienDTO>();
        NhanVienDTO nhanvienDTO = new NhanVienDTO();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();

        public NhanVienDTO NVDangNhap = null;

        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {    
            NhanVienBUS nhanvienbus = new NhanVienBUS();
            cobLoaiNhanVien.DataSource = nhanvienbus.LayLoaiNhanVien();
            cobLoaiNhanVien.DisplayMember = "LoaiNhanVien";
            cobLoaiNhanVien.ValueMember = "MaLoaiNhanVien";
            dgvNhanVien.DataSource = nhanvienbus.DanhSachNhanVien();
            txtMaNhanVien.Text = nhanvienBUS.TangNhanVien();
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Trở về trang chủ!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvnhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["colmanhanvien"].Value.ToString();
                txtHoNhanVien.Text = row.Cells["colhonhanvien"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["coltennhanvien"].Value.ToString();
                txtSDT.Text = row.Cells["colsdt"].Value.ToString();
                txtDiaChi.Text = row.Cells["coldiachi"].Value.ToString();
                txtLuong.Text = row.Cells["colluong"].Value.ToString();
                txtgioitinh.Text = row.Cells["colgioitinh"].Value.ToString();
                dateNgaySinh.Text = row.Cells["colngaysinh"].Value.ToString();
                txtMatKhau.Text = row.Cells["colmatkhau"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["coltinhtrang"].Value) == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
                picBoxNV.ImageLocation = row.Cells["colhinhanh"].Value.ToString();
                lblDuongDan.Text = row.Cells["colhinhanh"].Value.ToString();
                lblDuongDan.Visible = false;
            }
        }

        private void picBoxNV_Click(object sender, EventArgs e)
        {
            if(ofdHinhAnh.ShowDialog() == DialogResult.OK)
            {
                lblDuongDan.Text = picBoxNV.ImageLocation = ofdHinhAnh.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "" || txtHoNhanVien.Text == "" || txtMatKhau.Text == "" || txtgioitinh.Text == "" || txtSDT.Text == "" || txtLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                nhanvienDTO.MaNhanVien = nhanvienBUS.TangNhanVien();
                nhanvienDTO.HoNhanVien = txtHoNhanVien.Text;
                nhanvienDTO.TenNhanVien = txtTenNhanVien.Text;
                nhanvienDTO.MaLoaiNhanVien = cobLoaiNhanVien.SelectedValue.ToString();
                nhanvienDTO.MatKhau = txtMatKhau.Text;
                nhanvienDTO.GioiTinh = txtgioitinh.Text;
                nhanvienDTO.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text);
                nhanvienDTO.DiaChi = txtDiaChi.Text;
                nhanvienDTO.SDT = txtSDT.Text;
                nhanvienDTO.Luong = int.Parse(txtLuong.Text);
                nhanvienDTO.HinhAnh = lblDuongDan.Text;
                nhanvienDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
                if (nhanvienBUS.ThemNhanVien(nhanvienDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNhanVien.DataSource = nhanvienBUS.DanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                nhanvienDTO.MaNhanVien = txtMaNhanVien.Text;
                nhanvienDTO.HoNhanVien = txtHoNhanVien.Text;
                nhanvienDTO.TenNhanVien = txtTenNhanVien.Text;
                nhanvienDTO.MaLoaiNhanVien = cobLoaiNhanVien.SelectedValue.ToString();
                nhanvienDTO.MatKhau = txtMatKhau.Text;
                nhanvienDTO.GioiTinh = txtgioitinh.Text;
                nhanvienDTO.NgaySinh = dateNgaySinh.Value;
                nhanvienDTO.DiaChi = txtDiaChi.Text;
                nhanvienDTO.SDT = txtSDT.Text;
                nhanvienDTO.Luong = int.Parse(txtLuong.Text);
                nhanvienDTO.HinhAnh = lblDuongDan.Text;
                nhanvienDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);

                if (nhanvienBUS.SuaNhanVien(nhanvienDTO) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvNhanVien.DataSource = nhanvienBUS.DanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            if(nhanvienDTO.MaLoaiNhanVien=="LNV0001")
            {
                MessageBox.Show("Không thể xóa quản lý");
            }else if (nhanvienBUS.XoaNhanVien(maNV)== true)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            dgvNhanVien.DataSource = nhanvienBUS.DanhSachNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtHoNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
            txtgioitinh.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            chkTrangThai.Checked = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lsNhanVien = nhanvienBUS.DanhSachNhanVien();
            dgvNhanVien.DataSource = lsNhanVien.FindAll(o => o.HoTenNhanVien.Contains(txtTimTen.Text));
        }
    }
}
