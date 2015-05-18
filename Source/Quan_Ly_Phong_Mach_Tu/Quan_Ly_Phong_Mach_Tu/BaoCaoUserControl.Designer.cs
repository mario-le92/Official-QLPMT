namespace Quan_Ly_Phong_Mach_Tu
{
    partial class BaoCaoUserControl
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
            this.crvBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupNam = new System.Windows.Forms.NumericUpDown();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnRF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNam)).BeginInit();
            this.SuspendLayout();
            // 
            // crvBaoCao
            // 
            this.crvBaoCao.ActiveViewIndex = -1;
            this.crvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.crvBaoCao.Name = "crvBaoCao";
            this.crvBaoCao.Size = new System.Drawing.Size(659, 442);
            this.crvBaoCao.TabIndex = 0;
            this.crvBaoCao.Load += new System.EventHandler(this.crvBaoCao_Load);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Location = new System.Drawing.Point(294, 3);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(75, 23);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crvBaoCao);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 442);
            this.panel1.TabIndex = 2;
            // 
            // btnThuoc
            // 
            this.btnThuoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThuoc.FlatAppearance.BorderSize = 0;
            this.btnThuoc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuoc.Location = new System.Drawing.Point(375, 3);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnThuoc.TabIndex = 3;
            this.btnThuoc.Text = "Thuoc";
            this.btnThuoc.UseVisualStyleBackColor = false;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thang";
            // 
            // nupNam
            // 
            this.nupNam.Location = new System.Drawing.Point(172, 6);
            this.nupNam.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupNam.Name = "nupNam";
            this.nupNam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupNam.Size = new System.Drawing.Size(60, 20);
            this.nupNam.TabIndex = 6;
            this.nupNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupNam.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "Thang 1",
            "Thang 2",
            "Thang 3",
            "Thang 4",
            "Thang 5",
            "Thang 6",
            "Thang 7",
            "Thang 8",
            "Thang 9",
            "Thang 10",
            "Thang 11",
            "Thang 12"});
            this.cbThang.Location = new System.Drawing.Point(47, 5);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(84, 21);
            this.cbThang.TabIndex = 5;
            // 
            // btnRF
            // 
            this.btnRF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRF.FlatAppearance.BorderSize = 0;
            this.btnRF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRF.Location = new System.Drawing.Point(238, 3);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(50, 23);
            this.btnRF.TabIndex = 1;
            this.btnRF.Text = "Xem";
            this.btnRF.UseVisualStyleBackColor = false;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // BaoCaoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.btnThuoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRF);
            this.Controls.Add(this.btnDoanhThu);
            this.Name = "BaoCaoUserControl";
            this.Size = new System.Drawing.Size(659, 471);
            this.Load += new System.EventHandler(this.BaoCaoUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCao;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnRF;

    }
}
