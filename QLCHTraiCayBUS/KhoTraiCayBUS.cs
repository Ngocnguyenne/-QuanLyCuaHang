using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDAO;
using QLCHTraiCayDTO;

namespace QLCHTraiCayBUS
{
    public class KhoTraiCayBUS
    {
        KhoDAO Kho = new KhoDAO();
        public List<KhoTraiCayDTO> DanhSachKho()
        {
            return Kho.DanhSachKho();
        }
    }
}
