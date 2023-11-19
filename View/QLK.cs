using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Reflection.PortableExecutable;
using bai1.Controller;
using bai1.Model;
using bai1.Utils;
using bai1.Controller;
using bai1.Model;

namespace bai1
{
    public partial class QLK : Form
    {
        KhoController controller = new KhoController();
        Kho currentKho;
        List<Kho> dskho = new List<Kho>();

        public QLK()
        {
            InitializeComponent();
            dskho = new List<Kho>();
            controller = new KhoController();
            currentKho = new Kho();

            dtgv_kho.ColumnCount = 3;
            dtgv_kho.Columns[0].Name = "Mã kho";
            dtgv_kho.Columns[1].Name = "Tên kho";
            dtgv_kho.Columns[2].Name = "Địa chỉ";



        }
        // Sứa dữ liệu

        private void btnsua_Click(object sender, EventArgs e)
        {

        }


        // Xóa dữ liệu
        private void button4_Click(object sender, EventArgs e)
        {

        }
        // Load dữ liệu lên
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        //Thêm dữ liệu
        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            makho.Text = "";
            tenkho.Text = "";
            diachi.Text = "";
            timkiem.Text = "";
        }

        private void LoadData()
        {

            dskho.Clear();
            dskho = controller.Load();
            dtgv_kho.Rows.Clear();

            foreach (Kho k in dskho)
            {
                String[] row = { k.getMaKho(), k.getTenKho(), k.getDiaChi() };
                dtgv_kho.Rows.Add(row);
            }
        }

        private void dtgv_kho_Click(object sender, EventArgs e)
        {
            if (dtgv_kho.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = dtgv_kho.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            makho.Text = row.Cells[0].Value.ToString();
            tenkho.Text = row.Cells[1].Value.ToString();
            diachi.Text = row.Cells[2].Value.ToString();
        }

        private void dtgv_kho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (timkiem.Text == "")
            {
                // Hiển thị một thông báo lỗi.
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Thực hiện các bước tìm kiếm.
            dskho.Clear();
            dskho = controller.search(timkiem.Text);
            dtgv_kho.Rows.Clear();

            foreach (Kho k in dskho)
            {
                String[] row = { k.getMaKho(), k.getTenKho(), k.getDiaChi() };
                dtgv_kho.Rows.Add(row);
            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            bool isExist = controller.isExist(makho.Text);
            if (!isExist)
            {
                currentKho = new Kho(makho.Text, tenkho.Text, diachi.Text);
                controller.insert(currentKho);
                LoadData();
                clear();
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            currentKho = new Kho(makho.Text, tenkho.Text, diachi.Text);
            controller.Update(currentKho);
            LoadData();
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            currentKho = new Kho(makho.Text, tenkho.Text, diachi.Text);
            controller.Delete(currentKho);
            LoadData();
            clear();
        }

        private void dtgv_kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_kho.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = dtgv_kho.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            makho.Text = row.Cells[0].Value.ToString();
            tenkho.Text = row.Cells[1].Value.ToString();
            diachi.Text = row.Cells[2].Value.ToString();
        }

        private void QLK_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
