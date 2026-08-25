using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using QLCHTraiCayDAO;

namespace QLCHTraiCayBUS
{
    public class LoaiTraiCayBUS
    {
        public List<LoaiTraiCayDTO> LayLoaiTraiCay()
        {
            return LoaiTraiCayDAO.DanhSachLoaiTraiCay();
        }
    }
}
