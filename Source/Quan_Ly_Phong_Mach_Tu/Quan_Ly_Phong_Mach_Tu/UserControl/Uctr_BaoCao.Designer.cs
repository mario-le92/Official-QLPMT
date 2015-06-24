namespace Quan_Ly_Phong_Mach_Tu
{
    partial class Uctr_BaoCao
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
            this.pnCRContainer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupNamTu = new System.Windows.Forms.NumericUpDown();
            this.cmbxThangTu = new System.Windows.Forms.ComboBox();
            this.btnRF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupNamToi = new System.Windows.Forms.NumericUpDown();
            this.cmbxThangToi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbxToi = new System.Windows.Forms.CheckBox();
            this.rbtnDoanhThu = new System.Windows.Forms.RadioButton();
            this.rbtnSDThuoc = new System.Windows.Forms.RadioButton();
            this.pnCRContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNamTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNamToi)).BeginInit();
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
            this.crvBaoCao.Size = new System.Drawing.Size(980, 484);
            this.crvBaoCao.TabIndex = 0;
            this.crvBaoCao.Load += new System.EventHandler(this.crvBaoCao_Load);
            // 
            // pnCRContainer
            // 
            this.pnCRContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCRContainer.Controls.Add(this.crvBaoCao);
            this.pnCRContainer.Location = new System.Drawing.Point(0, 59);
            this.pnCRContainer.Name = "pnCRContainer";
            this.pnCRContainer.Size = new System.Drawing.Size(980, 484);
            this.pnCRContainer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng";
            // 
            // nupNamTu
            // 
            this.nupNamTu.Location = new System.Drawing.Point(243, 6);
            this.nupNamTu.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupNamTu.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupNamTu.Name = "nupNamTu";
            this.nupNamTu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupNamTu.Size = new System.Drawing.Size(60, 20);
            this.nupNamTu.TabIndex = 1;
            this.nupNamTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupNamTu.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupNamTu.ValueChanged += new System.EventHandler(this.nupNamTu_ValueChanged);
            // 
            // cmbxThangTu
            // 
            this.cmbxThangTu.FormattingEnabled = true;
            this.cmbxThangTu.Items.AddRange(new object[] {
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
            this.cmbxThangTu.Location = new System.Drawing.Point(118, 5);
            this.cmbxThangTu.Name = "cmbxThangTu";
            this.cmbxThangTu.Size = new System.Drawing.Size(84, 21);
            this.cmbxThangTu.TabIndex = 0;
            this.cmbxThangTu.SelectedIndexChanged += new System.EventHandler(this.cmbxThangTu_SelectedIndexChanged);
            // 
            // btnRF
            // 
            this.btnRF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRF.Location = new System.Drawing.Point(440, 13);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(68, 30);
            this.btnRF.TabIndex = 7;
            this.btnRF.Text = "Xem";
            this.btnRF.UseVisualStyleBackColor = false;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tháng";
            // 
            // nupNamToi
            // 
            this.nupNamToi.Location = new System.Drawing.Point(243, 33);
            this.nupNamToi.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupNamToi.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupNamToi.Name = "nupNamToi";
            this.nupNamToi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupNamToi.Size = new System.Drawing.Size(60, 20);
            this.nupNamToi.TabIndex = 4;
            this.nupNamToi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupNamToi.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupNamToi.ValueChanged += new System.EventHandler(this.nupNamToi_ValueChanged);
            // 
            // cmbxThangToi
            // 
            this.cmbxThangToi.FormattingEnabled = true;
            this.cmbxThangToi.Items.AddRange(new object[] {
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
            this.cmbxThangToi.Location = new System.Drawing.Point(118, 32);
            this.cmbxThangToi.Name = "cmbxThangToi";
            this.cmbxThangToi.Size = new System.Drawing.Size(84, 21);
            this.cmbxThangToi.TabIndex = 3;
            this.cmbxThangToi.SelectedIndexChanged += new System.EventHandler(this.cmbxThangToi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Từ";
            // 
            // ckbxToi
            // 
            this.ckbxToi.AutoSize = true;
            this.ckbxToi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxToi.Checked = true;
            this.ckbxToi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxToi.Location = new System.Drawing.Point(6, 34);
            this.ckbxToi.Name = "ckbxToi";
            this.ckbxToi.Size = new System.Drawing.Size(41, 17);
            this.ckbxToi.TabIndex = 2;
            this.ckbxToi.Text = "Tới";
            this.ckbxToi.UseVisualStyleBackColor = true;
            this.ckbxToi.CheckedChanged += new System.EventHandler(this.cbToi_CheckedChanged);
            // 
            // rbtnDoanhThu
            // 
            this.rbtnDoanhThu.AutoSize = true;
            this.rbtnDoanhThu.Checked = true;
            this.rbtnDoanhThu.Location = new System.Drawing.Point(326, 8);
            this.rbtnDoanhThu.Name = "rbtnDoanhThu";
            this.rbtnDoanhThu.Size = new System.Drawing.Size(79, 17);
            this.rbtnDoanhThu.TabIndex = 5;
            this.rbtnDoanhThu.TabStop = true;
            this.rbtnDoanhThu.Text = "Doanh Thu";
            this.rbtnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // rbtnSDThuoc
            // 
            this.rbtnSDThuoc.AutoSize = true;
            this.rbtnSDThuoc.Location = new System.Drawing.Point(326, 31);
            this.rbtnSDThuoc.Name = "rbtnSDThuoc";
            this.rbtnSDThuoc.Size = new System.Drawing.Size(101, 17);
            this.rbtnSDThuoc.TabIndex = 6;
            this.rbtnSDThuoc.Text = "Sử Dụng Thuốc";
            this.rbtnSDThuoc.UseVisualStyleBackColor = true;
            // 
            // Uctr_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.rbtnSDThuoc);
            this.Controls.Add(this.rbtnDoanhThu);
            this.Controls.Add(this.ckbxToi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupNamToi);
            this.Controls.Add(this.cmbxThangToi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupNamTu);
            this.Controls.Add(this.cmbxThangTu);
            this.Controls.Add(this.pnCRContainer);
            this.Controls.Add(this.btnRF);
            this.Name = "Uctr_BaoCao";
            this.Size = new System.Drawing.Size(980, 540);
            this.Load += new System.EventHandler(this.BaoCaoUserControl_Load);
            this.pnCRContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNamTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNamToi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCao;
        private System.Windows.Forms.Panel pnCRContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNamTu;
        private System.Windows.Forms.ComboBox cmbxThangTu;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupNamToi;
        private System.Windows.Forms.ComboBox cmbxThangToi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbxToi;
        private System.Windows.Forms.RadioButton rbtnDoanhThu;
        private System.Windows.Forms.RadioButton rbtnSDThuoc;

    }
}
