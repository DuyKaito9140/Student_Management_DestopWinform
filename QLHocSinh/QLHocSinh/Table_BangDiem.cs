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
    
    public partial class Table_BangDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_BangDiem()
        {
            this.Table_HocSinh = new HashSet<Table_HocSinh>();
        }
    
        public string MaDiem { get; set; }
        public string Toan { get; set; }
        public string Ly { get; set; }
        public string Hoa { get; set; }
        public string TiengAnh { get; set; }
        public string Gdcd { get; set; }
        public string Van { get; set; }
        public string Su { get; set; }
        public string Dia { get; set; }
        public string CongNghe { get; set; }
        public string TinHoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_HocSinh> Table_HocSinh { get; set; }
    }
}
