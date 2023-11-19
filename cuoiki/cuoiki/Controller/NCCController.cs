using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cuoiki.Model;
using cuoiki.Utils;
using System.Data.SqlClient;

namespace cuoiki.Controller
{
    internal class NCCController
    {
        List<Nhacungcap> Ds_NCC;

        public NCCController()
        {
            Ds_NCC = new List<Nhacungcap>();
        }



        public List<Nhacungcap> Load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NhaCungCap ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String manhacungcap = reader["MaNCC"].ToString();
                    String tennhacungcap = reader["TenNCC"].ToString();
                    String diachi = reader["DiaChi"].ToString();


                    Nhacungcap NCC = new Nhacungcap(manhacungcap,tennhacungcap,diachi);
                    Ds_NCC.Add(NCC);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Ds_NCC;
        }


        public Nhacungcap get(String MaNCC)
        {
            Nhacungcap ncc = null;

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM  WHERE NhaCungCap MaNCC = @mancc", conn);
                command.Parameters.AddWithValue("@mancc", MaNCC);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Read data from SqlDataReader and create a Hang object.
                    String id = reader["MaNCC"].ToString();
                    String name = reader["TenNCC"].ToString();
                    String diachi = reader["DiaChi"].ToString();
                    ncc = new Nhacungcap(id, name, diachi);
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

            return ncc;
        }

            public bool insert(Nhacungcap NCC)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi) VALUES (@mancc, @tenncc, @diachi)", conn);
                command.Parameters.AddWithValue("@mancc", NCC.manhacungcap);
                command.Parameters.AddWithValue("@tenncc", NCC.tennhacungcap);
                command.Parameters.AddWithValue("@diachi", NCC.diachi);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool Update(Nhacungcap NCC)
        {
            if (NCC != null && !string.IsNullOrEmpty(NCC.manhacungcap) && !string.IsNullOrEmpty(NCC.tennhacungcap) && !string.IsNullOrEmpty(NCC.diachi))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update NhaCungCap set TenNCC = @tenncc, DiaChi = @diachi where MaNCC = @mancc", conn);
                    cmd.Parameters.AddWithValue("@mancc", NCC.manhacungcap);
                    cmd.Parameters.AddWithValue("@tenncc", NCC.tennhacungcap);
                    cmd.Parameters.AddWithValue("@diachi", NCC.diachi);
                    
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

        public bool Delete(Nhacungcap NCC)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from NhaCungCap where MaNCC = @mancc", conn);
                command.Parameters.AddWithValue("@mancc", NCC.manhacungcap);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool Delete(string mancc)
        {
            if (!string.IsNullOrEmpty(mancc))
            {
                // Delete the kho from the list.
                Ds_NCC.Remove(Ds_NCC.FirstOrDefault(k => k.getmanhacungcap() == mancc));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from NhaCungCap where MaNCC = @mancc", conn);
                    cmd.Parameters.AddWithValue("@mancc", mancc);
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

        public List<Nhacungcap> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return Ds_NCC;
            }

            // Create a list to store the results.
            List<Nhacungcap> results = new List<Nhacungcap>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap where MaNCC = @mancc", conn);
                command.Parameters.AddWithValue("@mancc", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String manhacungcap = reader["MaNCC"].ToString();
                    String tennhacungcap = reader["TenNCC"].ToString();
                    String diachi = reader["DiaChi"].ToString();
                    Nhacungcap NCC = new Nhacungcap(manhacungcap, tennhacungcap, diachi);
                    results.Add(NCC);
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
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = @mancc", conn);

                command.Parameters.AddWithValue("@mancc", id);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }


        public bool isExist(Nhacungcap NCC)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = @mancc", conn);
                command.Parameters.AddWithValue("@mancc", NCC.manhacungcap);
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
    }

}
