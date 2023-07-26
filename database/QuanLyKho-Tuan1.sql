CREATE DATABASE QuanLyKho
USE QuanLyKho GO
CREATE TABLE LoaiHang
(
	MaLoaiHang VARCHAR(3) PRIMARY KEY,
	TenLoaiHang NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE DonViTinh
(
	MaDonViTinh VARCHAR(3) PRIMARY KEY,
	TenDonViTinh NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE HangHoa
(
	MaHangHoa VARCHAR(3) PRIMARY KEY,
	TenHangHoa NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE LoaiHangHangHoa
(
	MaLoaiHang VARCHAR(3) NOT NULL REFERENCES LoaiHang(MaLoaiHang),
	MaHangHoa VARCHAR(3) NOT NULL REFERENCES HangHoa(MaHangHoa)
	PRIMARY KEY(MaLoaiHang, MaHangHoa)
)
DROP TABLE DonViTinhHangHoa
select * from DonViTinhHangHoa
CREATE TABLE DonViTinhHangHoa
(
	MaHangHoa VARCHAR(3) NOT NULL REFERENCES HangHoa(MaHangHoa),
	MaDonViTinh VARCHAR(3) NOT NULL REFERENCES DonViTinh(MaDonViTinh),
	PRIMARY KEY (MaDonViTinh, MaHangHoa)
)

CREATE TABLE Kho
(
	MaKho VARCHAR(3) PRIMARY KEY,
	TenKho NVARCHAR(50) NOT NULL UNIQUE,
	DiaChi NVARCHAR(100) NOT NULL UNIQUE,
	ThuKho NVARCHAR(30) NOT NULL,
)

CREATE TABLE PhieuNhap
(
	MaPhieuNhap INT IDENTITY PRIMARY KEY,
	NgayNhap DATE NOT NULL,
	NguoiGiaoHang NVARCHAR(50) NOT NULL,
	NguonNhap NVARCHAR(100) NOT NULL,
	MaKho VARCHAR(3) NOT NULL REFERENCES Kho(MaKho),
	ThuKho NVARCHAR(30) NOT NULL,
	GhiChu NVARCHAR(100)
)
Drop table ChiTietPhieuNhap
CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap INT NOT NULL REFERENCES PhieuNhap(MaPhieuNhap),
	MaHangHoa VARCHAR(3) NOT NULL,
	MaDonViTinh VARCHAR(3) NOT NULL,
	SoLuong FLOAT NOT NULL,
	DonGia FLOAT NOT NULL,
	ChietKhau FLOAT NOT NULL,
	FOREIGN KEY (MaDonViTinh, MaHangHoa) REFERENCES DonViTinhHangHoa(MaDonViTinh, MaHangHoa)
)
DROP TABLE PhieuXuat
CREATE TABLE PhieuXuat
(
	MaPhieuXuat INT IDENTITY PRIMARY KEY,
	NgayXuat DATE NOT NULL,
	NguoiNhanHang NVARCHAR(50) NOT NULL,
	NoiNhan NVARCHAR(100) NOT NULL,
	MaKho VARCHAR(3) NOT NULL REFERENCES Kho(MaKho),
	ThuKho NVARCHAR(30) NOT NULL,
	GhiChu NVARCHAR(100)
)
DROP TABLE ChiTietPhieuXuat
CREATE TABLE ChiTietPhieuXuat
(
	MaPhieuXuat INT NOT NULL REFERENCES PhieuXuat(MaPhieuXuat),
	MaHangHoa VARCHAR(3) NOT NULL,
	MaDonViTinh VARCHAR(3) NOT NULL,
	SoLuong FLOAT NOT NULL,
	DonGia FLOAT NOT NULL,
	ChietKhau FLOAT NOT NULL,
	FOREIGN KEY (MaDonViTinh, MaHangHoa) REFERENCES DonViTinhHangHoa(MaDonViTinh, MaHangHoa)
)
CREATE TABLE ChiTietKho
(
	MaKho VARCHAR(3) NOT NULL REFERENCES Kho(MaKho),
	MaHangHoa VARCHAR(3) NOT NULL,
	MaDonViTinh VARCHAR(3) NOT NULL,
	SoLuong FLOAT NOT NULL,
	FOREIGN KEY (MaDonViTinh, MaHangHoa) REFERENCES DonViTinhHangHoa(MaDonViTinh, MaHangHoa)
)

create table NguoiDung
(
	TenDangNhap varchar(30) primary key,
	MatKhau varchar(128) not null,
	TrangThai BIT not null
)

create table NhatKy 
(
	MaNhatKy int identity primary key,
	TenDangNhap varchar(30) not null references NguoiDung(TenDangNhap),
	ThoiDiem datetime not null,
	NoiDung nvarchar(200) not null
)

select * from LoaiHang
insert LoaiHang(MaLoaiHang,TenLoaiHang) values ('LAP',N'Laptop')
ALTER TABLE LoaiHang 
ADD NguoiSua VARCHAR(30) not null REFERENCES NguoiDung(TenDangNhap) DEFAULT ('admin');
ALTER TABLE LoaiHang
ADD ThoiDiemSua DATETIME NOT NULL DEFAULT(GETDATE())

alter table DonViTinh
add NguoiSua varchar(30) references NguoiDung(TenDangNhap) DEFAULT ('admin');
alter table DonViTinh
add ThoiDiemSua datetime not null default(getdate())
select * from HangHoa
alter table HangHoa
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default ('admin');
alter table HangHoa
add ThoiDiemSua datetime not null default(getdate())

alter table DonViTinhHangHoa
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default ('admin');
alter table DonViTinhHangHoa
add ThoiDiemSua datetime not null default(getdate())

alter table LoaiHangHangHoa
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default ('admin');
alter table LoaiHangHangHoa
add ThoiDiemSua datetime not null default(getdate())

select * from Kho where MaKho = 'KLT';
select * from ChiTietKho where MaKho = 'KDS'
select * from PhieuNhap
select * from ChiTietPhieuNhap where MaPhieuNhap = 10

delete Kho where MaKho = 'KTL'
delete ChiTietKho where MaKho = 'KTL'
insert Kho values ('K1P',N'Kho tr',N'SKS',N'KK')
select HangHoa.MaHangHoa,TenHangHoa from HangHoa
inner join LoaiHangHangHoa on HangHoa.MaHangHoa = LoaiHangHangHoa.MaHangHoa where MaLoaiHang = 'BIA' 
select MaPhieuNhap,NgayNhap, NguoiGiaoHang, NguonNhap, TenKho,PhieuNhap.ThuKho,GhiChu from PhieuNhap inner join Kho on Kho.MaKho = PhieuNhap.MaKho

select * from ChiTietPhieuNhap 
inner join HangHoa on ChiTietPhieuNhap.MaHangHoa = HangHoa.MaHangHoa
inner join DonViTinh on ChiTietPhieuNhap.MaDonViTinh = DonViTinh.MaDonViTinh
where MaPhieuNhap = 11

select MaPhieuNhap,NgayNhap, NguoiGiaoHang, NguonNhap, TenKho,PhieuNhap.ThuKho,GhiChu 
from PhieuNhap
inner join Kho on Kho.MaKho = PhieuNhap.MaKho

select PhieuNhap.MaPhieuNhap, NgayNhap, NguoiGiaoHang, NguonNhap, TenKho, PhieuNhap.ThuKho, GhiChu, SoLuong
from PhieuNhap inner join Kho on Kho.MaKho = PhieuNhap.MaKho
inner join ChiTietPhieuNhap on PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap 
where SoLuong > 10

insert PhieuXuat(NgayXuat,NguoiNhanHang,NoiNhan,MaKho,ThuKho,GhiChu) values ('2020-1-1',N'ABC',N'SDS','KLT',N'ABC',null)

delete PhieuXuat where MaPhieuXuat = 6
select * from PhieuXuat
select * from ChiTietPhieuXuat

select distinct PhieuXuat.MaPhieuXuat 
from PhieuXuat 
inner join Kho on PhieuXuat.MaKho = Kho.MaKho 
inner join ChiTietPhieuXuat on PhieuXuat.MaPhieuXuat = ChiTietPhieuXuat.MaPhieuXuat
select MaKho,TenHangHoa,TenDonViTinh,SoLuong from ChiTietKho inner join HangHoa on ChiTietKho.MaHangHoa = HangHoa.MaHangHoa inner join DonViTinh on ChiTietKho.MaDonViTinh = DonViTinh.MaDonViTinh where MaKho = @maKho
-----------------------------------------------------------------------------------------------------
select Kho.MaKho,TenKho,DonViTinh.MaDonViTinh,DonViTinh.TenDonViTinh,HangHoa.MaHangHoa,HangHoa.TenHangHoa,
	   SoLuong		
from ChiTietKho
inner join HangHoa on ChiTietKho.MaHangHoa = HangHoa.MaHangHoa 
inner join DonViTinh on ChiTietKho.MaDonViTinh = DonViTinh.MaDonViTinh
inner join Kho on Kho.MaKho = ChiTietKho.MaKho
where ChiTietKho.MaHangHoa = 'MAL'

