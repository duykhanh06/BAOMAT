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
using cuoiki.Controller;
using cuoiki.Model;
using cuoiki.Utils;
using cuoiki.Controller;
using cuoiki.Model;


namespace cuoiki
{
    public partial class QLX : Form
    {
        BangXeController controller = new BangXeController();
        BangXe currentBangXe;
        List<BangXe> dsxe = new List<BangXe>();
        public QLX()
        {
            InitializeComponent();
            dsxe = new List<BangXe>();
            controller = new BangXeController();
            currentBangXe = new BangXe();

            dtgv_qlx.ColumnCount = 4;
            dtgv_qlx.Columns[0].Name = "Mã xe";
            dtgv_qlx.Columns[1].Name = "Tên xe";
            dtgv_qlx.Columns[2].Name = "Giá";
            dtgv_qlx.Columns[3].Name = "Số lượng";
        }
        private void LoadData()
        {

            dsxe.Clear();
            dsxe = controller.Load();
            dtgv_qlx.Rows.Clear();

            foreach (BangXe k in dsxe)
            {
                String[] row = { k.getMaxe(), k.getTenxe(), k.getGia().ToString(), k.getSoluong().ToString() };
                dtgv_qlx.Rows.Add(row);
            }
        }

        private void QLX_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isExist = controller.isExist(txt_maxe.Text);
            if (!isExist)
            {
                currentBangXe = new BangXe(txt_maxe.Text, txt_tenxe.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_soluong.Text));
                controller.insert(currentBangXe);
                LoadData();
                clear();
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
        }
        public void clear()
        {
            txt_maxe.Text = "";
            txt_tenxe.Text = "";
            txt_gia.Text = "";
            txt_soluong.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            {
                currentBangXe = new BangXe(txt_maxe.Text, txt_tenxe.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_soluong.Text));
                controller.Update(currentBangXe);
                LoadData();
                clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            currentBangXe = new BangXe(txt_maxe.Text, txt_tenxe.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_soluong.Text));
            controller.Delete(currentBangXe);
            LoadData();
            clear();
        }

        private void dtgv_qlx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                // Hiển thị một thông báo lỗi.
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Thực hiện các bước tìm kiếm.
            dsxe.Clear();
            dsxe = controller.search(txt_timkiem.Text);
            dtgv_qlx.Rows.Clear();

            foreach (BangXe k in dsxe)
            {
                String[] row = { k.getMaxe(), k.getTenxe(), k.getGia().ToString(), k.getSoluong().ToString() };
                dtgv_qlx.Rows.Add(row);
            }
        }

        private void dtgv_qlx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_qlx.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = dtgv_qlx.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_maxe.Text = row.Cells[0].Value.ToString();
            txt_tenxe.Text = row.Cells[1].Value.ToString();
            txt_gia.Text = row.Cells[2].Value.ToString();
            txt_soluong.Text = row.Cells[3].Value.ToString();
        }
    }
}