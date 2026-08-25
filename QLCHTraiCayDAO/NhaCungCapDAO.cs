using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class NhaCungCapDAO
    {
        public static List<NhaCungCapDTO> DanhSachNhaCungCap()
        {
            List<NhaCungCapDTO> lstNCC = new List<NhaCungCapDTO>();
            string CauLenh = "SELECT * FROM NhaCungCap";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while (dr.Read())
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.MaNhaCungCap = dr[0].ToString();
                ncc.TenNhaCungCap = dr[1].ToString();
                ncc.DiaChi = dr[2].ToString();
                ncc.SDT = dr[3].ToString();
                ncc.Email = dr[4].ToString();
                ncc.TrangThai = int.Parse(dr[5].ToString());
                lstNCC.Add(ncc);
            }
            dr.Close();
            conn.Close();
            return lstNCC;
        }

        public bool ThemNhaCungCap(NhaCungCapDTO nccDTO)
        {
            string CauLenh = "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, SDT, Email, TrangThai) VALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', {5})";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh,nccDTO.MaNhaCungCap, nccDTO.TenNhaCungCap, nccDTO.DiaChi,nccDTO.SDT, nccDTO.Email, nccDTO.TrangThai), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNhaCungCap(NhaCungCapDTO nccDTO)
        {
            string CauLenh = "UPDATE NhaCungCap SET TenNhaCungCap = N'" + nccDTO.TenNhaCungCap + "', DiaChi = N'" + nccDTO.DiaChi + "', SDT = N'" + nccDTO.SDT + "', Email = N'" + nccDTO.Email + "', TrangThai = N'" + nccDTO.TrangThai + "' WHERE MaNhaCungCap = '" + nccDTO.MaNhaCungCap + "'";
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
        public bool XoaNhaCungCap(string MaNhaCungCap)
        {
            string CauLenh = "UPDATE NhaCungCap set TrangThai = 0 WHERE MaNhaCungCap = '" + MaNhaCungCap + "' ";
            try
            {
                SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
                int kq = DataProvider_QLCHTraiCay.ThucThiCauLenh(String.Format(CauLenh, MaNhaCungCap), conn);
                return kq != 0;
            }
            catch
            {
                return false;
            }
        }

        public string TangNCC()
        {
            string CauLenh = "SELECT MAX(MaNhaCungCap) FROM NhaCungCap";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    int ncc = Convert.ToInt32(dr.GetString(0).Remove(0, 3));
                    ncc++;
                    dr.Close();
                    conn.Close();
                    return "NCC" + ncc.ToString("d4");
                }
            }
            return "NCC0001";
        }
    }
}
