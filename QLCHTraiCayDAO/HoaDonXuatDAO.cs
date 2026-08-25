using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class HoaDonXuatDAO
    {
        HoaDonXuatDTO HoaDonXuatDTO = new HoaDonXuatDTO();

        public List<HoaDonXuatDTO> DanhSachHoaDonXuat()
        {
            List<HoaDonXuatDTO> lstHoaDonXuat = new List<HoaDonXuatDTO>();
            string CauLenh = "SELECT * FROM HoaDonXuat";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                HoaDonXuatDTO hoadon = new HoaDonXuatDTO();
                hoadon.MaHoaDonXuat = dr[0].ToString();
                hoadon.MaNhanVien = dr[1].ToString();
                hoadon.MaKhachHang = dr[2].ToString();
                hoadon.NgayXuat = Convert.ToDateTime(dr[3].ToString());
                hoadon.TongTien = int.Parse(dr[4].ToString());
                hoadon.TrangThai = int.Parse(dr[5].ToString());
                lstHoaDonXuat.Add(hoadon);
            }
            dr.Close();
            conn.Close();
            return lstHoaDonXuat;
        }

        public bool SuaHoaDonXuat(HoaDonXuatDTO HoaDonXuatDTO)
        {
            string CauLenh = "UPDATE HoaDonXuat SET  NgayXuat = '{0}', TongTien = '{1}', TrangThai = '{2}' WHERE MaHoaDonNhap = '" + HoaDonXuatDTO.MaHoaDonXuat + "' AND MaNhanVien = '" + HoaDonXuatDTO.MaNhanVien + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, HoaDonXuatDTO.NgayXuat, HoaDonXuatDTO.TongTien, HoaDonXuatDTO.TrangThai, HoaDonXuatDTO.MaHoaDonXuat, HoaDonXuatDTO.MaNhanVien), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHoaDonXuat(HoaDonXuatDTO HoaDonXuatDTO)
        {
            string CauLenh = "UPDATE HoaDonXuat SET TrangThai = 0 WHERE MaHoaDonXuat = '" + HoaDonXuatDTO.MaHoaDonXuat + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, HoaDonXuatDTO.TrangThai, HoaDonXuatDTO.MaHoaDonXuat), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string TangHD()
        {
            string CauLenh = "SELECT MAX(MaHoaDonXuat) FROM HoaDonXuat";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    int hd = Convert.ToInt32(dr.GetString(0).Remove(0,3));
                    hd++;
                    dr.Close();
                    conn.Close();
                    return "HDX" + hd.ToString("d4");
                }
            }
            return "HDX0001";
        }

        public int LayTongTien(string MaHD)
        {
            string CauLenh = "SELECT SUM(SoLuong * GiaBan) FROM ChiTietHoaDonXuat WHERE MaCTHoaDonXuat='{1}'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(string.Format(CauLenh, MaHD), conn);
            return kq;
        }

        public int ThemHoaDon(HoaDonXuatDTO hoadonxuatDTO)
        {
            string CauLenh = "INSERT INTO HoaDonXuat(MaHoaDonXuat, MaNhanVien, MaKhachHang, NgayXuat, TongTien, TrangThai) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '1')";

            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(string.Format(CauLenh, hoadonxuatDTO.MaHoaDonXuat, hoadonxuatDTO.MaNhanVien, hoadonxuatDTO.MaKhachHang, hoadonxuatDTO.NgayXuat, hoadonxuatDTO.TongTien), conn);
            return kq;
        }

        public int ThongKeDoanhThuCuaHang(string thang, string nam)
        {
            int kq = 0;
            string tongtien = "select SUM(TongTien) from HoaDonXuat where TrangThai=1 and month(NgayXuat)={0} and year(NgayXuat)={1}";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader sdr = DataProvider_QLCHTraiCay.TruyVanDuLieu(string.Format(tongtien,thang,nam), conn);
            sdr.Read();
            try
            {
                if (!sdr.IsDBNull(0))
                    kq = int.Parse(sdr[0].ToString());
            }
            catch(Exception ex)
            {
                kq = 0;
            }
            sdr.Close();
            conn.Close();
            return kq;
        }

        public int ThongKeDoanhThuNhanVien(string MaNV ,string Thang, String Nam)
        {
            int kq = 0;
            string tongtien = "select SUM(TongTien) from HoaDonXuat where TrangThai = 1 and month(NgayXuat) ='{0}' and year(NgayXuat)='{1}' and MaNhanVien='{2}'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlCommand com = new SqlCommand(string.Format(tongtien,Thang,Nam,MaNV),conn);
            kq=(int)com.ExecuteScalar();
            
            return kq;
        }

        public List<HoaDonXuatDTO> DSHDXuatTheoma(string manv)
        {
            List<HoaDonXuatDTO> lstHDX = new List<HoaDonXuatDTO>();
            string caulenh = "SELECT * FROM HoaDonXuat Where TrangThai= 1 and MaNhanVien='" + manv + "'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader reader = DataProvider_QLCHTraiCay.TruyVanDuLieu(caulenh, conn);
            while (reader.Read())
            {
                HoaDonXuatDTO hdxDTO = new HoaDonXuatDTO();
                hdxDTO.MaHoaDonXuat = reader[0].ToString();
                hdxDTO.MaNhanVien = reader[1].ToString();
                hdxDTO.MaKhachHang = reader[2].ToString();
                hdxDTO.NgayXuat = DateTime.Parse(reader[3].ToString());
                hdxDTO.TongTien = int.Parse(reader[4].ToString());
                hdxDTO.TrangThai = int.Parse(reader[5].ToString());
                lstHDX.Add(hdxDTO);
            }
            reader.Close();
            conn.Close();
            return lstHDX;
        }
        public int LayTongTienTheoNV(string manv)
        {
            string query = "Select Sum(TongTien) from HoaDonXuat where TrangThai=1 and MaNhanVien='" + manv + "'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlCommand com = new SqlCommand(query, conn);
            int kq =(int) com.ExecuteScalar();
            return kq;
        }

        public int TongHoaDon(string MaHDX)
        {
            string query = "Select Sum(TongTien) from HoaDonXuat where TrangThai=1 and MaHoaDonXuat='" + MaHDX + "'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlCommand com = new SqlCommand(query, conn);
            int kq = (int)com.ExecuteScalar();
            return kq;
        }
    }
}
