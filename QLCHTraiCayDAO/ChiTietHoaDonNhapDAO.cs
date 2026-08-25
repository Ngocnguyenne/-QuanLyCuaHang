using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayDAO
{
    public class ChiTietHoaDonNhapDAO
    {
        public List<ChiTietHDNhapDTO> DanhSachChiTietHDNhap(string mahdn)
        {
            List<ChiTietHDNhapDTO> lstChiTiet = new List<ChiTietHDNhapDTO>();
            string CauLenh = "SELECT MaCTHoaDonNhap, tc.TenTraiCay, GiaNhap, cthdn.SoLuong, cthdn.TrangThai FROM ChiTietHoaDonNhap cthdn INNER JOIN TraiCay tc ON cthdn.MaTraiCay = tc.MaTraiCay WHERE MaCTHoaDonNhap='"+mahdn+"'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while(dr.Read())
            {
                ChiTietHDNhapDTO chitiet = new ChiTietHDNhapDTO();
                chitiet.MaCTHoaDonNhap = dr[0].ToString();
                chitiet.MaTraiCay = dr[1].ToString();
                chitiet.GiaNhap = int.Parse(dr[2].ToString());
                chitiet.SoLuong = int.Parse(dr[3].ToString());
                chitiet.TrangThai = int.Parse(dr[4].ToString());
                lstChiTiet.Add(chitiet);
            }
            dr.Close();
            conn.Close();
            return lstChiTiet;
        }

        public bool ThemCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            string CauLenh = "INSERT INTO ChiTietHoaDonNhap (MaCTHoaDonNhap, MaTraiCay, GiaNhap, SoLuong, ThanhTien, TrangThai) VALUES ('{0}','{1}','{2}','{3}','{4}','1')";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, CTHoaDonNhapDTO.MaCTHoaDonNhap, CTHoaDonNhapDTO.MaTraiCay, CTHoaDonNhapDTO.GiaNhap,CTHoaDonNhapDTO.SoLuong, CTHoaDonNhapDTO.ThanhTien, CTHoaDonNhapDTO.TrangThai), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            string CauLenh = "UPDATE ChiTietHoaDonNhap SET GiaNhap = '{0}', SoLuong = '{1}', TrangThai = '{2}' WHERE MaCTHoaDonNhap = '" + CTHoaDonNhapDTO.MaCTHoaDonNhap + "' AND MaTraiCay = '" + CTHoaDonNhapDTO.MaTraiCay + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, CTHoaDonNhapDTO.GiaNhap, CTHoaDonNhapDTO.SoLuong, CTHoaDonNhapDTO.TrangThai, CTHoaDonNhapDTO.MaCTHoaDonNhap, CTHoaDonNhapDTO.MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            string CauLenh = "UPDATE ChiTietHoaDonNhap SET TrangThai = 0 WHERE MaCTHoaDonNhap = '" + CTHoaDonNhapDTO.MaCTHoaDonNhap + "' AND MaTraiCay = '" + CTHoaDonNhapDTO.MaTraiCay + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, CTHoaDonNhapDTO.TrangThai, CTHoaDonNhapDTO.MaCTHoaDonNhap, CTHoaDonNhapDTO.MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
