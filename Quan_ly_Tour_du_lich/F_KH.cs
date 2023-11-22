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
    public partial class F_KH : Form
    {
        KHACH_HANG khachhang = new KHACH_HANG();
        BLL_QLT BLL = new BLL_QLT();

        public F_KH()
        {
            InitializeComponent();
        }

        public void clear_form()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_cccd.Clear();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            khachhang.Ma_KH = txt_makh.Text;
            khachhang.Ten_KH = txt_tenkh.Text;
            string ngaysinh = date_ngaysinh.Value.Date.ToString("yyyy/MM/dd");
            khachhang.NgaySinh = ngaysinh;
            khachhang.DiaChi = txt_diachi.Text;
            khachhang.Sdt = txt_sdt.Text;
            khachhang.CCCD = txt_cccd.Text;
            khachhang.Email = cb_email.Text;
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
                " '" + khachhang.Sdt + "', '" + khachhang.CCCD + "', '" + khachhang.Email + "',N'" + khachhang.GioiTinh + "')";
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
                //case "check_CCCD":
                //    MessageBox.Show("Số CCCD không đúng!");
                //    return;
                case "check_sdt":
                    MessageBox.Show("Số điện thoại không đúng!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã khách hàng đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Thêm thành công!");
                    clear_form();
                    txt_makh.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        public void LoadCombobox()
        {
            string sql = "SELECT * FROM ACCOUNT WHERE Ma_Quyen = '003'";
            DataTable dt = BLL.LoadCombobox(sql);
            cb_email.DisplayMember = "Email";
            cb_email.ValueMember = "Email";
            cb_email.DataSource = dt;
        }

        public void HienThi()
        {
            string sql_DGV = "SELECT * FROM KHACH_HANG";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            txt_makh.Focus();
            DGV_kh.DataSource = dt_DGV;
        }

        private void F_KH_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            HienThi();
            txt_makh.ReadOnly = true;
        }

        private void DGV_nv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txt_makh.Text = DGV_kh.Rows[dong].Cells[0].Value.ToString();
                txt_tenkh.Text = DGV_kh.Rows[dong].Cells[1].Value.ToString();
                date_ngaysinh.Text = DGV_kh.Rows[dong].Cells[2].Value.ToString();
                txt_diachi.Text = DGV_kh.Rows[dong].Cells[3].Value.ToString();
                txt_sdt.Text = DGV_kh.Rows[dong].Cells[4].Value.ToString();
                txt_cccd.Text = DGV_kh.Rows[dong].Cells[5].Value.ToString();
                cb_email.Text = DGV_kh.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            {
                clear_form();
                txt_makh.Focus();
            }
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
            khachhang.Email = cb_email.Text;
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
                "Email = '" + khachhang.Email + "',GioiTinh = N'" + khachhang.GioiTinh + "' WHERE Ma_KH = '" + khachhang.Ma_KH + "'";
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
                //case "check_CCCD":
                //    MessageBox.Show("Số CCCD không đúng!");
                //    return;
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
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            khachhang.Ma_KH = txt_makh.Text;
            DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string sql_key = "SELECT COUNT(*) FROM KHACH_HANG,BOOKING where KHACH_HANG.Ma_KH = BOOKING.Ma_KH and BOOKING.Ma_KH = '" + khachhang.Ma_KH + "'";
                    string str_delete = "DELETE FROM KHACH_HANG WHERE Ma_KH = '" + khachhang.Ma_KH + "'";
                    string del_nv = BLL.DeleteKey(str_delete, sql_key);
                    switch (del_nv)
                    {
                        case "Khóa ngoại!":
                            MessageBox.Show("Đang là khóa ngoại!");
                            return;
                        case "Thành công!":
                            MessageBox.Show("Xóa thành công!");
                            clear_form();
                            txt_makh.Focus();
                            HienThi();
                            return;
                    }
                    MessageBox.Show("Lỗi Xóa!");
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_cccd.Clear();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tim.Text == "")
                {
                    HienThi();
                }
                else
                {

                    string sql_DGV = "SELECT * FROM KHACH_HANG WHERE Ma_KH = '" + txt_tim.Text + "'";
                    DataTable dt_DGV = BLL.Hienthi(sql_DGV);
                    DGV_kh.DataSource = dt_DGV;
                    txt_tim.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGV_kh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_kh.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rd_nam.Checked = true;
                }
                else if (DGV_kh.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    rd_nu.Checked = true;
                }
            }
            catch
            {
                clear_form();
            }
        }
    }
}
