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
    public partial class ThongTinPhongKham : Form
    {
        ThongTinBUS bus = new ThongTinBUS();

        public ThongTinPhongKham()
        {
            InitializeComponent();
        }

        private void ThayDoiNDS_Load(object sender, EventArgs e)
        {
            DataTable temp = bus.LayThongTin();
            lbSLCu.Text = temp.Rows[0][1].ToString();
            lbDGCu.Text = temp.Rows[0][2].ToString();
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(tbxSoLuong.Text.ToString().Length == 0)
            {
                tbxSoLuong.Text = "0";
            }
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

//             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
//                 (e.KeyChar != '.'))
//             {
//                 e.Handled = true;
//             }
// 
//             // only allow one decimal point
//             if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
//             {
//                 e.Handled = true;
//             }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(tbxSoLuong.Text);
            int dgia = int.Parse(tbxDGMoi.Text);
            if (bus.updateTT(sl, dgia))
            {
                MessageBox.Show("Cập nhập thành công", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
