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
    
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            this.TaiKhoans = new HashSet<TaiKhoan>();
        }
    
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string DanhSach { get; set; }
    
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
