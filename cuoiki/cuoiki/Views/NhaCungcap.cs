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
using cuoiki.Controller;

namespace cuoiki.Views
{
    public partial class NhaCungcap : Form
    {
        NCCController controller1 = new NCCController();
        Nhacungcap currentNhaCungcap;
        List<Nhacungcap> dsnhacc = new List<Nhacungcap>();

        BangXeController xeController;
        BangXe currentBangXe;
        List<BangXe> dskho;

        Chitietnhap currentctn;
        PhieuNhap currentpn;
        ChitietnhapController ctnController;
        PhieuNhapController pnController;
        List<Chitietnhap> chiTietNhap;
        List<PhieuNhap> phieuNhap;


        public NhaCungcap()
        {
            InitializeComponent();
            dsnhacc = new List<Nhacungcap>();
            controller1 = new NCCController();
            currentNhaCungcap = new Nhacungcap();

            dtgv_nhacungcap.ColumnCount = 3;
            dtgv_nhacungcap.Columns[0].Name = "Mã nhà cung cấp";
            dtgv_nhacungcap.Columns[1].Name = "Tên nhà cung cấp";
            dtgv_nhacungcap.Columns[2].Name = "Địa chỉ";
        }
        private void LoadData()
        {

            dsnhacc.Clear();
            dsnhacc = controller1.Load();
            dtgv_nhacungcap.Rows.Clear();

            foreach (Nhacungcap k in dsnhacc)
            {
                String[] row = { k.getmanhacungcap(), k.gettennhacungcap(), k.getdiachi() };
                dtgv_nhacungcap.Rows.Add(row);
            }
        }

        private void NhaCungcap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isExist = controller1.isExist(txt_mncc.Text);
            if (!isExist)
            {
                currentNhaCungcap = new Nhacungcap(txt_mncc.Text, txt_tenncc.Text, txt_diachi.Text);
                controller1.insert(currentNhaCungcap);
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
            txt_mncc.Text = "";
            txt_tenncc.Text = "";
            txt_diachi.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            currentNhaCungcap = new Nhacungcap(txt_mncc.Text, txt_tenncc.Text, txt_diachi.Text);
            controller1.Update(currentNhaCungcap);
            LoadData();
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            currentNhaCungcap = new Nhacungcap(txt_mncc.Text, txt_tenncc.Text, txt_diachi.Text);
            controller1.Delete(currentNhaCungcap);
            LoadData();
            clear();
        }

        private void dtgv_nhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_nhacungcap.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = dtgv_nhacungcap.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_mncc.Text = row.Cells[0].Value.ToString();
            txt_tenncc.Text = row.Cells[1].Value.ToString();
            txt_diachi.Text = row.Cells[2].Value.ToString();
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
            dsnhacc.Clear();
            dsnhacc = controller1.search(txt_timkiem.Text);
            dtgv_nhacungcap.Rows.Clear();

            foreach (Nhacungcap k in dsnhacc)
            {
                String[] row = { k.getmanhacungcap(), k.gettennhacungcap(), k.getdiachi() };
                dtgv_nhacungcap.Rows.Add(row);
            }
        }

        private void dtgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_nhacungcap.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = dtgv_nhacungcap.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_mncc.Text = row.Cells[0].Value.ToString();
            txt_tenncc.Text = row.Cells[1].Value.ToString();
            txt_diachi.Text = row.Cells[2].Value.ToString();
            
        }
    }
}
