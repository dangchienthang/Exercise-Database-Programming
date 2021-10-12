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
    
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            this.LichKhams = new HashSet<LichKham>();
            this.PhieuKhams = new HashSet<PhieuKham>();
            this.ToaThuocs = new HashSet<ToaThuoc>();
            this.XetNghiems = new HashSet<XetNghiem>();
        }
    
        public int MaBS { get; set; }
        public string HoTenBS { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public int MaLGT { get; set; }
        public int MaLNV { get; set; }
    
        public virtual LoaiGioiTinh LoaiGioiTinh { get; set; }
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichKham> LichKhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKham> PhieuKhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToaThuoc> ToaThuocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XetNghiem> XetNghiems { get; set; }
    }
}