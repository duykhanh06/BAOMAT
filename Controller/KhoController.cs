using bai1.Model;
using bai1.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using bai1.Model;
using bai1.Utils;

namespace bai1.Controller
{
    internal class KhoController : DatabaseHelper
    {
        List<Kho> listKho;
        public KhoController()
        {
            listKho = new List<Kho>();
        }
        public List<Kho> Load()
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM QLK", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    String id = reader["MaKho"].ToString();
                    String name = reader["TenKho"].ToString();
                    String address = reader["DiaChi"].ToString();
                    Kho kho = new Kho(id, name, address);
                    listKho.Add(kho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listKho;
        }
        public Kho get(string MaKho)
        {
            foreach (Kho kho in listKho)
            {
                if (kho.getMaKho() == MaKho)
                {
                    return kho;
                }
            }
            return null;
        }
        public bool insert(Kho kho)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO QLK (MaKho, TenKho, DiaChi) VALUES (@maKho, @tenKho, @diaChi)", conn);
                command.Parameters.AddWithValue("@maKho", kho.makho);
                command.Parameters.AddWithValue("@tenKho", kho.tenkho);
                command.Parameters.AddWithValue("@diaChi", kho.diachi);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(Kho kho)
        {
            if (kho != null && !string.IsNullOrEmpty(kho.makho) && !string.IsNullOrEmpty(kho.tenkho) && !string.IsNullOrEmpty(kho.diachi))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update QLK set TenKho = @tenKho, DiaChi = @diaChi where MaKho = @maKho", conn);
                    cmd.Parameters.AddWithValue("@maKho", kho.makho);
                    cmd.Parameters.AddWithValue("@tenKho", kho.tenkho);
                    cmd.Parameters.AddWithValue("@diaChi", kho.diachi);
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

        public bool Delete(Kho kho)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from QLK where MaKho = @maKho", conn);
                command.Parameters.AddWithValue("@maKho", kho.makho);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

  
         public bool delete (string maKho)
          {
            if (!string.IsNullOrEmpty(maKho))
            {
                // Delete the kho from the list.
                listKho.Remove(listKho.FirstOrDefault(k => k.makho == maKho));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from QLK where MaKho = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", maKho);
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

        public List<Kho> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listKho;
            }

            // Create a list to store the results.
            List<Kho> results = new List<Kho>();

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM QLK where MaKho = @maKho", conn);
                command.Parameters.AddWithValue("@maKho", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String id = reader["MaKho"].ToString();
                    String name = reader["TenKho"].ToString();
                    String address = reader["DiaChi"].ToString();
                    Kho kho = new Kho(id, name, address);
                    results.Add(kho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
        /*
         * Method name: isExist
         * Parameters: 
         * Kho kho: đối tượng kho cần kiểm tra sự tồn tại
         * Output:
         * true: nếu id của đối tượng kho đã tồn tại trong csdl
         * false: nếu id nếu id của đối tượng chưa có trong csdl
         * */
        public bool isExist(string id)
        {
            // Tạo kết nối với database
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
               
                conn.Open();

               
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM QLK WHERE MaKho = @maKho", conn);
                command.Parameters.AddWithValue("@maKho", id);
                int count = (int)command.ExecuteScalar();
                return count > 0;
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool isExist(Kho kho)
        {

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
               
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM QLK WHERE MaKho = @maKho", conn);
                command.Parameters.AddWithValue("@maKho", kho.makho);
                int count = (int)command.ExecuteScalar();
                return (count > 0);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
