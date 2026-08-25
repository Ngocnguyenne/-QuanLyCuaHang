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
    public partial class BanTraiCay : Form
    {
        List<TraiCayDTO> lstTraiCay = new List<TraiCayDTO>();
        List<TraiCayDTO> lstTC = new List<TraiCayDTO>();
        List<ChiTietHDXuatDTO> lstchitiet = new List<ChiTietHDXuatDTO>();
        List<TraiCayDTO> listGioHang = new List<TraiCayDTO>();
        List<TraiCayDTO> listTam = new List<TraiCayDTO>();

        TraiCayBUS traicayBUS = new TraiCayBUS();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        HoaDonXuatBUS hdxuatBUS = new HoaDonXuatBUS();
        ChiTietHDXuatBUS cthdxuatBUS = new ChiTietHDXuatBUS();

        HoaDonXuatDTO hdxuatDTO = new HoaDonXuatDTO();
       

        public BanTraiCay()
        {
            InitializeComponent();
            dgvTraiCay.AutoGenerateColumns = false;
            dgvGioHang.AutoGenerateColumns = false;
            
        }
        private void BanTraiCay_Load(object sender, EventArgs e)
        {
            lstTraiCay = traicayBUS.DanhSachBanTraiCay();
            dgvTraiCay.DataSource = traicayBUS.DanhSachTraiCay();

            KhachHangBUS khBUS = new KhachHangBUS();
            cbbKhachHang.DataSource = khBUS.DanhSachKH();
            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "MaKhachHang";

            hdxuatBUS.TangHD();
        }

        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text == "" || txtSoLuongNhap.Text == "0")
            {
                MessageBox.Show("Chưa nhập số lượng cần mua hoặc số lượng không được bằng 0", "Thông báo");
                txtSoLuongNhap.Focus();
            }else if (int.Parse(txtSoLuongNhap.Text) > int.Parse(lblSoLuongTonKho.Text))
            {
                MessageBox.Show("Số lượng nhập không được lớn hơn số lượng tồn kho!");
            }
            else
            {
                string maTraiCay = dgvTraiCay.SelectedRows[0].Cells["colMaTC"].Value.ToString();
                int sl;
                sl = int.Parse(txtSoLuongNhap.Text);

                if (KiemTraTonTai(maTraiCay) == null)
                {
                    TraiCayDTO sp = new TraiCayDTO();
                    sp.MaTraiCay = dgvTraiCay.SelectedRows[0].Cells["colMaTC"].Value.ToString();
                    sp.TenTraiCay = dgvTraiCay.SelectedRows[0].Cells["colTenTC"].Value.ToString();
                    sp.SoLuong = sl;
                    sp.GiaTien = Convert.ToInt32(dgvTraiCay.SelectedRows[0].Cells["GiaTien"].Value.ToString());
                    sp.ThanhTien = sp.SoLuong * sp.GiaTien;
                    listGioHang.Add(sp);
                    listTam.Add(sp);
                }
                else
                {
                    KiemTraTonTai(maTraiCay).SoLuong += sl;
                    KiemTraTonTai(maTraiCay).ThanhTien = KiemTraTonTai(maTraiCay).SoLuong * KiemTraTonTai(maTraiCay).GiaTien;
                    LayTongTien();
                }
                dgvGioHang.DataSource = listGioHang;
                dgvGioHang.DataSource = listTam;

                lblTongTien.Text = string.Format("{0:0,00}",LayTongTien());
            }
        }

        public TraiCayDTO KiemTraTonTai(string MaTraiCay)
        {
            for (int i = 0; i < listGioHang.Count; i++)
            {
                if (listGioHang[i].MaTraiCay == MaTraiCay)
                    return listGioHang[i];
            }
            return null;
        }

        private int LayTongTien()
        {
            int TongTien = 0;
            int n = dgvGioHang.Rows.Count;
            
            for(int i = 0; i<n;i++)
            {
                string tt = dgvGioHang.Rows[i].Cells["colthanhtien"].Value.ToString();
                TongTien += int.Parse(tt);
            }
            return TongTien;
        }

        private void btnTimTraiCay_Click(object sender, EventArgs e)
        {
            lstTraiCay = traicayBUS.DanhSachTraiCay();
            dgvTraiCay.DataSource = lstTraiCay.FindAll(o => o.TenTraiCay.Contains(txtTimTen.Text));
        }

        private void dgvTraiCay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvTraiCay.Columns[e.ColumnIndex].Name == "colhinhanh")
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
            }
            catch (FormatException) { }
        }

        private void dgvTraiCay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = Convert.ToInt32(dgvTraiCay.CurrentRow.Index);
            lblTenTraiCay.Text = dgvTraiCay.Rows[vitri].Cells[1].Value.ToString();
            lblGiaTien.Text = dgvTraiCay.Rows[vitri].Cells[2].Value.ToString();
            lblSoLuongTonKho.Text = dgvTraiCay.Rows[vitri].Cells[3].Value.ToString();
            picTraiCay.ImageLocation = dgvTraiCay.Rows[vitri].Cells[4].Value.ToString();
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            int ChiSoDong = dgvGioHang.CurrentRow.Index;
            listGioHang.RemoveAt(ChiSoDong);
            listTam.RemoveAt(ChiSoDong);
            dgvGioHang.DataSource = listGioHang;
            dgvGioHang.DataSource = listTam;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            GetDuLieu();
            if (listGioHang.Count > 0)
            {
                try
                {
                    int tien = 0;
                    foreach (ChiTietHDXuatDTO ct in lstchitiet)
                    {
                        tien += ct.GiaBan * ct.SoLuong;
                    }

                    HoaDonXuatDTO hdb = new HoaDonXuatDTO();
                    QLSanPham sp = new QLSanPham();
                    frmMain fr = (frmMain)this.MdiParent;
                    hdb.MaHoaDonXuat = hdxuatBUS.TangHD();
                    hdb.MaNhanVien = fr.NVDangNhap.MaNhanVien;
                    hdb.MaKhachHang = cbbKhachHang.SelectedValue.ToString();
                    hdb.NgayXuat = System.DateTime.Now;
                    hdb.TongTien = tien;

                    int mhd = hdxuatBUS.themHoaDon(hdb);

                    ChiTietHDXuatBUS ctbus = new ChiTietHDXuatBUS();

                    int kq = 0;
                    foreach(ChiTietHDXuatDTO ct in lstchitiet)
                    {
                        ct.MaCTHoaDonXuat = hdb.MaHoaDonXuat;
                        if(ctbus.ThemCTHoaDonXuat(ct))
                        {
                            kq++;
                        }
                        if(traicayBUS.TimTC(ct.MaTraiCay))
                        {
                            TraiCayDTO hh = new TraiCayDTO();
                            hh.MaTraiCay = ct.MaTraiCay;
                            hh.SoLuong = ct.SoLuong;
                            traicayBUS.TruSL(hh);
                        }
                    }
                    if(kq == lstchitiet.Count)
                    {
                        MessageBox.Show("Thanh toán thành công!");
                    }
                    else 
                    {
                        MessageBox.Show("Thanh toán thất bại!");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Thanh toán thất bại!");
                }
                dgvTraiCay.DataSource = traicayBUS.DanhSachBanTraiCay();
                int ChiSoDong = dgvGioHang.CurrentRow.Index;
                listGioHang.RemoveAt(ChiSoDong);
                listTam.RemoveAt(ChiSoDong);
                dgvGioHang.DataSource = listGioHang;
                dgvGioHang.DataSource = listTam;
            }
        }

        private void GetDuLieu()
        {
            lstchitiet = new List<ChiTietHDXuatDTO>();
            for (int i = 0; i < dgvGioHang.RowCount; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGioHang.Rows[i];
                ChiTietHDXuatDTO ct = new ChiTietHDXuatDTO();
                ct.MaTraiCay = row.Cells["colmatraicay"].Value.ToString();
                ct.MaCTHoaDonXuat = hdxuatBUS.TangHD();
                ct.SoLuong = Convert.ToInt32(row.Cells["colsoluong"].Value.ToString());
                ct.ThanhTien = Convert.ToInt32(row.Cells["colthanhtien"].Value.ToString());
                ct.GiaBan = Convert.ToInt32(row.Cells["colgiatien"].Value.ToString());
                lstchitiet.Add(ct);
            }
        }

       
    }
}
