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
    
    public partial class Ghe
    {
        public Ghe()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        public int MaGhe { get; set; }
        public int MaPhong { get; set; }
        public string TenGhe { get; set; }
        public int LoaiGhe { get; set; }
        public string SoHang { get; set; }
        public int SoO { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual Phong Phong { get; set; }
    }
}