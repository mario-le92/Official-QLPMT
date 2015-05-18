namespace QL_PMT_yta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_thembenhnhan = new System.Windows.Forms.Button();
            this.btn_danhsachdkkham = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_thembenhnhan);
            this.panel1.Controls.Add(this.btn_danhsachdkkham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 80);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(200, 0);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 80);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_thembenhnhan
            // 
            this.btn_thembenhnhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_thembenhnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thembenhnhan.Location = new System.Drawing.Point(100, 0);
            this.btn_thembenhnhan.Name = "btn_thembenhnhan";
            this.btn_thembenhnhan.Size = new System.Drawing.Size(100, 80);
            this.btn_thembenhnhan.TabIndex = 1;
            this.btn_thembenhnhan.Text = "Thêm bệnh nhân";
            this.btn_thembenhnhan.UseVisualStyleBackColor = true;
            this.btn_thembenhnhan.Click += new System.EventHandler(this.btn_thembenhnhan_Click);
            // 
            // btn_danhsachdkkham
            // 
            this.btn_danhsachdkkham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_danhsachdkkham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_danhsachdkkham.Location = new System.Drawing.Point(0, 0);
            this.btn_danhsachdkkham.Name = "btn_danhsachdkkham";
            this.btn_danhsachdkkham.Size = new System.Drawing.Size(100, 80);
            this.btn_danhsachdkkham.TabIndex = 0;
            this.btn_danhsachdkkham.Text = "Danh sách đăng ký khám";
            this.btn_danhsachdkkham.UseVisualStyleBackColor = true;
            this.btn_danhsachdkkham.Click += new System.EventHandler(this.btn_danhsachdkkham_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 569);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Phong mach tu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_danhsachdkkham;
        private System.Windows.Forms.Button btn_thembenhnhan;
    }
}

