using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class ChiTietHDXuatDAO
    {
        public List<ChiTietHDXuatDTO> DanhSachChiTietHDXuat()
        {
            List<ChiTietHDXuatDTO> lstChiTiet = new List<ChiTietHDXuatDTO>();
            string CauLenh = "SELECT * FROM ChiTietHoaDonXuat";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                ChiTietHDXuatDTO chitiet = new ChiTietHDXuatDTO();
                chitiet.MaCTHoaDonXuat = dr[0].ToString();
                chitiet.MaTraiCay = dr[1].ToString();
                chitiet.GiaBan = int.Parse(dr[2].ToString());
                chitiet.SoLuong = int.Parse(dr[3].ToString());
                chitiet.ThanhTien = int.Parse(dr[4].ToString());
                chitiet.TrangThai = int.Parse(dr[5].ToString());
                lstChiTiet.Add(chitiet);
            }
            dr.Close();
            conn.Close();
            return lstChiTiet;
        }

        public bool SuaCT(ChiTietHDXuatDTO ctDTO)
        {
            string CauLenh = "UPDATE ChiTietHoaDonXuat SET  GiaBan = '{0}', SoLuong = '{1}', TrangThai = '{2}' WHERE MaHoaDonNhap = '" + ctDTO.MaCTHoaDonXuat + "' AND MaNhanVien = '" + ctDTO.MaTraiCay + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, ctDTO.GiaBan, ctDTO.SoLuong, ctDTO.TrangThai, ctDTO.MaCTHoaDonXuat, ctDTO.MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaCT(ChiTietHDXuatDTO ctDTO)
        {
            string CauLenh = "UPDATE ChiTietHoaDonXuat SET TrangThai = 0 WHERE MaCTHoaDonXuat = '" + ctDTO.MaCTHoaDonXuat + "' AND MaTraiCay = '" + ctDTO.MaTraiCay + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, ctDTO.TrangThai, ctDTO.MaCTHoaDonXuat, ctDTO.MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemCTHoaDonXuat(ChiTietHDXuatDTO CTHoaDonXuatDTO)
        {
            string CauLenh = "INSERT INTO ChiTietHoaDonXuat (MaCTHoaDonXuat, MaTraiCay, GiaBan, SoLuong, ThanhTien, TrangThai) VALUES ('{0}','{1}','{2}','{3}','{4}','1')";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, CTHoaDonXuatDTO.MaCTHoaDonXuat, CTHoaDonXuatDTO.MaTraiCay, CTHoaDonXuatDTO.GiaBan, CTHoaDonXuatDTO.SoLuong, CTHoaDonXuatDTO.ThanhTien, CTHoaDonXuatDTO.TrangThai), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
