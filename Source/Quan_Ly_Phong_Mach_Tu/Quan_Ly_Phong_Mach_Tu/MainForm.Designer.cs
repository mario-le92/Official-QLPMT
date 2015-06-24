namespace Quan_Ly_Phong_Mach_Tu
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.btn_caidat = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.btn_dkKham = new System.Windows.Forms.Button();
            this.btn_dsKham = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_caidat);
            this.panel1.Controls.Add(this.btn_thongtin);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btn_TraCuu);
            this.panel1.Controls.Add(this.btn_dkKham);
            this.panel1.Controls.Add(this.btn_dsKham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 92);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.ImageKey = "exit.ico";
            this.btn_thoat.ImageList = this.IconList;
            this.btn_thoat.Location = new System.Drawing.Point(978, 0);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(163, 92);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "1433576067_preferences-contact-list.ico");
            this.IconList.Images.SetKeyName(1, "1433576200_Application.ico");
            this.IconList.Images.SetKeyName(2, "Custom-Icon-Design-Flatastic-9-Custom-reports.ico");
            this.IconList.Images.SetKeyName(3, "exit.ico");
            this.IconList.Images.SetKeyName(4, "info.ico");
            this.IconList.Images.SetKeyName(5, "old_edit_find.ico");
            this.IconList.Images.SetKeyName(6, "service_manager.ico");
            // 
            // btn_caidat
            // 
            this.btn_caidat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_caidat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_caidat.ImageKey = "service_manager.ico";
            this.btn_caidat.ImageList = this.IconList;
            this.btn_caidat.Location = new System.Drawing.Point(815, 0);
            this.btn_caidat.Name = "btn_caidat";
            this.btn_caidat.Size = new System.Drawing.Size(163, 92);
            this.btn_caidat.TabIndex = 5;
            this.btn_caidat.Text = "Cài Đặt";
            this.btn_caidat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caidat.UseVisualStyleBackColor = true;
            this.btn_caidat.Click += new System.EventHandler(this.btn_caidat_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_thongtin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thongtin.ImageKey = "info.ico";
            this.btn_thongtin.ImageList = this.IconList;
            this.btn_thongtin.Location = new System.Drawing.Point(652, 0);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(163, 92);
            this.btn_thongtin.TabIndex = 4;
            this.btn_thongtin.Text = "Thuốc";
            this.btn_thongtin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.ImageKey = "Custom-Icon-Design-Flatastic-9-Custom-reports.ico";
            this.btnBaoCao.ImageList = this.IconList;
            this.btnBaoCao.Location = new System.Drawing.Point(489, 0);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(163, 92);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TraCuu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TraCuu.ImageKey = "old_edit_find.ico";
            this.btn_TraCuu.ImageList = this.IconList;
            this.btn_TraCuu.Location = new System.Drawing.Point(326, 0);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(163, 92);
            this.btn_TraCuu.TabIndex = 2;
            this.btn_TraCuu.Text = "Tra Cứu";
            this.btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // btn_dkKham
            // 
            this.btn_dkKham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_dkKham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dkKham.ImageKey = "1433576200_Application.ico";
            this.btn_dkKham.ImageList = this.IconList;
            this.btn_dkKham.Location = new System.Drawing.Point(163, 0);
            this.btn_dkKham.Name = "btn_dkKham";
            this.btn_dkKham.Size = new System.Drawing.Size(163, 92);
            this.btn_dkKham.TabIndex = 1;
            this.btn_dkKham.Text = "Đăng ký khám";
            this.btn_dkKham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dkKham.UseVisualStyleBackColor = true;
            this.btn_dkKham.Click += new System.EventHandler(this.btn_dkKham_Click);
            // 
            // btn_dsKham
            // 
            this.btn_dsKham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_dsKham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dsKham.ImageKey = "1433576067_preferences-contact-list.ico";
            this.btn_dsKham.ImageList = this.IconList;
            this.btn_dsKham.Location = new System.Drawing.Point(0, 0);
            this.btn_dsKham.Name = "btn_dsKham";
            this.btn_dsKham.Size = new System.Drawing.Size(163, 92);
            this.btn_dsKham.TabIndex = 0;
            this.btn_dsKham.Text = "DS khám bệnh";
            this.btn_dsKham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dsKham.UseVisualStyleBackColor = true;
            this.btn_dsKham.Click += new System.EventHandler(this.btn_dsKham_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 620);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 712);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Thông Tin";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dkKham;
        private System.Windows.Forms.Button btn_dsKham;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_caidat;
        private System.Windows.Forms.Button btn_thongtin;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Panel panel2;
    }
}