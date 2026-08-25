using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayDAO
{
    public class HoaDonNhapDAO
    {
        public List<HoaDonNhapDTO> DanhSachHoaDonNhap()
        {
            List<HoaDonNhapDTO> lstHoaDonhap = new List<HoaDonNhapDTO>();
            string CauLenh = "SELECT MaHoaDonNhap, nv.TenNhanVien, NgayNhap, TongTien, hdn.TrangThai FROM HoaDonNhap hdn INNER JOIN NhanVien nv ON hdn.MaNhanVien = nv.MaNhanVien";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while(dr.Read())
            {
                HoaDonNhapDTO hoadon = new HoaDonNhapDTO();
                hoadon.MaHoaDonNhap = dr[0].ToString();
                hoadon.MaNhanVien = dr[1].ToString();
                hoadon.NgayNhap = Convert.ToDateTime(dr[2].ToString());
                hoadon.TongTien = int.Parse(dr[3].ToString());
                hoadon.TrangThai = int.Parse(dr[4].ToString());
                lstHoaDonhap.Add(hoadon);
            }
            dr.Close();
            conn.Close();
            return lstHoaDonhap;
        }

        public int ThemHoaDonNhap(HoaDonNhapDTO HoaDonNhapDTO)
        {
            string CauLenh = "INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, NgayNhap,TongTien,TrangThai) values ('{0}','{1}','{2}','{3}','1')";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, HoaDonNhapDTO.MaHoaDonNhap, HoaDonNhapDTO.MaNhanVien, HoaDonNhapDTO.NgayNhap, HoaDonNhapDTO.TongTien, HoaDonNhapDTO.TrangThai), conn);
            return kq;

        }

        public bool SuaHoaDonNhap(HoaDonNhapDTO HoaDonNhapDTO)
        {
            string CauLenh = "UPDATE HoaDonNhap SET  NgayNhap = '{0}', TongTien = '{1}', TrangThai = '{2}' WHERE MaHoaDonNhap = '" + HoaDonNhapDTO.MaHoaDonNhap + "' AND MaNhanVien = '" + HoaDonNhapDTO.MaNhanVien + "'";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, HoaDonNhapDTO.NgayNhap, HoaDonNhapDTO.TongTien, HoaDonNhapDTO.TrangThai, HoaDonNhapDTO.MaHoaDonNhap, HoaDonNhapDTO.MaNhanVien), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHoaDonNhap(string HoaDonNhapDTO)
        {
            string CauLenh = "UPDATE HoaDonNhap SET TrangThai = 0 WHERE MaHoaDonNhap = '" + HoaDonNhapDTO + "'";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(CauLenh, conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string TangHD()
        {
            string CauLenh = "SELECT MAX(MaHoaDonNhap) FROM HoaDonNhap";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if(dr.Read())
            {
                if(!dr.IsDBNull(0))
                {
                    int hd = Convert.ToInt32(dr.GetString(0).Remove(0, 3));
                    hd++;
                    dr.Close();
                    conn.Close();
                    return "HDN" + hd.ToString("d4");
                }
            }
            return "HDN0001";
        }
    }
}
