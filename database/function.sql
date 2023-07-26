-----------------------------------------------------------
create function ufLayDanhSachHangHoaTheoLoaiHang(@maLoaiHang varchar(3))
returns table
as
	return select HangHoa.MaHangHoa,TenHangHoa from HangHoa inner join LoaiHangHangHoa on LoaiHangHangHoa.MaHangHoa = HangHoa.MaHangHoa where MaLoaiHang=@maLoaiHang

---------------------------------------------------------------------------
create function ufTimKiemLoaiHang(@maLoaiHang varchar(3), @tenLoaiHang varchar(30))
returns table
as
	return select * from LoaiHang
	where (@maLoaiHang='' or MaLoaiHang=@maLoaiHang) and (@tenLoaiHang='' or TenLoaiHang LIKE '%'+@tenLoaiHang+'%')
-------------------------------------------------------------------------------
create function ufLayDonViTinhCuaHangHoa(@maHangHoa varchar(3))
returns table
as
	return select DonViTinh.MaDonViTinh,TenDonViTinh from DonViTinh inner join DonViTinhHangHoa on DonViTinh.MaDonViTinh = DonViTinhHangHoa.MaDonViTinh where MaHangHoa=@maHangHoa
-----------------------------------------------------------------------------------------------------
create function ufTimKiemDonViTinh(@maDonViTinh varchar(3), @tenDonViTinh nvarchar(30))
returns table
as
	return select * from DonViTinh where ((@maDonViTinh = '' or MaDonViTinh = @maDonViTinh) and (@tenDonViTinh = '' or TenDonViTinh LIKE '%'+@tenDonViTinh+'%')) 
----------------------------------------------------------------------------------------------------
create function ufLayHangHoaTheoDonViTinh(@maDonViTinh varchar(3))
returns table
as return (select TenHangHoa from HangHoa inner join DonViTinhHangHoa on HangHoa.MaHangHoa = DonViTinhHangHoa.MaHangHoa where MaDonViTinh = @maDonViTinh);

------------------------------------------------------------------------------------------------------------
create function ufTimKiemPhieuNhap (@maPhieuNhap varchar(3), @ngayNhapTu date, @ngayNhapDen date, @nguoiGiaoHang nvarchar(50), @nguonNhap nvarchar(100),@maKho varchar(3) ,@thuKho nvarchar(30), @ghiChu nvarchar(100), @maHangHoa varchar(3), @maDonViTinh varchar(3), @soLuong float, @donGia float, @chietKhau float)
returns table
as return (select distinct PhieuNhap.MaPhieuNhap, NgayNhap, NguoiGiaoHang, NguonNhap, TenKho, PhieuNhap.ThuKho, GhiChu from PhieuNhap
		    inner join Kho on Kho.MaKho = PhieuNhap.MaKho
			inner join ChiTietPhieuNhap on PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap
			where (PhieuNhap.MaKho = @maKho or @maKho = '')
			and (@maPhieuNhap = '' or PhieuNhap.MaPhieuNhap = @maPhieuNhap)
			and (@ngayNhapTu = '' or NgayNhap >= @ngayNhapTu)
			and (@ngayNhapDen = '' or NgayNhap <= @ngayNhapDen)
			and (@nguoiGiaoHang = '' or NguoiGiaoHang LIKE '%'+@nguoiGiaoHang+'%')
			and (@nguonNhap = '' or NguonNhap LIKE '%'+@nguonNhap+'%')
			and (@maKho = '' or PhieuNhap.MaKho = @maKho)
			and (@thuKho = '' or PhieuNhap.ThuKho LIKE'%'+@thuKho+'%')
			and (@ghiChu = '' or GhiChu LIKE '%'+@ghiChu+'%')
			and (@maHangHoa = '' or MaHangHoa = @maHangHoa)
			and (@maDonViTinh = '' or MaDonViTinh = @maDonViTinh)
			and (@soLuong = '' or SoLuong = @soLuong)
			and (@donGia = '' or DonGia = @donGia)
			and (@chietKhau = '' or ChietKhau = @chietKhau))
--------------------------------------------------------------------------------------------------
create function ufLayHangHoaTheoMaLoaiHang(@maLoaiHang varchar(3))
returns table
as return (select HangHoa.MaHangHoa,TenhangHoa from HangHoa inner join LoaiHangHangHoa on HangHoa.MaHangHoa = LoaiHangHangHoa.MaHangHoa where MaLoaiHang = @maLoaiHang)
--------------------------------------------------------------------------------------------------

create function ufLayPhanQuyen(@tenDangNhap varchar(30))
returns table
as return (select ChucNang.MaChucNang,TenChucNang from ChucNang inner join PhanQuyen on ChucNang.MaChucNang = PhanQuyen.MaChucNang where TenDangNhap = @tenDangNhap)

--------------------------------------------------------------------------------------------------'
drop function ufLayChiTietPhieuXuat
create function ufLayChiTietPhieuXuat(@maPhieuXuat int)
returns table
as return (select ChiTietPhieuXuat.MaHangHoa,TenHangHoa,ChiTietPhieuXuat.MaDonViTinh,TenDonViTinh,SoLuong,DonGia,ChietKhau from ChiTietPhieuXuat 
			inner join HangHoa on HangHoa.MaHangHoa = ChiTietPhieuXuat.MaHangHoa 
			inner join DonViTinh on DonViTinh.MaDonViTinh = ChiTietPhieuXuat.MaDonViTinh 
			where MaPhieuXuat = @maPhieuXuat)
--------------------------------------------------------------------------------------------------
drop function ufLayChiTietPhieuNhap
create function ufLayChiTietPhieuNhap(@maPhieuNhap int)
returns table
as return (select ChiTietPhieuNhap.MaHangHoa,TenHangHoa,ChiTietPhieuNhap.MaDonViTinh,TenDonViTinh,DonGia,SoLuong,ChietKhau from ChiTietPhieuNhap 
				inner join HangHoa on HangHoa.MaHangHoa = ChiTietPhieuNhap.MaHangHoa 
				inner join DonViTinh on DonViTinh.MaDonViTinh = ChiTietPhieuNhap.MaDonViTinh
				where MaPhieuNhap = @maPhieuNhap)				
--------------------------------------------------------------------------------------------------
create function ufTimKiemPhieuXuat(@maPhieuXuat varchar(3), @ngayXuatTu date,@ngayXuatDen date,  @nguoiNhanHang nvarchar(50), @noiNhan nvarchar(100), @maKho varchar(3), @thuKho nvarchar(30), @ghiChu nvarchar(100), @maHangHoa varchar(3), @maDonViTinh varchar(3), @soLuong float, @donGia float, @chietKhau float)
returns table 
as return (select distinct PhieuXuat.MaPhieuXuat, NgayXuat, NguoiNhanHang, NoiNhan,TenKho,PhieuXuat.ThuKho, GhiChu from PhieuXuat
			inner join Kho on Kho.MaKho = PhieuXuat.MaKho
			inner join ChiTietPhieuXuat on ChiTietPhieuXuat.MaPhieuXuat = PhieuXuat.MaPhieuXuat
			where(@maPhieuXuat = '' or PhieuXuat.MaPhieuXuat = @maPhieuXuat) 
			and (@ngayXuatTu = '' or NgayXuat >= @ngayXuatTu) 
			and (@ngayXuatDen = '' or NgayXuat <= @ngayXuatDen)
			and (@nguoiNhanHang = '' or NguoiNhanHang LIKE '%'+@nguoiNhanHang+'%')
			and (@noiNhan = '' or NoiNhan LIKE '%'+@noiNhan+'%')
			and (@maKho = '' or PhieuXuat.MaKho = @maKho)
			and (@thuKho = '' or PhieuXuat.ThuKho LIKE '%'+@thuKho+'%')
			and (@ghiChu = '' or GhiChu LIKE '%'+@ghiChu+'%')
			and (@maHangHoa = '' or MaHangHoa = @maHangHoa)
			and (@maDonViTinh = '' or MaDonViTinh = @maDonViTinh)
			and (@soLuong = '' or SoLuong = @soLuong)
			and (@donGia = '' or DonGia = @donGia)
			and (@chietKhau = '' or ChietKhau = @chietKhau))
			
---------------------------------------------------------------------------------------
create function ufTimKiemKho(@maKho varchar(3), @diaChi nvarchar(100), @thuKho nvarchar(30), @maHangHoa varchar(3), @maDonViTinh varchar(3), @soLuong float)
returns table
as return (select distinct Kho.MaKho, TenKho, DiaChi, ThuKho
			from Kho inner join ChiTietKho on Kho.MaKho = ChiTietKho.MaKho
			inner join HangHoa on ChiTietKho.MaHangHoa = HangHoa.MaHangHoa
			inner join DonViTinh on DonViTinh.MaDonViTinh = ChiTietKho.MaDonViTinh
			where (@maKho = '' or Kho.MaKho = @maKho)
			and (@diaChi = '' or DiaChi LIKE '%'+@diaChi+'%')
			and (@thuKho = '' or ThuKho LIKE '%'+@thuKho+'%')
			and (@maHangHoa = '' or ChiTietKho.MaHangHoa = @maHangHoa)
			and (@maDonViTinh = '' or ChiTietKho.MaDonViTinh = @maDonViTinh)
			and (@soLuong = '' or SoLuong >= @soLuong)
			)  drop function ufTimKiemKho
---------------------------------------------------------------------------------------
create function ufTimKiemHangHoa (@maHangHoa varchar(3), @tenHangHoa nvarchar(30))
returns table
as return (select MaHangHoa,TenHangHoa from HangHoa where (@maHangHoa = '' or MaHangHoa = @maHangHoa) and (@tenHangHoa='' or TenHangHoa LIKE '%'+@tenHangHoa+'%'))
---------------------------------------------------------------------------------------
create function ufLayLoaiHangTheoMaHangHoa(@maHangHoa varchar(3))
returns table
as return (select LoaiHang.MaLoaiHang,TenLoaiHang from LoaiHang inner join LoaiHangHangHoa on LoaiHangHangHoa.MaLoaiHang = LoaiHang.MaLoaiHang where MaHangHoa = @maHangHoa)

create function ufLayPhieuNhap(@maPhieuNhap varchar(3))
returns table
as return (select MaPhieuNhap,NgayNhap,NguoiGiaoHang,NguonNhap,PhieuNhap.MaKho,PhieuNhap.ThuKho,Kho.TenKho, GhiChu
		   from PhieuNhap inner join Kho on Kho.MaKho = PhieuNhap.MaKho where MaPhieuNhap = @maPhieuNhap)

drop function ufLayChiTietKho
create function ufLayChiTietKho(@maKho varchar(3))
returns table
as return (select distinct ChiTietKho.MaHangHoa,TenHangHoa from ChiTietKho inner join HangHoa on HangHoa.MaHangHoa = ChiTietKho.MaHangHoa where MaKho = @maKho)

create function ufLayChietTietHangHoaTrongKho(@maKho varchar(3), @maHangHoa varchar(3))
returns table
as return (select SoLuong,TenDonViTinh from ChiTietKho inner join DonViTinh on ChiTietKho.MaDonViTinh = DonViTinh.MaDonViTinh where MaKHo = @maKho and MaHangHoa = @maHangHoa)

create function ufTimKiemNhatKy (@tenDangNhap varchar(30), @thoiDiemTu datetime, @thoiDiemDen datetime)
returns table
as return (select TenDangNhap,ThoiDiem,NoiDung from NhatKy 
			where(@tenDangNhap = '' or TenDangNhap = @tenDangNhap)
			and (@thoiDiemTu = '' or ThoiDiem >= @thoiDiemTu)
			and (@thoiDiemDen = '' or ThoiDiem <= @thoiDiemDen))

create function ufThongKeHangHoa (@maKho varchar(3),@maHangHoa varchar(3),@maDonViTinh varchar(3))
returns table
as return (select HangHoa.MaHangHoa,TenHangHoa,DonViTinh.MaDonViTinh,TenDonViTinh,SUM(SoLuong) as SoLuong from HangHoa
		inner join ChiTietKho on ChiTietKho.MaHangHoa = HangHoa.MaHangHoa
		inner join DonViTinh on ChiTietKho.MaDonViTinh = DonViTinh.MaDonViTinh
		where ((@maKho = '' or MaKho = @maKho)
		and (@maHangHoa = '' or HangHoa.MaHangHoa = @maHangHoa)
		and (@maDonViTinh = '' or DonViTinh.MaDonViTinh = @maDonViTinh))
		group by HangHoa.MaHangHoa,TenHangHoa,DonViTinh.MaDonViTinh,TenDonViTinh)

create function ufLayKhoChuaHangHoa(@maHangHoa varchar(3),@maDonViTinh varchar(3))
returns table 
as return (select TenKho,TenDonViTinh,SoLuong from Kho 
		inner join ChiTietKho on Kho.MaKho = ChiTietKho.MaKho 
		inner join HangHoa on ChiTietKho.MaHangHoa = HangHoa.MaHangHoa 
		inner join DonViTinh on DonViTinh.MaDonViTinh = ChiTietKho.MaDonViTinh
		where ChiTietKho.MaHangHoa = @maHangHoa and ChiTietKho.MaDonViTinh = @maDonViTinh)

