namespace Quan_Ly_Phong_Mach_Tu
{
    partial class ThayDoiNDS
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSLCu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So Luong Cu";
            // 
            // lbSLCu
            // 
            this.lbSLCu.AutoSize = true;
            this.lbSLCu.Location = new System.Drawing.Point(171, 9);
            this.lbSLCu.Name = "lbSLCu";
            this.lbSLCu.Size = new System.Drawing.Size(35, 13);
            this.lbSLCu.TabIndex = 1;
            this.lbSLCu.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "So Luong Moi";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(91, 32);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(115, 20);
            this.tbSoLuong.TabIndex = 2;
            this.tbSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            this.tbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(131, 58);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(15, 58);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ThayDoiNDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 92);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.lbSLCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(234, 126);
            this.MinimumSize = new System.Drawing.Size(234, 126);
            this.Name = "ThayDoiNDS";
            this.Text = "Thay doi so luong benh nhan kham";
            this.Load += new System.EventHandler(this.ThayDoiNDS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSLCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}