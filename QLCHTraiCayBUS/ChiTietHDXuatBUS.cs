using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDAO;
using QLCHTraiCayDTO;

namespace QLCHTraiCayBUS
{
    public class ChiTietHDXuatBUS
    {
        ChiTietHDXuatDAO ChiTietHDXuatDAO = new ChiTietHDXuatDAO();

        public List<ChiTietHDXuatDTO> DanhSachChiTietHDXuat()
        {
            return ChiTietHDXuatDAO.DanhSachChiTietHDXuat();
        }

        public bool ThemCTHoaDonXuat(ChiTietHDXuatDTO CTHoaDonXuatDTO)
        {
            return ChiTietHDXuatDAO.ThemCTHoaDonXuat(CTHoaDonXuatDTO);
        }

        public bool SuaCTHoaDonXuat(ChiTietHDXuatDTO CTHoaDonXuatDTO)
        {
            return ChiTietHDXuatDAO.SuaCT(CTHoaDonXuatDTO);
        }

        public bool XoaCTHoaDonXuat(ChiTietHDXuatDTO CTHoaDonXuatDTO)
        {
            return ChiTietHDXuatDAO.XoaCT(CTHoaDonXuatDTO);
        }
    }
}
