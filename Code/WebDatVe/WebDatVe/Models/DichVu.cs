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
    
    public partial class DichVu
    {
        public DichVu()
        {
            this.DonHangDichVus = new HashSet<DonHangDichVu>();
        }
    
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public string NoiDung { get; set; }
        public int GiaTien { get; set; }
        public string HinhAnh { get; set; }
        public System.DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
    
        public virtual ICollection<DonHangDichVu> DonHangDichVus { get; set; }
    }
}
