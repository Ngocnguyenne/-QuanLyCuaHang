using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTraiCayDTO;
using QLCHTraiCayDAO;

namespace QLCHTraiCayBUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO ncc = new NhaCungCapDAO();

        public List<NhaCungCapDTO> LayNhaCungCap()
        {
            return NhaCungCapDAO.DanhSachNhaCungCap();
        }
        
        public bool ThemNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return ncc.ThemNhaCungCap(nccDTO);
        }

        public bool SuaNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return ncc.SuaNhaCungCap(nccDTO);
        }

        public bool XoaNhaCungCap(string MaNhaCungCap)
        {
            if (ncc.XoaNhaCungCap(MaNhaCungCap))
            {
                return true;
            }
            return false;
        }

        public string TangNCC()
        {
            return ncc.TangNCC();
        }
    }
}
