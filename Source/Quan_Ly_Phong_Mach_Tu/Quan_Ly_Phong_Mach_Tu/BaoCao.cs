using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Mach_Tu
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
            //UCBaoCao a = new UCBaoCao();
            BaoCaoUserControl a = new BaoCaoUserControl();
            panel1.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            //a.BaoCao_Load();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }
    }

}
