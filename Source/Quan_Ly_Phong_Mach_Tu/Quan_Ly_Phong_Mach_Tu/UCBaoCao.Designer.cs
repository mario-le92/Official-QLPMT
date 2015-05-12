namespace Quan_Ly_Phong_Mach_Tu
{
    partial class UCBaoCao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXemDT = new System.Windows.Forms.Button();
            this.btnDTChart = new System.Windows.Forms.Button();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.dgvDTcol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTcol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTcol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTcol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTcol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupDTNam = new System.Windows.Forms.NumericUpDown();
            this.cbDTThang = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXemT = new System.Windows.Forms.Button();
            this.btnTChart = new System.Windows.Forms.Button();
            this.dgvT = new System.Windows.Forms.DataGridView();
            this.dgvTcol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTcol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTcol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTcol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTcol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTNam = new System.Windows.Forms.NumericUpDown();
            this.cbTThang = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDTNam)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTNam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 337);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXemDT);
            this.tabPage1.Controls.Add(this.btnDTChart);
            this.tabPage1.Controls.Add(this.dgvDT);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nupDTNam);
            this.tabPage1.Controls.Add(this.cbDTThang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo Cáo Doanh Thu Theo Ngày";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXemDT
            // 
            this.btnXemDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDT.Location = new System.Drawing.Point(243, 5);
            this.btnXemDT.Name = "btnXemDT";
            this.btnXemDT.Size = new System.Drawing.Size(62, 22);
            this.btnXemDT.TabIndex = 3;
            this.btnXemDT.Text = "Xem";
            this.btnXemDT.UseVisualStyleBackColor = true;
            this.btnXemDT.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnDTChart
            // 
            this.btnDTChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDTChart.BackgroundImage = global::Quan_Ly_Phong_Mach_Tu.Properties.Resources._318_9165;
            this.btnDTChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDTChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDTChart.Location = new System.Drawing.Point(439, 6);
            this.btnDTChart.Name = "btnDTChart";
            this.btnDTChart.Size = new System.Drawing.Size(42, 21);
            this.btnDTChart.TabIndex = 4;
            this.btnDTChart.UseVisualStyleBackColor = true;
            // 
            // dgvDT
            // 
            this.dgvDT.AllowUserToAddRows = false;
            this.dgvDT.AllowUserToDeleteRows = false;
            this.dgvDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDT.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDTcol1,
            this.dgvDTcol2,
            this.dgvDTcol3,
            this.dgvDTcol4,
            this.dgvDTcol5});
            this.dgvDT.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDT.Location = new System.Drawing.Point(11, 33);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.ReadOnly = true;
            this.dgvDT.Size = new System.Drawing.Size(470, 272);
            this.dgvDT.TabIndex = 5;
            // 
            // dgvDTcol1
            // 
            this.dgvDTcol1.HeaderText = "Stt";
            this.dgvDTcol1.Name = "dgvDTcol1";
            this.dgvDTcol1.ReadOnly = true;
            this.dgvDTcol1.Width = 45;
            // 
            // dgvDTcol2
            // 
            this.dgvDTcol2.HeaderText = "Ngay";
            this.dgvDTcol2.Name = "dgvDTcol2";
            this.dgvDTcol2.ReadOnly = true;
            this.dgvDTcol2.Width = 57;
            // 
            // dgvDTcol3
            // 
            this.dgvDTcol3.HeaderText = "So Benh Nhan";
            this.dgvDTcol3.Name = "dgvDTcol3";
            this.dgvDTcol3.ReadOnly = true;
            this.dgvDTcol3.Width = 102;
            // 
            // dgvDTcol4
            // 
            this.dgvDTcol4.HeaderText = "Doanh Thu";
            this.dgvDTcol4.Name = "dgvDTcol4";
            this.dgvDTcol4.ReadOnly = true;
            this.dgvDTcol4.Width = 86;
            // 
            // dgvDTcol5
            // 
            this.dgvDTcol5.HeaderText = "Ty Le";
            this.dgvDTcol5.Name = "dgvDTcol5";
            this.dgvDTcol5.ReadOnly = true;
            this.dgvDTcol5.Width = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thang";
            // 
            // nupDTNam
            // 
            this.nupDTNam.Location = new System.Drawing.Point(177, 7);
            this.nupDTNam.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupDTNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupDTNam.Name = "nupDTNam";
            this.nupDTNam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupDTNam.Size = new System.Drawing.Size(60, 20);
            this.nupDTNam.TabIndex = 2;
            this.nupDTNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDTNam.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // cbDTThang
            // 
            this.cbDTThang.FormattingEnabled = true;
            this.cbDTThang.Items.AddRange(new object[] {
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
            this.cbDTThang.Location = new System.Drawing.Point(52, 6);
            this.cbDTThang.Name = "cbDTThang";
            this.cbDTThang.Size = new System.Drawing.Size(84, 21);
            this.cbDTThang.TabIndex = 1;
            this.cbDTThang.SelectedIndexChanged += new System.EventHandler(this.cbDTThang_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXemT);
            this.tabPage2.Controls.Add(this.btnTChart);
            this.tabPage2.Controls.Add(this.dgvT);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nupTNam);
            this.tabPage2.Controls.Add(this.cbTThang);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo Cáo Sử Dụng Thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXemT
            // 
            this.btnXemT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemT.Location = new System.Drawing.Point(243, 5);
            this.btnXemT.Name = "btnXemT";
            this.btnXemT.Size = new System.Drawing.Size(62, 22);
            this.btnXemT.TabIndex = 3;
            this.btnXemT.Text = "Xem";
            this.btnXemT.UseVisualStyleBackColor = true;
            this.btnXemT.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTChart
            // 
            this.btnTChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTChart.BackgroundImage = global::Quan_Ly_Phong_Mach_Tu.Properties.Resources._318_9165;
            this.btnTChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTChart.Location = new System.Drawing.Point(439, 6);
            this.btnTChart.Name = "btnTChart";
            this.btnTChart.Size = new System.Drawing.Size(42, 21);
            this.btnTChart.TabIndex = 4;
            this.btnTChart.UseVisualStyleBackColor = true;
            // 
            // dgvT
            // 
            this.dgvT.AllowUserToAddRows = false;
            this.dgvT.AllowUserToDeleteRows = false;
            this.dgvT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvT.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTcol1,
            this.dgvTcol2,
            this.dgvTcol3,
            this.dgvTcol4,
            this.dgvTcol5});
            this.dgvT.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvT.Location = new System.Drawing.Point(11, 33);
            this.dgvT.Name = "dgvT";
            this.dgvT.ReadOnly = true;
            this.dgvT.Size = new System.Drawing.Size(470, 272);
            this.dgvT.TabIndex = 5;
            // 
            // dgvTcol1
            // 
            this.dgvTcol1.HeaderText = "Stt";
            this.dgvTcol1.Name = "dgvTcol1";
            this.dgvTcol1.ReadOnly = true;
            this.dgvTcol1.Width = 45;
            // 
            // dgvTcol2
            // 
            this.dgvTcol2.HeaderText = "Thuoc";
            this.dgvTcol2.Name = "dgvTcol2";
            this.dgvTcol2.ReadOnly = true;
            this.dgvTcol2.Width = 63;
            // 
            // dgvTcol3
            // 
            this.dgvTcol3.HeaderText = "Don Vi Tinh";
            this.dgvTcol3.Name = "dgvTcol3";
            this.dgvTcol3.ReadOnly = true;
            this.dgvTcol3.Width = 88;
            // 
            // dgvTcol4
            // 
            this.dgvTcol4.HeaderText = "So Luong";
            this.dgvTcol4.Name = "dgvTcol4";
            this.dgvTcol4.ReadOnly = true;
            this.dgvTcol4.Width = 78;
            // 
            // dgvTcol5
            // 
            this.dgvTcol5.HeaderText = "So Lan Dung";
            this.dgvTcol5.Name = "dgvTcol5";
            this.dgvTcol5.ReadOnly = true;
            this.dgvTcol5.Width = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thang";
            // 
            // nupTNam
            // 
            this.nupTNam.Location = new System.Drawing.Point(177, 7);
            this.nupTNam.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nupTNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupTNam.Name = "nupTNam";
            this.nupTNam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupTNam.Size = new System.Drawing.Size(60, 20);
            this.nupTNam.TabIndex = 2;
            this.nupTNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupTNam.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // cbTThang
            // 
            this.cbTThang.FormattingEnabled = true;
            this.cbTThang.Items.AddRange(new object[] {
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
            this.cbTThang.Location = new System.Drawing.Point(52, 6);
            this.cbTThang.Name = "cbTThang";
            this.cbTThang.Size = new System.Drawing.Size(84, 21);
            this.cbTThang.TabIndex = 1;
            // 
            // UCBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCBaoCao";
            this.Size = new System.Drawing.Size(503, 343);
            this.Load += new System.EventHandler(this.UCBaoCao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDTNam)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDTChart;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTcol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTcol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTcol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTcol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTcol5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupDTNam;
        private System.Windows.Forms.ComboBox cbDTThang;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTChart;
        private System.Windows.Forms.DataGridView dgvT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTcol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTcol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTcol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTcol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTcol5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTNam;
        private System.Windows.Forms.ComboBox cbTThang;
        private System.Windows.Forms.Button btnXemDT;
        private System.Windows.Forms.Button btnXemT;

    }
}
