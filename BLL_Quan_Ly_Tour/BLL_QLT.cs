using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DTO_Quan_Ly_Tour;
using DAL_Quan_Ly_Tour;
using System.Data;

namespace BLL_Quan_Ly_Tour
{
    public class BLL_QLT
    {
        QLT_Access Access = new QLT_Access();

        // Kiểm tra ngoại lệ Đăng nhập
        public string CheckLogin(ACCOUNT taikhoan)
        {
            if (taikhoan.Email == "")
            {
                return "requeid_email";
            }
            if (taikhoan.Mat_Khau == "")
            {
                return "requeid_password";
            }
            string info = Access.CheckLogin(taikhoan);
            return info;
        }

        // Kiểm tra ngoại lệ Đăng ký tài khoản
        public string CheckSignup(Insert_Account taikhoan, string str_insert, string sql_key)
        {
            Regex remail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (taikhoan.Email == "")
            {
                return "requeid_email";
            }
            if (!remail.IsMatch(taikhoan.Email))
            {
                return "check_email";
            }
            if (taikhoan.Pass == "")
            {
                return "requeid_password";
            }
            if (taikhoan.Pass.Length < 8)
            {
                return "check_password";
            }
            if (taikhoan.Pass != taikhoan.Repass)
            {
                return "requeid_pass_repass";
            }
            string info = Access.InsertAccount(str_insert,sql_key);
            return info;
        }

        // Kiểm tra ngoại lệ khuyến mãi khi thêm,sửa
        public string CheckInsertKhuyenmai(KHUYEN_MAI khuyenmai, string str_insert, string sql_key)
        {
            if (khuyenmai.Ma_KM == "")
            {
                return "requeid_Ma_KM";
            }
            if (khuyenmai.KhuyenMai == "")
            {
                return "requeid_Khuyenmai";
            }
            string info = Access.InsertKM(str_insert,sql_key);
            return info;
        }
        public string CheckUpdateKhuyenmai(KHUYEN_MAI khuyenmai, string str_update)
        { 
            if (khuyenmai.Ma_KM == "")
            {
                return "requeid_Ma_KM";
            }
            if (khuyenmai.KhuyenMai == "")
            {
                return "requeid_Khuyenmai";
            }
            string info = Access.UpdateKM(str_update);
            return info;
        }

        // Kiểm tra ngoại lệ Khách hàng khi thêm,sửa
        public string CheckInsertKhachhang(KHACH_HANG khachhang, string str_insert)
        {
            // Kiểm tra
            Regex rsdt = new Regex(@"^(032|033|034|035|036|037|038|039|086|096|097|098|081|082|083|084|085|086|088|091|094|056|058|092|070|076|077|078|079|089|090|093|099|059)+([0-9]{7})$");
            Regex rcccd = new Regex(@"^[0-9]{12} + $");
            if (khachhang.Ten_KH == "")
            {
                return "requeid_Ten_KH";
            }
            if (khachhang.DiaChi == "")
            {
                return "requeid_DiaChi";
            }
            if (khachhang.Sdt == "")
            {
                return "requeid_Sdt";
            }
            if (khachhang.CCCD == "")
            {
                return "requeid_CCCD";
            }
            if (!rcccd.IsMatch(khachhang.CCCD))
            {
                return "check_CCCD";
            }
            if (!rsdt.IsMatch(khachhang.Sdt))
            {
                return "check_sdt";
            }
            string info = Access.InsertKH(str_insert);
            return info;
        }
        public string CheckUpdateKhachhang(KHACH_HANG khachhang, string str_update)
        {
            //Regex rsdt = new Regex(@"/^(032|033|034|035|036|037|038|039|086|096|097|098|081|082|083|084|085|086|088|091|094|056|058|092|070|076|077|078|079|089|090|093|099|059)+([0-9]{7})$/");
            //Regex rcccd = new Regex(@"^[0 - 9]{ 12 } +$/");
            if (khachhang.Ten_KH == "")
            {
                return "requeid_Ten_KH";
            }
            if (khachhang.DiaChi == "")
            {
                return "requeid_DiaChi";
            }
            if (khachhang.Sdt == "")
            {
                return "requeid_Sdt";
            }
            if (khachhang.CCCD == "")
            {
                return "requeid_CCCD";
            }
            //if (!rcccd.IsMatch(khachhang.CCCD))
            //{
            //    return "check_CCCD";
            //}
            //if (!rsdt.IsMatch(khachhang.Sdt))
            //{
            //    return "check_sdt";
            //}
            string info = Access.UpdateKH(str_update);
            return info;
        }

        // Kiểm tra ngoại lệ Nhân viên khi thêm,sửa
        public string CheckInsertNhanvien(NHAN_VIEN nhanvien, string str_insert, string sql_key)
        {
            //Regex rsdt = new Regex(@"/^(032|033|034|035|036|037|038|039|086|096|097|098|081|082|083|084|085|086|088|091|094|056|058|092|070|076|077|078|079|089|090|093|099|059)+([0-9]{7})$/");
            //Regex rcccd = new Regex(@"^[0 - 9]{ 12 } +$/");
            if (nhanvien.Ma_NV == "")
            {
                return "requeid_Ma_NV";
            }
            if (nhanvien.Ten_NV == "")
            {
                return "requeid_Ten_NV";
            }
            if (nhanvien.DiaChi == "")
            {
                return "requeid_DiaChi";
            }
            if (nhanvien.Sdt == "")
            {
                return "requeid_Sdt";
            }
            //if (!rsdt.IsMatch(nhanvien.Sdt))
            //{
            //    return "check_Sdt";
            //}
            if (nhanvien.CCCD == "")
            {
                return "requeid_CCCD";
            }
            //if (!rcccd.IsMatch(nhanvien.CCCD))
            //{
            //    return "check_CCCD";
            //}
            if (nhanvien.ChucVu == "")
            {
                return "requeid_ChucVu";
            }
            string info = Access.InsertNV(str_insert,sql_key);
            return info;
        }
        public string CheckUpdateNhanvien(NHAN_VIEN nhanvien, string str_update)
        {
            //Regex rsdt = new Regex(@"/^(032|033|034|035|036|037|038|039|086|096|097|098|081|082|083|084|085|086|088|091|094|056|058|092|070|076|077|078|079|089|090|093|099|059)+([0-9]{7})$/");
            //Regex rcccd = new Regex(@"^[0-9]{12}$/");
            if (nhanvien.Ma_NV == "")
            {
                return "requeid_Ma_NV";
            }
            if (nhanvien.Ten_NV == "")
            {
                return "requeid_Ten_NV";
            }
            if (nhanvien.DiaChi == "")
            {
                return "requeid_DiaChi";
            }
            if (nhanvien.Sdt == "")
            {
                return "requeid_Sdt";
            }
            //if (!rsdt.IsMatch(nhanvien.Sdt))
            //{
            //    return "check_Sdt";
            //}
            if (nhanvien.CCCD == "")
            {
                return "requeid_CCCD";
            }
            //if (!rcccd.IsMatch(nhanvien.CCCD))
            //{
            //    return "check_CCCD";
            //}
            if (nhanvien.ChucVu == "")
            {
                return "requeid_ChucVu";
            }
            string info = Access.UpdateNV(str_update);
            return info;
        }

        // Kiểm tra ngoại lệ Tour khi thêm,sửa
        public string CheckInsertTour(TOUR tour, string str_insert, string sql_key)
        {
            Regex rgia = new Regex(@"^[0-9]$/");
            if (tour.Ma_Tour == "")
            {
                return "requeid_Ma_Tour";
            }
            if (tour.Img == "")
            {
                return "requeid_Img";
            }
            if (tour.Mota == "")
            {
                return "requeid_Mota";
            }
            if (tour.DiaDiem == "")
            {
                return "requeid_DiaDiem";
            }
            if (tour.ThoiGian == "")
            {
                return "requeid_ThoiGian";
            }
            if (tour.Gia == 0)
            {
                return "requeid_Gia";
            }
            if (!rgia.IsMatch(tour.Gia.ToString()))
            {
                return "check_Gia";
            }
            if (tour.DiaDiemKH == "")
            {
                return "requeid_DiaDiemKH";
            }
            if (tour.LoaiHinh == "")
            {
                return "requeid_LoaiHinh";
            }
            string info = Access.InsertTour(str_insert,sql_key);
            return info;
        }
        public string CheckUpdateTour(TOUR tour, string str_update)
        {
            Regex rgia = new Regex(@"^[0-9]$/");
            if (tour.Ma_Tour == "")
            {
                return "requeid_Ma_Tour";
            }
            if (tour.Img == "")
            {
                return "requeid_Img";
            }
            if (tour.Mota == "")
            {
                return "requeid_Mota";
            }
            if (tour.DiaDiem == "")
            {
                return "requeid_DiaDiem";
            }
            if (tour.ThoiGian == "")
            {
                return "requeid_ThoiGian";
            }
            if (tour.Gia == 0)
            {
                return "requeid_Gia";
            }
            if (!rgia.IsMatch(tour.Gia.ToString()))
            {
                return "check_Gia";
            }
            if (tour.DiaDiemKH == "")
            {
                return "requeid_DiaDiemKH";
            }
            if (tour.LoaiHinh == "")
            {
                return "requeid_LoaiHinh";
            }
            string info = Access.UpdateTour(str_update);
            return info;
        }

        // Kiểm tra ngoại lệ Tour khi thêm,sửa
        public string CheckInsertBooking(BOOKING booking, string str_insert)
        {
            string info = Access.InsertBooking(str_insert);
            return info;
        }
        public string CheckUpdateBooking(BOOKING booking, string str_update)
        {
            string info = Access.UpdateBooking(str_update);
            return info;
        }

        // Check Mabooking
        //public string Makh(string sql_key)
        //{
        //    return Access.Makh(sql_key);
        //}

        // CheckPK
        public string DeleteKey(string str_delete,string sql_key)
        {
            return Access.CheckDeleteKey(str_delete,sql_key);
        }

        // Xóa dữ liệu
        public string Delete(string str_delete)
        {
            return Access.Delete(str_delete);
        }

        // Lấy khuyến mãi
        public string Khuyenmai(string sql)
        {
            return Access.GetKhuyenmai(sql);
        }

        // Thanh toán
        public string Thanhtoan(string str_thanhtoan)
        {
            return Access.Thanhtoan(str_thanhtoan);
        } 

        // Hiển thị DGV
        public DataTable Hienthi(string sql_DGV)
        {
            return Access.Hienthi(sql_DGV);
        }

        // LoadCombobox
        public DataTable LoadCombobox(string sql )
        {
            return Access.LoadCombobox(sql);
        }

    }
}
