create database QuanLyPhongMach
go

use QuanLyPhongMach
go


create table LoaiNhanVien(
	MaLNV int identity primary key not null,
	TenLoaiNV nvarchar(10) not null
)

create table NguoiDung(
	MaND int IDENTITY primary key not null,
	TenDangNhap varchar(30) not null,
	MatKhau varchar(30) not null
)

create table TaiKhoan(
	MaTK int IDENTITY primary key NOT NULL,
	MaND int NULL,
	TenND nvarchar(100) NOT NULL,
	MoTa nvarchar(100) NULL,
	MaLNV int NOT NULL

	foreign key (MaND) references dbo.NguoiDung(MaND),
	foreign key (MaLNV) references dbo.LoaiNhanVien(MaLNV)
)

 create table LoaiGioiTinh(
	MaLGT int identity primary key not null,
	TenLoaiGT nvarchar(10) not null
 )

create table BacSi(
	MaBS int identity primary key not null,
	HoTenBS nvarchar(30) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	MaLGT int not null,
	MaLNV int not null default '1'

	foreign key (MaLGT) references dbo.LoaiGioiTinh(MaLGT),
	foreign key (MaLNV) references dbo.LoaiNhanVien(MaLNV)

)

create table YTa(
	MaYT int identity primary key not null,
	HoTenYT nvarchar(30) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	MaLGT int not null,
	MaLNV int not null default '2'

	foreign key (MaLGT) references dbo.LoaiGioiTinh(MaLGT),
	foreign key (MaLNV) references dbo.LoaiNhanVien(MaLNV)

)

create table BenhNhan(
	MaBN int identity primary key not null,
	HoTenBN nvarchar(30) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	DiaChi nvarchar(100) not null,
	MaLGT int not null,

	foreign key (MaLGT) references dbo.LoaiGioiTinh(MaLGT)
)

create table LichKham(
	MaLK int identity primary key not null,
	MaBN int not null,
	MaYT int not null,
	MaBS int not null,
	NgayHen date not null

	foreign key (MaBN) references dbo.BenhNhan(MaBN),
	foreign key (MaYT) references dbo.YTa(MaYT),
	foreign key (MaBS) references dbo.BacSi(MaBS)
)

create table Thuoc(
	MaThuoc int identity primary key not null,
	TenThuoc nvarchar(30) not null,
	MoTa nvarchar(100) null
)

create table ToaThuoc(
	MaToa int identity primary key not null,
	NgayKeToa date not null,
	MaBS int not null,
	MaBN int not null

	foreign key (MaBS) references dbo.BacSi(MaBS),
	foreign key (MaBN) references dbo.BenhNhan(MaBN)
)

create table ChiTietToaThuoc(
	MaThuoc int not null,
	MaToa int not null,
	SoLuong int not null,
	LieuDung nvarchar(100) not null,
	primary key (MaThuoc, MaToa),

	foreign key (MaThuoc) references dbo.Thuoc(MaThuoc),
	foreign key (MaToa) references dbo.ToaThuoc(MaToa)
)

create table LoaiXetNghiem(
	MaLXN int identity primary key not null,
	TenLXN nvarchar(50) not null
)


create table PhieuKham(
	MaPK int identity primary key not null,
	MaBS int not null,
	MaBN int not null,
	NgayKham date not null,
	TrieuChung nvarchar(100) not null,
	ChuanDoan nvarchar(100) not null,
	NgayTaiKham date null,

	foreign key (MaBS) references dbo.BacSi(MaBS),
	foreign key (MaBN) references dbo.BenhNhan(MaBN),
)

create table XetNghiem(
	MaXN int identity primary key not null,
	TenXN nvarchar(100) not null,
	MaBS int not null,
	MaBN int not null,
	MaLXN int not null,

	foreign key (MaBS) references dbo.BacSi(MaBS),
	foreign key (MaBN) references dbo.BenhNhan(MaBN),
	foreign key (MaLXN) references dbo.LoaiXetNghiem(MaLXN)
)

create table XetNghiem_PhieuKham
(
	MaXN int not null,
	MaPK int not null,
	NgayXN date not null,
	NgayHenLayKQ date not null,
	YeuCauXN nvarchar(100) not null,
	KetQuaXN nvarchar(100) not null,
	primary key (MaXN, MaPK),

	foreign key (MaXN) references dbo.XetNghiem(MaXN),
	foreign key (MaPK) references dbo.PhieuKham(MaPK)
)

CREATE proc [dbo].[sp_KiemTraThuoc] @MaToa int, @MaThuoc int
as
begin
	SET NOCOUNT ON
	declare @sl int
	select @sl = COUNT(*) from [ChiTietToaThuoc]
	where MaToa=@MaToa and MaThuoc=@MaThuoc
	select @sl as alias
end
GO