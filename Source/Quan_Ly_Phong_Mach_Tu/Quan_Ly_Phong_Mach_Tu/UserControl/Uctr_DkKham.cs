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
    public partial class Uctr_DkKham : UserControl
    {
        int slToiDa = 0;
        int sldkKham = 0;
        DataTable dsbn;
        Benh_NhanBUS bus = new Benh_NhanBUS();

        public Uctr_DkKham()
        {
            InitializeComponent();
        }

        public delegate void Reload();
        public Reload loaddata;

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoadlnhap();
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            Laythongtin();

            if(sldkKham >= slToiDa )
            {
                MessageBox.Show("Đã đạt số lượng khám tối đa không thể đăng ký thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }

            if (Kiemtra())
            {
                BenhNhan bn = new BenhNhan();

                bn.HoTen = tbx_HoTen.Text;
                bn.GioiTinh = rbx_Nam.Checked ? "Nam" : "Nữ";
                bn.NamSinh = dtpNgaysinh.Value;
                bn.DiaChi = tbx_DiaChi.Text;

                if (bus.TimBNCu(bn))
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoadlnhap();
                    if (loaddata != null)
                    {
                        loaddata();
                    }
                    return;
                }
                //Them benh nhan vao danh sach kham
                if (bus.LuuVaKham(bn))
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoadlnhap();
                    if (loaddata != null)
                    {
                        loaddata();
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, không thể lưu bệnh nhân !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            dgv_timbnhan.DataSource = null;
            int id;
            if (int.TryParse(tbx_tim.Text, out id))
            {
                //tim theo ID
                dsbn = bus.TimBenhNhanID(id);
                dgv_timbnhan.DataSource = dsbn;
            }
            else
            {
                //Tim theo ten
                dgv_timbnhan.DataSource = bus.TimBenhNhanName(tbx_tim.Text);
            }
        }

        private void xoadlnhap()
        {
            tbx_DiaChi.Text = "";
            tbx_HoTen.Text = "";
            rbx_Nam.Checked = true;
            dtpNgaysinh.Value = DateTime.Now;
            tbx_tim.Text = "";
            dgv_timbnhan.DataSource = null;
        } 

        private void luubn()
        {
            BenhNhan bn = new BenhNhan();

            bn.HoTen = tbx_HoTen.Text;
            bn.GioiTinh = rbx_Nam.Checked ? "Nam" : "Nữ";
            bn.NamSinh = dtpNgaysinh.Value;
            bn.DiaChi = tbx_DiaChi.Text;

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

        private void DkKham_Load(object sender, EventArgs e)
        {
            rbx_bnmoi.Checked = true;
        }

        private void rbx_bnmoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbx_bnmoi.Checked)
            {
                grb_bncu.Enabled = false;
                grb_bnmoi.Enabled = true;
            } 
            else
            {
                grb_bnmoi.Enabled = false;
                grb_bncu.Enabled = true;
            }
        }

        private void dgv_timbnhan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_timbnhan.SelectedRows.Count > 0)
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
        }

        private void tbx_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Laythongtin()
        {
            ThongTinBUS buss = new ThongTinBUS();

            DataTable thongtin = buss.LayThongTin();
            sldkKham = buss.SL_DKKham();

            if (thongtin.Rows.Count > 0)
            {
                slToiDa = (int)thongtin.Rows[0][1];
            }
        } 

        private bool Kiemtra()
        {
            if (tbx_HoTen.Text.Length < 3)
            {
                MessageBox.Show("Tên bệnh nhân phải ít nhất có 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = tbx_HoTen;
                return false;
            }
            return true;
        }
    }
}
