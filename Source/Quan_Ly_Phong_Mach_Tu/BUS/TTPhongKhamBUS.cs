using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TTPhongKhamBUS
    {
        public bool setTTPK(TTPhongKhamDTO ttpk)
        {
            TTPhongKhamDAO dao = new TTPhongKhamDAO();
            return dao.doiTTPK(ttpk);
        }

        public TTPhongKhamDTO getTTPK()
        {
            TTPhongKhamDAO dao = new TTPhongKhamDAO();
            return dao.getTTPK();
        }
    }
}
