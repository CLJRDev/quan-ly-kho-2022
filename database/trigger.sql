--TRIGGER
create trigger tgThemChiTietPhieuNhap
on ChiTietPhieuNhap
for insert
as begin
	declare @soLuong float;
	declare @maPhieuNhap int;
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maKho varchar(3);
	declare @dem int;
	set @soLuong = (select SoLuong from inserted);
	set @maPhieuNhap = (select MaPhieuNhap from inserted);
	set @maKho = (select MaKho from PhieuNhap where MaPhieuNhap = @maPhieuNhap);
	set @maHangHoa = (select MaHangHoa from inserted);
	set @maDonViTinh = (select MaDonViTinh from inserted);
	set @dem = (select count(*) from ChiTietKho where MaKho=@maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh);
	if @dem>0
		update ChiTietKho set SoLuong = SoLuong + @soLuong where MaKho=@maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh;
	else 
		insert ChiTietKho values(@maKho,@maHangHoa,@maDonViTinh,@soLuong);
end
drop trigger tgXoaChiTietPhieuNhap
create trigger tgXoaChiTietPhieuNhap
on ChiTietPhieuNhap
for delete 
as begin 
	declare @soLuong float;
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maPhieuNhap int;
	declare @maKho varchar(3);
	declare @soLuongTon float;
	set @soLuong = (select SoLuong from deleted);
	set @maHangHoa = (select MaHangHoa from deleted);
	set @maDonViTinh = (select MaDonViTinh from deleted);
	set @maPhieuNhap = (select MaPhieuNhap from deleted);
	set @maKho = (select MaKho from PhieuNhap where MaPhieuNhap=@maPhieuNhap);
	set @soLuongTon = (select SoLuong from ChiTietKho where MaKho=@maKho and MaDonViTinh=@maDonViTinh and MaHangHoa=@maHangHoa);
	if @soLuongTon >= @soLuong
		update ChiTietKho set SoLuong = SoLuong - @soLuong where MaKho=@maKho and MaDonViTinh=@maDonViTinh and MaHangHoa=@maHangHoa;
	else
		throw 50000,N'So luong ton kho bi am',1;
end

drop trigger tgXoaChiTietPhieuNhap

create trigger tgThemChiTietPhieuXuat
on ChiTietPhieuXuat
for insert
as begin
	declare @soLuong float;
	declare @maPhieuXuat int;
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maKho varchar(3);
	declare @dem int;
	set @soLuong = (select SoLuong from inserted);
	set @maPhieuXuat = (select MaPhieuXuat from inserted);
	set @maKho = (select MaKho from PhieuXuat where MaPhieuXuat = @maPhieuXuat);
	set @maHangHoa = (select MaHangHoa from inserted);
	set @maDonViTinh = (select MaDonViTinh from inserted);
	set @dem = (select count(*) from ChiTietKho where MaKho = @maKho and MaHangHoa = @maHangHoa and MaDonViTinh = @maDonViTinh);
	if @dem > 0
	begin
		declare @soLuongCon float;
		set @soLuongCon = (select SoLuong from ChiTietKho where MaKho=@maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh);
		if @soLuongCon >= @soLuong
			update ChiTietKho set SoLuong = SoLuong - @soLuong where MaKho = @maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh;
		else
			throw 50000,N'Không đủ hàng hoá để xuất kho',1;
	end
	else				
		throw 50001, N'Hàng hoá không tồn tại trong kho',1;
end

create trigger tgXoaChiTietPhieuXuat
on ChiTietPhieuXuat
for delete
as begin
	declare @soLuong float;
	declare @maPhieuXuat int;
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maKho varchar(3);
	set @soLuong = (select SoLuong from deleted);
	set @maPhieuXuat = (select MaPhieuXuat from deleted);
	set @maKho = (select MaKho from PhieuXuat where MaPhieuXuat = @maPhieuXuat);
	set @maHangHoa = (select MaHangHoa from deleted);
	set @maDonViTinh = (select MaDonViTinh from deleted);			
	update ChiTietKho set SoLuong = SoLuong + @soLuong where MaKho = @maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh;					
end

create trigger tgThemLoaiHang
on LoaiHang
for insert
as begin 
	declare @tenDangNhap varchar(30);
	declare @tenLoaiHang nvarchar(30);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenLoaiHang = (select TenLoaiHang from inserted);
	insert NhatKy(TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),N'Thêm dữ liệu bảng LoaiHang: ' + @tenLoaiHang);
end

create trigger tgSuaLoaiHang
on LoaiHang
for update
as begin
	declare @tenDangNhap varchar(30);
	declare @tenLoaiHangMoi nvarchar(30);
	declare @tenLoaiHangCu nvarchar(30);
	declare @noiDung nvarchar(200);
	set @noiDung = N'Sửa dữ liệu bảng LoaiHang: ';
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenLoaiHangMoi = (select TenLoaiHang from inserted);
	set @tenLoaiHangCu = (select TenLoaiHang from deleted);
	if @tenLoaiHangCu <> @tenLoaiHangMoi 
	begin
		set @noiDung = @noiDung + N'Tên loại hàng: ' + @tenLoaiHangCu + ' => ' + @tenLoaiHangMoi + '.';
		insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap, getdate(),@noiDung);
	end
end


create trigger tgXoaLoaihang
on LoaiHang 
for delete 
as begin
	declare @tenDangNhap varchar(30);
	declare @tenLoaiHang nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from deleted);
	set @tenLoaiHang = (select TenLoaiHang from deleted);
	set @noiDung = N'Xoá loại hàng: ' + @tenLoaiHang;
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
end

create trigger tgThemDonViTinh
on DonViTinh
for insert
as begin
	declare @tenDangNhap varchar(30);
	declare @tenDonViTinh nvarchar(30);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenDonViTinh = (select TenDonViTinh from inserted);
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),N'Thêm dữ liệu bảng DonViTinh: ' + @tenDonViTinh);
end
drop trigger tgSuaDonViTinh
create trigger tgSuaDonViTinh
on DonViTinh
for update
as begin
	declare @tenDangNhap varchar(30);
	declare @tenDonViTinhCu nvarchar(30);
	declare @tenDonViTinhMoi nvarchar(30);
	declare @noiDung nvarchar(200);
	set @noiDung = N'Sửa dữ liệu bảng DonViTinh: ';
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenDonViTinhCu = (select TenDonViTinh from deleted);
	set @tenDonViTinhMoi = (select TenDonViTinh from inserted);
	if @tenDonViTinhCu <> @tenDonViTinhMoi
	begin
		set @noiDung = @noiDung + N'Tên đơn vị tính: ' + @tenDonViTinhCu + ' => ' +@tenDonViTinhMoi + '.';
		insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
	end
end

create trigger tgXoaDonViTinh
on DonViTinh 
for delete 
as begin
	declare @tenDangNhap varchar(30);
	declare @tenDonViTinh nvarchar(30);
	set @tenDangNhap = (select NguoiSua from deleted);
	set @tenDonViTinh = (select TenDonViTinh from deleted);
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),N'Xoá đơn vị tính: ' + @tenDonViTinh);
end

create trigger tgThemHangHoa
on HangHoa
for insert
as begin
	declare @tenDangNhap varchar(30);
	declare @tenHangHoa nvarchar(30);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenHangHoa = (select TenHangHoa from inserted);
	insert NhatKy(TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),N'Thêm dữ liệu bảng HangHoa: ' + @tenHangHoa);
end

create trigger tgSuaHangHoa
on HangHoa
for update 
as begin
	declare @tenDangNhap varchar(30);
	declare @tenHangHoaCu nvarchar(30);
	declare @tenHangHoaMoi nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @tenHangHoaCu = (select TenHangHoa from deleted);
	set @tenHangHoaMoi = (select TenHangHoa from inserted);
	set @noiDung = N'Sửa dữ liệu bảng HangHoa: ';
	if @tenHangHoaCu <> @tenHangHoaMoi
	begin
		set @noiDung = @noiDung + N'Tên đơn vị tính: ' + @tenHangHoaCu + ' => ' + @tenHangHoaMoi + '.';
		insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
	end
end

create trigger tgXoaHangHoa
on HangHoa
for delete
as begin 
	declare @tenDangNhap varchar(30);
	declare @tenHangHoa nvarchar(30);
	set @tenDangNhap = (select NguoiSua from deleted);
	set @tenHangHoa = (select TenHangHoa from deleted);
	insert NhatKy(TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),N'Xoá dữ liệu bảng HangHoa: ' + @tenHangHoa);
end


create trigger tgThemDonViTinhHangHoa
on DonViTinhHangHoa
for insert
as begin
	declare @tenDangNhap varchar(30);
	declare @maHangHoa nvarchar(3);
	declare @tenHangHoa nvarchar(30);
	declare @maDonViTinh varchar(3);
	declare @tenDonViTinh nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @maHangHoa = (select MaHangHoa from inserted);
	set @tenHangHoa = (select TenHangHoa from HangHoa where MaHangHoa=@maHangHoa);
	set @maDonViTinh = (select MaDonViTinh from inserted);
	set @tenDonViTinh = (select TenDonViTinh from DonViTinh where MaDonViTinh = @maDonViTinh);
	set @noiDung = N'Thêm dữ liệu bảng DonViTinhHangHoa: Thêm đơn vị tính ' + @tenDonViTinh + N' cho hàng hoá ' + @tenHangHoa;
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
end

create trigger tgXoaDonViTinhHangHoa
on DonViTinhHangHoa
for delete 
as begin
	declare @tenDangNhap varchar(30);
	declare @maHangHoa nvarchar(3);
	declare @tenHangHoa nvarchar(30);
	declare @maDonViTinh varchar(3);
	declare @tenDonViTinh nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from deleted);
	set @maHangHoa = (select MaHangHoa from deleted);
	set @tenHangHoa = (select TenHangHoa from HangHoa where MaHangHoa=@maHangHoa);
	set @maDonViTinh = (select MaDonViTinh from deleted);
	set @tenDonViTinh = (select TenDonViTinh from DonViTinh where MaDonViTinh = @maDonViTinh);
	set @noiDung = N'Xoá dữ liệu bảng DonViTinhHangHoa: Xoá đơn vị tính ' + @tenDonViTinh + N' của hàng hoá ' + @tenHangHoa;
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
end

create trigger tgThemLoaiHangHangHoa
on LoaiHangHangHoa
for insert
as begin
	declare @tenDangNhap varchar(30);
	declare @maLoaiHang nvarchar(3);
	declare @tenLoaiHang nvarchar(30);
	declare @maHangHoa varchar(3);
	declare @tenHangHoa nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from inserted);
	set @maLoaiHang = (select MaLoaiHang from inserted);
	set @tenLoaiHang = (select TenLoaiHang from LoaiHang where MaLoaiHang=@maLoaiHang);
	set @maHangHoa = (select MaHangHoa from inserted);
	set @tenHangHoa = (select TenHangHoa from HangHoa where MaHangHoa = @maHangHoa);
	set @noiDung = N'Thêm dữ liệu bảng LoaiHangHangHoa: Thêm loại hàng ' + @tenLoaiHang + N' cho hàng hoá ' + @tenHangHoa;
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
end

create trigger tgXoaLoaiHangHangHoa
on LoaiHangHangHoa
for delete 
as begin
	declare @tenDangNhap varchar(30);
	declare @maLoaiHang nvarchar(3);
	declare @tenLoaiHang nvarchar(30);
	declare @maHangHoa varchar(3);
	declare @tenHangHoa nvarchar(30);
	declare @noiDung nvarchar(200);
	set @tenDangNhap = (select NguoiSua from deleted);
	set @maLoaiHang = (select MaLoaiHang from deleted);
	set @tenLoaiHang = (select TenLoaiHang from LoaiHang where MaLoaiHang=@maLoaiHang);
	set @maHangHoa = (select MaHangHoa from deleted);
	set @tenHangHoa = (select TenHangHoa from HangHoa where MaHangHoa = @maHangHoa);
	set @noiDung = N'Xoá dữ liệu bảng LoaiHangHangHoa: Xoá loại hàng ' + @tenLoaiHang + N' của hàng hoá ' + @tenHangHoa;
	insert NhatKy (TenDangNhap,ThoiDiem,NoiDung) values (@tenDangNhap,getdate(),@noiDung);
end

