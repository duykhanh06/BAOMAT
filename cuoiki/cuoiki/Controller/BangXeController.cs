using cuoiki.Model;
using cuoiki.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using cuoiki.Model;
using cuoiki.Utils;

namespace cuoiki.Controller
{
    internal class BangXeController : DatabaseHelper
    {
        List<BangXe> listbangxe;
        public BangXeController()
        {
            listbangxe = new List<BangXe>();
        }
        public List<BangXe> Load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM BangXe", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    String maxe = reader["MaXe"].ToString();
                    String tenxe = reader["TenXe"].ToString();
                    Int32 gia = reader.GetFieldValue<int>(2);
                    Int32 soluong = reader.GetFieldValue<int>(3);
                    BangXe bangxe = new BangXe(maxe, tenxe, gia, soluong);
                    listbangxe.Add(bangxe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listbangxe;
        }
        public BangXe get(string MaXe)
        {
            BangXe xe = null;

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM BangXe WHERE MaXe = @maXe", conn);
                command.Parameters.AddWithValue("@maXe", MaXe);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Read data from SqlDataReader and create a Hang object.
                    String id = reader["MaXe"].ToString();
                    String name = reader["TenXe"].ToString();
                    Int32 gia = reader.GetFieldValue<int>(2);
                    Int32 soluong = reader.GetFieldValue<int>(3);
                    xe = new BangXe (id, name, gia,soluong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return xe;
        }
        public bool insert(BangXe bangxe)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO BangXe (MaXe, TenXe, Gia, Soluong) VALUES (@maxe, @tenxe, @gia, @soluong)", conn);
                command.Parameters.AddWithValue("@maxe", bangxe.maxe);
                command.Parameters.AddWithValue("@tenxe", bangxe.tenxe);
                command.Parameters.AddWithValue("@gia", bangxe.gia);
                command.Parameters.AddWithValue("@soluong", bangxe.gia);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(BangXe bangxe)
        {
            if (bangxe != null && !string.IsNullOrEmpty(bangxe.maxe) && !string.IsNullOrEmpty(bangxe.tenxe) && !string.IsNullOrEmpty(bangxe.gia.ToString()) && !string.IsNullOrEmpty(bangxe.soluong.ToString()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update BangXe set TenXe = @tenxe, Gia = @gia, Soluong = @soluong where MaXe = @maxe", conn);
                    cmd.Parameters.AddWithValue("@maxe", bangxe.maxe);
                    cmd.Parameters.AddWithValue("@tenxe", bangxe.tenxe);
                    cmd.Parameters.AddWithValue("@gia", bangxe.gia);
                    cmd.Parameters.AddWithValue("@soluong", bangxe.soluong);
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

        public bool Delete(BangXe bangXe)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from BangXe where MaXe = @maxe", conn);
                command.Parameters.AddWithValue("@maKho", bangXe.maxe);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }


        public bool delete(string maxe)
        {
            if (!string.IsNullOrEmpty(maxe))
            {
                // Delete the kho from the list.
                listbangxe.Remove(listbangxe.FirstOrDefault(k => k.maxe == maxe));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from BangXe where MaXe = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", maxe);
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

        public List<BangXe> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listbangxe;
            }

            // Create a list to store the results.
            List<BangXe> results = new List<BangXe>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM BangXe where MaXe = @maxe", conn);
                command.Parameters.AddWithValue("@maxe", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String maxe = reader["MaXe"].ToString();
                    String tenxe = reader["TenXe"].ToString();
                    Int32 gia = reader.GetFieldValue<int>(2);
                    Int32 soluong = reader.GetFieldValue<int>(3);
                    BangXe bangxe = new BangXe(maxe, tenxe, gia, soluong);
                    results.Add(bangxe);
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
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {

                conn.Open();


                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BangXe WHERE MaXe = @maxe", conn);
                command.Parameters.AddWithValue("@maxe", id);
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
        public bool isExist(BangXe bangxe)
        {

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {

                conn.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BangXe WHERE MaXe = @maxe", conn);
                command.Parameters.AddWithValue("@maKho", bangxe.maxe);
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
