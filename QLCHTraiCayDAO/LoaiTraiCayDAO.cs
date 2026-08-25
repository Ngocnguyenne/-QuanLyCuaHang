using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using QLCHTraiCayDAO;
using System.Data.SqlClient;

namespace QLCHTraiCayDAO
{
    public class LoaiTraiCayDAO
    {
        public static  List<LoaiTraiCayDTO> DanhSachLoaiTraiCay()
        {
            List<LoaiTraiCayDTO> lstLoaiTraiCay = new List<LoaiTraiCayDTO>();
            string CauLenh = "SELECT * FROM LoaiTraiCay";
            SqlConnection conn = DataProvider_QLCHTraiCay.TaoKetNoi();
            SqlDataReader dr = DataProvider_QLCHTraiCay.TruyVanDuLieu(CauLenh, conn);
            while(dr.Read())
            {
                LoaiTraiCayDTO loai = new LoaiTraiCayDTO();
                loai.MaLoaiTraiCay=dr[0].ToString();
                loai.TenLoaiTraiCay=dr[1].ToString();
                loai.TrangThai=int.Parse(dr[2].ToString());

                lstLoaiTraiCay.Add(loai);

            }
            return lstLoaiTraiCay;

        }
    }
}
