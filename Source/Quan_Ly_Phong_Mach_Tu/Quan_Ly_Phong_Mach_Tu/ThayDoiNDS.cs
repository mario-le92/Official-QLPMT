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
using BUS;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class ThayDoiNDS : Form
    {
        TTPhongKhamDTO dto;
        public ThayDoiNDS()
        {
            InitializeComponent();
        }

        private void ThayDoiNDS_Load(object sender, EventArgs e)
        {
            lbSLCu.Text = "loi";
            dto = new TTPhongKhamDTO();
            TTPhongKhamBUS bus = new TTPhongKhamBUS();
            dto =  bus.getTTPK();
            //lbSLCu.Text = dto.getSoLuong().ToString();
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(tbSoLuong.Text.ToString().Length == 0)
            {
                tbSoLuong.Text = "0";
            }
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sl = tbSoLuong.Text;
            int sls = 0;
            try
            {
                sls = int.Parse(sl);
                //dto.setSoLuong(sls);
            }
            catch (InvalidCastException exx) 
            {
                MessageBox.Show(exx.Message.ToString());
            }
            TTPhongKhamBUS bus = new TTPhongKhamBUS();
            if (!bus.setTTPK(dto))
            {
                MessageBox.Show("Luu ko dc");
            }
            else
                this.Close();
        }
    }
}
