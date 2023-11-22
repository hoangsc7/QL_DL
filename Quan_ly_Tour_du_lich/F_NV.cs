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
    public partial class F_NV : Form
    {
        NHAN_VIEN nhanvien = new NHAN_VIEN();
        BLL_QLT BLL = new BLL_QLT();

        public F_NV()
        {
            InitializeComponent();
        }
        public void clear_form()
        {
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_cccd.Clear();
        }
        // Load dữ liệu vào combobox
        public void LoadCombobox()
        {
            string sql = "SELECT * FROM ACCOUNT WHERE Ma_Quyen = '002'";
            DataTable dt = BLL.LoadCombobox(sql);
            cb_email.DisplayMember = "Email";
            cb_email.ValueMember = "Email";
            cb_email.DataSource = dt;
        }

        // Hiển thị dữ liệu vào Datagitview
        public void HienThi()
        {
            string sql_DGV = "SELECT * FROM NHAN_VIEN";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            txt_manv.Focus();
            DGV_nv.DataSource = dt_DGV;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            nhanvien.Ma_NV = txt_manv.Text;
            nhanvien.Ten_NV = txt_tennv.Text;
            string ngaysinh = date_ngaysinh.Value.Date.ToString("yyyy/MM/dd");
            nhanvien.NgaySinh = ngaysinh;
            nhanvien.DiaChi = txt_diachi.Text;
            nhanvien.Sdt = txt_sdt.Text;
            nhanvien.CCCD = txt_cccd.Text;
            nhanvien.ChucVu = cb_chucvu.Text;
            nhanvien.Email = cb_email.Text;
            string gioitinh = "";
            if (rd_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rd_nu.Checked)
            {
                gioitinh = "Nữ";
            }
            nhanvien.GioiTinh = gioitinh;

            string sql_key = "SELECT count(*)  FROM NHAN_VIEN WHERE Ma_NV = '" + nhanvien.Ma_NV + "'";
            string str_insert = "INSERT INTO NHAN_VIEN VALUES('" + nhanvien.Ma_NV + "',N'" + nhanvien.Ten_NV + "'," +
                " '" + nhanvien.NgaySinh + "', N'" + nhanvien.DiaChi + "','" + nhanvien.Sdt + "'," +
                " '" + nhanvien.CCCD + "', N'" + nhanvien.ChucVu + "','" + nhanvien.Email + "', N'" + nhanvien.GioiTinh + "')";
            string getnv = BLL.CheckInsertNhanvien(nhanvien,str_insert,sql_key);
            switch (getnv)
            {
                case "requeid_Ma_NV":
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    return;
                case "requeid_Ten_NV":
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
                case "requeid_ChucVu":
                    MessageBox.Show("Chức vụ không được để trống!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Thêm thành công!");
                    clear_form();
                    txt_manv.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        private void F_NV_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            HienThi();
        }

        private void DGV_nv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txt_manv.Text = DGV_nv.Rows[dong].Cells[0].Value.ToString();
                txt_tennv.Text = DGV_nv.Rows[dong].Cells[1].Value.ToString();
                date_ngaysinh.Text = DGV_nv.Rows[dong].Cells[2].Value.ToString();
                txt_diachi.Text = DGV_nv.Rows[dong].Cells[3].Value.ToString();
                txt_sdt.Text = DGV_nv.Rows[dong].Cells[4].Value.ToString();
                txt_cccd.Text = DGV_nv.Rows[dong].Cells[5].Value.ToString();
                cb_chucvu.Text = DGV_nv.Rows[dong].Cells[6].Value.ToString();
                cb_email.Text = DGV_nv.Rows[dong].Cells[7].Value.ToString();
            }
            catch
            {
                clear_form();
                txt_manv.Focus();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            nhanvien.Ma_NV = txt_manv.Text;
            nhanvien.Ten_NV = txt_tennv.Text;
            string ngaysinh = date_ngaysinh.Value.Date.ToString("yyyy/MM/dd");
            nhanvien.NgaySinh = ngaysinh;
            nhanvien.DiaChi = txt_diachi.Text;
            nhanvien.Sdt = txt_sdt.Text;
            nhanvien.CCCD = txt_cccd.Text;
            nhanvien.ChucVu = cb_chucvu.Text;
            nhanvien.Email = cb_email.Text;
            string gioitinh = "";
            if (rd_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rd_nu.Checked)
            {
                gioitinh = "Nữ";
            }
           nhanvien.GioiTinh = gioitinh;

            string str_update = "UPDATE NHAN_VIEN SET Ten_NV = N'" + nhanvien.Ten_NV + "',NgaySinh = '" + nhanvien.NgaySinh + "'," +
                " DiaChi = N'" + nhanvien.DiaChi + "',Sdt = '" + nhanvien.Sdt + "', CCCD = '" + nhanvien.CCCD + "'," +
                " ChucVu = N'" + nhanvien.ChucVu + "', Email = '" + nhanvien.Email + "',GioiTinh = N'" + nhanvien.GioiTinh + "'" +
                " WHERE Ma_NV = '" + nhanvien.Ma_NV + "'";
            string getnv = BLL.CheckUpdateNhanvien(nhanvien, str_update);
            switch (getnv)
            {
                case "requeid_Ma_NV":
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    return;
                case "requeid_Ten_NV":
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
                case "requeid_ChucVu":
                    MessageBox.Show("Chức vụ không được để trống!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Sửa thành công!");
                    clear_form();
                    txt_manv.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Sửa!");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            nhanvien.Ma_NV = txt_manv.Text;
            DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string str_delete = "DELETE FROM NHAN_VIEN WHERE Ma_NV = '" + nhanvien.Ma_NV + "'";
                    string del_nv = BLL.Delete(str_delete);
                    switch (del_nv)
                    {
                        case "Thành công!":
                            MessageBox.Show("Xóa thành công!");
                            clear_form();
                            txt_manv.Focus();
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
            txt_manv.Clear();
            txt_tennv.Clear();
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

                    string sql_DGV = "SELECT * FROM NHAN_VIEN WHERE Ma_NV = '" + txt_tim.Text + "'";
                    DataTable dt_DGV = BLL.Hienthi(sql_DGV);
                    DGV_nv.DataSource = dt_DGV;
                    txt_tim.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGV_nv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_nv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rd_nam.Checked = true;
                }
                else if (DGV_nv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nữ")
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
