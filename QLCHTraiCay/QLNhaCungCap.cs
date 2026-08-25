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
    public partial class QLNhaCungCap : Form
    {
        List<NhaCungCapDTO> lsNhaCungCap = new List<NhaCungCapDTO>();
        NhaCungCapDTO nccDTO = new NhaCungCapDTO();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        public QLNhaCungCap()
        {
            InitializeComponent();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhaCungCap.Rows[e.RowIndex];
            }
        }

        private void dgvNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhaCungCap.Rows[e.RowIndex];

                txtMaNhaCungCap.Text = row.Cells["colmanhacungcap"].Value.ToString();
                txtTenNhaCungCap.Text = row.Cells["coltennhacungcap"].Value.ToString();
                txtDiaChi.Text = row.Cells["coldiachi"].Value.ToString();
                txtSDT.Text = row.Cells["colsdt"].Value.ToString();
                txtEmail.Text = row.Cells["colemail"].Value.ToString();
                chkTrangThai.Checked = true;
            }
        }

        private void QLNhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCapBUS nhacungcap = new NhaCungCapBUS();
            dgvNhaCungCap.DataSource = nhacungcap.LayNhaCungCap();
            txtMaNhaCungCap.Text = nccBUS.TangNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text == "" || txtTenNhaCungCap.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
            }
            else
            {
                nccDTO.MaNhaCungCap = nccBUS.TangNCC();
                nccDTO.TenNhaCungCap = txtTenNhaCungCap.Text;
                nccDTO.DiaChi = txtDiaChi.Text;
                nccDTO.SDT = txtSDT.Text;
                nccDTO.Email = txtEmail.Text;
                nccDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
                if (nccBUS.ThemNhaCungCap(nccDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNhaCungCap.DataSource = nccBUS.LayNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nccDTO.MaNhaCungCap = txtMaNhaCungCap.Text;
            nccDTO.TenNhaCungCap = txtTenNhaCungCap.Text;
            nccDTO.DiaChi = txtDiaChi.Text;
            nccDTO.SDT = txtSDT.Text;
            nccDTO.Email = txtEmail.Text;
            nccDTO.TrangThai = Convert.ToInt32(chkTrangThai.Checked);
            if (nccBUS.SuaNhaCungCap(nccDTO))
            {
                MessageBox.Show("Sửa thành công!");
                dgvNhaCungCap.DataSource = nccBUS.LayNhaCungCap();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNhaCungCap.Text;
            if (nccBUS.XoaNhaCungCap(maNCC) == true)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            dgvNhaCungCap.DataSource = nccBUS.LayNhaCungCap();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            chkTrangThai.Checked = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lsNhaCungCap = nccBUS.LayNhaCungCap();
            dgvNhaCungCap.DataSource = lsNhaCungCap.FindAll(o => o.TenNhaCungCap.Contains(txtTimTen.Text));
        }
    }
}
