using QLCuaHangDiDong.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDiDong.DAL;
using QLCuaHangDiDong.ViewModel;

namespace QLCuaHangDiDong
{
    public partial class frmQLSP : Form
    {
        public frmQLSP()
        {
            InitializeComponent();
            NapSanPham();
        }
        void NapSanPham()
        {
            var ls = SanPhamBLL.GetListViewModel();
            SanPhambindingSource.DataSource = ls;
            dataGridView1.DataSource = SanPhambindingSource;
        }
        public void get()
        {
            QLSanPhamModel model = new QLSanPhamModel();
            var rows = model.SanPhams.Select(row => row);
            SanPhambindingSource.DataSource = rows;
            dataGridView1.DataSource = SanPhambindingSource;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sanPham = SanPhambindingSource.Current as SanPhamViewModel;
            if(sanPham != null)
            {
                SanPhamBLL.Delete(sanPham.TenSP);
                MessageBox.Show("Xóa thành công", "Thông báo");
                NapSanPham();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSP();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapSanPham();
            }
        }
        int i;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = dataGridView1.CurrentRow.Index;
            lbl.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text)|| string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa");
            }
            else
            {
                QLSanPhamModel model = new QLSanPhamModel();
                var lh = model.SanPhams.Where(t => t.TenSP == lbl.Text).FirstOrDefault();
                lh.MaSP = txtMaSP.Text;
                lh.TenSP = txtTenSP.Text;
                lh.Gia = txtGia.Text;
                model.SanPhams.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thành công");
                NapSanPham();
            }
        }
    }
}
