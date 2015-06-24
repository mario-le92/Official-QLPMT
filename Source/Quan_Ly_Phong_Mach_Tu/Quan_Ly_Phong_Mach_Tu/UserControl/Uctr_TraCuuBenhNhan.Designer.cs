namespace Quan_Ly_Phong_Mach_Tu
{
    partial class Uctr_TraCuuBenhNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_danh_sach_benh_nhan = new System.Windows.Forms.DataGridView();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_loai_benh = new System.Windows.Forms.ComboBox();
            this.dtp_ngay_kham = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tat_ca = new System.Windows.Forms.CheckBox();
            this.btn_lam_moi = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_kham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieu_chung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wmt_ma_so = new Quan_Ly_Phong_Mach_Tu.watermark_textbox();
            this.wmt_ho_ten = new Quan_Ly_Phong_Mach_Tu.watermark_textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danh_sach_benh_nhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danh_sach_benh_nhan
            // 
            this.dgv_danh_sach_benh_nhan.AllowUserToAddRows = false;
            this.dgv_danh_sach_benh_nhan.AllowUserToDeleteRows = false;
            this.dgv_danh_sach_benh_nhan.AllowUserToResizeColumns = false;
            this.dgv_danh_sach_benh_nhan.AllowUserToResizeRows = false;
            this.dgv_danh_sach_benh_nhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danh_sach_benh_nhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danh_sach_benh_nhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ho_ten,
            this.ngay_kham,
            this.ten,
            this.trieu_chung});
            this.dgv_danh_sach_benh_nhan.Location = new System.Drawing.Point(16, 89);
            this.dgv_danh_sach_benh_nhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_danh_sach_benh_nhan.Name = "dgv_danh_sach_benh_nhan";
            this.dgv_danh_sach_benh_nhan.ReadOnly = true;
            this.dgv_danh_sach_benh_nhan.RowHeadersVisible = false;
            this.dgv_danh_sach_benh_nhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danh_sach_benh_nhan.Size = new System.Drawing.Size(1471, 363);
            this.dgv_danh_sach_benh_nhan.TabIndex = 6;
            this.dgv_danh_sach_benh_nhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_sach_benh_nhan_CellClick);
            this.dgv_danh_sach_benh_nhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_sach_benh_nhan_CellContentClick);
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tim_kiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem.Location = new System.Drawing.Point(1297, 459);
            this.btn_tim_kiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(161, 48);
            this.btn_tim_kiem.TabIndex = 5;
            this.btn_tim_kiem.Text = "tìm kiếm";
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày khám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ và tên:";
            // 
            // cbx_loai_benh
            // 
            this.cbx_loai_benh.FormattingEnabled = true;
            this.cbx_loai_benh.Location = new System.Drawing.Point(487, 48);
            this.cbx_loai_benh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_loai_benh.Name = "cbx_loai_benh";
            this.cbx_loai_benh.Size = new System.Drawing.Size(197, 24);
            this.cbx_loai_benh.TabIndex = 4;
            this.cbx_loai_benh.SelectedIndexChanged += new System.EventHandler(this.cbx_loai_benh_SelectedIndexChanged);
            // 
            // dtp_ngay_kham
            // 
            this.dtp_ngay_kham.CustomFormat = "";
            this.dtp_ngay_kham.Enabled = false;
            this.dtp_ngay_kham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay_kham.Location = new System.Drawing.Point(487, 12);
            this.dtp_ngay_kham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ngay_kham.Name = "dtp_ngay_kham";
            this.dtp_ngay_kham.Size = new System.Drawing.Size(169, 22);
            this.dtp_ngay_kham.TabIndex = 3;
            this.dtp_ngay_kham.Value = new System.DateTime(2015, 6, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã số:";
            // 
            // cb_tat_ca
            // 
            this.cb_tat_ca.AutoSize = true;
            this.cb_tat_ca.Location = new System.Drawing.Point(665, 18);
            this.cb_tat_ca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tat_ca.Name = "cb_tat_ca";
            this.cb_tat_ca.Size = new System.Drawing.Size(15, 14);
            this.cb_tat_ca.TabIndex = 18;
            this.cb_tat_ca.UseVisualStyleBackColor = true;
            this.cb_tat_ca.CheckedChanged += new System.EventHandler(this.cb_tat_ca_CheckedChanged);
            // 
            // btn_lam_moi
            // 
            this.btn_lam_moi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lam_moi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lam_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lam_moi.Location = new System.Drawing.Point(1119, 459);
            this.btn_lam_moi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lam_moi.Name = "btn_lam_moi";
            this.btn_lam_moi.Size = new System.Drawing.Size(161, 48);
            this.btn_lam_moi.TabIndex = 19;
            this.btn_lam_moi.Text = "làm mới";
            this.btn_lam_moi.UseVisualStyleBackColor = true;
            this.btn_lam_moi.Click += new System.EventHandler(this.btn_lam_moi_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã số";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ tên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
            this.ho_ten.Width = 350;
            // 
            // ngay_kham
            // 
            this.ngay_kham.DataPropertyName = "ngay_kham";
            this.ngay_kham.HeaderText = "Ngày khám";
            this.ngay_kham.Name = "ngay_kham";
            this.ngay_kham.ReadOnly = true;
            this.ngay_kham.Width = 255;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Loại bệnh";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 255;
            // 
            // trieu_chung
            // 
            this.trieu_chung.DataPropertyName = "trieu_chung";
            this.trieu_chung.HeaderText = "Triệu chứng";
            this.trieu_chung.Name = "trieu_chung";
            this.trieu_chung.ReadOnly = true;
            this.trieu_chung.Width = 255;
            // 
            // wmt_ma_so
            // 
            this.wmt_ma_so.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmt_ma_so.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmt_ma_so.Location = new System.Drawing.Point(124, 12);
            this.wmt_ma_so.Margin = new System.Windows.Forms.Padding(5);
            this.wmt_ma_so.Name = "wmt_ma_so";
            this.wmt_ma_so.Size = new System.Drawing.Size(185, 23);
            this.wmt_ma_so.TabIndex = 1;
            this.wmt_ma_so.txt_value = "";
            this.wmt_ma_so.Load += new System.EventHandler(this.wmt_ma_so_Load);
            // 
            // wmt_ho_ten
            // 
            this.wmt_ho_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmt_ho_ten.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmt_ho_ten.Location = new System.Drawing.Point(124, 52);
            this.wmt_ho_ten.Margin = new System.Windows.Forms.Padding(5);
            this.wmt_ho_ten.Name = "wmt_ho_ten";
            this.wmt_ho_ten.Size = new System.Drawing.Size(185, 23);
            this.wmt_ho_ten.TabIndex = 2;
            this.wmt_ho_ten.txt_value = "";
            this.wmt_ho_ten.Load += new System.EventHandler(this.wmt_ho_ten_Load);
            // 
            // Uctr_TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cb_tat_ca);
            this.Controls.Add(this.btn_lam_moi);
            this.Controls.Add(this.wmt_ma_so);
            this.Controls.Add(this.wmt_ho_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_loai_benh);
            this.Controls.Add(this.dtp_ngay_kham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.dgv_danh_sach_benh_nhan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uctr_TraCuuBenhNhan";
            this.Size = new System.Drawing.Size(1492, 513);
            this.Load += new System.EventHandler(this.TraCuuUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danh_sach_benh_nhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lam_moi;
        private watermark_textbox wmt_ma_so;
        private watermark_textbox wmt_ho_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_loai_benh;
        private System.Windows.Forms.DateTimePicker dtp_ngay_kham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.DataGridView dgv_danh_sach_benh_nhan;
        private System.Windows.Forms.CheckBox cb_tat_ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_kham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieu_chung;

    }
}
