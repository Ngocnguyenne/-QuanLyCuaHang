using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayDAO
{
    public class KhoDAO
    {
        public List<KhoTraiCayDTO> DanhSachKho()
        {
            List<KhoTraiCayDTO> lstKho = new List<KhoTraiCayDTO>();
            string CauLenh = "SELECT NhanVien.TenNhanVien,TraiCay.TenTraiCay,TraiCay.GiaTien,LoaiTraiCay.MaLoaiTraiCay,TraiCay.SoLuong,TraiCay.TrangThai FROM TraiCay,NhanVien,LoaiTraiCay WHERE TraiCay.TrangThai = 1";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while(dr.Read())
            {
                KhoTraiCayDTO Kho = new KhoTraiCayDTO();
                Kho.TenNhanVien = dr[0].ToString();
                Kho.TenTraiCay = dr[1].ToString();
                Kho.GiaTien = double.Parse(dr[2].ToString());
                Kho.MaLoaiTraiCay = dr[3].ToString();
                Kho.SoLuong = int.Parse(dr[4].ToString());
                Kho.TrangThai = int.Parse(dr[5].ToString());
                lstKho.Add(Kho);
            }
            dr.Close();
            conn.Close();
            return lstKho;
        }
    }
}
