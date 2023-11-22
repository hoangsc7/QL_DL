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
    public partial class F_signup : Form
    {
        Insert_Account taikhoan = new Insert_Account();
        BLL_QLT tkBLL = new BLL_QLT();
        public bool isThoat = true;

        public F_signup()
        {
            InitializeComponent();
        }

        private void phiye1_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                peye1.BringToFront();
                txt_pass.PasswordChar = '\0';
            }
        }

        private void peye1_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                phiye1.BringToFront();
                txt_pass.PasswordChar = '*';
            }
        }

        private void phiye2_Click(object sender, EventArgs e)
        {
            if (txt_repass.PasswordChar == '*')
            {
                peye2.BringToFront();
                txt_repass.PasswordChar = '\0';
            }
        }

        private void peye2_Click(object sender, EventArgs e)
        {
            if (txt_repass.PasswordChar == '\0')
            {
                phiye2.BringToFront();
                txt_repass.PasswordChar = '*';
            }
        }


        private void bt_signup_Click(object sender, EventArgs e)
        {
            taikhoan.Email = txt_email.Text;
            taikhoan.Pass = txt_pass.Text;
            taikhoan.Repass = txt_repass.Text;

            string sql_key = "SELECT count(*) FROM ACCOUNT WHERE Email = '" + taikhoan.Email + "'";
            string str_insert = "INSERT INTO ACCOUNT VALUES('" + taikhoan.Email + "','" + taikhoan.Pass + "', '003')";
            string getemail = tkBLL.CheckSignup(taikhoan, str_insert,sql_key);
            switch (getemail)
            {
                case "requeid_email":
                    MessageBox.Show("Email không được để trống!");
                    return;
                case "check_email":
                    MessageBox.Show("Email không đúng!");
                    return;
                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "check_password":
                    MessageBox.Show("Mật khẩu phải lớn hơn 8 ký tự!");
                    return;
                case "requeid_pass_repass":
                    MessageBox.Show("Mật khẩu không trùng khớp!");
                    return;
                case "Không thành công!":
                    MessageBox.Show("Email đã có trong hệ thống!");
                    return;
                case "Thành công!":
                    MessageBox.Show("Đăng ký thành công!");
                    F_Infor.email = txt_email.Text;
                    F_Infor finfor = new F_Infor();
                    finfor.Show();
                    this.Hide();
                    return;
            }
            MessageBox.Show("Lỗi đăng ký!");
        }

        private void F_signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void F_signup_Load(object sender, EventArgs e)
        {

        }
    }
}
