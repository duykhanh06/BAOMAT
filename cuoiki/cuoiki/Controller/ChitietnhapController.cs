using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using cuoiki.Model;
using cuoiki.Utils;
using cuoiki.Model;
using cuoiki.Utils;

namespace cuoiki.Controller
{
    internal class ChitietnhapController
    {
        List<Chitietnhap> Ds_Chitietnhap;

        public ChitietnhapController()
        {
            Ds_Chitietnhap = new List<Chitietnhap>();
        }



        public List<Chitietnhap> Load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Chitietnhap", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPN"].ToString();
                    String maxe = reader["MaXe"].ToString();
                    Int32 soluongnhap = reader.GetFieldValue<int>(3);
                    Int32 gianhap = reader.GetFieldValue<int>(4);
                    Chitietnhap ctn = new Chitietnhap(id, maphieunhap, maxe, soluongnhap, gianhap);
                    Ds_Chitietnhap.Add(ctn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Ds_Chitietnhap;
        }


        public Chitietnhap get(Int32 id)
        {
            foreach (Chitietnhap chitietnhap in Ds_Chitietnhap)
            {
                if (chitietnhap.getid() == id)
                {
                    return chitietnhap;
                }
            }
            return null;

        }


        public bool insert(Chitietnhap ctn)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Chitietnhap (MaPN, MaXe, Soluongnhap, Gianhap) VALUES (@mpn, @mmh,@sl,@dg )", conn);
                command.Parameters.AddWithValue("@mpn", ctn.maphieunhap);
                command.Parameters.AddWithValue("@mx", ctn.maxe);
                command.Parameters.AddWithValue("@sl", ctn.soluongnhap);
                command.Parameters.AddWithValue("@dg", ctn.gianhap);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(Chitietnhap ctn)
        {
            if (ctn != null && !string.IsNullOrEmpty(ctn.maphieunhap) && !string.IsNullOrEmpty(ctn.maxe) && !string.IsNullOrEmpty(ctn.soluongnhap.ToString()) && !string.IsNullOrEmpty(ctn.gianhap.ToString()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("update Chitietnhap set MaPN = @mpn, MaXe = @mmh, Soluongnhap = @sl, Gianhap = @dg where ID = @Id", conn);
                    command.Parameters.AddWithValue("@mpn", ctn.maphieunhap);
                    command.Parameters.AddWithValue("@mx", ctn.maxe);
                    command.Parameters.AddWithValue("@sl", ctn.soluongnhap);
                    command.Parameters.AddWithValue("@dg", ctn.gianhap);
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

        public bool Delete(Chitietnhap ctn)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from Chitietnhap where ID = @id", conn);
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
                Ds_Chitietnhap.Remove(Ds_Chitietnhap.FirstOrDefault(k => k.id == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Chitietnhap where ID = @Id", conn);
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

        public List<Chitietnhap> search(Int32 keyword)
        {
            if (string.IsNullOrEmpty(keyword.ToString()))
            {
                return Ds_Chitietnhap;
            }

            // Create a list to store the results.
            List<Chitietnhap> results = new List<Chitietnhap>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Chitietnhap where ID = @id", conn);
                command.Parameters.AddWithValue("@id", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPN"].ToString();
                    String maxe = reader["MaXe"].ToString();
                    Int32 soluongnhap = reader.GetFieldValue<int>(3);
                    Int32 gianhap = reader.GetFieldValue<int>(4);
                    Chitietnhap ctn = new Chitietnhap(id, maphieunhap, maxe, soluongnhap, gianhap);
                    results.Add(ctn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
        public DataTable getPhieunhap(string maPhieuNhap)
        {

            SqlConnection conn = DatabaseHelper.getConnection();

            //2. Mở kết nối đến database
            conn.Open();

            //3. Tạo câu truy vấn
            string sql = "SELECT * FROM PhieuNhap WHERE MaPN = @maPhieuNhap";

            //4. Tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            //5. Gắn giá trị tham số
            cmd.Parameters.AddWithValue("@maPhieuNhap", maPhieuNhap);

            //6. Thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);

            //7. Đóng kết nối đến database
            conn.Close();

            return dtPhieuNhap;
        }
        public DataTable getChitietnhap(string maPhieuNhap)
        {

            SqlConnection conn = DatabaseHelper.getConnection();

            //2. Mở kết nối đến database
            conn.Open();

            //3. Tạo câu truy vấn
            string sql = "SELECT * FROM Chitietnhap WHERE MaPN = @maPhieuNhap";

            //4. Tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            //5. Gắn giá trị tham số
            cmd.Parameters.AddWithValue("@maPhieuNhap", maPhieuNhap);

            //6. Thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);

            //7. Đóng kết nối đến database
            conn.Close();

            return dtPhieuNhap;
        }
        public List<Chitietnhap> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return Ds_Chitietnhap;
            }

            // Create a list to store the results.
            List<Chitietnhap> results = new List<Chitietnhap>();
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Chitietnhap where MaPN = @mp", conn);
                command.Parameters.AddWithValue("@mp", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Int32 id = reader.GetFieldValue<int>(0);
                    String maphieunhap = reader["MaPN"].ToString();
                    String maxe = reader["MaXe"].ToString();
                    Int32 soluongnhap = reader.GetFieldValue<int>(3);
                    Int32 gianhap = reader.GetFieldValue<int>(4);
                    Chitietnhap ctn = new Chitietnhap(id, maphieunhap, maxe, soluongnhap, gianhap);
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