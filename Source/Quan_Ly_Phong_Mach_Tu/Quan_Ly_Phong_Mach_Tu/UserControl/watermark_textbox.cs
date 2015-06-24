using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class watermark_textbox : UserControl
    {
        //public data members.
        public string txt_value
        {
            set
            {
                txt_input.Text = value;
            }

            get
            {
                return txt_input.Text;
            }
        }

        //public behaviours.
        public Func<bool> searchable;

        public Func<List<string>> finding;

        public Func<bool> do_some_after_leaving;

        public watermark_textbox()
        {
            InitializeComponent();
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {            
            txt_value = txt_input.Text;

            if (searchable()) //kiem tra thong tin nhap vao dung khong?
            {
                if (txt_input.Focused)
                {
                    lst_result.DataSource = null;
                    lst_result.DataSource = finding();

                    lst_result.Enabled = true;
                    lst_result.Size = /* cbx size=(no. of items+1)*(the height of an item) */
                        new Size(this.Width, lst_result.ItemHeight * (lst_result.Items.Count + 1));
                    this.Size = new Size(this.Width, lst_result.Bottom);
                }
            }
            else
            {
                lst_result.Enabled = false;
                this.Size = new Size(this.Width, txt_input.Height);
            }
        }

        private void lst_result_DoubleClick(object sender, EventArgs e)
        {
            txt_input.Text = lst_result.SelectedItem.ToString();

            lst_result.Enabled = false;
            this.Size = new Size(this.Width, txt_input.Height);

            SendKeys.Send("{END}");
        }

        private void watermark_textbox_Load(object sender, EventArgs e)
        {
            txt_input.Text = "";

            txt_input.Top = -1;
            txt_input.Left = -1;
            txt_input.Size = new Size(this.Width, txt_input.Height);

            lst_result.Left = -1;
            lst_result.Top = txt_input.Bottom;
            lst_result.Size = new Size(this.Width, lst_result.Height);

            this.Size = new Size(this.Width, txt_input.Height);
            lst_result.Enabled = false;
                        
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    lst_result.Focus();

                    if (lst_result.SelectedIndex != lst_result.Items.Count - 1)
                    {
                        lst_result.SelectedIndex = lst_result.SelectedIndex + 1;
                    }
                    break;

                case Keys.Up:
                    lst_result.Focus();

                    if (lst_result.SelectedIndex > 0)
                    {
                        lst_result.SelectedIndex = lst_result.SelectedIndex - 1;
                    }
                    break;

                case Keys.Enter:
                    lst_result_DoubleClick(null, null);

                    SendKeys.Send("{TAB}");

                    SendKeys.Send("{END}");
                    break;
            }
        }

        private void lst_result_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                if (lst_result.Items.Count != 0)
                {
                    //txt_input.Text = lst_result.SelectedItem.ToString();
                    //lst_result.Enabled = false;
                    //this.Size = new Size(this.Width, txt_input.Bottom);                    

                    //SendKeys.Send("{END}");

                    lst_result_DoubleClick(null, null);             
                }
            }
        }

        public void refresh()
        {
            txt_input.Text = "";
        }

        private void watermark_textbox_Leave(object sender, EventArgs e)
        {
            try { do_some_after_leaving(); }
            catch { } 

        }

        public void disable_popup()
        {
            lst_result.Enabled = false;
            lst_result.Size = new Size(lst_result.Width, 0);
            this.Size = new Size(this.Width, txt_input.Height);
        }
    }
}