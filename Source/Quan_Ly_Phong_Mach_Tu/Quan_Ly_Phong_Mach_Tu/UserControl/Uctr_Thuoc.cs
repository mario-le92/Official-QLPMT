using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class Uctr_Thuoc : UserControl
    {
        public Uctr_Thuoc()
        {
            InitializeComponent();
        }

        private void Uctr_Thuoc_Load(object sender, EventArgs e)
        {
            LoadDSThuoc();
            DataGridViewFormat();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == true)
            {
                if (KiemTraThuocTonTai_Xoa() == true)
                {
                    ThuocBUS Thuoc = new ThuocBUS();
                    ThuocDTO t = new ThuocDTO();
                    t.Tenthuoc = txtTenThuoc.Text;
                    Thuoc.PhucHoiThuoc(t);
                    LoadDSThuoc();
                    MessageBox.Show("Phục hồi thành công!");
                }
                else
                {
                    if (KiemTraThuocTonTai() == false)
                    {
                        ThuocBUS Thuoc = new ThuocBUS();
                        ThuocDTO t = TaoThuoc();
                        Thuoc.ThemThuoc(t);
                        LoadDSThuoc();
                        MessageBox.Show("Thêm thành công thuốc " + txtTenThuoc.Text + " !", "Thông báo");
                    }
                }
            }

        }
        private ThuocDTO TaoThuoc()
        {
            ThuocDTO t = new ThuocDTO();
            string TenThuoc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTenThuoc.Text);
            t.Tenthuoc = TenThuoc;
            t.Soluong = int.Parse(txtSoLuong.Text);
            t.Dongia = int.Parse(txtDonGia.Text);
            t.Donvitinh = int.Parse(cmbDonViTinh.SelectedValue.ToString());
            t.Xoa = int.Parse(cmbTinhTrang.SelectedValue.ToString());
            return t;
        }
        private void dgvDanhSachThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //Hiển thi thông tin từng dòng của datagridview lên trên các textbox, combobox...
        private void dgvDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvDanhSachThuoc.CurrentRow.Cells[0].Value.ToString();
            txtTenThuoc.Text = dgvDanhSachThuoc.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvDanhSachThuoc.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvDanhSachThuoc.CurrentRow.Cells[3].Value.ToString();
            cmbDonViTinh.Text = dgvDanhSachThuoc.CurrentRow.Cells[4].Value.ToString();
            cmbTinhTrang.Text = dgvDanhSachThuoc.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraDaChonDoiTuong() == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa thuốc " + dgvDanhSachThuoc.CurrentRow.Cells[1].Value.ToString() + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ThuocBUS Thuoc = new ThuocBUS();
                    ThuocDTO t = TaoThuoc_Xoa();
                    Thuoc.XoaThuoc(t);
                    LoadDSThuoc();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamTrongTextBox();
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDaChonDoiTuong() == true)
            {
                if (KiemTraDuLieuNhap() == true)
                {
                    ThuocBUS Thuoc = new ThuocBUS();
                    ThuocDTO t = TaoThuoc_CapNhat();
                    Thuoc.CapNhatThuoc(t);
                    LoadDSThuoc();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnDonVi_Click(object sender, EventArgs e)
        {
            frmDonViTinh dvt = new frmDonViTinh();
            dvt.ShowDialog();
            if (dvt.DialogResult == DialogResult.Cancel)
            {
                LoadDSDonViTinh();
            }
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ThuocBUS Thuoc = new ThuocBUS();
            ThuocDTO t = TaoThuoc_TimKiem();
            dt = Thuoc.TimThuoc(t);
            dgvDanhSachThuoc.DataSource = dt;
        }
        ThuocDTO TaoThuoc_TimKiem()
        {
            ThuocDTO t = new ThuocDTO();
            string TenThuoc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTimKiem.Text);
            t.Tenthuoc = TenThuoc;
            return t;
        }
        private ThuocDTO TaoThuoc_Xoa()
        {
            ThuocDTO t = new ThuocDTO();
            t.MaThuoc = int.Parse(dgvDanhSachThuoc.SelectedRows[0].Cells[0].Value.ToString());
            return t;
        }
        ThuocDTO TaoThuoc_CapNhat()
        {
            ThuocDTO t = new ThuocDTO();
            t.MaThuoc = int.Parse(dgvDanhSachThuoc.SelectedRows[0].Cells[0].Value.ToString());
            string TenThuoc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTenThuoc.Text);
            t.Tenthuoc = TenThuoc;
            t.Soluong = int.Parse(txtSoLuong.Text);
            t.Dongia = int.Parse(txtDonGia.Text);
            t.Donvitinh = int.Parse(cmbDonViTinh.SelectedValue.ToString());
            t.Xoa = int.Parse(cmbTinhTrang.SelectedValue.ToString());
            return t;
        }
        Boolean KiemTraThuocTonTai()
        {
            DataTable dt = new DataTable();
            ThuocBUS Thuoc = new ThuocBUS();
            dt = Thuoc.KiemTraThuocTonTai(txtTenThuoc.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên thuốc đã tồn tại , vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // thuốc đã tồn tại trong CSDL
            }
            return false; // thuốc chưa tồn tại
        }
        Boolean KiemTraThuocTonTai_Xoa()
        {
            DataTable dt = new DataTable();
            ThuocBUS Thuoc = new ThuocBUS();
            dt = Thuoc.KiemTraThuocTonTai_Xoa(txtTenThuoc.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên thuốc đã tồn tại và tạm thời bị xóa , bạn có muốn khôi phục! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // thuốc đã tồn tại trong CSDL
            }
            return false; // thuốc chưa tồn tại
        }
        Boolean KiemTraDuLieuNhap()
        {
            if (txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Các dữ liệu không được để trống , vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        Boolean KiemTraDaChonDoiTuong()
        {
            if (dgvDanhSachThuoc.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng để thao tác ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void DataGridViewFormat()
        {
            dgvDanhSachThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachThuoc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachThuoc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachThuoc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachThuoc.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachThuoc.EnableHeadersVisualStyles = false;
        }
        private void LoadDSThuoc()
        {
            DataTable dt = new DataTable();
            ThuocBUS Thuoc = new ThuocBUS();
            dt = Thuoc.LoadDSThuoc();
            dgvDanhSachThuoc.DataSource = dt;
            LoadDSDonViTinh();
            LoadDSTinhTrang();
            //LoadDSLoaiThuoc();
        }
        private void LoadDSDonViTinh()
        {
            DonViTinhBUS dvtBus = new DonViTinhBUS();
            DataTable ds = new DataTable();
            ds = dvtBus.LoadDSTenDonViTinh();
            cmbDonViTinh.DataSource = ds;
            cmbDonViTinh.ValueMember = "ID";
            cmbDonViTinh.DisplayMember = "Ten";
        }
        private void LoadDSTinhTrang()
        {
            TinhTrangBUS ttBus = new TinhTrangBUS();
            DataTable ds = new DataTable();
            ds = ttBus.LoadDSTinhTrang();
            cmbTinhTrang.DataSource = ds;
            cmbTinhTrang.ValueMember = "ID";
            cmbTinhTrang.DisplayMember = "Ten_tinh_trang";
        }
        private void LamTrongTextBox()
        {
            txtTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtID.Text = "";
            txtDonGia.Text = "";
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)
                   && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)
                   && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ThuocBUS Thuoc = new ThuocBUS();
            ThuocDTO t = TaoThuoc_TimKiem();
            dt = Thuoc.TimThuoc(t);
            dgvDanhSachThuoc.DataSource = dt;
        }

    }
}

