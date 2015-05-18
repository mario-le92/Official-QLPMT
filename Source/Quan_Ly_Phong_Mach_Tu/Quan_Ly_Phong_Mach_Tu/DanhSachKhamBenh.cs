using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class DanhSachKhamBenh : Form
    {
        #region 

        /*ID of UserControl*/
        private int iUI = 0;
        TraCuuUserControl TCUC = new TraCuuUserControl(); // ID = 2
        BaoCaoUserControl BCUC = new BaoCaoUserControl(); // ID = 4

        #endregion

        public DanhSachKhamBenh()
        {
            InitializeComponent();
        }

        private void DanhSachKhamBenh_Load(object sender, EventArgs e)
        {
            danhSachKhamBenhToolStripMenuItem_Click(sender, e);
        }

        private void btnEditSoLuongKham_Click(object sender, EventArgs e)
        {
            ThayDoiNDS tnds = new ThayDoiNDS();
            tnds.Show();
        }

        private void danhSachKhamBenhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iUI != 1)
            {
                iUI = 1;
                pnUISwitch.Controls.Clear();
                //pnUISwitch.Controls.Add(TCUC);
                //TCUC.Dock = DockStyle.Fill;
                this.Text = AppString.Title_DanhSachKhamBenh;
            }
        }

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iUI != 2)
            {
                iUI = 2;
                pnUISwitch.Controls.Clear();
                pnUISwitch.Controls.Add(TCUC);
                TCUC.Dock = DockStyle.Fill;
                this.Text = AppString.Title_TraCuuBenhNhan;
            }

        }

        private void thongTinThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iUI != 3)
            {
                iUI = 3;
                pnUISwitch.Controls.Clear();
                //pnUISwitch.Controls.Add(TCUC);
                //TCUC.Dock = DockStyle.Fill;
                this.Text = AppString.Title_ThongTinThuoc;
            }
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iUI != 4)
            {
                iUI = 4;
                pnUISwitch.Controls.Clear();
                pnUISwitch.Controls.Add(BCUC);
                BCUC.Dock = DockStyle.Fill;
                this.Text = AppString.Title_BaoCao;
            }
        }
    }
}
