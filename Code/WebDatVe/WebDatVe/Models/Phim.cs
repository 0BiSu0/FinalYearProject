//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDatVe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phim
    {
        public Phim()
        {
            this.LichChieux = new HashSet<LichChieu>();
            this.TheLoais = new HashSet<TheLoai>();
        }
    
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string GioiThieu { get; set; }
        public string NoiDung { get; set; }
        public string HinhAnh { get; set; }
        public string VideoGioiThieu { get; set; }
        public int ThoiLuong { get; set; }
        public System.DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public System.DateTime NgayKhoiChieu { get; set; }
    
        public virtual ICollection<LichChieu> LichChieux { get; set; }
        public virtual ICollection<TheLoai> TheLoais { get; set; }
    }
}
