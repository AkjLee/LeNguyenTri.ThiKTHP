using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDiDong
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txtUsser.Focus();
            txtPass.Focus();
        }
        void dangnhap()
        {
            if (txtUsser.Text.Length == 0 && txtPass.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản mật khẩu");
            else
                if (txtUsser.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản");
            else
                    if (txtPass.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
            else
                    if (this.txtUsser.Text == "Admin" && this.txtPass.Text == "123")
                MessageBox.Show("Bạn đăng nhập tài khoản mật khẩu thành công");
            else
                MessageBox.Show("Bạn đăng nhập thất bại");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmQLSP frm = new frmQLSP();
            if (this.txtUsser.Text == "Admin" && this.txtPass.Text == "123")
            {
                frm.Show();
            }
            dangnhap();
            this.Hide();
        }
    }
}
