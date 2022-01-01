using QLCuaHangDiDong.ViewModel;
using QLCuaHangDiDong.BLL;
using QLCuaHangDiDong.DAL;
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
    public partial class frmThemSP : Form
    {
        SanPhamViewModel sanPham;
        public frmThemSP()
        {
            InitializeComponent();
            this.sanPham = sanPham;
            if(sanPham == null)
            {
                this.Text = "Thêm mới sản phẩm";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu";
                txtMaSP.Text = sanPham.MaSP;
                txtTenSP.Text = sanPham.TenSP;
                txtGia.Text = sanPham.Gia;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXanNhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var sanPham = txtMaSP.Text;
            var sanPham2 = txtTenSP.Text;
            var sanPham3 = txtGia.Text;
            QLSanPhamModel model = new QLSanPhamModel();
            var lh = model.SanPhams.Where(t => t.MaSP == sanPham.ToString()).FirstOrDefault();
            if(lh != null)
            {
                MessageBox.Show("Sản phẩm đã tôn tại", "Chú ý");
            }
            else
            {
                lh = new SanPham
                {
                    MaSP = sanPham,
                    TenSP = sanPham2,
                    Gia = sanPham3
                };
                model.SanPhams.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
