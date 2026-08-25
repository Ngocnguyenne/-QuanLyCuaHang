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
    public partial class QLHoaDonXuat : Form
    {
        HoaDonXuatDTO hoadonxuatDTO = new HoaDonXuatDTO();
        HoaDonXuatBUS hoadonxuatBUS = new HoaDonXuatBUS();
        ChiTietHDXuatDTO ctDTO = new ChiTietHDXuatDTO();
        ChiTietHDXuatBUS ctBUS = new ChiTietHDXuatBUS();

        public QLHoaDonXuat()
        {
            InitializeComponent();
        }

        private void QLHoaDonXuat_Load(object sender, EventArgs e)
        {
            HoaDonXuatBUS hoadon = new HoaDonXuatBUS();
            dgvHoaDonXuat.DataSource = hoadon.DanhSachHoaDonXuat();

            ChiTietHDXuatBUS chitiet = new ChiTietHDXuatBUS();
            dgvCTHoaDonXuat.DataSource = chitiet.DanhSachChiTietHDXuat();
        }

        private void dgvHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDonXuat.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["colmahoadonxuat"].Value.ToString();
                txtMaNhanVien.Text = row.Cells["colmanhanvien"].Value.ToString();
                txtMaKhachHang.Text = row.Cells["colMaKhachHang"].Value.ToString();
                txtTongTien.Text = row.Cells["coltongtien"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["colTrangThai"].Value) == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
        }

        private void dgvCTHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTHoaDonXuat.Rows[e.RowIndex];
                txtMaCTHDXuat.Text = row.Cells["colmacthoadonxuat"].Value.ToString();
                txtMaTraiCay.Text = row.Cells["colmatraicay"].Value.ToString();
                txtGiaNhap.Text = row.Cells["colgiaban"].Value.ToString();
                txtSoLuong.Text = row.Cells["colsoluong"].Value.ToString();
                txtThanhTien.Text = row.Cells["colThanhTien"].Value.ToString();
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

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            hoadonxuatDTO.MaHoaDonXuat = txtMaHoaDon.Text;
            if (hoadonxuatBUS.xoaHoaDon(hoadonxuatDTO))
            {
                MessageBox.Show("Xóa thành công!");
                dgvHoaDonXuat.DataSource = hoadonxuatBUS.DanhSachHoaDonXuat();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            ctDTO.MaCTHoaDonXuat = txtMaCTHDXuat.Text;
            ctDTO.MaTraiCay = txtMaTraiCay.Text;
            if (ctBUS.XoaCTHoaDonXuat(ctDTO))
            {
                MessageBox.Show("Xóa thành công!");
                dgvCTHoaDonXuat.DataSource = ctBUS.DanhSachChiTietHDXuat();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
