namespace Quan_Ly_Phong_Mach_Tu
{
    partial class ThongTinPhongKham
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
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxDGMoi = new System.Windows.Forms.TextBox();
            this.lbDGCu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng cũ";
            // 
            // lbSLCu
            // 
            this.lbSLCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSLCu.Location = new System.Drawing.Point(92, 23);
            this.lbSLCu.Name = "lbSLCu";
            this.lbSLCu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbSLCu.Size = new System.Drawing.Size(115, 13);
            this.lbSLCu.TabIndex = 1;
            this.lbSLCu.Text = "40";
            this.lbSLCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng mới";
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(82, 46);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxSoLuong.Size = new System.Drawing.Size(122, 22);
            this.tbxSoLuong.TabIndex = 2;
            this.tbxSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            this.tbxSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(396, 94);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 29);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(315, 94);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbSLCu);
            this.groupBox1.Controls.Add(this.tbxSoLuong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng bệnh nhân khám một ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxDGMoi);
            this.groupBox2.Controls.Add(this.lbDGCu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(241, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đơn giá khám bệnh";
            // 
            // tbxDGMoi
            // 
            this.tbxDGMoi.Location = new System.Drawing.Point(75, 46);
            this.tbxDGMoi.Name = "tbxDGMoi";
            this.tbxDGMoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxDGMoi.Size = new System.Drawing.Size(146, 22);
            this.tbxDGMoi.TabIndex = 1;
            this.tbxDGMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            // 
            // lbDGCu
            // 
            this.lbDGCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDGCu.Location = new System.Drawing.Point(79, 23);
            this.lbDGCu.Name = "lbDGCu";
            this.lbDGCu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDGCu.Size = new System.Drawing.Size(145, 13);
            this.lbDGCu.TabIndex = 0;
            this.lbDGCu.Text = "30,000";
            this.lbDGCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá cũ";
            // 
            // ThongTinPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 131);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinPhongKham";
            this.Text = "Thông tin phòng khám";
            this.Load += new System.EventHandler(this.ThayDoiNDS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSLCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxDGMoi;
        private System.Windows.Forms.Label lbDGCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}