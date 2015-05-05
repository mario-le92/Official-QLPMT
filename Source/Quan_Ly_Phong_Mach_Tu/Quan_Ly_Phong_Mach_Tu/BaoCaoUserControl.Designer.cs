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
            this.panel1.SuspendLayout();
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
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Location = new System.Drawing.Point(3, 3);
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
            this.btnThuoc.Location = new System.Drawing.Point(84, 3);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnThuoc.TabIndex = 3;
            this.btnThuoc.Text = "Thuoc";
            this.btnThuoc.UseVisualStyleBackColor = false;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // BaoCaoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThuoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDoanhThu);
            this.Name = "BaoCaoUserControl";
            this.Size = new System.Drawing.Size(659, 471);
            this.Load += new System.EventHandler(this.BaoCaoUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCao;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThuoc;

    }
}
