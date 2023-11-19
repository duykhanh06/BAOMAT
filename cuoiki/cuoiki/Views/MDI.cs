using cuoiki.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiki.Views
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void khoXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLX qLX = new QLX();
            qLX.ShowDialog();
        }

        private void phiếuNhậpXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungcap q = new NhaCungcap();
            q.ShowDialog();
        }

        private void phiếuNhậpXeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuNhapXe q = new PhieuNhapXe();
            q.ShowDialog();
        }
    }
}
