//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHocSinh
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_HocSinh
    {
        public string MaHS { get; set; }
        public string TenHocSinh { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string MaLop { get; set; }
        public string MaDiem { get; set; }
    
        public virtual Table_BangDiem Table_BangDiem { get; set; }
        public virtual Table_LopHoc Table_LopHoc { get; set; }
    }
}
