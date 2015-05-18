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
    public partial class TraCuuUserControl : UserControl
    {
        #region stuff
        /* cai ten noi len tat ca.
         */
        public void clear_data()
        {
            dgvKetQua.DataSource = null;
            lst_thong_tin.Clear();
        }

        /* cap nhat du lieu tu db vao lst_thong_tin tu.
         */
        public void update_data()
        {
            TimKiemBUS tk = new TimKiemBUS();
            var kq = tk.lay_thong_tin_benh_nhan();
            lst_thong_tin = kq;
        }

        /* cap nhat du lieu datagridview.
         */
        public void update_datagridview()
        {
            update_data();
            dgvKetQua.DataSource = lst_thong_tin;
        }

        /* refresh form thuc hien cac buoc sau:
         * 1. lam trong txt thong tin benh nhan.
         * 2. cap nhat du lieu tu database vao bien lst_thongtin.
         * 3. cap nhat du lieu cho datagridview.
         */
        private void refresh_form()
        {
            txtThongTinBenhNhan.Text = "";
            update_datagridview();
            resize_all_columns();
            dgvKetQua.Columns[1].Visible = false;
        }

        /* cai ten noi len tat ca.
         */
        private void resize_all_columns()
        {
            for (int i = 0; i < dgvKetQua.ColumnCount; i++)
            {
                dgvKetQua.AutoResizeColumn(i);
            }
        }

        /* cai ten noi len tat ca.
         */
        private void naming_columns()
        {
            dgvKetQua.Columns[0].HeaderText = "stt";
            dgvKetQua.Columns[1].HeaderText = "họ và tên";
            dgvKetQua.Columns[2].HeaderText = "ngày khám";
            dgvKetQua.Columns[3].HeaderText = "loại bệnh";
            dgvKetQua.Columns[4].HeaderText = "triệu chứng";
        }

        #endregion stuff

        List<ModelTimKiemDTO> lst_thong_tin;
        private bool tu_dong_tim_kiem = false;

        public TraCuuUserControl()
        {
            InitializeComponent();
        }

        private void TraCuuUserControl_Load(object sender, EventArgs e)
        {
            lst_thong_tin = new List<ModelTimKiemDTO>();

            refresh_form();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            refresh_form();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtThongTinBenhNhan.Text.Length == 0)
            {
                btnLamMoi.PerformClick();
            }
            else
            {
                int n;
                bool isNumeric;
                List<ModelTimKiemDTO> temp;

                if (txtThongTinBenhNhan.Text.IndexOf(',') != -1)
                {
                    var sep = txtThongTinBenhNhan.Text.Split(',');

                    if (!int.TryParse(sep[0], out n)) //sep[0] ko phai la digit -> sep[1], "1, nguyen van a" hoac "nguyen van a, 1"
                    {
                        temp = lst_thong_tin.Where(o => o.ma_benh_nhan == sep[1].TrimStart(' ')).ToList();
                    }
                    else
                    {
                        temp = lst_thong_tin.Where(o => o.ma_benh_nhan == sep[0].TrimStart(' ')).ToList();
                    }
                }
                else
                {
                    isNumeric = int.TryParse(txtThongTinBenhNhan.Text, out n);

                    if (isNumeric)
                    {
                        temp = lst_thong_tin.Where(o => o.ma_benh_nhan == txtThongTinBenhNhan.Text).ToList();
                    }

                    else
                    {
                        temp = lst_thong_tin.Where(o => o.ho_ten.Contains(txtThongTinBenhNhan.Text)).ToList();
                    }
                }

                dgvKetQua.DataSource = temp;

            }
        }

        private void txtThongTinBenhNhan_TextChanged(object sender, EventArgs e)
        {
            if (tu_dong_tim_kiem)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void cbxTuDong_CheckedChanged(object sender, EventArgs e)
        {
            tu_dong_tim_kiem = !tu_dong_tim_kiem;
        }

        private void btnLichSuKham_Click(object sender, EventArgs e)
        {

        }

        private void cbxTuDong_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }
    }
}
