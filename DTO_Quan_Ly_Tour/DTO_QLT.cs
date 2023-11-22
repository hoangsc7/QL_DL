using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_Ly_Tour
{
    public class ACCOUNT
    {
        public string Email { get; set; }
        public string Mat_Khau { get; set; }
        public string Ma_Quyen { get; set; }
    }
    public class Insert_Account
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Repass { get; set; }
    }
    public class Quyen
    {
        public string Ma_Quyen { get; set; }
        public string quyen { get; set; }
    }
    public class KHUYEN_MAI
    {
        public string Ma_KM { get; set; }
        public string Ngay_KM { get; set; }
        public string Ngay_KTKM { get; set; }
        public string KhuyenMai { get; set; }
    }
    public class KHACH_HANG
    {
        public string Ma_KH { get; set; }
        public string Ten_KH { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
    }
    public class NHAN_VIEN
    {
        public string Ma_NV { get; set; }
        public string Ten_NV { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string CCCD { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
    }
    public class TOUR
    {
        public string Ma_Tour { get; set; }
        public string Img { get; set; }
        public string Mota { get; set; }
        public string DiaDiem { get; set; }
        public string ThoiGian { get; set; }
        public string NgayKhoiHanh { get; set; }
        public int GiaKM { get; set; }
        public int Gia { get; set; }
        public string DiaDiemKH { get; set; }
        public string LoaiHinh { get; set; }
        public string Ma_KM { get; set; }
    }
    public class BOOKING
    {
        public string Ma_Booking { get; set; }
        public int NguoiLon { get; set; }
        public int TreEm { get; set; }
        public int EmBe { get; set; }
        public int Gia { get; set; }
        public string NgayBooking { get; set; }
        public string PTTT { get; set; }
        public string ThoiHan_TT { get; set; }
        public string LuuY { get; set; }
        public string Ma_Tour { get; set; }
        public string Ma_KH { get; set; }
    }
}
