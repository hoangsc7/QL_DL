using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Quan_Ly_Tour;

namespace DAL_Quan_Ly_Tour
{
    public class QLT_Access : DatabaseAccess
    {
        // Kiểm tra đăng nhập
        public string CheckLogin(ACCOUNT taikhoan)
        {
            string info = CheckLoginDTO(taikhoan);
            return info;
        }

        // Đăng ký tài khoản
        public string InsertAccount(string str_insert, string sql_key)
        {
            string info = Insert_FK(str_insert, sql_key);
            return info;
        }

        // Thêm,Sửa khuyến mãi
        public string InsertKM(string str_insert, string sql_key)
        {
            string info = Insert_FK(str_insert, sql_key);
            return info;
        }
        public string UpdateKM(string str_update)
        {
            string info = Execute_sql(str_update);
            return info;
        }

        // Thêm,Sửa khách hàng
        public string InsertKH(string str_insert)
        {
            string info = Execute_sql(str_insert);
            return info;
        }
        public string UpdateKH(string str_update)
        {
            string info = Execute_sql(str_update);
            return info;
        }

        // Thêm,Sửa nhân viên
        public string InsertNV(string str_insert, string sql_key)
        {
            string info = Insert_FK(str_insert, sql_key);
            return info;
        }
        public string UpdateNV(string str_update)
        {
            string info = Execute_sql(str_update);
            return info;
        }

        // Thêm,Sửa Tour
        public string InsertTour(string str_insert, string sql_key)
        {
            string info = Insert_FK(str_insert, sql_key);
            return info;
        }
        public string UpdateTour(string str_update)
        {
            string info = Execute_sql(str_update);
            return info;
        }

        // Thêm,Sửa booking
        public string InsertBooking(string str_insert)
        {
            string info = Execute_sql(str_insert);
            return info;
        }
        public string UpdateBooking(string str_update)
        {
            string info = Execute_sql(str_update);
            return info;
        }

        public string CheckDeleteKey(string str_delete,string sql_key)
        {
            string info = Delete_PK(str_delete,sql_key);
            return info;
        }

        // Xóa
        public string Delete(string str_delete)
        {
            string info = Execute_sql(str_delete);
            return info;
        }

        public string Thanhtoan(string str_thanhtoan)
        {
            string info = Execute_sql(str_thanhtoan);
            return info;
        }
    }
}
