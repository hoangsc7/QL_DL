using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO_Quan_Ly_Tour;
using BLL_Quan_Ly_Tour;

namespace Quan_ly_Tour_du_lich
{
    public partial class F_tour : Form
    {
        TOUR tour = new TOUR();
        BLL_QLT BLL = new BLL_QLT();
        public F_tour()
        {
            InitializeComponent();
        }

        public void clear_form()
        {
            txt_matour.Clear();
            txt_img.Clear();
            txt_diadiem.Clear();
            txt_ddkhoihanh.Clear();
            txt_gia.Clear();
            txt_mota.Clear();
            txt_thoigian.Clear();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            tour.Ma_Tour = txt_matour.Text;
            tour.Img = txt_img.Text;
            tour.Mota = txt_mota.Text;
            tour.DiaDiem = txt_diadiem.Text;
            tour.ThoiGian = txt_thoigian.Text;
            string ngaykh = date_khoihanh.Value.Date.ToString("yyyy/MM/dd");
            tour.NgayKhoiHanh = ngaykh;
            int gia = int.Parse(txt_gia.Text);
            tour.Gia = gia;
            tour.DiaDiemKH = txt_ddkhoihanh.Text;
            tour.LoaiHinh = cb_loaihinh.Text;
            tour.Ma_KM = cb_makm.Text;

            string sql_km = "SELECT KhuyenMai FROM KHUYEN_MAI WHERE Ma_KM = '" + tour.Ma_KM + "'";
            int khuyenmai = int.Parse(BLL.Khuyenmai(sql_km));
            tour.GiaKM = gia * (100 - khuyenmai) / 100;

            string sql_key = "SELECT count(*)  FROM TOUR WHERE Ma_Tour = '" + tour.Ma_Tour +"'";
            string str_insert = "INSERT INTO TOUR VALUES('" + tour.Ma_Tour + "','" + tour.Img + "'," +
                " N'" + tour.Mota + "', N'" + tour.DiaDiem + "', '" + tour.ThoiGian + "', '" + tour.NgayKhoiHanh + "'," +
                " '" + tour.GiaKM + "','" + tour.Gia + "',N'" + tour.DiaDiemKH + "',N'" + tour.LoaiHinh + "','" + tour.Ma_KM + "')";
            string gettour = BLL.CheckInsertTour(tour, str_insert, sql_key);

            switch (gettour)
            {
                case "requeid_Tour":
                    MessageBox.Show("Mã tour không được để trống!");
                    return;
                case "requeid_Img":
                    MessageBox.Show("IMG không được để trống!");
                    return;
                case "requeid_Mota":
                    MessageBox.Show("Mô tả không được để trống!");
                    return;
                case "requeid_DiaDiem":
                    MessageBox.Show("Địa điểm không được để trống!");
                    return;
                case "requeid_ThoiGian":
                    MessageBox.Show("Thời gian không được để trống!");
                    return;
                case "requeid_Gia":
                    MessageBox.Show("Giá không được để trống!");
                    return;
                case "requeid_DiaDiemKH":
                    MessageBox.Show("Địa điểm khởi hành không được để trống!");
                    return;
                case "requeid_LoaiHinh":
                    MessageBox.Show("Loại hình không được để trống!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã tour đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Thêm thành công!");
                    clear_form();
                    txt_matour.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Thêm!");
        }

        public void LoadConbobox()
        {
            string sql = "SELECT * FROM KHUYEN_MAI";
            DataTable dt = BLL.LoadCombobox(sql);
            cb_makm.DisplayMember = "Ma_KM";
            cb_makm.ValueMember = "KhuyenMai";
            cb_makm.DataSource = dt;
        }

        public void HienThi()
        {
            string sql_DGV = "SELECT * FROM TOUR";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            txt_matour.Focus();
            DGV_tour.DataSource = dt_DGV;
        }
        private void F_tour_Load(object sender, EventArgs e)
        {
            LoadConbobox();
            HienThi();
        }

        private void bt_mo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All file(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pt_img.Image = Image.FromFile(dlgOpen.FileName);
                txt_img.Text = dlgOpen.FileName;
            }
        }

        private void DGV_tour_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txt_matour.Text = DGV_tour.Rows[dong].Cells[0].Value.ToString();
                txt_img.Text = DGV_tour.Rows[dong].Cells[1].Value.ToString();
                txt_mota.Text = DGV_tour.Rows[dong].Cells[2].Value.ToString();
                txt_diadiem.Text = DGV_tour.Rows[dong].Cells[3].Value.ToString();
                txt_thoigian.Text = DGV_tour.Rows[dong].Cells[4].Value.ToString();
                date_khoihanh.Text = DGV_tour.Rows[dong].Cells[5].Value.ToString();
                txt_gia.Text = DGV_tour.Rows[dong].Cells[7].Value.ToString();
                txt_ddkhoihanh.Text = DGV_tour.Rows[dong].Cells[8].Value.ToString();
                cb_loaihinh.Text = DGV_tour.Rows[dong].Cells[9].Value.ToString();
                cb_makm.Text = DGV_tour.Rows[dong].Cells[10].Value.ToString();

            }
            catch
            {
                clear_form();
                txt_matour.Focus();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tour.Ma_Tour = txt_matour.Text;
            tour.Img = txt_img.Text;
            tour.Mota = txt_mota.Text;
            tour.DiaDiem = txt_diadiem.Text;
            tour.ThoiGian = txt_thoigian.Text;
            string ngaykh = date_khoihanh.Value.Date.ToString("yyyy/MM/dd");
            tour.NgayKhoiHanh = ngaykh;
            int gia = int.Parse(txt_gia.Text);
            tour.Gia = gia;
            tour.DiaDiemKH = txt_ddkhoihanh.Text;
            tour.LoaiHinh = cb_loaihinh.Text;
            tour.Ma_KM = cb_makm.Text;
            string sql_km = "SELECT KhuyenMai FROM KHUYEN_MAI WHERE Ma_KM = '" + tour.Ma_KM + "'";
            int khuyenmai = int.Parse(BLL.Khuyenmai(sql_km));
            tour.GiaKM = gia * (100 - khuyenmai) / 100;

            string str_update = "UPDATE TOUR SET Img = '" + tour.Img + "',Mota = N'" + tour.Mota + "'," +
                "DiaDiem = N'" + tour.DiaDiem + "',ThoiGian = '" + tour.ThoiGian + "', NgayKhoiHanh = N'" + tour.NgayKhoiHanh + "'," +
                "GiaKM = '" + tour.GiaKM + "', Gia = '" + tour.Gia + "', DiaDiemKH = N'" + tour.DiaDiemKH + "'," +
                "LoaiHinh = N'" + tour.LoaiHinh + "', Ma_KM = '" + tour.Ma_KM + "' WHERE Ma_Tour = '" + tour.Ma_Tour + "'";
            string gettour = BLL.CheckUpdateTour(tour, str_update);

            switch (gettour)
            {
                case "requeid_Tour":
                    MessageBox.Show("Mã tour không được để trống!");
                    return;
                case "requeid_Img":
                    MessageBox.Show("IMG không được để trống!");
                    return;
                case "requeid_Mota":
                    MessageBox.Show("Mô tả không được để trống!");
                    return;
                case "requeid_DiaDiem":
                    MessageBox.Show("Địa điểm không được để trống!");
                    return;
                case "requeid_ThoiGian":
                    MessageBox.Show("Thời gian không được để trống!");
                    return;
                case "requeid_Gia":
                    MessageBox.Show("Giá không được để trống!");
                    return;
                case "requeid_DiaDiemKH":
                    MessageBox.Show("Địa điểm khởi hành không được để trống!");
                    return;
                case "requeid_LoaiHinh":
                    MessageBox.Show("Loại hình không được để trống!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Sửa thành công!");
                    clear_form();
                    txt_matour.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi Sửa!");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tour.Ma_Tour = txt_matour.Text;
            DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string sql_key = "SELECT COUNT(*) FROM TOUR,BOOKING where TOUR.Ma_Tour = BOOKING.Ma_Tour and BOOKING.Ma_Tour = '" + tour.Ma_Tour + "'";
                    string str_delete = "DELETE FROM TOUR WHERE Ma_Tour = '" + tour.Ma_Tour + "'";
                    string del_nv = BLL.DeleteKey(str_delete, sql_key);
                    switch (del_nv)
                    {
                        case "Khóa ngoại!":
                            MessageBox.Show("Đang là khóa ngoại!");
                            return;
                        case "Thành công!":
                            MessageBox.Show("Xóa thành công!");
                            clear_form();
                            txt_matour.Focus();
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
            txt_matour.Clear();
            txt_img.Clear();
            txt_diadiem.Clear();
            txt_ddkhoihanh.Clear();
            txt_gia.Clear();
            txt_mota.Clear();
            txt_thoigian.Clear();
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

                    string sql_DGV = "SELECT * FROM TOUR WHERE Ma_Tour = '" + txt_tim.Text + "'";
                    DataTable dt_DGV = BLL.Hienthi(sql_DGV);
                    DGV_tour.DataSource = dt_DGV;
                    txt_tim.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
