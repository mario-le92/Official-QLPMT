using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BaoCaoBUS
    {
        public List<BaoCaoDTDTO> getBaoCaoDT(string thang, string nam)
        {
            BaoCaoDAO dao = new BaoCaoDAO();
            return dao.getBaoCaoDT(thang, nam);
        }
    }
}
