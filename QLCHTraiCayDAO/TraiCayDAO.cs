using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class TraiCayDAO
    {
        public List<TraiCayDTO> DanhSachTraiCay()
        {
            List<TraiCayDTO> lstTraiCay = new List<TraiCayDTO>();
            string CauLenh = "SELECT MaTraiCay, TenTraiCay, Mau, TenLoaiTraiCay, XuatXu, GiaTien, HinhAnh, SoLuong, TenNhaCungCap, tc.TrangThai FROM TraiCay tc INNER JOIN LoaiTraiCay ltc ON tc.MaLoaiTraiCay = ltc.MaLoaiTraiCay INNER JOIN NhaCungCap ncc ON tc.MaNhaCungCap = ncc.MaNhaCungCap";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                TraiCayDTO TraiCayDTO = new TraiCayDTO();
                TraiCayDTO.MaTraiCay = dr[0].ToString();
                TraiCayDTO.TenTraiCay = dr[1].ToString();
                TraiCayDTO.Mau = dr[2].ToString();
                TraiCayDTO.MaLoaiTraiCay = dr[3].ToString();
                TraiCayDTO.XuatXu = dr[4].ToString();
                TraiCayDTO.GiaTien = int.Parse(dr[5].ToString());
                TraiCayDTO.HinhAnh = dr[6].ToString();
                TraiCayDTO.SoLuong = int.Parse(dr[7].ToString());
                TraiCayDTO.MaNhaCungCap = dr[8].ToString();
                
                TraiCayDTO.TrangThai = int.Parse(dr[9].ToString());
                lstTraiCay.Add(TraiCayDTO);
            }
            dr.Close();
            conn.Close();
            return lstTraiCay;
        }

        public List<TraiCayDTO> LayDSHangHoaSapHet()
        {
            List<TraiCayDTO> lstTraiCay = new List<TraiCayDTO>();
            string strTruyVan = "Select * From TraiCay Where TrangThai = 1 and SoLuong<=20";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader sdr = DataProvider_QLCHTraiCay.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                TraiCayDTO traicay = new TraiCayDTO();
                traicay.MaTraiCay = sdr[0].ToString();
                traicay.TenTraiCay = sdr[1].ToString().Trim();
                traicay.Mau = sdr[2].ToString().Trim();
                traicay.MaLoaiTraiCay = sdr[3].ToString().Trim();
                traicay.XuatXu = sdr[4].ToString();
                traicay.GiaTien = int.Parse(sdr[5].ToString());
                traicay.SoLuong = int.Parse(sdr[7].ToString().Trim());
                traicay.MaNhaCungCap = sdr[8].ToString();
                traicay.TrangThai = int.Parse(sdr[9].ToString());
                lstTraiCay.Add(traicay);
            }
            sdr.Close();
            conn.Close();
            return lstTraiCay;
        }

        public bool ThemTraiCay(TraiCayDTO traicayDTO)
        {
            string CauLenh = "INSERT INTO TraiCay (MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,SoLuong,MaNhaCungCap,TrangThai) values ('{0}',N'{1}',N'{2}','{3}',N'{4}',{5},N'{6}','{7}',{8})";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, traicayDTO.MaTraiCay, traicayDTO.TenTraiCay, traicayDTO.Mau, traicayDTO.MaLoaiTraiCay, traicayDTO.XuatXu, traicayDTO.GiaTien,traicayDTO.SoLuong, traicayDTO.MaNhaCungCap, traicayDTO.TrangThai),conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTraiCay(TraiCayDTO traicayDTO)
        {
            string CauLenh = "UPDATE TraiCay SET  TenTraiCay = N'{0}', Mau = N'{1}', MaLoaiTraiCay = '{2}', XuatXu = N'{3}', GiaTien = {4}, HinhAnh = N'{5}', SoLuong = {6}, MaNhaCungCap = '{7}', TrangThai = {8} WHERE MaTraiCay = '"+ traicayDTO.MaTraiCay + "' " ;
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, traicayDTO.TenTraiCay, traicayDTO.Mau, traicayDTO.MaLoaiTraiCay, traicayDTO.XuatXu, traicayDTO.GiaTien, traicayDTO.HinhAnh, traicayDTO.SoLuong, traicayDTO.MaNhaCungCap, traicayDTO.TrangThai,traicayDTO.MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaTraiCay(string MaTraiCay)
        {
            string CauLenh = "UPDATE TraiCay set TrangThai = 0 WHERE MaTraiCay = '" + MaTraiCay + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, MaTraiCay), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string LayMaTCMAX()
        {
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            string query = "select max(MaTraiCay) from TraiCay";
            SqlCommand com = new SqlCommand(query,conn);
            string kq = (string)com.ExecuteScalar();
            return kq;
        }

        public List<TraiCayDTO> DanhSachBanTraiCay()
        {
            List<TraiCayDTO> lstTraiCay = new List<TraiCayDTO>();
            string CauLenh = "SELECT * FROM TraiCay WHERE TrangThai = 1";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                TraiCayDTO TraiCayDTO = new TraiCayDTO();
                TraiCayDTO.MaTraiCay = dr[0].ToString();
                TraiCayDTO.TenTraiCay = dr[1].ToString();
                TraiCayDTO.GiaTien = int.Parse(dr[5].ToString());
                TraiCayDTO.HinhAnh = dr[6].ToString();
                TraiCayDTO.SoLuong = int.Parse(dr[7].ToString());
                lstTraiCay.Add(TraiCayDTO);
            }
            dr.Close();
            conn.Close();
            return lstTraiCay;
        }

        public string TangTraiCay()
        {
            string CauLenh = "SELECT MAX(MaTraiCay) FROM TraiCay";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    int tc = Convert.ToInt32(dr.GetString(0).Remove(0, 2));
                    tc++;
                    dr.Close();
                    conn.Close();
                    return "TC" + tc.ToString("d4");
                }
            }
            return "TC0001";
        }

        public int ThemChiTietHDBan()
        {
            string CauLenh = "INSERT INTO ChiTietHoaDonXuat(MaCTHoaDonXuat, MaTraiCay, GiaBan, SoLuong, TrangThai) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(CauLenh, conn);
            return kq;
        }

        public int CapNhatSoLuong(int sl,string mahd,string matc)
        {
            string CauLenh = "UPDATE TraiCay SET SoLuong += '{0}' WHERE MaCTHoaDonXuat = '{1}' AND MaTraiCay = '{2}'";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(string.Format(CauLenh,sl,mahd,matc),conn);
            return kq;
        }

        public bool TruSL(TraiCayDTO tc1)
        {
            string CauLenh = "UPDATE TraiCay SET SoLuong -=" + tc1.SoLuong + " WHERE MaTraiCay = '" + tc1.MaTraiCay + "'";
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

        public bool CongSL(TraiCayDTO tc1)
        {
            string CauLenh = "UPDATE TraiCay SET SoLuong +=" + tc1.SoLuong + " WHERE MaTraiCay = '" + tc1.MaTraiCay + "'";
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

        public bool TimMaTC(string MaTraiCay)
        {
            string CauLenh = "SELECT * FROM TraiCay WHERE MaTraiCay='" + MaTraiCay + "'";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
                if(dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
