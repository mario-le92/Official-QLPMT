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
    public partial class frmTraCuuBenhNhanSubForm : Form
    {
        public List<int> danh_sach_trieu_chung;
        private bool btnokay_click;

        public frmTraCuuBenhNhanSubForm()
        {
            InitializeComponent();

            btnokay_click = false;
            danh_sach_trieu_chung = new List<int>();
        }

        private void frmTraCuuBenhNhanSubForm_Load(object sender, EventArgs e)
        {
            //test.
            var data_source = new List<string>() { "nhức đầu", "chóng mặt", "choáng váng", "buồn nôn" };
            try
            {
                lstDanhSachTrieuChung.DataSource = data_source;
            }
            catch
            {

            }            
        }

        private void lstDanhSachTrieuChung_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

        }
    }
}
