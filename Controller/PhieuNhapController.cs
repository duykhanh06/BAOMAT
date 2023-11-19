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
    internal class PhieuNhapController
    {
        List<PhieuNhap> listPN;
        public PhieuNhapController()
        {
            listPN = new List<PhieuNhap>();
        }
        public List<PhieuNhap> Load()
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap1", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader và tạo các đối tượng Kho.
                    String maphieunhap = reader["MaPhieuNhap"].ToString();
                    DateTime ngaynhapphieu = Convert.ToDateTime(reader["NgayNhapPhieu"]);
                    String nguoigiao = reader["NguoiGiao"].ToString();
                    String sohoadon = reader["SoHoaDon"].ToString();
                    DateTime ngayhoadon = Convert.ToDateTime(reader["NgayHoaDon"]);
                    String dvph = reader["DonViPhatHanhHoaDon"].ToString();
                    Int32 makho = reader.GetFieldValue<int>(3);
                    PhieuNhap pn = new PhieuNhap(maphieunhap, ngaynhapphieu, nguoigiao, sohoadon, ngayhoadon, dvph, makho);
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
            foreach (PhieuNhap PhieuNhap in listPN)
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
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO PhieuNhap1 (MaPN, NgayPN, NguoiGiao, SoHoaDon, NgayHD, DonViPhatHanh, MaKho) VALUES (@mpn, @nnp, @ng,@shd,@nhd,@dvph,@mk )", conn);
                command.Parameters.AddWithValue("@mpn", pn.maphieunhap);
                command.Parameters.AddWithValue("@nnp", pn.ngayphieunhap);
                command.Parameters.AddWithValue("@ng", pn.nguoigiao);
                command.Parameters.AddWithValue("@shd", pn.sohoadon);
                command.Parameters.AddWithValue("@nhd", pn.ngayhoadon);
                command.Parameters.AddWithValue("@dvph", pn.donviphathanh);
                command.Parameters.AddWithValue("@mk", pn.makho);
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
            if (pn != null && !string.IsNullOrEmpty(pn.maphieunhap) && !string.IsNullOrEmpty(pn.ngayphieunhap.ToString()) && !string.IsNullOrEmpty(pn.nguoigiao) && !string.IsNullOrEmpty(pn.sohoadon) && !string.IsNullOrEmpty(pn.ngayhoadon.ToString()) && !string.IsNullOrEmpty(pn.donviphathanh) && !string.IsNullOrEmpty(pn.makho.ToString()))

            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("update PhieuNhap1 set NgayNhapPhieu = @nnp, NguoiGiao = @ng, SoHoaDon = @shd, NgayHoaDon = @nhd, DonViPhatHanh = @dvph, MaKho = @mk where MaPhieu = @mp", conn);
                    command.Parameters.AddWithValue("@mp", pn.maphieunhap);
                    command.Parameters.AddWithValue("@nnp", pn.ngayphieunhap);
                    command.Parameters.AddWithValue("@ng", pn.nguoigiao);
                    command.Parameters.AddWithValue("@shd", pn.sohoadon);
                    command.Parameters.AddWithValue("@nhd", pn.ngayhoadon);
                    command.Parameters.AddWithValue("@dvphhd", pn.donviphathanh);
                    command.Parameters.AddWithValue("@mk", pn.makho);
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

        public bool Delete(PhieuNhap pn)
        {
            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from PhieuNhap1 where MaPhieuNhap = @id", conn);
                command.Parameters.AddWithValue("@id", pn.maphieunhap);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
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
                SqlConnection conn = DatabaseHelper.GetConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from PhieuNhap1 where MaPhieuNhap = @Id", conn);
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

        public List<PhieuNhap> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listPN;
            }

            // Create a list to store the results.
            List<PhieuNhap> results = new List<PhieuNhap>();

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap1 where MaPhieuNhap = @id", conn);
                command.Parameters.AddWithValue("@id", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String maphieunhap = reader["MaPhieuNhap"].ToString();
                    DateTime ngaynhapphieu = Convert.ToDateTime(reader["NgayNhapPhieu"]);
                    String nguoigiao = reader["NguoiGiao"].ToString();
                    String sohoadon = reader["SoHoaDon"].ToString();
                    DateTime ngayhoadon = Convert.ToDateTime(reader["NgayHoaDon"]);
                    String dvphhd = reader["DonViPhatHanhHoaDon"].ToString();
                    Int32 makho = reader.GetFieldValue<int>(3);
                    PhieuNhap pn = new PhieuNhap(maphieunhap, ngaynhapphieu, nguoigiao, sohoadon, ngayhoadon, dvphhd, makho);
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
            SqlConnection conn = DatabaseHelper.GetConnection();
            //mở kết nối đến database
            conn.Open();
            //tạo câu truy vấn
            string sql = "select * from PhieuNhap1 where maphieunhap = @maphieunhap";
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