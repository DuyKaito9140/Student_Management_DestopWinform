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
    
    public partial class Table_LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_LopHoc()
        {
            this.Table_HocSinh = new HashSet<Table_HocSinh>();
        }
    
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string Khoi { get; set; }
        public string GiaoVien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_HocSinh> Table_HocSinh { get; set; }
    }
}