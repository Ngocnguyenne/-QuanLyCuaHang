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
    public partial class QLSanPham : Form
    {
        List<TraiCayDTO> ls = new List<TraiCayDTO>();
        TraiCayDTO traicayDTO = new TraiCayDTO();
        TraiCayBUS traiCayBUS = new TraiCayBUS();

        public QLSanPham()
        {
            InitializeComponent();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            LoaiTraiCayBUS loaitc = new LoaiTraiCayBUS();
            cmbLoaiTC.DataSource = loaitc.LayLoaiTraiCay();
            cmbLoaiTC.DisplayMember = "TenLoaiTraiCay";
            cmbLoaiTC.ValueMember = "MaLoaiTraiCay";

            NhaCungCapBUS ncc = new NhaCungCapBUS();
            cmbNhaCungCap.DataSource = ncc.LayNhaCungCap();
            cmbNhaCungCap.DisplayMember = "TenNhaCungCap";
            cmbNhaCungCap.ValueMember = "MaNhaCungCap";

            TraiCayBUS traicaybus = new TraiCayBUS();
            dgvTraiCay.DataSource = traicaybus.DanhSachTraiCay();

            txtMaTraiCay.Text = traiCayBUS.TangTraiCay();
        }

        private void dgvTraiCay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTraiCay.Rows[e.RowIndex];
                txtMaTraiCay.Text = row.Cells["colmatraicay"].Value.ToString();
                txtTenTraiCay.Text = row.Cells["coltentraicay"].Value.ToString();
                txtgiatien.Text = row.Cells["colgiatien"].Value.ToString();
                txtmausac.Text = row.Cells["colmausac"].Value.ToString();
                txtxuatxu.Text = row.Cells["colxuatxu"].Value.ToString();
                txtsoluong.Text = row.Cells["colsoluong"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["coltinhtrang"].Value) == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
                picBoxTraiCay.ImageLocation = row.Cells["colhinh"].Value.ToString();
                lblDuongDan.Text = row.Cells["colhinh"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Trở về trang chủ!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtTenTraiCay.Text == "" || txtgiatien.Text == "" || txtmausac.Text == "" || txtxuatxu.Text == "" || txtsoluong.Text == "" || chkTrangThai.Checked == false)
            //{
            //    MessageBox.Show("Chưa nhập đủ thông tin trái cây", "Thông báo");
            //    return;
            //}
            //else
            //{
            //    traicayDTO.MaTraiCay = traiCayBUS.TangTraiCay();
            //    traicayDTO.TenTraiCay = txtTenTraiCay.Text;
            //    traicayDTO.GiaTien = int.Parse(txtgiatien.Text);
            //    traicayDTO.Mau = txtmausac.Text;
            //    traicayDTO.MaNhaCungCap = cmbNhaCungCap.SelectedValue.ToString();
            //    traicayDTO.XuatXu = txtxuatxu.Text;
            //    traicayDTO.SoLuong = int.Parse(txtsoluong.Text);
            //    traicayDTO.HinhAnh = lblDuongDan.Text;
            //    traicayDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            //    traicayDTO.MaLoaiTraiCay = cmbLoaiTC.SelectedValue.ToString();
            //    if (traiCayBUS.themTraiCay(traicayDTO))
            //    {
            //        MessageBox.Show("Thêm thành công!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm thất bại!");
            //    }
            //    dgvTraiCay.DataSource = traiCayBUS.DanhSachTraiCay();
            //}
        }

        private void picBoxTraiCay_Click(object sender, EventArgs e)
        {
            if (ofdHinhAnh.ShowDialog() == DialogResult.OK)
            {
                lblDuongDan.Text = picBoxTraiCay.ImageLocation = ofdHinhAnh.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            traicayDTO.MaTraiCay = txtMaTraiCay.Text;
            traicayDTO.TenTraiCay = txtTenTraiCay.Text;
            traicayDTO.GiaTien = int.Parse(txtgiatien.Text);
            traicayDTO.Mau = txtmausac.Text;
            traicayDTO.MaNhaCungCap = cmbNhaCungCap.SelectedValue.ToString();
            traicayDTO.XuatXu = txtxuatxu.Text;
            traicayDTO.SoLuong = int.Parse(txtsoluong.Text);
            traicayDTO.HinhAnh = lblDuongDan.Text;
            traicayDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            traicayDTO.MaLoaiTraiCay = cmbLoaiTC.SelectedValue.ToString();
            if (traiCayBUS.suaTraiCay(traicayDTO))
            {
                MessageBox.Show("Sửa thành công!");
                dgvTraiCay.DataSource = traiCayBUS.DanhSachTraiCay();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTC = txtMaTraiCay.Text;
            if (traiCayBUS.XoaTraiCay(maTC) == true)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            dgvTraiCay.DataSource = traiCayBUS.DanhSachTraiCay();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTraiCay.Text = "";
            txtTenTraiCay.Text = "";
            txtmausac.Text = "";
            txtgiatien.Text = "";
            txtsoluong.Text = "";
            txtxuatxu.Text = "";
            chkTrangThai.Checked = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ls = traiCayBUS.DanhSachTraiCay();
            dgvTraiCay.DataSource = ls.FindAll(o => o.TenTraiCay.Contains(txtten.Text));
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }     
    }
}
