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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSachKhamBenhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUISwitch = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachKhamBenhToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.thongTinThuocToolStripMenuItem,
            this.baoCaoToolStripMenuItem});
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
            this.danhSachKhamBenhToolStripMenuItem.Click += new System.EventHandler(this.danhSachKhamBenhToolStripMenuItem_Click);
            // 
            // traCuuToolStripMenuItem
            // 
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.traCuuToolStripMenuItem.Text = "Tra cuu";
            this.traCuuToolStripMenuItem.Click += new System.EventHandler(this.traCuuToolStripMenuItem_Click);
            // 
            // thongTinThuocToolStripMenuItem
            // 
            this.thongTinThuocToolStripMenuItem.Name = "thongTinThuocToolStripMenuItem";
            this.thongTinThuocToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.thongTinThuocToolStripMenuItem.Text = "Thong tin thuoc";
            this.thongTinThuocToolStripMenuItem.Click += new System.EventHandler(this.thongTinThuocToolStripMenuItem_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.baoCaoToolStripMenuItem.Text = "Bao cao";
            this.baoCaoToolStripMenuItem.Click += new System.EventHandler(this.baoCaoToolStripMenuItem_Click);
            // 
            // pnUISwitch
            // 
            this.pnUISwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUISwitch.Location = new System.Drawing.Point(0, 24);
            this.pnUISwitch.Name = "pnUISwitch";
            this.pnUISwitch.Size = new System.Drawing.Size(844, 447);
            this.pnUISwitch.TabIndex = 3;
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 471);
            this.Controls.Add(this.pnUISwitch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DanhSachKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Sach Kham Benh";
            this.Load += new System.EventHandler(this.DanhSachKhamBenh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachKhamBenhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinThuocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.Panel pnUISwitch;
    }
}

