using QLCHTraiCayDAO;
using QLCHTraiCayDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayBUS
{
    public class ChiTietHDNhapBUS
    {
        ChiTietHoaDonNhapDAO ChiTietHDNhapDAO = new ChiTietHoaDonNhapDAO();

        public List<ChiTietHDNhapDTO> DanhSachChiTietHoaDonNhap(string mahdn)
        {
            return ChiTietHDNhapDAO.DanhSachChiTietHDNhap(mahdn);
        }

        public bool ThemCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            return ChiTietHDNhapDAO.ThemCTHoaDonNhap(CTHoaDonNhapDTO);
        }

        public bool SuaCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            return ChiTietHDNhapDAO.SuaCTHoaDonNhap(CTHoaDonNhapDTO);
        }

        public bool XoaCTHoaDonNhap(ChiTietHDNhapDTO CTHoaDonNhapDTO)
        {
            return ChiTietHDNhapDAO.XoaCTHoaDonNhap(CTHoaDonNhapDTO);
        }
    }
}
