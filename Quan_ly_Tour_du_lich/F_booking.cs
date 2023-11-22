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
    public partial class F_booking : Form
    {
        BOOKING booking = new BOOKING();
        BLL_QLT BLL = new BLL_QLT();

        public static string email;
        public static string quyen;

        public F_booking()
        {
            InitializeComponent();
        }

        public void clear_form()
        {
            txt_mabooking.Clear();
            cb_nguoilon.Text = String.Empty;
            cb_treem.Text = String.Empty;
            cb_embe.Text = String.Empty;
        }
        public void HienThi()
        {
            string sql_DGV = "SELECT * FROM BOOKING";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            DGV_booking.DataSource = dt_DGV;
        }

        public void HienThiKH_Login()
        {
            string sql_DGV = "SELECT * FROM BOOKING WHERE Ma_KH = '"+ txt_makh.Text +"'";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            DGV_booking.DataSource = dt_DGV;
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
        }


        public void ThongtinNV_Login()
        {
            string sql_kh = "SELECT * FROM NHAN_VIEN WHERE Email = '" + email + "'";
            DataTable dt = BLL.LoadCombobox(sql_kh);
            txt_makh.Text = dt.Rows[0][0].ToString();
            txt_tenkh.Text = dt.Rows[0][1].ToString();
            date_ngaysinh.Text = dt.Rows[0][2].ToString();
            txt_diachi.Text = dt.Rows[0][3].ToString();
            txt_sdt.Text = dt.Rows[0][4].ToString();
        }

        public void ThongtinTour()
        {
            string sql_tour = "SELECT * FROM TOUR";
            DataTable dt = BLL.LoadCombobox(sql_tour);
            cb_matour.DisplayMember = "Ma_Tour";
            cb_matour.ValueMember = "Ma_Tour";
            cb_matour.DataSource = dt;
            txt_diadiem.DataBindings.Clear();
            txt_diadiem.DataBindings.Add("Text", cb_matour.DataSource, "DiaDiem");
            txt_thoigian.DataBindings.Clear();
            txt_thoigian.DataBindings.Add("Text", cb_matour.DataSource, "ThoiGian");
            date_khoihanh.DataBindings.Clear();
            date_khoihanh.DataBindings.Add("Text", cb_matour.DataSource, "NgayKhoiHanh");
            txt_gia.DataBindings.Clear();
            txt_gia.DataBindings.Add("Text", cb_matour.DataSource, "GiaKM");
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int nguoilon = int.Parse(cb_nguoilon.Text);
            booking.NguoiLon = nguoilon;
            int treem = int.Parse(cb_treem.Text);
            booking.TreEm = treem;
            int embe = int.Parse(cb_embe.Text);
            booking.EmBe = embe;
            int gia = int.Parse(txt_gia.Text);
            booking.Gia = (gia * nguoilon) + (gia * treem * (100 - 20) / 100) + (gia * embe * (100 - 50) / 100);
            booking.NgayBooking = DateTime.Now.ToString("yyyy/MM/dd");
            string pttt = "";
            if (rd_tienmat.Checked)
            {
                pttt = "Tiền mặt";
            }
            else if (rd_online.Checked)
            {
                pttt = "Online";
            }
            booking.PTTT = pttt;
            booking.ThoiHan_TT = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd");
            booking.LuuY = null; 
            booking.Ma_Tour= cb_matour.Text;
            booking.Ma_KH = txt_makh.Text;

            string str_insert = "INSERT INTO BOOKING VALUES('" + booking.NguoiLon + "'," +
                " '" + booking.TreEm + "', '" + booking.EmBe + "','" + booking.Gia + "','" + booking.NgayBooking + "'," +
                " N'" + booking.PTTT + "', '" + booking.ThoiHan_TT + "', N'" + booking.LuuY + "', N'Chưa thanh toán', '" + booking.Ma_Tour + "'," +
                " '" + booking.Ma_KH + "')";
            string getkh = BLL.CheckInsertBooking(booking, str_insert);
            switch (getkh)
            {
                case "requeid_Ma_KH":
                    MessageBox.Show("Mã booking không được để trống!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã booking đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Thêm thành công!");
                    clear_form();
                    txt_mabooking.Focus();
                    if (quyen == "003")
                    {
                        HienThiKH_Login();
                    }
                    else
                    {
                        HienThi();
                    }
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        private void F_booking_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<100; i++)
            {
                cb_nguoilon.Items.Add(i);
                cb_treem.Items.Add(i);
                cb_embe.Items.Add(i);
            }
            ThongtinTour();
            if (quyen == "003")
            {
                ThongtinKH_Login();
                HienThiKH_Login();
                txt_mabooking.ReadOnly = true;
                txt_makh.ReadOnly = true;
                txt_tenkh.ReadOnly = true;
                date_ngaysinh.Enabled = false;
                txt_diachi.ReadOnly = true;
                txt_sdt.ReadOnly = true;
                txt_diadiem.ReadOnly = true;
                txt_thoigian.ReadOnly = true;
                date_khoihanh.Enabled = false;
                txt_gia.ReadOnly = true;

            }
            else
            {
                bt_thanhtoan.Visible = false;
                ThongtinNV_Login();            
                HienThi();
            }
        
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            booking.Ma_Booking = txt_mabooking.Text;
            DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string str_delete = "DELETE FROM BOOKING WHERE Ma_Booking = '" + booking.Ma_Booking + "'";
                    string del_nv = BLL.Delete(str_delete);
                    switch (del_nv)
                    {
                        case "Thành công!":
                            MessageBox.Show("Xóa thành công!");
                            clear_form();
                            txt_mabooking.Focus();
                            if (quyen == "003")
                            {
                                HienThiKH_Login();
                            }
                            else
                            {
                                HienThi();
                            }
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

        private void bt_sua_Click(object sender, EventArgs e)
        {
            booking.Ma_Booking = txt_mabooking.Text;
            int nguoilon = int.Parse(cb_nguoilon.Text);
            booking.NguoiLon = nguoilon;
            int treem = int.Parse(cb_treem.Text);
            booking.TreEm = treem;
            int embe = int.Parse(cb_embe.Text);
            booking.EmBe = embe;
            int gia = int.Parse(txt_gia.Text);
            booking.Gia = (gia * nguoilon) + (gia * treem * (100 - 20) / 100) + (gia * embe * (100 - 50) / 100);
            booking.NgayBooking = DateTime.Now.ToString("yyyy/MM/dd");
            string pttt = "";
            if (rd_tienmat.Checked)
            {
                pttt = "Tiền mặt";
            }
            else if (rd_online.Checked)
            {
                pttt = "Banking";
            }
            booking.PTTT = pttt;
            booking.ThoiHan_TT = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd");
            booking.LuuY = null;
            booking.Ma_Tour = cb_matour.Text;
            booking.Ma_KH = txt_makh.Text;

            string str_update = "UPDATE BOOKING SET NguoiLon = N'" + booking.NguoiLon + "',TreEm = '" + booking.TreEm + "'," +
                "EmBe = N'" + booking.EmBe + "',Gia = '" + booking.Gia + "', NgayBooking = '" + booking.NgayBooking + "'," +
                "PTTT = N'" + booking.PTTT + "',ThoiHan_TT = '" + booking.ThoiHan_TT + "',LuuY = N'" + booking.LuuY + "'," +
                "Ma_Tour = '" + booking.Ma_Tour + "', Ma_KH = '" + booking.Ma_KH + "'  WHERE Ma_Booking = '" + booking.Ma_Booking + "'";
            string getkh = BLL.CheckUpdateBooking(booking, str_update);
            switch (getkh)
            {
                case "requeid_Ma_KH":
                    MessageBox.Show("Mã booking không được để trống!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã booking đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Sửa thành công!");
                    clear_form();
                    txt_mabooking.Focus();
                    if (quyen == "003")
                    {
                        HienThiKH_Login();
                    }
                    else
                    {
                        HienThi();
                    }
                    return;
            }
            MessageBox.Show("Lỗi Sửa!");
        }

        private void DGV_booking_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txt_mabooking.Text = DGV_booking.Rows[dong].Cells[0].Value.ToString();
                cb_nguoilon.Text = DGV_booking.Rows[dong].Cells[1].Value.ToString();
                cb_treem.Text = DGV_booking.Rows[dong].Cells[2].Value.ToString();
                cb_embe.Text = DGV_booking.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
                clear_form();
                txt_mabooking.Focus();
            }
        }

        private void DGV_booking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_booking.CurrentRow.Cells["PTTT"].Value.ToString() == "Tiền mặt")
                {
                    rd_tienmat.Checked = true;
                }
                else if (DGV_booking.CurrentRow.Cells["PTTT"].Value.ToString() == "Banking")
                {
                    rd_online.Checked = true;
                }
            }
            catch
            {
                clear_form();
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_mabooking.Text = String.Empty;
            cb_nguoilon.Text = String.Empty;
            cb_treem.Text = String.Empty;
            cb_embe.Text = String.Empty;
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

                    string sql_DGV = "SELECT * FROM BOOKING WHERE Ma_Booking = '" + txt_tim.Text + "'";
                    DataTable dt_DGV = BLL.Hienthi(sql_DGV);
                    DGV_booking.DataSource = dt_DGV;
                    txt_tim.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            booking.Ma_Booking = txt_mabooking.Text;
            DialogResult msg = MessageBox.Show("Bạn thực sự muốn thanh toán!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string str_thanhtoan= "UPDATE BOOKING SET XacnhanTT = 'Đã thanh toán' WHERE Ma_booking = '" + booking.Ma_Booking + "'";
                    string del_nv = BLL.Thanhtoan(str_thanhtoan);
                    switch (del_nv)
                    {
                        case "Thành công!":
                            MessageBox.Show("Thanh toán thành công!");
                            clear_form();
                            txt_mabooking.Focus();
                            if (quyen == "003")
                            {
                                HienThiKH_Login();
                            }
                            else
                            {
                                HienThi();
                            }
                            return;
                    }
                    MessageBox.Show("Lỗi Thanh toán!");
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cb_nguoilon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
