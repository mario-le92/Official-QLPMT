using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class BaoCaoUserControl : UserControl
    {
        public BaoCaoUserControl()
        {
            InitializeComponent();
        }

        private void BaoCaoUserControl_Load(object sender, EventArgs e)
        {

            
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            crvBaoCao.ReportSource = new Quan_Ly_Phong_Mach_Tu.CRDoanhThu();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            crvBaoCao.ReportSource = new Quan_Ly_Phong_Mach_Tu.CRSuDungThuoc();
        }
    }
}
