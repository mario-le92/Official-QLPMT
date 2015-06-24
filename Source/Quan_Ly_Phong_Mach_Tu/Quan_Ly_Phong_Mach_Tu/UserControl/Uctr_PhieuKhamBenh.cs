using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.Linq.SqlClient;
using System.Globalization;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class Uctr_PhieuKhamBenh : UserControl
    {
        KhamBenhBUS bus = new KhamBenhBUS();
        BenhNhan bn = new BenhNhan();
        DataTable dsthuoc = new DataTable();
        DataTable dsbenh = new DataTable();
        DataSet Temple = new DataSet("Temple");
        DataTable ToaThuoc;
        int idkham = 0;
        long Tongtien = 0;
        long TienThuoc = 0;
        long TienKham = 0;
        public delegate void Reload();
        public Reload loaddata;

        public Uctr_PhieuKhamBenh(BenhNhan pass, int id)
        {
            InitializeComponent();
            bn = pass;
            idkham = id;
        }

        private void PhieuKhamBenh_Load(object sender, EventArgs e)
        {
            lbHoTen.Text = bn.HoTen;
            lbNgayKham.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            lb_ID.Text = bn.ID.ToString();

            dsbenh = bus.DSBenh();
            cbxBenh.DataSource = dsbenh;
            cbxBenh.DisplayMember = "Ten";

            dsthuoc = bus.DSThuoc();
            cbxThuoc.DataSource = dsthuoc;
            cbxThuoc.DisplayMember = "Ten_thuoc";

            cbxThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxThuoc.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxBenh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxBenh.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTableToa();

            TienKham = bus.TienKham();
            lbTienKham.Text = TienKham.ToString("C");
        }

        private void tbxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxThuoc.SelectedIndex;

            int id = (int)dsthuoc.Rows[index][0];

            cbxCachDung.DataSource = bus.DSCachDung(id);
            cbxCachDung.DisplayMember = "Ten";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int Thuoc_index = cbxThuoc.SelectedIndex;
            int CachDung_index = cbxCachDung.SelectedIndex;

            if (ThuocTF())
            {
                DataRow rr = ToaThuoc.NewRow();

                rr[0] = 0;
                rr[1] = cbxThuoc.Text;
                rr[2] = dsthuoc.Rows[Thuoc_index][4];
                rr[3] = int.Parse(tbxSoLuong.Text);
                rr[4] = cbxCachDung.Text;
                rr[5] = dsthuoc.Rows[Thuoc_index][3];
                rr[6] = dsthuoc.Rows[Thuoc_index][0];

                //Tim thuoc trong toa da co chua
                DataRow temp = ToaThuoc.Rows.Find(rr[1]);
                
                if (temp == null)
                {
                    ToaThuoc.Rows.Add(rr);
                }
                else
                {
                    int index = (int)temp[0];
                    ToaThuoc.Rows[index - 1][3] = (int)temp[3] + (int)ToaThuoc.Rows[index - 1][3];
                }
                
                STT_Toa();
                TinhTien();
                dgvToaThuoc.DataSource = ToaThuoc;
            }  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bus.TaoToa();
            bus.LuuChiTietToa(ToaThuoc);
            int idbenh = (int)dsthuoc.Rows[cbxBenh.SelectedIndex][0];
            bus.HoaDon(bn.ID, idbenh, tbxTrieuChung.Text);
            bus.DaKham(idkham);
            if (loaddata != null)
            {
                loaddata();
            }

//             HoaDonrp rp = new HoaDonrp();
// 
//             rp.SetDataSource(ToaThuoc);
//             rp.SetParameterValue("MaBN", bn.ID);
//             rp.SetParameterValue("TenBenhNhan", bn.HoTen);
//             rp.SetParameterValue("DChi", bn.DiaChi);
//             rp.SetParameterValue("Trieuchung", tbxTrieuChung.Text);
//             rp.SetParameterValue("Benh", cbxBenh.Text);
// 
//             HoaDon fm = new HoaDon();
//             fm.KhoiTao(rp);
//             fm.Show();
        }

        private void DataTableToa()
        {
            //ToaThuoc = Temple.Tables.Add("Toa");
            ToaThuocds dts = new ToaThuocds();
            ToaThuoc = dts.Toa_Thuoc.Clone();

//             DataColumn[] key = new DataColumn[1];
// 
//             ToaThuoc.Columns.Add("STT", typeof(Int32));
//             ToaThuoc.Columns.Add("Thuoc", typeof(string));
//             ToaThuoc.Columns.Add("DonVi", typeof(string));
//             ToaThuoc.Columns.Add("SoLuong", typeof(Int32));
//             ToaThuoc.Columns.Add("CachDung", typeof(string));
//             ToaThuoc.Columns.Add("DonGia", typeof(Int32));
//             ToaThuoc.Columns.Add("ID", typeof(Int32));
// 
//             key[0] = ToaThuoc.Columns[1];
// 
//             ToaThuoc.PrimaryKey = key;
        }

        private bool ThuocTF()
        {
            bool TF = true;
            int Thuoc_index = cbxThuoc.SelectedIndex;
            int CachDung_index = cbxCachDung.SelectedIndex;

            if (Thuoc_index < 0)
            {
                TF = false;
                MessageBox.Show("Tên thuốc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CachDung_index < 0)
            {
                TF = false;
                MessageBox.Show("Cách dùng thuốc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbxSoLuong.Text == "")
            {
                TF = false;
                MessageBox.Show("Số lượng thuốc không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TF;
        }

        private void STT_Toa()
        {
            int sl = ToaThuoc.Rows.Count;

            for (int i = 0; i < sl; i++)
            {
                ToaThuoc.Rows[i][0] = i + 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = (int)dgvToaThuoc.SelectedRows[0].Cells[0].Value;
            ToaThuoc.Rows.RemoveAt(index - 1);
            STT_Toa();
            TinhTien();
            dgvToaThuoc.DataSource = ToaThuoc;
        }

        private void TinhTien()
        {
            //Tinh tien thuoc
            for (int i = 0; i < ToaThuoc.Rows.Count; i++)
            {
                TienThuoc = TienThuoc + (long)ToaThuoc.Rows[i][3] * (long)ToaThuoc.Rows[i][5];
            }
            lbTienThuoc.Text = TienThuoc.ToString("C");

            Tongtien = TienThuoc + TienKham;

            lbTongTien.Text = Tongtien.ToString("C");
        }

        public DataTable GetToaThuoc()
        {
            return ToaThuoc;
        }
    }
}
