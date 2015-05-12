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
    public partial class UCBaoCao : UserControl
    {
        List<BaoCaoDTDTO> lstbcDT = new List<BaoCaoDTDTO>();
        public UCBaoCao()
        {
            InitializeComponent();
            inits();
        }

        private void inits()
        {
            nupTNam.Maximum = nupDTNam.Maximum = new decimal(new int[] {
            DateTime.Today.Year,
            0,
            0,
            0});
            cbTThang.SelectedIndex = cbDTThang.SelectedIndex = 0;
        }

        private void getDTData(string thang, string nam)
        {
            //dgvDT.Columns.Add("dgvDTCol1", "a b c");
            BaoCaoBUS bus = new BaoCaoBUS();
            lstbcDT = bus.getBaoCaoDT(thang, nam);

            dgvDT.Rows.Clear();
            for (int i = 0; i < lstbcDT.Count(); i++)
            {
                dgvDT.Rows.Add(lstbcDT[i].getID(), lstbcDT[i].getNgay(), lstbcDT[i].getSoBenhNhan(), lstbcDT[i].getDoanhThu(), lstbcDT[i].getTyLe());
            }
            /*BindingSource binding = new BindingSource();
            binding.DataSource = lstbcDT;

            //bind datagridview to binding source
            dgvDT.DataSource = binding;*/
        }

        private void getTData(string thang, string nam)
        {
            //dgvDT.Columns.Add("dgvDTCol1", "a b c");
            MessageBox.Show("b");
        }

        public void BaoCao_Load()
        {
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string xx = ((Control)sender).Name;
            switch (xx)
            {
                case "btnXemDT":
                    getDTData((cbDTThang.SelectedIndex + 1).ToString(), nupDTNam.Value.ToString());
                    break;
                case "btnXemT":
                    getTData((cbTThang.SelectedIndex + 1).ToString(), nupTNam.Value.ToString());
                    break;
                default:
                    break;
            }
        }

        private void UCBaoCao_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void cbDTThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
