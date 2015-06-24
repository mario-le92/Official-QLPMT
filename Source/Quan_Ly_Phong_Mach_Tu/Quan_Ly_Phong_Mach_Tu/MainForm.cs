using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class MainForm : Form
    {
        Uctr_DanhSachKhamBenh ctr_dskham = new Uctr_DanhSachKhamBenh();
        Uctr_DkKham ctr_dkkham = new Uctr_DkKham();
        Uctr_PhieuKhamBenh ctr_phieukham;
        Uctr_TraCuuBenhNhan ctr_tracuu = new Uctr_TraCuuBenhNhan();
        Uctr_Thuoc ctr_thuoc = new Uctr_Thuoc();
        Uctr_BaoCao ctr_baocao = new Uctr_BaoCao();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_dsKham_Click(object sender, EventArgs e)
        {
            ctr_dskham.Dock = DockStyle.Fill;
            ctr_dskham.callForm = new Quan_Ly_Phong_Mach_Tu.Uctr_DanhSachKhamBenh.Reload(OpenFormPK);
            this.Text = AppString.Title_DanhSachKhamBenh;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_dskham);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctr_dskham.Dock = DockStyle.Fill;
            ctr_dskham.callForm = new Quan_Ly_Phong_Mach_Tu.Uctr_DanhSachKhamBenh.Reload(OpenFormPK);
            this.Text = AppString.Title_DanhSachKhamBenh;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_dskham);
            ReloadData();
        }

        private void btn_dkKham_Click(object sender, EventArgs e)
        {
            ctr_dkkham.Dock = DockStyle.Fill;
            ctr_dkkham.loaddata = new Quan_Ly_Phong_Mach_Tu.Uctr_DkKham.Reload(ReloadData);
            this.Text = AppString.Title_DangKyKhamBenh;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_dkkham);
            ReloadData();
        }

        void OpenFormPK(BenhNhan bn, int id)
        {
            ctr_phieukham = new Uctr_PhieuKhamBenh(bn, id);
            ctr_phieukham.Dock = DockStyle.Fill;
            ctr_phieukham.loaddata = new Quan_Ly_Phong_Mach_Tu.Uctr_PhieuKhamBenh.Reload(ReloadData);
            this.Text = AppString.Title_PhieuKham;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_phieukham);
        }

        private void ReloadData()
        {
            ctr_dskham.Loadform();
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            this.Text = AppString.Title_TraCuuBenhNhan;
            ctr_tracuu.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_tracuu);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Text = AppString.Title_BaoCao;
            ctr_baocao.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_baocao);
        }

        private void btn_caidat_Click(object sender, EventArgs e)
        {
            ThongTinPhongKham fmCaiDat = new ThongTinPhongKham();
            fmCaiDat.ShowDialog();
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            this.Text = AppString.Title_ThongTinThuoc;
            ctr_thuoc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(ctr_thuoc);
        }

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\PMT_help.chm");            
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\PMT_help.chm");
        }
    }
}
