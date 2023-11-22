using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_Quan_Ly_Tour;
using DAL_Quan_Ly_Tour;
using System.Data.SqlClient;

namespace DAL_Quan_Ly_Tour
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối CSDL
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-1DAGDL4\SQLEXPRESS;Initial Catalog=QL_Tour;User ID=sa;Password=123";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }
    }

    public class DatabaseAccess
    {
        // Load dữ liệu vào combobox
        public DataTable LoadCombobox(string sql)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            conn.Close();
            return dt;
        }

        // Load dữ liệu vào datagitview
        public DataTable Hienthi(string sql_DGV)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql_DGV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // Tính toán 
        public string GetKhuyenmai(string sql)
        {
            string khuyenmai = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    khuyenmai = reader.GetString(0);
                    return khuyenmai;
                }
                reader.Close();
                conn.Close();
            }
            return khuyenmai;
        }

        //public static string GetMakh(string sql_key)
        //{
        //    string makh = null;
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();
        //    SqlCommand command = new SqlCommand(sql_key, conn);
        //    SqlDataReader reader = command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            makh = reader.GetString(0);
        //            return makh;
        //        }
        //        reader.Close();
        //        conn.Close();
        //    }
        //    else
        //    {
        //        return "Email mật khẩu không chính xác!";
        //    }
        //    conn.Close();
        //    return makh;
        //}
        // Kiểm tra đăng nhập
        public static string CheckLoginDTO(ACCOUNT taikhoan)
        {
            string quyen = null;
            // Hàm connect tời SQL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // SQL Kiểm tra tài khoản đăng nhập
            string insert_login = "SELECT * FROM ACCOUNT WHERE Email = '" + taikhoan.Email + "'AND Mat_Khau = '" + taikhoan.Mat_Khau + "'";
            SqlCommand command = new SqlCommand(insert_login, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quyen = reader.GetString(2);
                    return quyen;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email mật khẩu không chính xác!";
            }
            conn.Close();
            return quyen;
        }

        // Thêm khi có nhập khóa chính
        public static string Insert_FK(string str_insert, string sql_key)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand(sql_key, conn);
            int kt = (int)command.ExecuteScalar();
            if (kt == 0)
            {
                command = new SqlCommand(str_insert, conn);
                command.ExecuteNonQuery();
                conn.Close();//đóng kết nối
                return "Thành công!";
            }
            conn.Close();
            return "Không thành công!";
        }

        // Xóa khi là khóa chính
        public static string Delete_PK(string str_delete, string sql_key)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand(sql_key, conn);
            int kt = (int)command.ExecuteScalar();
            if (kt == 0)
            {
                conn.Close();
                return Execute_sql(str_delete);
            }
            else
            {
                conn.Close();
                return "Khóa ngoại!";
            }
        }
        // Thực thi sql
        public static string Execute_sql(string str_sql)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand(str_sql, conn);
            command.ExecuteNonQuery();
            conn.Close();//đóng kết nối
            return "Thành công!";
        }
    }
}
