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
    public partial class F_KM : Form
    {
        KHUYEN_MAI khuyenmai = new KHUYEN_MAI();
        BLL_QLT BLL = new BLL_QLT();
        public F_KM()
        {
            InitializeComponent();
        }

        public void clear_form()
        {
            txt_makm.Clear();
            txt_tim.Clear();
        }

        public void HienThi()
        {
            string sql_DGV = "SELECT * FROM KHUYEN_MAI";
            DataTable dt_DGV = BLL.Hienthi(sql_DGV);
            DGV_km.DataSource = dt_DGV;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            khuyenmai.Ma_KM = txt_makm.Text;
            string ngaykm = date_ngaykm.Value.Date.ToString("yyyy/MM/dd");
            khuyenmai.Ngay_KM = ngaykm;
            string ngayktkm = date_ngayktkm.Value.Date.ToString("yyyy/MM/dd");
            khuyenmai.Ngay_KTKM = ngayktkm;
            khuyenmai.KhuyenMai = nu_km.Text;

            string sql_key = "SELECT count(*) FROM KHUYEN_MAI WHERE Ma_KM = '" + khuyenmai.Ma_KM + "'";
            string str_insert = "INSERT INTO KHUYEN_MAI VALUES('" + khuyenmai.Ma_KM + "','" + khuyenmai.Ngay_KM + "'," +
                " '" + khuyenmai.Ngay_KTKM + "', '" + khuyenmai.KhuyenMai + "')";
            string getkm = BLL.CheckInsertKhuyenmai(khuyenmai,str_insert,sql_key);
            switch (getkm)
            {
                case "requeid_Ma_KM":
                    MessageBox.Show("Mã khuyến mãi không được để trống!");
                    return;
                case "requeid_Khuyenmai":
                    MessageBox.Show("Thông tin không được để trống!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Mã khuyến mãi đã tồn tại!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Thêm thành công!");
                    clear_form();
                    txt_makm.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi đăng ký!");
        }

        private void F_KM_Load(object sender, EventArgs e)
        {
            
            HienThi();
        }

        private void DGV_km_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txt_makm.Text = DGV_km.Rows[dong].Cells[0].Value.ToString();
                date_ngaykm.Text = DGV_km.Rows[dong].Cells[1].Value.ToString();
                date_ngayktkm.Text = DGV_km.Rows[dong].Cells[2].Value.ToString();
                nu_km.Text = DGV_km.Rows[dong].Cells[3].Value.ToString();
                txt_makm.Focus();
            }
            catch
            {
                clear_form();
                txt_makm.Focus();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            khuyenmai.Ma_KM = txt_makm.Text;
            string ngaykm = date_ngaykm.Value.Date.ToString("yyyy/MM/dd");
            khuyenmai.Ngay_KM = ngaykm;
            string ngayktkm = date_ngayktkm.Value.Date.ToString("yyyy/MM/dd");
            khuyenmai.Ngay_KTKM = ngayktkm;
            khuyenmai.KhuyenMai = nu_km.Text;

            string str_update = "UPDATE KHUYEN_MAI SET Ngay_KM = N'" + khuyenmai.Ngay_KM + "', Ngay_KTKM = N'" + khuyenmai.Ngay_KTKM + "'," +
                "KhuyenMai = '" + khuyenmai.KhuyenMai + "' WHERE Ma_KM = '" + khuyenmai.Ma_KM + "'";
            string getkm = BLL.CheckUpdateKhuyenmai(khuyenmai, str_update);
            switch (getkm)
            {
                case "requeid_Ma_KM":
                    MessageBox.Show("Mã khuyến mãi không được để trống!");
                    return;
                case "requeid_Khuyenmai":
                    MessageBox.Show("Thông tin không được để trống!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Sửa thành công!");
                    clear_form();
                    txt_makm.Focus();
                    HienThi();
                    return;
            }
            MessageBox.Show("Lỗi sửa!");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            khuyenmai.Ma_KM = txt_makm.Text;
            DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string sql_key = "SELECT COUNT(*) FROM KHUYEN_MAI,TOUR where KHUYEN_MAI.Ma_KM = TOUR.Ma_KM and TOUR.Ma_KM = '" + khuyenmai.Ma_KM + "'";
                    string str_delete = "DELETE FROM KHUYEN_MAI WHERE Ma_KM = '" + khuyenmai.Ma_KM + "'";
                    string del_km = BLL.DeleteKey(str_delete,sql_key);
                    switch (del_km)
                    {
                        case "Khóa ngoại!":
                            MessageBox.Show("Đang là khóa ngoại!");
                            return;
                        case "Thành công!":
                            MessageBox.Show("Xóa thành công!");
                            clear_form();
                            nu_km.Focus();
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
            txt_makm.Clear();
            txt_tim.Clear();
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

                    string sql_DGV = "SELECT * FROM KHUYEN_MAI WHERE Ma_KM = '"+ txt_tim.Text +"'";
                    DataTable dt_DGV = BLL.Hienthi(sql_DGV);
                    DGV_km.DataSource = dt_DGV;
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
