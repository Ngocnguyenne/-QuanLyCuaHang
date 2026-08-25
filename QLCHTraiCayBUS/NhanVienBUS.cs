using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDAO;
using QLCHTraiCayDTO;

namespace QLCHTraiCayBUS
{
    public class NhanVienBUS
    {
        NhanVienDAO NhanVienDAO = new NhanVienDAO();

        public  List<NhanVienDTO> DanhSachNhanVien()
        {
            return NhanVienDAO.DanhSachNhanVien();
        }

        public  List<LoaiNhanVienDTO> LayLoaiNhanVien()
        {
            return NhanVienDAO.DanhSachLoaiNhanVien();
        }

        public bool ThemNhanVien(NhanVienDTO nhanvienDTO)
        {
            return NhanVienDAO.ThemNhanVien(nhanvienDTO);
        }

        public bool SuaNhanVien(NhanVienDTO nhanvienDTO)
        {
            return NhanVienDAO.SuaNhanVien(nhanvienDTO);
        }

        public bool XoaNhanVien(string MaNhanVien)
        {
            if (NhanVienDAO.XoaNhanVien(MaNhanVien))
            {
                return true;
            }
            return false;
        }

        public string TangNhanVien()
        {
            return NhanVienDAO.TangNhanVien();
        }
    }
}
