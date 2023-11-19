using cuoiki.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using cuoiki.Model;
using cuoiki.Utils;
using System.Data;
using System.Linq.Expressions;

namespace cuoiki.Controller
{
    internal class PhieuNhapController
    {
        List<PhieuNhap> listPN;
        public PhieuNhapController()
        {
            listPN = new List<PhieuNhap>();
        }
        public List<PhieuNhap> Load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select * from PhieuNhap", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String maphieunhap = reader["MaPN"].ToString();
                    String sophieunhap = reader["SoPN"].ToString();
                    DateTime ngaynhap = Convert.ToDateTime(reader["Ngaynhap"]);
                    String manhacungcap = reader["MaNCC"].ToString();
                    PhieuNhap pn = new PhieuNhap(maphieunhap, sophieunhap, ngaynhap, manhacungcap);
                    listPN.Add(pn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPN;
        }
        public PhieuNhap get(String id)
        {
            foreach(PhieuNhap PhieuNhap in listPN)
            {
                if (PhieuNhap.getmaphieunhap() == id)
                {
                    return PhieuNhap;
                }
            }
            return null;
        }
        public bool insert(PhieuNhap pn)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("insert into PhieuNhap(MaPN, SoPN, Ngaynhap, MaNCC) values (@mpn, @spn, @nn, @mncc)", conn);
                command.Parameters.AddWithValue("@mpn", pn.maphieunhap);
                command.Parameters.AddWithValue("@spn", pn.sophieunhap);
                command.Parameters.AddWithValue("@nn", pn.ngaynhap);
                command.Parameters.AddWithValue("@mncc", pn.manhacungcap);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool Update(PhieuNhap pn)
        {
            if (pn != null && !string.IsNullOrEmpty(pn.maphieunhap) && !string.IsNullOrEmpty(pn.sophieunhap) && !string.IsNullOrEmpty(pn.ngaynhap.ToString()) && !string.IsNullOrEmpty(pn.manhacungcap));
            {
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("update PhieuNhap set SoPN = @spn, Ngaynhap = @nn, MaNCC = @mncc where MaPN = @mpn", conn);
                    command.Parameters.AddWithValue("@mpn", pn.maphieunhap);
                    command.Parameters.AddWithValue("@spn", pn.sophieunhap);
                    command.Parameters.AddWithValue("@nn", pn.ngaynhap);
                    command.Parameters.AddWithValue("@mncc", pn.manhacungcap);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
        public bool delete(PhieuNhap pn)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from PhieuNhap where MaPN = @id", conn);
                command.Parameters.AddWithValue("@id", pn.maphieunhap);
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool Delete(String id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                // Delete the kho from the list.
                listPN.Remove(listPN.FirstOrDefault(k => k.maphieunhap == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from PhieuNhap where MaPN = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
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
        public List<PhieuNhap> search (String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listPN;
            }
            List<PhieuNhap> results = new List<PhieuNhap>();
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from PhieuNhap where MaPN = @id", conn);
                cmd.Parameters.AddWithValue("@id", keyword);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String maphieunhap = reader["MaPN"].ToString();
                    String sophieunhap = reader["SoPN"].ToString();
                    DateTime ngaynhap = Convert.ToDateTime(reader["Ngaynhap"]);
                    String manhacungcap = reader["MaNCC"].ToString();
                    PhieuNhap pn = new PhieuNhap(maphieunhap, sophieunhap, ngaynhap, manhacungcap);
                    results.Add(pn);

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
            SqlConnection conn = DatabaseHelper.getConnection();
            //mở kết nối đến database
            conn.Open();
            //tạo câu truy vấn
            string sql = "select * from PhieuNhap where MaPN = @maphieunhap";
            //tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //gắn giá trị tham số
            cmd.Parameters.AddWithValue("@maphieunhap", maphieunhap);
            //thực thi các truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            //đóng kết nối đến database
            conn.Close();
            return dtPhieuNhap;
        }
    }
}
