using bai1.Model;
using bai1.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using bai1.Model;
using bai1.Utils;
using System.Data;

namespace bai1.Controller
{
    internal class ChiTietNhapController : DatabaseHelper
    {
        List<ChiTietNhap> listCTN;
        public ChiTietNhapController()
        {
            listCTN = new List<ChiTietNhap>();
        }
        public List<ChiTietNhap> Load()
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietNhap", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPhieuNhap"].ToString();
                    String mahanghoa = reader["MaHangHoa"].ToString();
                    Int32 soluong = reader.GetFieldValue<int>(3);
                    float dongia = reader.GetFieldValue<float>(5);
                    ChiTietNhap ctn = new ChiTietNhap(id, maphieunhap, mahanghoa, soluong, dongia);
                    listCTN.Add(ctn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listCTN;
        }
        public ChiTietNhap get(Int32 id)
        {
            foreach (ChiTietNhap ChiTietNhap in listCTN)
            {
                if (ChiTietNhap.getid() == id)
                {
                    return ChiTietNhap;
                }
            }
            return null;
        }
        public bool insert(ChiTietNhap ctn)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO ChiTietNhap (ID, MaPN, MaHangHoa, SoLuong, DonGia) VALUES (@id, @mpn, @mmh,@sl,@dg )", conn);
                command.Parameters.AddWithValue("@id", ctn.id);
                command.Parameters.AddWithValue("@mpn", ctn.maphieunhap);
                command.Parameters.AddWithValue("@mmh", ctn.mahanghoa);
                command.Parameters.AddWithValue("@sl", ctn.soluong);
                command.Parameters.AddWithValue("@dg", ctn.dongia);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(ChiTietNhap ctn)
        {
            if (ctn != null && !string.IsNullOrEmpty(ctn.maphieunhap) && !string.IsNullOrEmpty(ctn.mahanghoa) && !string.IsNullOrEmpty(ctn.soluong.ToString()) && !string.IsNullOrEmpty(ctn.dongia.ToString()))

            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("update ChiTietNhap set MaPhieuNhap = @mpn, MaMatHang = @mmh, SoLuong = @sl, DonGia = @dg where ID = @Id", conn);
                    command.Parameters.AddWithValue("@mpn", ctn.maphieunhap);
                    command.Parameters.AddWithValue("@mmh", ctn.mahanghoa);
                    command.Parameters.AddWithValue("@sl", ctn.soluong);
                    command.Parameters.AddWithValue("@dg", ctn.dongia);
                    command.Parameters.AddWithValue("@id", ctn.id);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }

        public bool Delete(ChiTietNhap ctn)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from ChiTietNhap where ID = @id", conn);
                command.Parameters.AddWithValue("@id", ctn.id);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool Delete(Int32 id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                // Delete the kho from the list.
                listCTN.Remove(listCTN.FirstOrDefault(k => k.id == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from ChiTietNhap where ID = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }

        public List<ChiTietNhap> search(Int32 keyword)
        {
            if (string.IsNullOrEmpty(keyword.ToString()))
            {
                return listCTN;
            }

            // Create a list to store the results.
            List<ChiTietNhap> results = new List<ChiTietNhap>();

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietNhap where ID = @id", conn);
                command.Parameters.AddWithValue("@id", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPhieuNhap"].ToString();
                    String mahanghoa = reader["MaHangHoa"].ToString();
                    Int32 soluong = reader.GetFieldValue<int>(3);
                    float dongia = reader.GetFieldValue<float>(4);
                    ChiTietNhap ctn = new ChiTietNhap(id, maphieunhap, mahanghoa, soluong, dongia);
                    results.Add(ctn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
        public DataTable getPhieuNhap(string maphieunhap)
        {

            SqlConnection conn = DatabaseHelper.GetConnection();

            //2. Mở kết nối đến database
            conn.Open();

            //3. Tạo câu truy vấn
            string sql = "SELECT * FROM PhieuNhap1 WHERE MaPhieu = @maphieunhap";

            //4. Tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            //5. Gắn giá trị tham số
            cmd.Parameters.AddWithValue("@maphieunhap", maphieunhap);

            //6. Thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);

            //7. Đóng kết nối đến database
            conn.Close();

            return dtPhieuNhap;
        }
        public DataTable getChiTietNhap(string maphieunhap)
        {

            SqlConnection conn = DatabaseHelper.GetConnection();

            //2. Mở kết nối đến database
            conn.Open();

            //3. Tạo câu truy vấn
            string sql = "SELECT * FROM ChiTietNhap WHERE MaPhieuNhap = @maphieunhap";

            //4. Tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            //5. Gắn giá trị tham số
            cmd.Parameters.AddWithValue("@maPhieuNhap", maphieunhap);

            //6. Thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);

            //7. Đóng kết nối đến database
            conn.Close();

            return dtPhieuNhap;
        }
        public List<ChiTietNhap> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listCTN;
            }

            // Create a list to store the results.
            List<ChiTietNhap> results = new List<ChiTietNhap>();

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietNhap where MaPhieuNhap = @mp", conn);
                command.Parameters.AddWithValue("@mp", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPhieuNhap"].ToString();
                    String mahanghoa = reader["MaHangHoa"].ToString();
                    Int32 sl = reader.GetFieldValue<int>(3);
                    Int32 dg = reader.GetFieldValue<int>(4);
                    ChiTietNhap ctn = new ChiTietNhap(id, maphieunhap, mahanghoa, sl, dg);
                    results.Add(ctn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
    }
}


