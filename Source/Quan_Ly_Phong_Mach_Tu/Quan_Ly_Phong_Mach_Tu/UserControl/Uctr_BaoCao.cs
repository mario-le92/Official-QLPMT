using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BUS;
using DTO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class Uctr_BaoCao : UserControl
    {
        public Uctr_BaoCao()
        {
            InitializeComponent();
        }
        private void inits()
        {
            nupNamTu.Maximum = nupNamToi.Maximum = new decimal(new int[] {
            DateTime.Today.Year,
            0,
            0,
            0});
            cmbxThangTu.SelectedIndex = cmbxThangToi.SelectedIndex = DateTime.Today.Month - 1;
            

        }

        private void BaoCaoUserControl_Load(object sender, EventArgs e)
        {
            inits();            
        }

        private void crvBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            BaoCaoBUS bus = new BaoCaoBUS();
            if (ckbxToi.Checked)
                if (rbtnDoanhThu.Checked)
                    crvBaoCao.ReportSource = bus.getCRDoanhThu(Application.StartupPath, cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString(), cmbxThangToi.SelectedIndex, nupNamToi.Value.ToString());
                else
                    crvBaoCao.ReportSource = bus.getCRSuDungThuoc(Application.StartupPath, cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString(), cmbxThangToi.SelectedIndex, nupNamToi.Value.ToString());
            else
                if (rbtnDoanhThu.Checked)
                    crvBaoCao.ReportSource = bus.getCRDoanhThu(Application.StartupPath, cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString(), cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString());
                else
                    crvBaoCao.ReportSource = bus.getCRSuDungThuoc(Application.StartupPath, cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString(), cmbxThangTu.SelectedIndex, nupNamTu.Value.ToString());
            crvBaoCao.RefreshReport();
        }

        private void cbToi_CheckedChanged(object sender, EventArgs e)
        {
            cmbxThangToi.Enabled = nupNamToi.Enabled = ckbxToi.Checked;
        }

        private void cmbxThangTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nupNamTu.Value == nupNamToi.Value)
            {
                if (cmbxThangTu.SelectedIndex > cmbxThangToi.SelectedIndex)
                    cmbxThangToi.SelectedIndex = cmbxThangTu.SelectedIndex;
            }
        }

        private void nupNamTu_ValueChanged(object sender, EventArgs e)
        {
            if (nupNamTu.Value > nupNamToi.Value)
            {
                nupNamToi.Value = nupNamTu.Value;
                if (cmbxThangTu.SelectedIndex > cmbxThangToi.SelectedIndex)
                    cmbxThangToi.SelectedIndex = cmbxThangTu.SelectedIndex;
            }
        }

        private void cmbxThangToi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nupNamTu.Value == nupNamToi.Value)
            {
                if (cmbxThangTu.SelectedIndex > cmbxThangToi.SelectedIndex)
                    cmbxThangTu.SelectedIndex = cmbxThangToi.SelectedIndex;
            }
        }

        private void nupNamToi_ValueChanged(object sender, EventArgs e)
        {
            if (nupNamTu.Value >= nupNamToi.Value)
            {
                nupNamTu.Value = nupNamToi.Value;
                if (cmbxThangTu.SelectedIndex > cmbxThangToi.SelectedIndex)
                    cmbxThangToi.SelectedIndex = cmbxThangTu.SelectedIndex;
            }
        }
    }
}
