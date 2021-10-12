﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyPhongMachEntities : DbContext
    {
        public QuanLyPhongMachEntities()
            : base("name=QuanLyPhongMachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<ChiTietToaThuoc> ChiTietToaThuocs { get; set; }
        public virtual DbSet<LichKham> LichKhams { get; set; }
        public virtual DbSet<LoaiGioiTinh> LoaiGioiTinhs { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiXetNghiem> LoaiXetNghiems { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhieuKham> PhieuKhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<ToaThuoc> ToaThuocs { get; set; }
        public virtual DbSet<XetNghiem> XetNghiems { get; set; }
        public virtual DbSet<XetNghiem_PhieuKham> XetNghiem_PhieuKham { get; set; }
        public virtual DbSet<YTa> YTas { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_KiemTraThuoc(Nullable<int> maToa, Nullable<int> maThuoc)
        {
            var maToaParameter = maToa.HasValue ?
                new ObjectParameter("MaToa", maToa) :
                new ObjectParameter("MaToa", typeof(int));
    
            var maThuocParameter = maThuoc.HasValue ?
                new ObjectParameter("MaThuoc", maThuoc) :
                new ObjectParameter("MaThuoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_KiemTraThuoc", maToaParameter, maThuocParameter);
        }
    }
}
