using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTraiCayDTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }

        public string HoNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public string MaLoaiNhanVien { get; set; }

        public string MatKhau { get; set; }

        public string GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string SDT { get; set; }

        public double Luong { get; set; }

        public string HinhAnh { get; set; }

        public int TrangThai { get; set; }

        public string HoTenNhanVien
        {
            get { return HoNhanVien + " " + TenNhanVien; }
        }
    }
}
