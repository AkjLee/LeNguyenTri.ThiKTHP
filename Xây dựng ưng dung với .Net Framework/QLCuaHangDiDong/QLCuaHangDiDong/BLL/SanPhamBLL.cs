using QLCuaHangDiDong.DAL;
using QLCuaHangDiDong.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDiDong.BLL
{
    internal class SanPhamBLL
    {
        public static List<SanPham> GetList(String TenSP)
        {
            QLSanPhamModel model = new QLSanPhamModel();
            var ls = model.SanPhams.Where(e => e.TenSP == TenSP).ToList();
            return ls;
        }
        public static List<SanPhamViewModel> GetListViewModel()
        {
            QLSanPhamModel model = new QLSanPhamModel();
            var ls = model.SanPhams.Select(e => new SanPhamViewModel
            {
                MaSP = e.MaSP,
                TenSP = e.TenSP,
                Gia = e.Gia
            }).ToList();
            return ls;
        }
        public static bool Delete (String MaSP)
        {
            QLSanPhamModel model = new QLSanPhamModel();
            var sanPham = model.SanPhams.Where(e => e.TenSP == MaSP).FirstOrDefault();

                model.SanPhams.Remove(sanPham);
                model.SaveChanges();
            return true;

        }
    }
}
