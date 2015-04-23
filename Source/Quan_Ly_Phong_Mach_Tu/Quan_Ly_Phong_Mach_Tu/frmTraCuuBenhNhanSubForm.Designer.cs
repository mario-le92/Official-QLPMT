namespace Quan_Ly_Phong_Mach_Tu
{
    partial class frmTraCuuBenhNhanSubForm
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstDanhSachTrieuChung = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(39, 215);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(100, 28);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "xong";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(147, 215);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstDanhSachTrieuChung
            // 
            this.lstDanhSachTrieuChung.FormattingEnabled = true;
            this.lstDanhSachTrieuChung.ItemHeight = 16;
            this.lstDanhSachTrieuChung.Location = new System.Drawing.Point(12, 12);
            this.lstDanhSachTrieuChung.Name = "lstDanhSachTrieuChung";
            this.lstDanhSachTrieuChung.ScrollAlwaysVisible = true;
            this.lstDanhSachTrieuChung.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSachTrieuChung.Size = new System.Drawing.Size(260, 196);
            this.lstDanhSachTrieuChung.TabIndex = 2;
            this.lstDanhSachTrieuChung.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachTrieuChung_SelectedIndexChanged);
            // 
            // frmTraCuuBenhNhanSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.lstDanhSachTrieuChung);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuBenhNhanSubForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTraCuuBenhNhanSubForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTraCuuBenhNhanSubForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstDanhSachTrieuChung;
    }
}