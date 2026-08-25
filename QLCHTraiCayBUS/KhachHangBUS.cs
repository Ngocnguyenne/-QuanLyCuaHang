using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using QLCHTraiCayDAO;

namespace QLCHTraiCayBUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khachhangDAO = new KhachHangDAO();
        KhachHangDTO khachhangDTO = new KhachHangDTO();

        public List<KhachHangDTO> DanhSachKH()
        {
            return khachhangDAO.DanhSachKhachHang();
        }

        public bool ThemKhachHang(KhachHangDTO khachhangDTO)
        {
            return khachhangDAO.ThemKhachHang(khachhangDTO);
        }

        public bool SuaKhachHang(KhachHangDTO khachhangDTO)
        {
            return khachhangDAO.SuaKhachHang(khachhangDTO);
        }

        public bool XoaKhachHang(string MaKhachHang)
        {
            if (khachhangDAO.XoaKhachHang(MaKhachHang))
            {
                return true;
            }
            return false;
        }

        public string TangKhachHang()
        {
            return khachhangDAO.TangKhachHang();
        }
    }
}
