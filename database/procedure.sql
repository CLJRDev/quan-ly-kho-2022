create procedure spThemLoaiHang 
@maLoaiHang varchar(3), @tenLoaiHang nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) MaLoaiHang from LoaiHang where MaLoaiHang=@maLoaiHang);
	if @dem > 0
		throw 50000,N'Trùng mã loại hàng',1;
	else begin
		set @dem = (select count(*) from LoaiHang where TenLoaiHang=@tenLoaiHang);
		if @dem>0
			throw 50001, N'Trùng tên loại hàng',1;
		else
			insert LoaiHang(MaLoaiHang,TenLoaiHang,NguoiSua) values (@maLoaiHang, @tenLoaiHang,@nguoiSua);
	end
end
drop procedure [spXoaLoaiHang]
-----------------------------------------------------------------------------------------------------
create procedure spXoaLoaiHang @maLoaiHang varchar(3), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) Dem from LoaiHangHangHoa where MaLoaiHang = @maLoaiHang);
	if @dem>0
		throw 50000,N'Còn loại hàng hoá liên quan',1;
	else
		update LoaiHang set NguoiSua = @nguoiSua where MaLoaiHang = @maLoaiHang;
		delete LoaiHang where MaLoaiHang=@maLoaiHang;
end
-----------------------------------------------------------------
DROP PROCEDURE [spSuaLoaiHang];
GO
create procedure spSuaLoaiHang @maLoaiHang varchar(3), @tenLoaiHang nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*)Dem from LoaiHang where MaLoaiHang<>@maLoaiHang and TenLoaiHang=@tenLoaiHang);
	if @dem>0
		throw 50000,N'Trùng tên loại hàng',1;
	else 
		update LoaiHang set TenLoaiHang = @tenLoaiHang, NguoiSua = @nguoiSua where MaLoaiHang = @maLoaiHang;
end

create view vwChiTietPhieuNhap
as
select MaPhieuNhap,TenHangHoa,TenDonViTinh,SoLuong,DonGia,ChietKhau from ChiTietPhieuNhap
              inner join HangHoa on ChiTietPhieuNhap.MaHangHoa = HangHoa.MaHangHoa
              inner join DonViTinh on ChiTietPhieuNhap.MaDonViTinh = DonViTinh.MaDonViTinh
-----------------------------------------------------------------------------------------------------

create procedure spThemDonViTinh @maDonViTinh varchar(3), @tenDonViTinh nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*)Dem from DonViTinh where MaDonViTinh=@maDonViTinh);
	if @dem>0
		throw 50000,N'Trùng mã đơn vị tính',1;
	else begin
		set @dem = (select count(*)Dem from DonViTinh where TenDonViTinh = @tenDonViTinh);
		if @dem>0
			throw 50001,N'Trùng tên đơn vị tính',1;
		else
			insert DonViTinh(MaDonViTinh,TenDonViTinh,NguoiSua) values (@maDonViTinh,@tenDonViTinh,@nguoiSua);
	end
end 
drop procedure [spXoaDonViTinh]
-----------------------------------------------------------------------------------------------------
create procedure spXoaDonViTinh @maDonViTinh varchar(3), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*)Dem from HangHoa inner join DonViTinhHangHoa on HangHoa.MaHangHoa = DonViTinhHangHoa.MaHangHoa where MaDonViTinh = @maDonViTinh);
	if @dem>0
		throw 50000,N'Tồn tại hàng hoá liên quan',1;
	else
		update DonViTinh set NguoiSua = @nguoiSua where MaDonViTinh = @maDonViTinh;
		delete DonViTinh where MaDonViTinh = @maDonViTinh;
end
----------------------------------------------------------------------------------------------------

create procedure spSuaDonViTinh @maDonViTinh varchar(3), @tenDonViTinh nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) Dem from DonViTinh where MaDonViTinh <> @maDonViTinh and TenDonViTinh = @tenDonViTinh);
	if @dem>0
		throw 50000,N'Lỗi trùng tên đơn vị tính',1;		
	else
		update DonViTinh set TenDonViTinh = @tenDonViTinh, NguoiSua = @nguoiSua where MaDonViTinh = @maDonViTinh;
end
-------------------------------------------------------------------------------------------------------

create procedure spThemDonViTinhHangHoa @maHangHoa varchar(3), @maDonViTinh varchar(3), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from DonViTinhHangHoa where MaHangHoa = @maHangHoa and MaDonViTinh = @maDonViTinh);
	if @dem > 0
		throw 50000,N'Hàng hoá đã tồn tại đơn vị tính này',1;
	else
		insert DonViTinhHangHoa(MaHangHoa,MaDonViTinh,NguoiSua) values (@maHangHoa,@maDonViTinh,@nguoiSua);
end


create procedure spXoaDonViTinhHangHoa @maHangHoa varchar(3), @maDonViTinh varchar(3),@nguoiSua varchar(30)
as begin
	update DonViTinhHangHoa set NguoiSua = @nguoiSua where MaDonViTinh = @maDonViTinh and MaHangHoa = @maHangHoa;
	delete DonViTinhHangHoa where MaHangHoa = @maHangHoa and MaDonViTinh = @maDonViTinh;
end


create procedure spThemLoaiHangHangHoa @maLoaiHang varchar(3), @maHangHoa varchar(3), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from LoaiHangHangHoa where MaLoaiHang = @maLoaiHang and MaHangHoa = @maHangHoa);
	if @dem > 0
		throw 50000,N'Hàng hoá đã tồn tại loại hàng này',1;
	else 
		insert LoaiHangHangHoa(MaLoaiHang,MaHangHoa,NguoiSua) values (@maLoaiHang,@maHangHoa,@nguoiSua);
end
drop procedure [spXoaLoaiHangHangHoa]
create procedure spXoaLoaiHangHangHoa @maLoaiHang varchar(3), @maHangHoa varchar(3), @nguoiSua varchar(30)
as begin
	update LoaiHangHangHoa set NguoiSua = @nguoiSua where MaLoaiHang = @maLoaiHang and MaHangHoa = @maHangHoa;
	delete LoaiHangHangHoa where MaLoaiHang = @maLoaiHang and MaHangHoa = @maHangHoa;
end

create procedure spThemPhieuNhap @ngayNhap date, @nguoiGiaoHang nvarchar(50), @nguonNhap nvarchar(100), @maKho varchar(3), @ghiChu nvarchar(100)
as begin
	declare @thuKho nvarchar(30);
	set @thuKho = (select ThuKho from Kho where MaKho=@maKho);
	insert PhieuNhap values (@ngayNhap,@nguoiGiaoHang,@nguonNhap,@maKho,@thuKho,@ghiChu);
end

----------------------------------------------------------------------------------------------
drop procedure [spThemChiTietPhieuNhap]
create procedure spThemChiTietPhieuNhap @maHangHoa varchar(3),@maDonViTinh varchar(3),@soLuong float,@donGia float,@chietKhau float
as begin
	declare @maPhieuNhap int;
	set @maPhieuNhap = (select max(MaPhieuNhap) from PhieuNhap);
	insert ChiTietPhieuNhap values(@maPhieuNhap,@maHangHoa,@maDonviTinh,@soLuong,@donGia,@chietKhau);
end

create procedure spThemChiTietPhieuXuatDuocSua @maPhieuXuat int, @maHangHoa varchar(3),@maDonViTinh varchar(3),@soLuong float,@donGia float,@chietKhau float
as begin
	insert ChiTietPhieuXuat values(@maPhieuXuat,@maHangHoa,@maDonviTinh,@soLuong,@donGia,@chietKhau);
end

create procedure spThemChiTietPhieuNhapDuocSua @maPhieuNhap int, @maHangHoa varchar(3),@maDonViTinh varchar(3),@soLuong float,@donGia float,@chietKhau float
as begin
	insert ChiTietPhieuNhap values(@maPhieuNhap,@maHangHoa,@maDonviTinh,@soLuong,@donGia,@chietKhau);
end

----------------------------------------------------------------------------------

-------------------------------------------------------------------------------------
create procedure spDangNhap @tenDangNhap varchar(30), @matKhau varchar(128)
as begin
	declare @dem int;
	set @dem = (select count(*) from NguoiDung where TenDangNhap = @tenDangNhap);
	if @dem > 0 begin
		declare @matKhauDung varchar(128);
		set @matKhauDung = (select MatKhau from NguoiDung where TenDangNhap = @tenDangNhap);
		if @matKhauDung <> @matKhau
			throw 50000,N'Sai mật khẩu',1;
		else begin
			declare @trangThai bit;
			set @trangThai = (select TrangThai from NguoiDung where TenDangNhap = @tenDangNhap);
			if @trangThai = 0
				throw 50001,N'Người dùng đã bị khoá',1;
		end
	end
	else
		throw 50002,N'Người dùng không tồn tại',1;
end
-------------------------------------------------------------------------------
create table ChucNang
(
	MaChucNang int primary key,
	TenChucNang varchar(50) not null unique,
	TrangThai bit not null
)
-------------------------------------------------------------------------------
create table PhanQuyen
(
	TenDangNhap varchar(30) not null references NguoiDung(TenDangNhap),
	MaChucNang int not null references ChucNang(MaChucNang),
	primary key(TenDangNhap,MaChucNang)
)
-------------------------------------------------------------------------------


create procedure spPhanQuyen @tenDangNhap varchar(30), @maChucNang int
as begin
	declare @trangThai bit;
	set @trangThai = (select TrangThai from NguoiDung where TenDangNhap = @tenDangNhap);
	if @trangThai = 0
		throw 50000,N'Người dùng đã bị khoá',1;
	else begin
		declare @dem int;
		set @dem = (select count(*) from ChucNang inner join PhanQuyen on ChucNang.MaChucNang = PhanQuyen.MaChucNang where TenDangNhap = @tenDangNhap and PhanQuyen.MaChucNang = @maChucNang);
		if @dem > 0 
			throw 50001,N'Người dùng đã có chức năng này',1;
		else
			insert PhanQuyen values (@tenDangNhap,@maChucNang);	
	end
end
drop procedure [spXoaPhanQuyen]
create procedure spXoaPhanQuyen @tenDangNhap varchar(30), @maChucNang int
as begin
	delete PhanQuyen where TenDangNhap = @tenDangNhap and MaChucNang = @maChucNang;
end

create procedure spThemNguoiDung @tenDangNhap varchar(30), @matKhau varchar(128), @trangThai bit
as begin
	declare @dem int;
	set @dem = (select count(*) from NguoiDung where TenDangNhap = @tenDangNhap);
	if @dem>0
		throw 50000,N'Người dùng đã tồn tại',1;
	else
		insert NguoiDung values (@tenDangNhap, @matKhau, @trangThai);
end
drop procedure[spDoiMatKhau]
create procedure spDoiMatKhau @tenDangNhap varchar(30), @matKhauMoi varchar(128)
as begin
	update NguoiDung set MatKhau = @matKhauMoi where TenDangNhap = @tenDangNhap;
end

create procedure spDoiTrangThai @tenDangNhap varchar(30), @trangThai bit
as begin 
	update NguoiDung set TrangThai = @trangThai where TenDangNhap = @tenDangNhap;
end

create procedure spXoaNguoiDung @tenDangNhap varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from ChucNang inner join PhanQuyen on ChucNang.MaChucNang = PhanQuyen.MaChucNang where TenDangNhap = @tenDangNhap);
	if @dem > 0
		throw 50000,N'Người dùng còn tồn tại chức năng liên quan',1;
	else 
		delete NguoiDung where TenDangNhap = @tenDangNhap;
end

create procedure spThemPhieuXuat @ngayXuat date, @nguoiNhanHang nvarchar(50), @noiNhan nvarchar(100), @maKho varchar(3), @ghiChu nvarchar(100)
as begin
	declare @thuKho nvarchar(30);
	set @thuKho = (select ThuKho from Kho where MaKho=@maKho);
	insert PhieuXuat(NgayXuat,NguoiNhanHang,NoiNhan,MaKho,ThuKho,GhiChu) values (@ngayXuat,@nguoiNhanHang, @noiNhan,@maKho,@thuKho,@ghiChu)	
end

create procedure spThemChiTietPhieuXuat @maHangHoa varchar(3),@maDonViTinh varchar(3),@soLuong float,@donGia float,@chietKhau float
as begin
	insert ChiTietPhieuXuat values((select MAX(MaPhieuXuat) from PhieuXuat), @maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau)	
end

drop procedure [spThemHangHoa]

create procedure spThemHangHoa @maHangHoa varchar(3), @tenHangHoa nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from HangHoa where MaHangHoa = @maHangHoa)
	if @dem>0
		throw 50000,N'Trùng mã hàng hoá',1;	
	else begin
		set @dem = (select count(*) from HangHoa where TenHangHoa = @tenHangHoa)
		if @dem > 0
			throw 50001,N'Trùng tên hàng hoá',1;
		else 
			insert HangHoa(MaHangHoa,TenHangHoa,NguoiSua) values (@maHangHoa,@tenHangHoa,@nguoiSua);
	end
end
drop procedure [spSuaHangHoa]
create procedure spSuaHangHoa @maHangHoa varchar(3), @tenHangHoa nvarchar(30), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from HangHoa where MaHangHoa <> @maHangHoa and TenHangHoa = @tenHangHoa)
	if @dem > 0
		throw 50000,N'Trùng tên hàng hoá',1;
	else 
		update HangHoa set TenHangHoa = @tenHangHoa, NguoiSua = @nguoiSua where MaHangHoa = @maHangHoa;
end

drop procedure [spXoaHangHoa]
create procedure spXoaHangHoa @maHangHoa varchar(3), @nguoiSua varchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from LoaiHangHangHoa where MaHangHoa = @maHangHoa)
	if @dem>0
		throw 50000,N'Còn loại hàng liên quan',1;
	else
		set @dem = (select count(*) from DonViTinhHangHoa where MaHangHoa = @maHangHoa);
		if @dem > 0
			throw 50001,N'Còn đơn vị tính liên quan',1;
		else
			update HangHoa set NguoiSua = @nguoiSua where MaHangHoa = @maHangHoa;
			delete HangHoa where MaHangHoa = @maHangHoa;
end
drop procedure [spSuaPhieuNhap]

create procedure spSuaPhieuNhap @maPhieuNhap int, @ngayNhap date, @nguoiGiaoHang nvarchar(50), @nguonNhap nvarchar(100),   @ghiChu nvarchar(100)
as begin
	update PhieuNhap set NgayNhap = @ngayNhap, NguoiGiaoHang =@nguoiGiaoHang, NguonNhap = @nguonNhap, GhiChu = @ghiChu where MaPhieuNhap = @maPhieuNhap;
end

create procedure spSuaPhieuXuat @maPhieuXuat int, @ngayXuat date, @nguoiNhanHang nvarchar(50), @noiNhan nvarchar(100), @ghiChu nvarchar(100)
as begin 
	update PhieuXuat set NgayXuat = @ngayXuat, NguoiNhanHang = @nguoiNhanHang, NoiNhan = @noiNhan, GhiChu = @ghiChu where MaPhieuXuat = @maPhieuXuat;
end

drop procedure [spSuaChiTietPhieuNhap]

create procedure spSuaChiTietPhieuNhap @maPhieuNhap int, @maHangHoa varchar(3), @maDonViTinh varchar(3), @soLuong float, @donGia float, @chietKhau float
as begin
	update ChiTietPhieuNhap set SoLuong=@soLuong,DonGia=@donGia,ChietKhau=@chietKhau where MaPhieuNhap=@maPhieuNhap and MaHangHoa = @maHangHoa and MaDonViTinh=@maDonViTinh;
end

create procedure spXoaChiTietPhieuNhap @maPhieuNhap int, @maHangHoa varchar(3), @maDonViTinh varchar(3)
as begin
	delete ChiTietPhieuNhap where MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh and MaPhieuNhap=@maPhieuNhap;
end



create procedure spXoaChiTietPhieuXuat @maPhieuXuat int, @maHangHoa varchar(3), @maDonViTinh varchar(3) 
as begin
	delete ChiTietPhieuXuat where MaPhieuXuat = @maPhieuXuat and MaHangHoa = @maHangHoa and MaDonViTinh=@maDonViTinh;
end

create procedure spXoaPhieuNhap @maPhieuNhap int
as begin
	declare @dem int;
	set @dem = (select count(*) from ChiTietPhieuNhap where MaPhieuNhap = @maPhieuNhap);
	if @dem > 0
		throw 50000,N'Còn tồn tại chi tiết phiếu nhập liên quan',1;
	else
		delete PhieuNhap where MaPhieuNhap = @maPhieuNhap;
end

create procedure spXoaPhieuXuat @maPhieuXuat int
as begin
	declare @dem int;
	set @dem = (select count(*) from ChiTietPhieuXuat where MaPhieuXuat = @maPhieuXuat);
	if @dem > 0
		throw 50000,N'Còn tồn tại chi tiết phiếu xuất liên quan',1;
	else
		delete PhieuXuat where MaPhieuXuat = @maPhieuXuat;
end
----------------------------------------------------------------------------------------------------------
create procedure spThemKho @maKho varchar(3), @tenKho nvarchar(50), @diaChi nvarchar(100), @thuKho nvarchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from Kho where MaKho=@maKho)
	if @dem>0
		throw 50000,N'Trùng mã kho',1;
	else begin
		set @dem = (select count(*) from Kho where DiaChi = @diaChi)
		if @dem > 0
			throw 50001,N'Trùng địa chỉ',1;
		else begin
			set @dem = (select count(*) from Kho where TenKho = @tenKho)
			if @dem > 0
				throw 50002,N'Trùng tên kho',1;
			else
				insert Kho values (@maKho,@tenKho,@diaChi,@thuKho);
		end
	end
end
insert Kho values ('KQN',N'Kho Quảng Ninh',N'214 Quảng Ninh',N'Hải Ninh')



create procedure spThemChiTietKho @maKho varchar(3),@maHangHoa varchar(3),@maDonViTinh varchar(3),@soLuong float
as begin
	insert Kho values (@maKho,@maHangHoa,@maDonViTinh,@soLuong);
end

create procedure spSuaKho @maKho varchar(3), @tenKho nvarchar(50), @diaChi nvarchar(100), @thuKho nvarchar(30)
as begin
	declare @dem int;
	set @dem = (select count(*) from Kho where TenKho = @tenKho and MaKho != @maKho);
	if @dem > 0
		throw 50000,N'Trùng lặp tên kho',1;
	else
		set @dem = (select count(*) from Kho where DiaChi = @diaChi and MaKho != @maKho);
		if @dem > 0
			throw 50001,N'Trùng lặp địa chỉ kho',1;
		else
			update Kho set TenKho = @tenKho, DiaChi = @diaChi, ThuKho = @thuKho where MaKho = @maKho;
end

create procedure spXoaKho @maKho varchar(3)
as begin
    declare @dem int;
    set @dem = (select count(*) from ChiTietKho where MaKho = @maKho);
    if @dem > 0
		throw 50000,N'Còn tồn tại hàng hoá trong kho',1;
	else
		delete Kho where MaKho = @maKho;
end