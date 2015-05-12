using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class BaoCaoUserControl : UserControl
    {
        bool isDT = true;
        public BaoCaoUserControl()
        {
            InitializeComponent();
        }
        private void inits()
        {
            nupNam.Maximum = new decimal(new int[] {
            DateTime.Today.Year,
            0,
            0,
            0});
            cbThang.SelectedIndex = 0;
        }

        private void BaoCaoUserControl_Load(object sender, EventArgs e)
        {
            inits();            
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            BaoCaoBUS bus = new BaoCaoBUS();
            crvBaoCao.ReportSource = bus.getCRDoanhThu(cbThang.SelectedIndex, nupNam.Value.ToString());
            isDT = true;
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            BaoCaoBUS bus = new BaoCaoBUS();
            crvBaoCao.ReportSource = bus.getCRSuDungThuoc("", "");
            isDT = false;
        }

        private void crvBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            BaoCaoBUS bus = new BaoCaoBUS();
            if (isDT)
                crvBaoCao.ReportSource = bus.getCRDoanhThu(cbThang.SelectedIndex, nupNam.Value.ToString());
            else
                crvBaoCao.ReportSource = bus.getCRSuDungThuoc("", "");
        }
    }
}
