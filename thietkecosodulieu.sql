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

create table BacSi(
	MaBS int identity primary key not null,
	HoTenBS nvarchar(30) not null,
	GioiTinh nvarchar(10) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	MaLNV int not null default '2'

	foreign key (MaLNV) references dbo.LoaiNhanVien(MaLNV)
)

create table YTa(
	MaYT int identity primary key not null,
	HoTenYT nvarchar(30) not null,
	GioiTinh nvarchar(10) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	MaLNV int not null default '3'

	foreign key (MaLNV) references dbo.LoaiNhanVien(MaLNV)
)

create table BenhNhan(
	MaBN int identity primary key not null,
	HoTenBN nvarchar(30) not null,
	GioiTinh nvarchar(10) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	DiaChi nvarchar(100) not null,
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
	TenLXN nvarchar(50) not null,
	MoTa nvarchar(100) not null
)

create table XetNghiem(
	MaXN int identity primary key not null,
	TenXN nvarchar(100) not null,
	MaLXN int not null,
	MoTa nvarchar(100) not null

	foreign key (MaLXN) references dbo.LoaiXetNghiem(MaLXN)
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

CREATE proc KiemTraThuoc @MaToa int, @MaThuoc int
as
begin
	SET NOCOUNT ON
	declare @sl int
	select @sl = COUNT(*) from ChiTietToaThuoc
	where MaToa=@MaToa and MaThuoc=@MaThuoc
	select @sl as alias
end
GO

CREATE proc KiemTraXetNghiem @MaPK int, @MaXN int
as
begin
	SET NOCOUNT ON
	declare @sl int
	select @sl = COUNT(*) from XetNghiem_PhieuKham
	where MaPK=@MaPK and MaXN=@MaXN
	select @sl as alias
end
GO

create proc timKiemBacSi @chuoi nvarchar(30)
as
begin
	select *
	from BacSi
	where MaBS like CONCAT('%', @chuoi, '%') or HoTenBS like CONCAT('%', @chuoi, '%') or GioiTinh like CONCAT('%', @chuoi, '%')
	order by MaBS asc
end

create proc timKiemYTa @chuoi nvarchar(30)
as
begin
	select *
	from YTa
	where MaYT like CONCAT('%', @chuoi, '%') or HoTenYT like CONCAT('%', @chuoi, '%') or GioiTinh like CONCAT('%', @chuoi, '%')
	order by MaYT asc
end

create proc timKiemBenhNhan @chuoi nvarchar(30)
as
begin
	select *
	from BenhNhan
	where MaBN like CONCAT('%', @chuoi, '%') or HoTenBN like CONCAT('%', @chuoi, '%') or GioiTinh like CONCAT('%', @chuoi, '%')
	order by MaBN asc
end

create proc timKiemThuoc @chuoi nvarchar(30)
as
begin
	select *
	from Thuoc
	where MaThuoc like CONCAT('%', @chuoi, '%') or TenThuoc like CONCAT('%', @chuoi, '%') or MoTa like CONCAT('%', @chuoi, '%')
	order by MaThuoc asc
end

create proc thongKeLichSuKham
(
	@NgayBatDau date,
	@NgayKetThuc date
)
as
begin
	select PhieuKham.*, HoTenBS, HoTenBN
	from PhieuKham inner join BacSi on PhieuKham.MaBS = BacSi.MaBS inner join BenhNhan on PhieuKham.MaBN = BenhNhan.MaBN
	where NgayKham between @NgayBatDau and @NgayKetThuc
	order by MaPK asc
end