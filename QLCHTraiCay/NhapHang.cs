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
    public partial class NhapHang : Form
    {
        List<ChiTietHDNhapDTO> lstChiTiet = new List<ChiTietHDNhapDTO>();
        
        List<TraiCayDTO> lstTraiCay = new List<TraiCayDTO>();
        List<TraiCayDTO> lstGioHang = new List<TraiCayDTO>();
        List<TraiCayDTO> lstTC = new List<TraiCayDTO>();
        List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
        List<LoaiTraiCayDTO> lstLoaiTC = new List<LoaiTraiCayDTO>();
        List<NhaCungCapDTO> lstNCC = new List<NhaCungCapDTO>();

        TraiCayDTO traicayDTO = new TraiCayDTO();

        ChiTietHDNhapDTO chitietDTO = new ChiTietHDNhapDTO();
        ChiTietHDNhapBUS chitietBUS = new ChiTietHDNhapBUS();

        LoaiTraiCayBUS loaitcBUS = new LoaiTraiCayBUS();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        HoaDonNhapBUS hoadonBUS = new HoaDonNhapBUS();
        TraiCayBUS traicayBUS = new TraiCayBUS();


        public NhapHang()
        {
            InitializeComponent();
            dgvSPThem.AutoGenerateColumns = false;
            dgvTraiCay.AutoGenerateColumns = false;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            TangMaHD();
            TangMaTC();
            ThanhTien();

            txtMaTraiCay.Visible = true;
            txtMaHD.Visible = true;
            lblDuongDan.Visible = false;
            txtSoLuong.Focus();

            lstTraiCay = traicayBUS.DanhSachTraiCay();
            lstNCC = nccBUS.LayNhaCungCap();
            lstLoaiTC = loaitcBUS.LayLoaiTraiCay();

            cbbLoaiTC.DataSource = lstLoaiTC;
            cbbLoaiTC.DisplayMember = "TenLoaiTraiCay";
            cbbLoaiTC.ValueMember = "MaLoaiTraiCay";

            cbbNCC.DataSource = lstNCC;
            cbbNCC.DisplayMember = "TenNhaCungCap";
            cbbNCC.ValueMember = "MaNhaCungCap";

            dgvTraiCay.DataSource = traicayBUS.DanhSachTraiCay();
        }

        private void ThanhTien()
        {
            if (txtGiaTien.Text.Trim() != "" && txtSoLuong.Text.Trim() != "")
            {
                int thanhtien = 0;
                int dongia = Convert.ToInt32(txtGiaTien.Text);
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                thanhtien = soluong * dongia;
                lblThanhTien.Text = thanhtien.ToString();
                lblThanhTien.Text = string.Format("{0:0,0}", thanhtien);
            }
            else
            {
                lblThanhTien.Text = "0";
            }       
        }

        private int LayTongTien()
        {
            int TongTien = 0;
            int n = dgvSPThem.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                string tt = dgvSPThem.Rows[i].Cells["colThanhTien"].Value.ToString();
                TongTien += int.Parse(tt);
            }
            return TongTien;
        }

        private void TangMaHD()
        {
            txtMaHD.Text = hoadonBUS.TangHD();
        }

        private void TangMaTC()
        {
            txtMaTraiCay.Text = traicayBUS.TangTraiCay();
        }

        private void dgvTraiCay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvTraiCay.Columns[e.ColumnIndex].Name == "colhinh")
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
            }
            catch (FormatException) { }
        }

        private void dgvTraiCay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTraiCay.Rows[e.RowIndex];
                //txtMaTraiCay.Text = row.Cells["colmatraicay"].Value.ToString();
                txtTenTraiCay.Text = row.Cells["coltentraicay"].Value.ToString();
                txtGiaTien.Text = row.Cells["colgiatien"].Value.ToString();
                txtMau.Text = row.Cells["colmausac"].Value.ToString();
                txtXuatXu.Text = row.Cells["colxuatxu"].Value.ToString();

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
                ThanhTien();
            }
        }

        private void picBoxTraiCay_Click(object sender, EventArgs e)
        {
            if (ofdHinh.ShowDialog() == DialogResult.OK)
            {
                lblDuongDan.Text = picBoxTraiCay.ImageLocation = ofdHinh.FileName;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lstTraiCay = traicayBUS.DanhSachTraiCay();
            dgvTraiCay.DataSource = lstTraiCay.FindAll(o => o.TenTraiCay.Contains(txtTim.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<TraiCayDTO> lsttc = new List<TraiCayDTO>();
            if(dgvSPThem.RowCount == 0)
            {
                int tt= int.Parse(txtSoLuong.Text) * int.Parse(txtGiaTien.Text);
                int vitri = dgvSPThem.Rows.Add();
                dgvSPThem.Rows[vitri].Cells[0].Value = txtMaTraiCay.Text;
                dgvSPThem.Rows[vitri].Cells[1].Value = txtTenTraiCay.Text;
                dgvSPThem.Rows[vitri].Cells[2].Value = txtMau.Text;
                dgvSPThem.Rows[vitri].Cells[3].Value = cbbLoaiTC.SelectedValue;
                dgvSPThem.Rows[vitri].Cells[4].Value = txtXuatXu.Text;
                dgvSPThem.Rows[vitri].Cells[5].Value = txtGiaTien.Text;
                dgvSPThem.Rows[vitri].Cells[6].Value = lblThanhTien.Text;
                dgvSPThem.Rows[vitri].Cells[7].Value = picBoxTraiCay.Image;
                dgvSPThem.Rows[vitri].Cells[8].Value = txtSoLuong.Text;
                dgvSPThem.Rows[vitri].Cells[9].Value = cbbNCC.SelectedValue;
            }
            else
            {
                for (int i = 0; i < dgvSPThem.RowCount; i++)
                {
                    if (txtMaTraiCay.Text == dgvSPThem.Rows[i].Cells["colMaTC"].Value.ToString())
                    {
                        int gt = int.Parse(dgvSPThem.Rows[i].Cells["colSoLuongTC"].Value.ToString());
                        int sl = int.Parse(txtSoLuong.Text) + gt;
                        float tttt = float.Parse(dgvSPThem.Rows[i].Cells["colThanhTien"].Value.ToString());
                        float ttt = float.Parse(lblThanhTien.Text) + tttt;
                        dgvSPThem.Rows[i].Cells["colSoLuongTC"].Value =sl;
                        dgvSPThem.Rows[i].Cells["colThanhTien"].Value = string.Format("{0:#,##0}",ttt);
                    }
                    else
                    {
                        int vitri = dgvSPThem.Rows.Add();
                        dgvSPThem.Rows[vitri].Cells[0].Value = txtMaTraiCay.Text;
                        dgvSPThem.Rows[vitri].Cells[1].Value = txtTenTraiCay.Text;
                        dgvSPThem.Rows[vitri].Cells[2].Value = txtMau.Text;
                        dgvSPThem.Rows[vitri].Cells[3].Value = cbbLoaiTC.SelectedValue;
                        dgvSPThem.Rows[vitri].Cells[4].Value = txtXuatXu.Text;
                        dgvSPThem.Rows[vitri].Cells[5].Value = txtGiaTien.Text;
                        dgvSPThem.Rows[vitri].Cells[6].Value = lblThanhTien.Text;
                        dgvSPThem.Rows[vitri].Cells[7].Value = picBoxTraiCay.Image;
                        dgvSPThem.Rows[vitri].Cells[8].Value = txtSoLuong.Text;
                        dgvSPThem.Rows[vitri].Cells[9].Value = cbbNCC.SelectedValue;
                        dgvSPThem.Rows[vitri].Cells[10].Value = Convert.ToInt32(chkTrangThai.Checked);
                    }
                }
            }

        }
        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        public TraiCayDTO KiemTraTonTai(string MaTraiCay)
        {
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                if (lstGioHang[i].MaTraiCay == MaTraiCay)
                    return lstGioHang[i];
            }
            return null;
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            txtMaTraiCay.Text = traicayBUS.TangTraiCay();
            txtTenTraiCay.Text = "";
            txtMau.Text = "";
            txtXuatXu.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            picBoxTraiCay.Image = null;
            chkTrangThai.Checked = false;
        }

        //private void GetDuLieu()
        //{
        //    lstChiTiet = new List<ChiTietHDNhapDTO>();
        //    for (int i = 0; i < dgvSPThem.RowCount; i++)
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row = dgvSPThem.Rows[i];
        //        ChiTietHDNhapDTO ct = new ChiTietHDNhapDTO();
        //        ct.MaTraiCay = row.Cells["colMaTC"].Value.ToString();
        //        ct.MaCTHoaDonNhap = hoadonBUS.TangHD();
        //        ct.SoLuong = Convert.ToInt32(row.Cells["colSoLuongTC"].Value.ToString());
        //        ct.ThanhTien = float.Parse(row.Cells["colThanhTien"].Value.ToString());
        //        ct.GiaNhap = Convert.ToInt32(row.Cells["colGiaTienTC"].Value.ToString());
        //        lstChiTiet.Add(ct);
        //    }
        //}

        //private void GetTC()
        //{
        //    lstTC = new List<TraiCayDTO>();

        //    for (int i = 0; i < dgvSPThem.RowCount; i++)
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row = dgvSPThem.Rows[i];
        //        TraiCayDTO tc = new TraiCayDTO();
        //        tc.MaTraiCay = row.Cells["colMaTC"].Value.ToString();
        //        tc.TenTraiCay = row.Cells["colTenTC"].Value.ToString();
        //        tc.Mau = row.Cells["colLoaiTC"].Value.ToString();
        //        tc.XuatXu = row.Cells["colXuatXuTC"].Value.ToString();
        //        tc.GiaTien = Convert.ToInt32(row.Cells["colGiaTienTC"].Value.ToString());
        //        tc.HinhAnh = row.Cells["colHinhTC"].Value.ToString();
        //        tc.SoLuong = Convert.ToInt32(row.Cells["colSoLuongTC"].Value.ToString());
        //        tc.MaNhaCungCap = row.Cells["colNCC"].Value.ToString();
        //        tc.TrangThai = 1;
        //    }
        //}

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            List<TraiCayDTO> lstChiTiet = new List<TraiCayDTO>();

            for (int i = 0; i < dgvSPThem.RowCount; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSPThem.Rows[i];
                TraiCayDTO ct = new TraiCayDTO();
                ct.MaTraiCay = txtMaTraiCay.Text;
                ct.TenTraiCay = row.Cells["colTenTC"].Value.ToString();
                ct.SoLuong = Convert.ToInt32(row.Cells["colSoLuongTC"].Value.ToString());
                ct.ThanhTien = float.Parse(row.Cells["colThanhTien"].Value.ToString());
                ct.GiaTien = Convert.ToInt32(row.Cells["colGiaTienTC"].Value.ToString());
                ct.MaNhaCungCap = row.Cells["colNCC"].Value.ToString();
                ct.XuatXu = row.Cells["colXuatXuTC"].Value.ToString();
                ct.MaLoaiTraiCay = row.Cells["colLoaiTC"].Value.ToString();
                lstChiTiet.Add(ct);
            }
            HoaDonNhapDTO hdn = new HoaDonNhapDTO();
            QLSanPham sp = new QLSanPham();
            frmMain fr = (frmMain)this.MdiParent;

            hdn.MaHoaDonNhap = hoadonBUS.TangHD();
            hdn.MaNhanVien = fr.NVDangNhap.MaNhanVien;
            hdn.NgayNhap = System.DateTime.Now;

            int mhd = hoadonBUS.ThemHoaDonNhap(hdn);

            for (int i = 0; i < lstChiTiet.Count; i++)
            {
                TraiCayDTO cthd = new TraiCayDTO();
                cthd.MaTraiCay = txtMaTraiCay.Text;
                cthd.MaLoaiTraiCay = lstChiTiet[i].MaLoaiTraiCay;
                cthd.TenTraiCay = lstChiTiet[i].TenTraiCay;
                cthd.SoLuong = lstChiTiet[i].SoLuong;
                cthd.ThanhTien = lstChiTiet[i].ThanhTien;
                cthd.GiaTien = lstChiTiet[i].GiaTien;
                cthd.Mau = lstChiTiet[i].Mau;
                cthd.MaNhaCungCap = lstChiTiet[i].MaNhaCungCap;
                cthd.XuatXu = lstChiTiet[i].XuatXu;
                cthd.TrangThai = 1;

                if (traicayBUS.themTraiCay(cthd) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    lblTongTien.Text = dgvSPThem.CurrentRow.Cells[6].Value.ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            dgvTraiCay.DataSource = traicayBUS.DanhSachTraiCay();

            for (int i = 0; i < dgvSPThem.Rows.Count; i++)
            {
                dgvSPThem.Rows.RemoveAt(rowIndex);
            }
        }      

        private int rowIndex = 0;

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPThem.Rows.Count; i++)
            {
                dgvSPThem.Rows.RemoveAt(rowIndex);
            }
        }
    }
}
