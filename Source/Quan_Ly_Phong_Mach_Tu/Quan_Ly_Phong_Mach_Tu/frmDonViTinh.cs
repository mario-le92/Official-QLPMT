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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
        //Form load
        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonViTinh();
        }
        //Thêm đơn vị tính
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == true)
            {
                if (KiemTraTonTai() == false)
                {
                    DonViTinhBUS DonViTinh = new DonViTinhBUS();
                    DonViTinhDTO dvt = TaoDonViTinh();
                    DonViTinh.ThemDonViTinh(dvt);
                    LoadDanhSachDonViTinh();
                    MessageBox.Show("Thêm thành công!");

                    this.Close();
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDaChonDoiTuong() == true)
            {
                if (KiemTraDuLieuNhap() == true)
                {
                    DonViTinhBUS DonViTinh = new DonViTinhBUS();
                    DonViTinhDTO dvt = TaoDonViTinh_CapNhat();
                    DonViTinh.CapNhatDonViTinh(dvt);
                    LoadDanhSachDonViTinh();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }   
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DonViTinhBUS DonViTinh = new DonViTinhBUS();
            DonViTinhDTO dvtDTO = TaoDonViTinh_TimKiem();
            dt = DonViTinh.TimDonViTinh(dvtDTO);
            dgvDanhSachDonVi.DataSource = dt;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Ánh xạ thông tin đơn vị từ lưới dữ liệu lên các textbox,....
        private void dgvDanhSachDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvDanhSachDonVi.CurrentRow.Cells[0].Value.ToString();
            txtTenDonVi.Text = dgvDanhSachDonVi.CurrentRow.Cells[1].Value.ToString();
            //dgvDanhSachDonVi.CurrentRơ.Style.Font = new Font("Arial", 10, FontStyle.Bold);
        }
        //Load danh sách đơn vị tính
        private void LoadDanhSachDonViTinh()
        {
            DataTable dt = new DataTable();
            DonViTinhBUS dvt = new DonViTinhBUS();
            dt = dvt.LoadDSDonViTinh();
            dgvDanhSachDonVi.DataSource = dt;
            dgvDanhSachDonVi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachDonVi.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           // dgvDanhSachDonVi.Columns[1].DefaultCellStyle.Format = ;
            dgvDanhSachDonVi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }       
        DonViTinhDTO TaoDonViTinh_CapNhat()
        {
            DonViTinhDTO dvt = new DonViTinhDTO();
            dvt.Ma_don_vi = int.Parse(dgvDanhSachDonVi.SelectedRows[0].Cells[0].Value.ToString());
            dvt.Ten_don_vi = txtTenDonVi.Text;
            return dvt;
        }
        DonViTinhDTO TaoDonViTinh()
        {
            DonViTinhDTO dvt = new DonViTinhDTO();
            dvt.Ten_don_vi = txtTenDonVi.Text;
            return dvt;
        }
        DonViTinhDTO TaoDonViTinh_TimKiem()
        {
            DonViTinhDTO dvt = new DonViTinhDTO();
            //dvt.Ten_don_vi = txtTimKiem.Text;
            return dvt;
        }
        Boolean KiemTraTonTai()
        {
            DataTable dt = new DataTable();
            DonViTinhBUS DonViTinh = new DonViTinhBUS();
            dt = DonViTinh.KiemTraTonTai(txtTenDonVi.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đơn vị tính đã tồn tại , vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // đơn vị tính đã tồn tại trong CSDL
            }
            return false; // đơn vị tính chưa tồn tại
        }
        Boolean KiemTraDuLieuNhap()
        {
            if (txtTenDonVi.Text == "")
            {
                MessageBox.Show("Các dữ liệu không được để trống , vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        Boolean KiemTraDaChonDoiTuong()
        {
            if (dgvDanhSachDonVi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng để thao tác ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
       
    }
}
