using bai1.Controller;
using bai1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1.View
{
    public partial class PhieuNhapKho : Form
    {
        KhoController khoController;
        HanghoaController hanghoaController;
        List<Kho> dskho;
        List<Hanghoa> dshanghoa;
        ChiTietNhap currentctn;
        PhieuNhap currentpn;
        ChiTietNhapController ctnController;
        PhieuNhapController pnController;
        List<ChiTietNhap> chiTietNhap;
        List<PhieuNhap> phieuNhap;
        public PhieuNhapKho()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dskho = new List<Kho>();
            khoController = new KhoController();
            dskho = khoController.Load();

            dshanghoa = new List<Hanghoa>();
            hanghoaController = new HanghoaController();
            dshanghoa = hanghoaController.Load();

            currentctn = new ChiTietNhap();
            currentpn = new PhieuNhap();

            ctnController = new ChiTietNhapController();
            pnController = new PhieuNhapController();

            chiTietNhap = new List<ChiTietNhap>();
            phieuNhap = new List<PhieuNhap>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dskho = new List<Kho>();
            khoController = new KhoController();
            dskho = khoController.Load();
            dshanghoa = new List<Hanghoa>();
            hanghoaController = new HanghoaController();
            dshanghoa = hanghoaController.Load();

            foreach (Kho k in dskho)
            {
                combomakho.Items.Add(k.getMaKho());
            }
            DataGridViewComboBoxColumn comboBoxColumn;
            comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "name";
            comboBoxColumn.HeaderText = "Mã hàng hóa";
            comboBoxColumn.DropDownWidth = 150;
            comboBoxColumn.Width = 90;
            comboBoxColumn.MaxDropDownItems = 3;
            comboBoxColumn.FlatStyle = FlatStyle.Flat;
            foreach (Hanghoa k in dshanghoa)
            {
                comboBoxColumn.Items.Add(k.getmahanghoa());
            }
            dgDetails.Columns.Clear();
            dgDetails.Columns.Add(comboBoxColumn);
            //Tên hàng
            DataGridViewTextBoxColumn colTenhang = new DataGridViewTextBoxColumn();
            colTenhang.DataPropertyName = "TenHangHoa";
            colTenhang.HeaderText = "Tên Hàng";
            dgDetails.Columns.Add(colTenhang);
            //Đơn vị tính
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "DVT";
            colDVT.HeaderText = "Đơn vị tính";
            dgDetails.Columns.Add(colDVT);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            dgDetails.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            dgDetails.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            dgDetails.Columns.Add(colThanhTien);
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dgDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                String id = dgDetails.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dgDetails.Rows[e.RowIndex].Cells[1].Value = hanghoaController.get(id).tenhanghoa;
                dgDetails.Rows[e.RowIndex].Cells[2].Value = hanghoaController.get(id).dvt;


            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(dgDetails.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int dg = int.Parse(dgDetails.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                dgDetails.Rows[e.RowIndex].Cells[5].Value = sl * dg;

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //1.Lưu chi tiết chi tiết phiếu nhập
            currentpn = new PhieuNhap(sp.Text, Convert.ToDateTime(ng.Text), ngg.Text, shd.Text, Convert.ToDateTime(nghd.Text), donviph.Text, Convert.ToInt32(combomakho.Text));
            bool check = pnController.insert(currentpn);
            if (check)
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            //2. Lưu chi tiết phiếu nhập
            for (int i = 0; i < dgDetails.Rows.Count - 1; i++)
            {
                ChiTietNhap ct = new ChiTietNhap();
                ct.setmaphieunhap(sp.Text);
                ct.setmahanghoa(dgDetails.Rows[i].Cells[0].Value.ToString());
                ct.setsoluong(Convert.ToInt32(dgDetails.Rows[i].Cells[3].Value.ToString()));
                ct.setdongia(Convert.ToInt32(dgDetails.Rows[i].Cells[4].Value.ToString()));
                ctnController.insert(ct);
            }
            clear();
            dgDetails.Rows.Clear();
        }

        private void sp_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Hiển thị thông tin phiếu nhập
                DataTable dtPhieuNhap = pnController.getPhieuNhap(sp.Text);

                //2. Hiển thị thông tin phiếu nhập lên các textbox
                ng.Text = dtPhieuNhap.Rows[0]["NgayNhapPhieu"].ToString();
                ngg.Text = dtPhieuNhap.Rows[0]["NguoiGiao"].ToString();
                shd.Text = dtPhieuNhap.Rows[0]["SoHoaDon"].ToString();
                nghd.Text = dtPhieuNhap.Rows[0]["NgayHoaDon"].ToString();
                donviph.Text = dtPhieuNhap.Rows[0]["DonViPhatHangHoaDon"].ToString();
                combomakho.Text = dtPhieuNhap.Rows[0]["MaKho"].ToString();



                String keyword = sp.Text;

                // Gọi phương thức tìm kiếm
                List<ChiTietNhap> results;
                results = ctnController.search(keyword);
                // Load kết quả vào DataGridView
                dgDetails.DataSource = results;

            }
        }
        public void clear()
        {
            sp.Text = "";
            ng.Text = "";
            ngg.Text = "";
            shd.Text = "";
            ngayhd.Text = "";
            donviph.Text = "";
            combomakho.Text = "";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                String id = dgDetails.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dgDetails.Rows[e.RowIndex].Cells[1].Value = hanghoaController.get(id).tenhanghoa;
                dgDetails.Rows[e.RowIndex].Cells[2].Value = hanghoaController.get(id).dvt;


            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(dgDetails.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int dg = int.Parse(dgDetails.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                dgDetails.Rows[e.RowIndex].Cells[5].Value = sl * dg;

            }
        }

        private void PhieuNhapKho_Load(object sender, EventArgs e)
        {

        }

        private void dgDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
