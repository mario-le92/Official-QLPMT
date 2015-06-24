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
using DTO;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class Uctr_DanhSachKhamBenh : UserControl
    {
        int slToiDa = 0;
        int sldkKham = 0;
        public Uctr_DanhSachKhamBenh()
        {
            InitializeComponent();
            Laythongtin();
        }

        public delegate void Reload(BenhNhan bnn, int id);
        public Reload callForm;

        void Laythongtin()
        {
            ThongTinBUS bus = new ThongTinBUS();

            DataTable thongtin = bus.LayThongTin();
            sldkKham = bus.SL_DKKham();

            if (thongtin.Rows.Count > 0)
            {
                slToiDa = (int)thongtin.Rows[0][1];
            }
        }

        private void DanhSachKhamBenh_Load(object sender, EventArgs e)
        {
            Loadform();

            lbDate.Text = DateTime.Now.Date.ToString();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            //Uctr_DkKham bn = new Uctr_DkKham();

            //bn.func1 = new Uctr_DkKham.Reload(Loadform);
            //bn.ShowDialog();
        }

        public void Loadform()
        {
            Benh_NhanBUS bn = new Benh_NhanBUS();

            DataTable dsbn = bn.DanhsachKham();
            dgvDSBenhNhan.DataSource = dsbn;
            foreach (DataGridViewRow item in dgvDSBenhNhan.Rows)
            {
                if ((bool)item.Cells[5].Value)
                {
                    item.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

            Laythongtin();
            lbSoLuongbn.Text = "Số lượng bệnh nhân : " + sldkKham.ToString() + "/" + slToiDa.ToString();
        }

        private void dgvDSBenhNhan_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDSBenhNhan.SelectedRows.Count > 0 && !(bool)dgvDSBenhNhan.SelectedRows[0].Cells[5].Value)
            {
                BenhNhan bn = new BenhNhan();
                bn.ID = (int)dgvDSBenhNhan.SelectedRows[0].Cells[0].Value;
                bn.HoTen = (string)dgvDSBenhNhan.SelectedRows[0].Cells[1].Value;
                bn.GioiTinh = (string)dgvDSBenhNhan.SelectedRows[0].Cells[2].Value;
                bn.NamSinh = (DateTime)dgvDSBenhNhan.SelectedRows[0].Cells[3].Value;
                bn.DiaChi = (string)dgvDSBenhNhan.SelectedRows[0].Cells[4].Value;
                int idkh = int.Parse(dgvDSBenhNhan.SelectedRows[0].Cells[6].Value.ToString());
                callForm(bn, idkh);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if((bool)dgvDSBenhNhan.SelectedRows[0].Cells[5].Value)
            {
                MessageBox.Show("Xóa không thành công !!! Không thể xóa bệnh nhân đã khám xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvDSBenhNhan.SelectedRows.Count > 0)
                {
                    //Xóa bệnh nhân
                    Benh_NhanBUS bs = new Benh_NhanBUS();

                    int id = (int)dgvDSBenhNhan.SelectedRows[0].Cells[0].Value;
                    if (!bs.Xoa_DK_Kham(id))
                    {
                        MessageBox.Show("Xóa không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Loadform();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !!! Chọn bệnh nhân cần xóa trước khí nhấn nút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
