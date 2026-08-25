using QLCHTraiCayDAO;
using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayBUS
{
    public class HoaDonNhapBUS
    {
        HoaDonNhapDAO HoaDonNhapDAO = new HoaDonNhapDAO();

        public List<HoaDonNhapDTO> DanhSachHoaDonNhap()
        {
            return HoaDonNhapDAO.DanhSachHoaDonNhap();
        }

        public int ThemHoaDonNhap(HoaDonNhapDTO HoaDonNhapDTO)
        {
            return HoaDonNhapDAO.ThemHoaDonNhap(HoaDonNhapDTO);
        }

        public bool SuaHoaDonNhap(HoaDonNhapDTO HoaDonNhapDTO)
        {
            return HoaDonNhapDAO.SuaHoaDonNhap(HoaDonNhapDTO);
        }

        public bool XoaHoaDonNhap(string HoaDonNhapDTO)
        {
            return HoaDonNhapDAO.XoaHoaDonNhap(HoaDonNhapDTO);
        }

        public string TangHD()
        {
            return HoaDonNhapDAO.TangHD();
        }
    }
}
