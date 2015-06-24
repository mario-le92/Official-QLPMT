namespace Quan_Ly_Phong_Mach_Tu
{
    partial class frmDonViTinh
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachDonVi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_loai_thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::Quan_Ly_Phong_Mach_Tu.Properties.Resources.database_download;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(154, 125);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 60);
            this.btnCapNhat.TabIndex = 41;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Quan_Ly_Phong_Mach_Tu.Properties.Resources.database_add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(29, 125);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 60);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenDonVi.Location = new System.Drawing.Point(125, 85);
            this.txtTenDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(267, 23);
            this.txtTenDonVi.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên đơn vị";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtID.Location = new System.Drawing.Point(125, 47);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(267, 23);
            this.txtID.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã đơn vị";
            // 
            // dgvDanhSachDonVi
            // 
            this.dgvDanhSachDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDonVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten_loai_thuoc});
            this.dgvDanhSachDonVi.Location = new System.Drawing.Point(20, 211);
            this.dgvDanhSachDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachDonVi.Name = "dgvDanhSachDonVi";
            this.dgvDanhSachDonVi.Size = new System.Drawing.Size(372, 314);
            this.dgvDanhSachDonVi.TabIndex = 34;
            this.dgvDanhSachDonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonVi_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã đơn vị tính";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // Ten_loai_thuoc
            // 
            this.Ten_loai_thuoc.DataPropertyName = "Ten";
            this.Ten_loai_thuoc.HeaderText = "Tên đơn vị tính";
            this.Ten_loai_thuoc.Name = "Ten_loai_thuoc";
            this.Ten_loai_thuoc.Width = 200;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Quan_Ly_Phong_Mach_Tu.Properties.Resources.gnome_application_exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.Location = new System.Drawing.Point(292, 125);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 60);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "QUẢN LÝ ĐƠN VỊ TÍNH";
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenDonVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachDonVi);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonViTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachDonVi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_loai_thuoc;
        private System.Windows.Forms.Label label3;
    }
}