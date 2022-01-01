namespace QLCuaHangDiDong.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [StringLength(50)]
        public string MaCTHD { get; set; }

        [StringLength(50)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string SoLuong { get; set; }

        [StringLength(50)]
        public string MaHD { get; set; }

        public bool? DaMua { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
