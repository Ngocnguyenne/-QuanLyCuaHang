using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class KhachHangDAO
    {
        public List<KhachHangDTO> DanhSachKhachHang()
        {
            List<KhachHangDTO> lstKhachHang = new List<KhachHangDTO>();
            string CauLenh = "SELECT * FROM KhachHang";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                KhachHangDTO KhachHangDTO = new KhachHangDTO();
                KhachHangDTO.MaKhachHang = dr[0].ToString();
                KhachHangDTO.TenKhachHang = dr[1].ToString();
                KhachHangDTO.DiaChi = dr[2].ToString();
                KhachHangDTO.SDT = dr[3].ToString(); ;
                KhachHangDTO.TrangThai = int.Parse(dr[4].ToString());
                lstKhachHang.Add(KhachHangDTO);
            }
            dr.Close();
            conn.Close();
            return lstKhachHang;
        }

        public bool ThemKhachHang(KhachHangDTO khachhangDTO)
        {
            string CauLenh = "insert into KhachHang (MaKhachHang,TenKhachHang,DiaChi,SDT,TrangThai) values ('{0}',N'{1}',N'{2}','{3}','{4}')";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, khachhangDTO.MaKhachHang, khachhangDTO.TenKhachHang, khachhangDTO.DiaChi, khachhangDTO.SDT, khachhangDTO.TrangThai), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaKhachHang (KhachHangDTO khachhangDTO)
        {
            string CauLenh = "UPDATE KhachHang SET TenKhachHang = N'" + khachhangDTO.TenKhachHang + "', DiaChi = N'" + khachhangDTO.DiaChi + "', SDT = N'" + khachhangDTO.SDT + "', TrangThai = N'" + khachhangDTO.TrangThai + "' WHERE MaKhachHang = N'" + khachhangDTO.MaKhachHang + "'";
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

        public bool XoaKhachHang(string MaKhachHang)
        {
            string CauLenh = "UPDATE KhachHang set TrangThai = 0 WHERE MaKhachHang = '" + MaKhachHang + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, MaKhachHang), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string TangKhachHang()
        {
            string CauLenh = "SELECT MAX(MaKhachHang) FROM KhachHang";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    int kh = Convert.ToInt32(dr.GetString(0).Remove(0, 2));
                    kh++;
                    dr.Close();
                    conn.Close();
                    return "KH" + kh.ToString("d4");
                }
            }
            return "KH0001";
        }
    }
}
