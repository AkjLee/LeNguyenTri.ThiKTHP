using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDiDong.DAL
{
    public class QLSanPhamModel : DbContext
    {
        public QLSanPhamModel()
            : base("name=model1") { 
        }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
