using bai1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLK q = new QLK();
            q.ShowDialog();
        }

        private void phiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapKho p = new PhieuNhapKho();
            p.ShowDialog();
        }
    }
}
