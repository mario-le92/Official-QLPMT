using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class DanhSachKhamBenh : Form
    {
        public DanhSachKhamBenh()
        {
            InitializeComponent();
        }

        private void DanhSachKhamBenh_Load(object sender, EventArgs e)
        {
            BUS.Benh_Nhan bn = new BUS.Benh_Nhan();
            //DataTable dt = 
            dgvDSBenhNhan.DataSource = bn.DanhsachBN();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDSBenhNhan_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSoLuongKham_Click(object sender, EventArgs e)
        {
            ThayDoiNDS tnds = new ThayDoiNDS();
            tnds.Show();
        }
    }
}
