using bai1.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1.Model;
using bai1.Utils;

namespace bai1.Controller
{
    internal class HanghoaController : DatabaseHelper
    {

        List<Hanghoa> listHangHoa;
        public HanghoaController()
        {
            listHangHoa = new List<Hanghoa>();
        }
        public List<Hanghoa> Load()
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM HangHoa", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    String id = reader["MaHangHoa"].ToString();
                    String name = reader["TenHangHoa"].ToString();
                    String dvt = reader["DonViTinh"].ToString();
                    Hanghoa hanghoa = new Hanghoa(id, name, dvt);
                    listHangHoa.Add(hanghoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listHangHoa;
        }
        public Hanghoa get(string mahanghoa)
        {
            foreach (Hanghoa hanghoa in listHangHoa)
            {
                if (hanghoa.getmahanghoa() == mahanghoa)
                {
                    return hanghoa;
                }
            }
            return null;
        }
        public bool insert(Hanghoa hanghoa)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO HangHoa (MaHangHoa, TenHangHoa, DonViTinh) VALUES (@maHang, @tenHang, @dvt)", conn);
                command.Parameters.AddWithValue("@maHang", hanghoa.mahanghoa);
                command.Parameters.AddWithValue("@tenHang", hanghoa.tenhanghoa);
                command.Parameters.AddWithValue("@dvt", hanghoa.dvt);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(Hanghoa hanghoa)
        {
            if (hanghoa != null && !string.IsNullOrEmpty(hanghoa.mahanghoa) && !string.IsNullOrEmpty(hanghoa.tenhanghoa) && !string.IsNullOrEmpty(hanghoa.dvt))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update HangHoa set TenHangHoa = @Name, DonViTinh = @dvt where MaHangHoa = @Id", conn);
                    cmd.Parameters.AddWithValue("@Name", hanghoa.tenhanghoa);
                    cmd.Parameters.AddWithValue("@dvt", hanghoa.dvt);
                    cmd.Parameters.AddWithValue("@Id", hanghoa.mahanghoa);
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

        public bool Delete(Hanghoa hanghoa)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from HangHoa where MaHangHoa = @maHang", conn);
                command.Parameters.AddWithValue("@maHang", hanghoa.mahanghoa);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool Delete(string mahanghoa)
        {
            if (!string.IsNullOrEmpty(mahanghoa))
            {
                // Delete the kho from the list.
                listHangHoa.Remove(listHangHoa.FirstOrDefault(k => k.mahanghoa == mahanghoa));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from HangHoa where MaHangHoa = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", mahanghoa);
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

        public List<Hanghoa> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listHangHoa;
            }

            // Create a list to store the results.
            List<Hanghoa> results = new List<Hanghoa>();

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM HangHoa where MaHangHoa = @maHang", conn);
                command.Parameters.AddWithValue("@maHang", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String id = reader["MaHang"].ToString();
                    String name = reader["TenHang"].ToString();
                    String address = reader["DonViTinh"].ToString();
                    Hanghoa hanghoa = new Hanghoa(id, name, address);
                    results.Add(hanghoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
        public bool isExist(String id)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select count(*) from HangHoa where MaHangHoa = @mahanghoa", conn);
                command.Parameters.AddWithValue("@mahanghoa", id);
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
        public bool isExist(Hanghoa hanghoa)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select count(*) from HangHoa where MaHangHoa = @mahanghoa", conn);
                command.Parameters.AddWithValue("@mahanghoa", hanghoa.mahanghoa);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch(Exception ex)
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
