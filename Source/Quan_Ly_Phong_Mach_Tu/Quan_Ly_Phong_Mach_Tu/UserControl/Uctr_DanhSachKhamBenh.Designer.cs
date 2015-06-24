namespace Quan_Ly_Phong_Mach_Tu
{
    partial class Uctr_DanhSachKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDate = new System.Windows.Forms.Label();
            this.dgvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.lbSoLuongbn = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Da_kham = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(12, 40);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(28, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "date";
            // 
            // dgvDSBenhNhan
            // 
            this.dgvDSBenhNhan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDSBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Dia_chi,
            this.Da_kham,
            this.BNID});
            this.dgvDSBenhNhan.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSBenhNhan.Location = new System.Drawing.Point(0, 61);
            this.dgvDSBenhNhan.MultiSelect = false;
            this.dgvDSBenhNhan.Name = "dgvDSBenhNhan";
            this.dgvDSBenhNhan.ReadOnly = true;
            this.dgvDSBenhNhan.RowTemplate.Height = 30;
            this.dgvDSBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBenhNhan.Size = new System.Drawing.Size(980, 438);
            this.dgvDSBenhNhan.TabIndex = 4;
            this.dgvDSBenhNhan.DoubleClick += new System.EventHandler(this.dgvDSBenhNhan_DoubleClick);
            // 
            // lbSoLuongbn
            // 
            this.lbSoLuongbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSoLuongbn.AutoSize = true;
            this.lbSoLuongbn.Location = new System.Drawing.Point(12, 515);
            this.lbSoLuongbn.Name = "lbSoLuongbn";
            this.lbSoLuongbn.Size = new System.Drawing.Size(0, 13);
            this.lbSoLuongbn.TabIndex = 6;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(862, 505);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 32);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa Đăng ký";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(324, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách khám bệnh";
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
            this.Ho_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho_ten.DataPropertyName = "Ho_ten";
            this.Ho_ten.HeaderText = "Họ và tên";
            this.Ho_ten.Name = "Ho_ten";
            this.Ho_ten.ReadOnly = true;
            // 
            // Gioi_tinh
            // 
            this.Gioi_tinh.DataPropertyName = "Gioi_tinh";
            this.Gioi_tinh.HeaderText = "Giới tính";
            this.Gioi_tinh.Name = "Gioi_tinh";
            this.Gioi_tinh.ReadOnly = true;
            this.Gioi_tinh.Width = 80;
            // 
            // Nam_sinh
            // 
            this.Nam_sinh.DataPropertyName = "Nam_sinh";
            this.Nam_sinh.HeaderText = "Ngày Sinh";
            this.Nam_sinh.Name = "Nam_sinh";
            this.Nam_sinh.ReadOnly = true;
            this.Nam_sinh.Width = 129;
            // 
            // Dia_chi
            // 
            this.Dia_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dia_chi.DataPropertyName = "Dia_chi";
            this.Dia_chi.HeaderText = "Địa chỉ";
            this.Dia_chi.Name = "Dia_chi";
            this.Dia_chi.ReadOnly = true;
            // 
            // Da_kham
            // 
            this.Da_kham.DataPropertyName = "Da_kham";
            this.Da_kham.HeaderText = "Đã Khám";
            this.Da_kham.Name = "Da_kham";
            this.Da_kham.ReadOnly = true;
            // 
            // BNID
            // 
            this.BNID.DataPropertyName = "BNID";
            this.BNID.HeaderText = "IDKham";
            this.BNID.Name = "BNID";
            this.BNID.ReadOnly = true;
            this.BNID.Visible = false;
            // 
            // Uctr_DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lbSoLuongbn);
            this.Controls.Add(this.dgvDSBenhNhan);
            this.Controls.Add(this.lbDate);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Uctr_DanhSachKhamBenh";
            this.Size = new System.Drawing.Size(980, 540);
            this.Load += new System.EventHandler(this.DanhSachKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView dgvDSBenhNhan;
        private System.Windows.Forms.Label lbSoLuongbn;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_chi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Da_kham;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNID;
    }
}

