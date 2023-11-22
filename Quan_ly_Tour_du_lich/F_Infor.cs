using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Quan_Ly_Tour;
using BLL_Quan_Ly_Tour;

namespace Quan_ly_Tour_du_lich
{
    public partial class F_Infor : Form
    {
        KHACH_HANG khachhang = new KHACH_HANG();
        BLL_QLT BLL = new BLL_QLT();

        public static string email;
        public static string quyen;

        public F_Infor()
        {
            InitializeComponent();
        }

        public void clear_form()
        {
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_cccd.Clear();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            khachhang.Ten_KH = txt_tenkh.Text;
            string ngaysinh = date_ngaysinh.Value.Date.ToString("yyyy/MM/dd");
            khachhang.NgaySinh = ngaysinh;
            khachhang.DiaChi = txt_diachi.Text;
            khachhang.Sdt = txt_sdt.Text;
            khachhang.CCCD = txt_cccd.Text;
            string gioitinh = "";
            if (rd_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rd_nu.Checked)
            {
                gioitinh = "Nữ";
            }
            khachhang.GioiTinh = gioitinh;

            string str_insert = "INSERT INTO KHACH_HANG VALUES(N'" + khachhang.Ten_KH + "'," +
                " '" + khachhang.NgaySinh + "', N'" + khachhang.DiaChi + "'," +
                " '" + khachhang.Sdt + "', '" + khachhang.CCCD + "', '" + email + "',N'" + khachhang.GioiTinh + "')";
            string getkh = BLL.CheckInsertKhachhang(khachhang, str_insert);
            switch (getkh)
            {
                case "requeid_Ma_KH":
                    MessageBox.Show("Mã khách hàng không được để trống!");
                    return;
                case "requeid_Ten_KH":
                    MessageBox.Show("Tên không được để trống!");
                    return;
                case "requeid_DiaChi":
                    MessageBox.Show("Địa chỉ không được để trống!");
                    return;
                case "requeid_Sdt":
                    MessageBox.Show("Số điện thoại không được để trống!");
                    return;
                case "requeid_CCCD":
                    MessageBox.Show("Số CCCD không được để trống!");
                    return;
                case "check_CCCD":
                    MessageBox.Show("Số CCCD không đúng!");
                    return;
                case "check_sdt":
                    MessageBox.Show("Số điện thoại không đúng!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã khách hàng đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Nhập thông tin thành công!");
                    clear_form();
                    F_login flogin = new F_login();
                    flogin.Show();
                    this.Hide();
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            khachhang.Ma_KH = txt_makh.Text;
            khachhang.Ten_KH = txt_tenkh.Text;
            string ngaysinh = date_ngaysinh.Value.Date.ToString("yyyy/MM/dd");
            khachhang.NgaySinh = ngaysinh;
            khachhang.DiaChi = txt_diachi.Text;
            khachhang.Sdt = txt_sdt.Text;
            khachhang.CCCD = txt_cccd.Text;
            string gioitinh = "";
            if (rd_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rd_nu.Checked)
            {
                gioitinh = "Nữ";
            }
            khachhang.GioiTinh = gioitinh;

            string str_update = "UPDATE KHACH_HANG SET Ten_KH = N'" + khachhang.Ten_KH + "',NgaySinh = '" + khachhang.NgaySinh + "'," +
                "DiaChi = N'" + khachhang.DiaChi + "',Sdt = '" + khachhang.Sdt + "', CCCD = '" + khachhang.CCCD + "'," +
                "GioiTinh = N'" + khachhang.GioiTinh + "' WHERE Ma_KH = '" + khachhang.Ma_KH + "'";
            string getkh = BLL.CheckUpdateKhachhang(khachhang, str_update);
            switch (getkh)
            {
                case "requeid_Ma_KH":
                    MessageBox.Show("Mã khách hàng không được để trống!");
                    return;
                case "requeid_Ten_KH":
                    MessageBox.Show("Tên không được để trống!");
                    return;
                case "requeid_DiaChi":
                    MessageBox.Show("Địa chỉ không được để trống!");
                    return;
                case "requeid_Sdt":
                    MessageBox.Show("Số điện thoại không được để trống!");
                    return;
                case "requeid_CCCD":
                    MessageBox.Show("Số CCCD không được để trống!");
                    return;
                case "check_CCCD":
                    MessageBox.Show("Số CCCD không đúng!");
                    return;
                case "check_sdt":
                    MessageBox.Show("Số điện thoại không đúng!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã khách hàng đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Sửa thành công!");
                    clear_form();
                    txt_makh.Focus();
                    if (quyen == "003")
                    {
                        ThongtinKH_Login();
                    }
                    else
                    {
                        ThongtinNV_Login();
                    }
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ThongtinKH_Login()
        {
            string sql_kh = "SELECT * FROM KHACH_HANG WHERE Email = '" + email + "'";
            DataTable dt = BLL.LoadCombobox(sql_kh);
            txt_makh.Text = dt.Rows[0][0].ToString();
            txt_tenkh.Text = dt.Rows[0][1].ToString();
            date_ngaysinh.Text = dt.Rows[0][2].ToString();
            txt_diachi.Text = dt.Rows[0][3].ToString();
            txt_sdt.Text = dt.Rows[0][4].ToString();
            txt_cccd.Text = dt.Rows[0][5].ToString();
            if (dt.Rows[0][7].ToString() == "Nam")
            {
                rd_nam.Checked = true;
            }
            else if (dt.Rows[0][7].ToString() == "Nữ")
            {
                rd_nu.Checked = true;
            }
        }

        public void ThongtinNV_Login()
        {
            string sql_nv = "SELECT * FROM NHAN_VIEN WHERE Email = '" + email + "'";
            DataTable dt = BLL.LoadCombobox(sql_nv);
            txt_makh.Text = dt.Rows[0][0].ToString();
            txt_tenkh.Text = dt.Rows[0][1].ToString();
            date_ngaysinh.Text = dt.Rows[0][2].ToString();
            txt_diachi.Text = dt.Rows[0][3].ToString();
            txt_sdt.Text = dt.Rows[0][4].ToString();
            txt_cccd.Text = dt.Rows[0][5].ToString();
            if (dt.Rows[0][8].ToString() == "Nam")
            {
                rd_nam.Checked = true;
            }
            else if (dt.Rows[0][8].ToString() == "Nữ")
            {
                rd_nu.Checked = true;
            }
        }
        private void F_Infor_Load(object sender, EventArgs e)
        {
            if (quyen == "003")
            {
                ThongtinKH_Login();
                txt_makh.ReadOnly = true;
                bt_them.Visible = false;
            }
            else if (quyen == "002" || quyen == "001")
            {
                ThongtinNV_Login();
                txt_makh.ReadOnly = true;
                bt_them.Visible = false;
                bt_sua.Visible = false;
            }
            else
            {
                lb_ma.Visible = false;
                txt_makh.Visible = false;
                bt_sua.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
