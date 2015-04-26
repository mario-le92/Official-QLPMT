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
    public partial class ThemBenhNhan : Form
    {
        public ThemBenhNhan()
        {
            InitializeComponent();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoadlnhap();
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan();

            bn.HoTen = tbx_HoTen.Text;
            bn.GioiTinh = rbx_Nam.Checked ? "Nam" : "Nữ";
            bn.NamSinh = dtpNgaysinh.Value;
            bn.DiaChi = tbx_DiaChi.Text;
            
            //Them benh nhan vao danh sach kham
            Benh_NhanBUS bnb = new Benh_NhanBUS();
            if (bnb.LuuVaKham(bn))
            {
                MessageBox.Show("Lưu bệnh nhân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoadlnhap();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, không thể lưu bệnh nhân !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            Benh_NhanBUS bn = new BUS.Benh_NhanBUS();
            dgv_timbnhan.DataSource = null;
            int id;
            if (int.TryParse(tbx_tim.Text, out id))
            {
                //tim theo ID
                dgv_timbnhan.DataSource = bn.TimBenhNhanID(id);
            }
            else
            {
                //Tim theo ten
                dgv_timbnhan.DataSource = bn.TimBenhNhanName(tbx_tim.Text);
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            tbx_HoTen.Text = (string)dgv_timbnhan.SelectedRows[0].Cells[1].Value;
            dtpNgaysinh.Value = (DateTime)dgv_timbnhan.SelectedRows[0].Cells[3].Value;
            tbx_DiaChi.Text = (string)dgv_timbnhan.SelectedRows[0].Cells[4].Value;
            if ((string)dgv_timbnhan.SelectedRows[0].Cells[2].Value == "Nam")
            {
                rbx_Nam.Checked = true;
            }
            else
            {
                rbx_Nu.Checked = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Luu benh nhan xuong csdl
            luubn();
        }

        void xoadlnhap()
        {
            tbx_DiaChi.Text = "";
            tbx_HoTen.Text = "";
            rbx_Nam.Checked = true;
            dtpNgaysinh.Value = DateTime.Now;
            tbx_tim.Text = "";
            dgv_timbnhan.DataSource = null;
        } 

        void luubn()
        {
            BenhNhan bn = new BenhNhan();

            bn.HoTen = tbx_HoTen.Text;
            bn.GioiTinh = rbx_Nam.Checked ? "Nam" : "Nữ";
            bn.NamSinh = dtpNgaysinh.Value;
            bn.DiaChi = tbx_DiaChi.Text;

            Benh_NhanBUS bus = new Benh_NhanBUS();
            if (bus.LuuBenhNhan(bn))
            {
                MessageBox.Show("Lưu bệnh nhân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoadlnhap();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, không thể lưu bệnh nhân !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
