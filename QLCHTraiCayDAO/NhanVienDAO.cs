using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class NhanVienDAO
    {
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
            string CauLenh = "SELECT * FROM NhanVien";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                NhanVienDTO NhanVienDTO = new NhanVienDTO();

                NhanVienDTO.MaNhanVien = dr[0].ToString();
                NhanVienDTO.HoNhanVien = dr[1].ToString();
                NhanVienDTO.TenNhanVien = dr[2].ToString();
                NhanVienDTO.MaLoaiNhanVien = dr[3].ToString();
                NhanVienDTO.MatKhau = dr[4].ToString();
                NhanVienDTO.GioiTinh = dr[5].ToString();
                NhanVienDTO.NgaySinh = DateTime.Parse(dr[6].ToString());
                NhanVienDTO.DiaChi = dr[7].ToString();
                NhanVienDTO.SDT = dr[8].ToString();
                NhanVienDTO.Luong = double.Parse(dr[9].ToString());
                NhanVienDTO.HinhAnh = dr[10].ToString();
                NhanVienDTO.TrangThai = int.Parse(dr[11].ToString());
                lstNhanVien.Add(NhanVienDTO);
            }
            dr.Close();
            conn.Close();
            return lstNhanVien;
        }

        public List<LoaiNhanVienDTO> DanhSachLoaiNhanVien()
        {
            List<LoaiNhanVienDTO> lstloai = new List<LoaiNhanVienDTO>();
            string query = "Select * from LoaiNhanVien";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader rdr = DataProvider_QLCHTraiCay.TruyVanDuLieu(query, conn);
            while (rdr.Read())
            {
                LoaiNhanVienDTO loainv = new LoaiNhanVienDTO();
                loainv.MaLoaiNhanVien = rdr[0].ToString();
                loainv.LoaiNhanVien = rdr[1].ToString();
                lstloai.Add(loainv);
            }
            rdr.Close();
            conn.Close();
            return lstloai;
        }

        public bool ThemNhanVien(NhanVienDTO nhanvienDTO)
        {
            string CauLenh = "INSERT INTO NhanVien (MaNhanVien,HoNhanVien,TenNhanVien,MaLoaiNhanVien,MatKhau,GioiTinh,NgaySinh,DiaChi,SDT,Luong,HinhAnh,TrangThai) values ('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}','{8}',{9},N'{10}','{11}')";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, nhanvienDTO.MaNhanVien, nhanvienDTO.HoNhanVien, nhanvienDTO.TenNhanVien, nhanvienDTO.MaLoaiNhanVien, nhanvienDTO.MatKhau, nhanvienDTO.GioiTinh, nhanvienDTO.NgaySinh, nhanvienDTO.DiaChi, nhanvienDTO.SDT, nhanvienDTO.Luong, nhanvienDTO.HinhAnh, nhanvienDTO.TrangThai), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        
        }

        public bool SuaNhanVien(NhanVienDTO nhanvienDTO)
        {
            string CauLenh = "UPDATE NhanVien SET HoNhanVien = N'" + nhanvienDTO.HoNhanVien + "', TenNhanVien = N'" + nhanvienDTO.TenNhanVien + "', MaLoaiNhanVien = '" + nhanvienDTO.MaLoaiNhanVien + "', MatKhau = '" + nhanvienDTO.MatKhau + "', GioiTinh = N'" + nhanvienDTO.GioiTinh + "', NgaySinh = '" + nhanvienDTO.NgaySinh + "', DiaChi = N'" + nhanvienDTO.DiaChi + "', SDT = '" + nhanvienDTO.SDT + "', Luong = '" + nhanvienDTO.Luong + "', HinhAnh = N'" + nhanvienDTO.HinhAnh + "', TrangThai = '" + nhanvienDTO.TrangThai + "' WHERE MaNhanVien = '" + nhanvienDTO.MaNhanVien + "'";
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

        public bool XoaNhanVien(string MaNhanVien)
        {
            string CauLenh = "UPDATE NhanVien set TrangThai = 0 WHERE MaNhanVien = '" + MaNhanVien + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, MaNhanVien), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string TangNhanVien()
        {
            string CauLenh = "SELECT MAX(MaNhanVien) FROM NhanVien";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    int nv = Convert.ToInt32(dr.GetString(0).Remove(0, 2));
                    nv++;
                    dr.Close();
                    conn.Close();
                    return "NV" + nv.ToString("d4");
                }
            }
            return "NV0001";
        }
    }
}
