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
            Benh_NhanBUS bn = new BUS.Benh_NhanBUS();

            dgvDSBenhNhan.DataSource = bn.DanhsachKham();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            ThemBenhNhan bn = new ThemBenhNhan();

            bn.ShowDialog();
        }
    }
}
