using QLCHTraiCayBUS;
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
    public partial class QLKhachHang : Form
    {
        List<KhachHangDTO> lsKhachHang = new List<KhachHangDTO>();
        KhachHangDTO khachhangDTO = new KhachHangDTO();
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        public QLKhachHang()
        {
           
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            KhachHangBUS khachang = new KhachHangBUS();
            dgvKhachHang.DataSource = khachang.DanhSachKH();
            txtMaKhachHang.Text = khachhangBUS.TangKhachHang();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhachHang.Rows[e.RowIndex];
            }
        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKhachHang.Text = row.Cells["colmakhachhang"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["coltenkhachhang"].Value.ToString();
                txtDiaChi.Text = row.Cells["coldiachi"].Value.ToString();
                txtSDT.Text = row.Cells["colsdt"].Value.ToString();
                chkTrangThai.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin","Thông báo");
            }
            else
            {
                khachhangDTO.MaKhachHang = khachhangBUS.TangKhachHang();
                khachhangDTO.TenKhachHang = txtTenKhachHang.Text;
                khachhangDTO.DiaChi = txtDiaChi.Text;
                khachhangDTO.SDT = txtSDT.Text;
                khachhangDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);

                khachhangDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
                if (khachhangBUS.ThemKhachHang(khachhangDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
                dgvKhachHang.DataSource = khachhangBUS.DanhSachKH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            khachhangDTO.MaKhachHang = txtMaKhachHang.Text;
            khachhangDTO.TenKhachHang = txtTenKhachHang.Text;
            khachhangDTO.DiaChi = txtDiaChi.Text;
            khachhangDTO.SDT = txtSDT.Text;
            khachhangDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);

            khachhangDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            if (khachhangBUS.SuaKhachHang(khachhangDTO))
            {
                MessageBox.Show("Sửa thành công!");
                dgvKhachHang.DataSource = khachhangBUS.DanhSachKH();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text;
            if (khachhangBUS.XoaKhachHang(maKH) == true)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            dgvKhachHang.DataSource = khachhangBUS.DanhSachKH();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            chkTrangThai.Checked = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lsKhachHang = khachhangBUS.DanhSachKH();
            dgvKhachHang.DataSource = lsKhachHang.FindAll(o => o.TenKhachHang.Contains(txtTimTen.Text));
        }

       
    }
}
