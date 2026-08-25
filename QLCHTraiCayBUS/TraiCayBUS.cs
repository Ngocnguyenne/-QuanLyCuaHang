using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDAO;
using QLCHTraiCayDTO;

namespace QLCHTraiCayBUS
{
    public class TraiCayBUS
    {
        TraiCayDAO TraiCayDAO = new TraiCayDAO();

        public List<TraiCayDTO> DanhSachTraiCay()
        {
            return TraiCayDAO.DanhSachTraiCay();
        }

        //public List<TraiCayDTO> DanhSachLoaiTraiCay()
        //{
        //    return TraiCayDAO.DanhSachLoaiTraiCay();
        //}

        public List<TraiCayDTO> DanhSachBanTraiCay()
        {
            return TraiCayDAO.DanhSachBanTraiCay();
        }

        public bool themTraiCay(TraiCayDTO traiCayDTO)
        {
            return TraiCayDAO.ThemTraiCay(traiCayDTO);
        }

        public bool suaTraiCay(TraiCayDTO traiCayDTO)
        {
            return TraiCayDAO.SuaTraiCay(traiCayDTO);
        }

        public bool XoaTraiCay(string MaTraiCay)
        {
            if (TraiCayDAO.XoaTraiCay(MaTraiCay))
            {
                return true;
            }
            return false;
        }

        public string TangTraiCay()
        {
            return TraiCayDAO.TangTraiCay();
        }

        public bool TruSL(TraiCayDTO tc1)
        {
            return TraiCayDAO.TruSL(tc1);
        }

        public bool CongSL(TraiCayDTO tc1)
        {
            return TraiCayDAO.CongSL(tc1);
        }

        public bool TimTC(string MaTraiCay)
        {
            return TraiCayDAO.TimMaTC(MaTraiCay);
        }

        public List<TraiCayDTO> LayDSHangHoaSapHet()
        {
            return TraiCayDAO.LayDSHangHoaSapHet();
        }
    }
}
