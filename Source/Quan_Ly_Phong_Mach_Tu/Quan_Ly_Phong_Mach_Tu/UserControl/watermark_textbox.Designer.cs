namespace Quan_Ly_Phong_Mach_Tu
{
    partial class watermark_textbox
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lst_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(36, 12);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(198, 23);
            this.txt_input.TabIndex = 0;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            
            // 
            // lst_result
            // 
            this.lst_result.Enabled = false;
            this.lst_result.FormattingEnabled = true;
            this.lst_result.ItemHeight = 16;
            this.lst_result.Location = new System.Drawing.Point(36, 42);
            this.lst_result.Name = "lst_result";
            this.lst_result.Size = new System.Drawing.Size(198, 180);
            this.lst_result.TabIndex = 999;
            this.lst_result.DoubleClick += new System.EventHandler(this.lst_result_DoubleClick);
            this.lst_result.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lst_result_PreviewKeyDown);
            // 
            // watermark_textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lst_result);
            this.Controls.Add(this.txt_input);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "watermark_textbox";
            this.Size = new System.Drawing.Size(271, 238);
            this.Load += new System.EventHandler(this.watermark_textbox_Load);
            this.Leave += new System.EventHandler(this.watermark_textbox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.ListBox lst_result;
    }
}
