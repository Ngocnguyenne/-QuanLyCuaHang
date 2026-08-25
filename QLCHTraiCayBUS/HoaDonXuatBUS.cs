using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using QLCHTraiCayDAO;

namespace QLCHTraiCayBUS
{
    public class HoaDonXuatBUS
    {
        HoaDonXuatDAO HoaDonXuatDAO = new HoaDonXuatDAO();

        public List<HoaDonXuatDTO> DanhSachHoaDonXuat()
        {
            return HoaDonXuatDAO.DanhSachHoaDonXuat();
        }


        public string TangHD()
        {
            return HoaDonXuatDAO.TangHD();
        }

        public int themHoaDon(HoaDonXuatDTO hoadonxuatDTO)
        {
            return HoaDonXuatDAO.ThemHoaDon(hoadonxuatDTO);
        }

        public bool suaHoaDon(HoaDonXuatDTO hoadonxuatDTO)
        {
            return HoaDonXuatDAO.SuaHoaDonXuat(hoadonxuatDTO);
        }

        public bool xoaHoaDon(HoaDonXuatDTO hoadonxuatDTO)
        {
            return HoaDonXuatDAO.XoaHoaDonXuat(hoadonxuatDTO);
        }

        public int ThongKeDoanhThuCuaHang(string TheoThang, string TheoNam)
        {
            return HoaDonXuatDAO.ThongKeDoanhThuCuaHang(TheoThang, TheoNam);
        }

        public int ThongKeDoanhThuNhanVien(string MaNV, string TheoThang, String TheoNam)
        {
            return HoaDonXuatDAO.ThongKeDoanhThuNhanVien(MaNV, TheoThang, TheoNam);
        }

        public List<HoaDonXuatDTO> DSCTHDBTheoMa(string mahd)
        {
            return HoaDonXuatDAO.DSHDXuatTheoma(mahd);
        }
         public int LayTongTienTheoMa(string manv)
        {
            return HoaDonXuatDAO.LayTongTienTheoNV(manv);
        }

         //public int TongHoaDon(string MaHDX)
         //{
         //    return HoaDonXuatDAO.TongHoaDon(MaHDX);
         //}
    }
}
