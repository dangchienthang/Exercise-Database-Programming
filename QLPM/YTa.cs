//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class YTa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YTa()
        {
            this.LichKhams = new HashSet<LichKham>();
        }
    
        public int MaYT { get; set; }
        public string HoTenYT { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public int MaLGT { get; set; }
        public int MaLNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichKham> LichKhams { get; set; }
        public virtual LoaiGioiTinh LoaiGioiTinh { get; set; }
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
    }
}
