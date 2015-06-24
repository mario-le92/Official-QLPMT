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
    public partial class Uctr_TraCuuBenhNhan : UserControl
    {
        private DanhSachBenhNhanBUS data = new DanhSachBenhNhanBUS();

        //GUI interaction.
        public Uctr_TraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void TraCuuUserControl_Load(object sender, EventArgs e)
        {
            //valid_input();

            refresh_form();
            DataGridViewFormat();
        }

        //utility functions.
        private bool is_number(string s) //false ~ this isn't a number, true ~ this is a number.
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool contain_digit(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }

            return false;
        }

        private bool contain_special_chars(string s)
        {
            foreach (char c in s)
            {
                if ((c == ' ' || char.IsDigit(c) || char.IsLetter(c)) == false)
                {
                    return true;
                }
            }

            return false;
        }

        //underlying functions.
        private void refresh_form()
        {
            //txt_searh_box.Text = "";
            wmt_ho_ten.refresh();
            wmt_ma_so.refresh();
            dtp_ngay_kham.Value = DateTime.Today;

            dgv_danh_sach_benh_nhan.DataSource = null;
            cbx_loai_benh.DataSource = null;

            cbx_loai_benh.DataSource = data.danh_sach_loai_benh();
            cbx_loai_benh.DisplayMember = "ten";
            cbx_loai_benh.ValueMember = "id";

            cbx_loai_benh.SelectedIndex = 0;

            dgv_danh_sach_benh_nhan.DataSource = data.danh_sach_benh_nhan();
            
            //dgv_danh_sach_benh_nhan.Columns["id"].Visible = false;
            //dgv_danh_sach_benh_nhan.Columns["id"].HeaderText = "Mã số";
            //dgv_danh_sach_benh_nhan.Columns["ho_ten"].HeaderText = "Họ tên";
            //dgv_danh_sach_benh_nhan.Columns["ngay_kham"].HeaderText = "Ngày khám";
            //dgv_danh_sach_benh_nhan.Columns["ten"].HeaderText = "Loại bệnh";
            //dgv_danh_sach_benh_nhan.Columns["trieu_chung"].HeaderText = "Triệu chứng";
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            DanhSachBenhNhanDTO d = new DanhSachBenhNhanDTO();

            if (wmt_ma_so.txt_value == "")
            {
                d.ma_so = -1;
            }
            else
            {
                d.ma_so = Convert.ToInt32(wmt_ma_so.txt_value);
            }

            d.ho_ten = wmt_ho_ten.txt_value;

            if (dtp_ngay_kham.Enabled == false)
            {
                d.ngay_kham = "";
            }
            else
            {
                d.ngay_kham = dtp_ngay_kham.Value.ToShortDateString();
            }

            d.loai_benh = Convert.ToInt32(cbx_loai_benh.SelectedValue);

            dgv_danh_sach_benh_nhan.DataSource = data.tim_kiem_benh_nhan(d);

            wmt_ho_ten.disable_popup();
            //wmt_ma_so.disable_popup();

            if (dgv_danh_sach_benh_nhan.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void wmt_ho_ten_Load(object sender, EventArgs e)
        {
            wmt_ho_ten.finding = () => new DanhSachBenhNhanBUS().ho_ten_hint(wmt_ho_ten.txt_value);
            wmt_ho_ten.searchable = () =>
            {
                //debugging.
                bool aaa = string.IsNullOrEmpty(wmt_ho_ten.txt_value);
                bool bbb = contain_digit(wmt_ho_ten.txt_value);
                bool ccc = contain_special_chars(wmt_ho_ten.txt_value);

                return !(string.IsNullOrEmpty(wmt_ho_ten.txt_value) ||
                    contain_digit(wmt_ho_ten.txt_value) ||
                    contain_special_chars(wmt_ho_ten.txt_value));
            };
        }

        private void wmt_ma_so_Load(object sender, EventArgs e)
        {
            wmt_ma_so.do_some_after_leaving = () =>
            {
                if (!string.IsNullOrEmpty(wmt_ma_so.txt_value))
                {
                    wmt_ho_ten.txt_value = new DanhSachBenhNhanBUS().t_utility1(wmt_ma_so.txt_value);
                }

                return false;
            };

            wmt_ma_so.finding = () => new DanhSachBenhNhanBUS().ma_so_hint(wmt_ma_so.txt_value);
            wmt_ma_so.searchable = () =>
            {
                //debugging.
                bool aaa = string.IsNullOrEmpty(wmt_ma_so.txt_value);
                bool bbb = !is_number(wmt_ma_so.txt_value);

                bool ccc = aaa || bbb;

                return !(string.IsNullOrEmpty(wmt_ma_so.txt_value) ||
                    !is_number(wmt_ma_so.txt_value));
            };
        }

        private void cb_tat_ca_CheckedChanged(object sender, EventArgs e)
        {
            dtp_ngay_kham.Enabled = cb_tat_ca.Checked;
        }

        private void dgv_danh_sach_benh_nhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_danh_sach_benh_nhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            dgv_danh_sach_benh_nhan.Focus();
            if (dgv_danh_sach_benh_nhan.Rows.Count != 0)
            {
                wmt_ma_so.txt_value =
                    dgv_danh_sach_benh_nhan["id", e.RowIndex].Value.ToString();
                wmt_ho_ten.txt_value =
                    dgv_danh_sach_benh_nhan["ho_ten", e.RowIndex].Value.ToString();
                dtp_ngay_kham.Value = (DateTime)
                    dgv_danh_sach_benh_nhan["ngay_kham", e.RowIndex].Value;
                cbx_loai_benh.Text =
                    dgv_danh_sach_benh_nhan["ten", e.RowIndex].Value.ToString();

                //MessageBox.Show(cbx_loai_benh.SelectedIndex.ToString());
            }
        }

        private void cbx_loai_benh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_lam_moi_Click(object sender, EventArgs e)
        {
            refresh_form();
        }
        private void DataGridViewFormat()
        {
            dgv_danh_sach_benh_nhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_danh_sach_benh_nhan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_danh_sach_benh_nhan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_danh_sach_benh_nhan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_danh_sach_benh_nhan.EnableHeadersVisualStyles = false;
        }
    }
}