namespace Quan_Ly_Phong_Mach_Tu
{
    partial class DanhSachKhamBenh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSachKhamBenhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditSoLuongKham = new System.Windows.Forms.Button();
            this.lbSoLuongHienTai = new System.Windows.Forms.Label();
            this.btn_ThemBN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(12, 31);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(28, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachKhamBenhToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.thongTinThuocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSachKhamBenhToolStripMenuItem
            // 
            this.danhSachKhamBenhToolStripMenuItem.Name = "danhSachKhamBenhToolStripMenuItem";
            this.danhSachKhamBenhToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.danhSachKhamBenhToolStripMenuItem.Text = "Danh sach kham benh";
            // 
            // traCuuToolStripMenuItem
            // 
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.traCuuToolStripMenuItem.Text = "Tra cuu";
            // 
            // thongTinThuocToolStripMenuItem
            // 
            this.thongTinThuocToolStripMenuItem.Name = "thongTinThuocToolStripMenuItem";
            this.thongTinThuocToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.thongTinThuocToolStripMenuItem.Text = "Thong tin thuoc";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(665, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(167, 20);
            this.tbSearch.TabIndex = 3;
            // 
            // dgvDSBenhNhan
            // 
            this.dgvDSBenhNhan.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDSBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSBenhNhan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ho_ten,
            this.Gioi_tinh,
            this.Nam_sinh,
            this.Dia_chi});
            this.dgvDSBenhNhan.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSBenhNhan.Location = new System.Drawing.Point(0, 54);
            this.dgvDSBenhNhan.Name = "dgvDSBenhNhan";
            this.dgvDSBenhNhan.ReadOnly = true;
            this.dgvDSBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBenhNhan.Size = new System.Drawing.Size(844, 457);
            this.dgvDSBenhNhan.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Bệnh nhân";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Ho_ten
            // 
            this.Ho_ten.DataPropertyName = "Ho_ten";
            this.Ho_ten.HeaderText = "Họ và tên";
            this.Ho_ten.Name = "Ho_ten";
            this.Ho_ten.ReadOnly = true;
            this.Ho_ten.Width = 200;
            // 
            // Gioi_tinh
            // 
            this.Gioi_tinh.DataPropertyName = "Gioi_tinh";
            this.Gioi_tinh.HeaderText = "Giới tính";
            this.Gioi_tinh.Name = "Gioi_tinh";
            this.Gioi_tinh.ReadOnly = true;
            // 
            // Nam_sinh
            // 
            this.Nam_sinh.DataPropertyName = "Nam_sinh";
            this.Nam_sinh.HeaderText = "Năm Sinh";
            this.Nam_sinh.Name = "Nam_sinh";
            this.Nam_sinh.ReadOnly = true;
            // 
            // Dia_chi
            // 
            this.Dia_chi.DataPropertyName = "Dia_chi";
            this.Dia_chi.HeaderText = "Địa chỉ";
            this.Dia_chi.Name = "Dia_chi";
            this.Dia_chi.ReadOnly = true;
            this.Dia_chi.Width = 320;
            // 
            // btnEditSoLuongKham
            // 
            this.btnEditSoLuongKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSoLuongKham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSoLuongKham.Location = new System.Drawing.Point(705, 517);
            this.btnEditSoLuongKham.Name = "btnEditSoLuongKham";
            this.btnEditSoLuongKham.Size = new System.Drawing.Size(127, 23);
            this.btnEditSoLuongKham.TabIndex = 5;
            this.btnEditSoLuongKham.Text = "Thay Doi So Luong BN";
            this.btnEditSoLuongKham.UseVisualStyleBackColor = true;
            // 
            // lbSoLuongHienTai
            // 
            this.lbSoLuongHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSoLuongHienTai.AutoSize = true;
            this.lbSoLuongHienTai.Location = new System.Drawing.Point(12, 527);
            this.lbSoLuongHienTai.Name = "lbSoLuongHienTai";
            this.lbSoLuongHienTai.Size = new System.Drawing.Size(103, 13);
            this.lbSoLuongHienTai.TabIndex = 6;
            this.lbSoLuongHienTai.Text = "So Benh Nhan 0/30";
            // 
            // btn_ThemBN
            // 
            this.btn_ThemBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemBN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemBN.Location = new System.Drawing.Point(594, 517);
            this.btn_ThemBN.Name = "btn_ThemBN";
            this.btn_ThemBN.Size = new System.Drawing.Size(105, 23);
            this.btn_ThemBN.TabIndex = 7;
            this.btn_ThemBN.Text = "Them Benh Nhan";
            this.btn_ThemBN.UseVisualStyleBackColor = true;
            this.btn_ThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.btn_ThemBN);
            this.Controls.Add(this.lbSoLuongHienTai);
            this.Controls.Add(this.btnEditSoLuongKham);
            this.Controls.Add(this.dgvDSBenhNhan);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbDate);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DanhSachKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng mạch tư";
            this.Load += new System.EventHandler(this.DanhSachKhamBenh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachKhamBenhToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvDSBenhNhan;
        private System.Windows.Forms.Button btnEditSoLuongKham;
        private System.Windows.Forms.Label lbSoLuongHienTai;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinThuocToolStripMenuItem;
        private System.Windows.Forms.Button btn_ThemBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_chi;
    }
}

