using cuoiki.Controller;
using cuoiki.Model;
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
    public partial class PhieuNhapXe : Form
    {
        BangXeController bangxeController;
        NCCController nhaccController;
        List<BangXe> dsxe;
        List<Nhacungcap> dsnhacc;
        Chitietnhap currentctn;
        PhieuNhap currentpn;
        ChitietnhapController ctnController;
        PhieuNhapController pnController;
        List<Chitietnhap> chiTietNhap;
        List<PhieuNhap> phieuNhap;

        public PhieuNhapXe()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dsxe = new List<BangXe>();
            bangxeController = new BangXeController();
            dsxe = bangxeController.Load();

            dsnhacc = new List<Nhacungcap>();
            nhaccController = new NCCController();
            dsnhacc = nhaccController.Load();

            currentctn = new Chitietnhap();
            currentpn = new PhieuNhap();

            ctnController = new ChitietnhapController();
            pnController = new PhieuNhapController();

            chiTietNhap = new List<Chitietnhap>();
            phieuNhap = new List<PhieuNhap>();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhapXe_Load(object sender, EventArgs e)
        {
            dsnhacc = new List<Nhacungcap>();
            nhaccController = new NCCController();
            dsnhacc = nhaccController.Load();

            dsxe = new List<BangXe>();
            bangxeController = new BangXeController();
            dsxe = bangxeController.Load();

            foreach (BangXe k in dsxe)
            {
                combomncc.Items.Add(k.getMaxe());
            }
            DataGridViewComboBoxColumn comboBoxColumn;
            comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "name";
            comboBoxColumn.HeaderText = "Mã xe";
            comboBoxColumn.DropDownWidth = 150;
            comboBoxColumn.Width = 90;
            comboBoxColumn.MaxDropDownItems = 3;
            comboBoxColumn.FlatStyle = FlatStyle.Flat;
            foreach (BangXe k in dsxe)
            {
                comboBoxColumn.Items.Add(k.getMaxe());
            }
            dataGridChitiet.Columns.Clear();
            dataGridChitiet.Columns.Add(comboBoxColumn);
            //Tên hàng
            DataGridViewTextBoxColumn colTenxe = new DataGridViewTextBoxColumn();
            colTenxe.DataPropertyName = "TenXe";
            colTenxe.HeaderText = "Tên Xe";
            dataGridChitiet.Columns.Add(colTenxe);

            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            dataGridChitiet.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            dataGridChitiet.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            dataGridChitiet.Columns.Add(colThanhTien);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                String id = dataGridChitiet.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dataGridChitiet.Rows[e.RowIndex].Cells[1].Value = bangxeController.get(id).tenxe;
                //dataGridChitiet.Rows[e.RowIndex].Cells[2].Value = bangxeController.get(id).soluong;


            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(dataGridChitiet.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
                int dg = int.Parse(dataGridChitiet.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                dataGridChitiet.Rows[e.RowIndex].Cells[4].Value = sl * dg;

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //1.Lưu chi tiết chi tiết phiếu nhập
            currentpn = new PhieuNhap(sp.Text, mpn.Text, Convert.ToDateTime(ng.Text), (combomncc.Text));
            bool check = pnController.insert(currentpn);
            if (check)
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            //2. Lưu chi tiết phiếu nhập
            for (int i = 0; i < dataGridChitiet.Rows.Count - 1; i++)
            {
                Chitietnhap ct = new Chitietnhap();
                ct.setmaphieunhap(sp.Text);
                ct.setmaxe(dataGridChitiet.Rows[i].Cells[0].Value.ToString());
                ct.setsoluongnhap(Convert.ToInt32(dataGridChitiet.Rows[i].Cells[2].Value.ToString()));
                ct.setgianhap(Convert.ToInt32(dataGridChitiet.Rows[i].Cells[3].Value.ToString()));
                ctnController.insert(ct);
            }
            clear();
            dataGridChitiet.Rows.Clear();
        }


        public void clear()
        {
            sp.Text = "";
            mpn.Text = "";
            ng.Text = "";
            combomncc.Text = "";

        }

        private void dataGridChitiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String id = dataGridChitiet.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dataGridChitiet.Rows[e.RowIndex].Cells[1].Value = bangxeController.get(id).tenxe;
                dataGridChitiet.Rows[e.RowIndex].Cells[2].Value = bangxeController.get(id).soluong;


            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 3)
            {
                int sl = int.Parse(dataGridChitiet.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
                int dg = int.Parse(dataGridChitiet.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                dataGridChitiet.Rows[e.RowIndex].Cells[4].Value = sl * dg;

            }



        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridChitiet_Click(object sender, EventArgs e)
        {

        }
    }
}
