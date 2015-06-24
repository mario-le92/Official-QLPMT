using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViTinhDTO
    {
        private int _Ma_don_vi;

        public int Ma_don_vi
        {
            get { return _Ma_don_vi; }
            set { _Ma_don_vi = value; }
        }
        private string _Ten_don_vi;

        public string Ten_don_vi
        {
            get { return _Ten_don_vi; }
            set { _Ten_don_vi = value; }
        }
    }
}
