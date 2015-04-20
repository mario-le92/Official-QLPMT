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
    public partial class frmTraCuuBenhNhan : Form
    {
        #region stuff

        private void refresh_form()
        {
            txtHoTen.Text = "";
            txtTrieuChung.Text = "";
            dtpNgayKham.Value = DateTime.Today;
            //cbxLoaiBenh.DataSource
            cbxLoaiBenh.SelectedIndex = 0;
            //lstKetQua.DataSource
        }

        #endregion stuff

        public frmTraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void frmTraCuuBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            refresh_form();
        }

        private void btnThemTrieuChung_Click(object sender, EventArgs e)
        {
            frmTraCuuBenhNhanSubForm f = new frmTraCuuBenhNhanSubForm();
            f.ShowDialog();
        }
    }
}
