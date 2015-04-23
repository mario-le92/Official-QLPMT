using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_PMT_yta.usercontrols;

namespace QL_PMT_yta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Danh_sach_dang_ky_kham main = new Danh_sach_dang_ky_kham();
            main.Dock = DockStyle.Bottom;

            this.Controls.Add(main);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_danhsachdkkham_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);

            Danh_sach_dang_ky_kham main = new Danh_sach_dang_ky_kham();
            main.Dock = DockStyle.Bottom;

            this.Controls.Add(main);
        }

        private void btn_thembenhnhan_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);

            Them_Benh_Nhan main = new Them_Benh_Nhan();
            main.Dock = DockStyle.Bottom;

            this.Controls.Add(main);
        }
    }
}
