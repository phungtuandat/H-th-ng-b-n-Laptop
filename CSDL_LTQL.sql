create database LapTrinhQuanLy
use LapTrinhQuanLy

create table NhaCungCap(
	MaNCC varchar(10) not null primary key,
	TenNCC nvarchar(225),
	DiaChi nvarchar(225) null,
	DienThoai varchar(11) null,
)

create table TrungTamBaoHanh(
	MaTTBH varchar(10) primary key not null,
	TenTT nvarchar(200) not null,
	DiaChi nvarchar(200),
	DienThoai varchar(11)
)

create table NhanVien (
	MaNV varchar(10) not null primary key,
	TenNV nvarchar(100) not null,
	DiaChi nvarchar(225),
	DienThoai varchar(11),
	MatKhau varchar(225) not null,
	Quyen smallint not null, --1 : Admin, 0: User
)

create table KhachHang (
	MaKH varchar(10) not null primary key,
	TenKH nvarchar(100) not null,
	DiaChi nvarchar(225),
	DienThoai varchar(11),
)

create table LichSuLogin(
	STT int primary key not null,
	MaNv varchar(10) foreign key (MaNv) references NhanVien(MaNv) not null,
	GioVao varchar(200) default GetDate(),-- trả về ngày tháng hiện tại
	GioRa varchar(200) default Getdate(),
	TinhTrang nvarchar(50) default N'Thành công'
)

create table LoaiLaptop(
	MaLH varchar(10) not null primary key,
	MaNCC varchar(10) not null foreign key (MaNCC) references NhaCungCap(MaNCC) ,
	MaTTBH varchar(10) not null foreign key (Mattbh) references TrungTamBaoHanh(MATTBH) ,
	TenLH nvarchar(225),
)


-- kho + sản phẩm
create table laptop (
	MaLaptop varchar(10)  not null primary key,
	MaLH varchar(10) not null,
	TenLaptop nvarchar(225) not null,
	Ram varchar(10) null,
	OCung varchar(100) null,
	CPU varchar(225) null,
	GPU nvarchar(225) null,
	HDH varchar(225) null,
	GiaBan bigint null default 0,
	Image_Product varchar(225) null,
	GhiChu nvarchar(225) null
)

create table HoaDonNhap (
	MaHD varchar(10) primary key not null,
	MaNCC varchar(10) foreign key (MaNcc) references NhaCungCap(MaNCC),
	TenNCC nvarchar(225) not null,
	MaNV varchar(10) foreign key (MaNV) references NhanVien(MaNV),
	TenNV nvarchar(225) not null,
	TongTien int default 0 not null,
	NgayLap varchar(200),
	TinhTrang int default 0,
	-- 0: Mới , 1: Đã xác nhận , 2 Nhận thành công, 
)

create table Kho (
	STT int not null,
	MaLaptop varchar(10) foreign key (Malaptop) references Laptop(MaLaptop)  on delete cascade not null,
	TenLaptop varchar(225),
	SoLuongTon int default 0,
	SoLuongBan int default 0,
	Primary key (MaLaptop)
) 
create table HoaDonNhapChiTiet(
	MaHD varchar(10) NOT NULL,
	MaLaptop varchar(10) not null,
	TenLaptop varchar(225) not null,
	SoLuong int not null,
	GiaMua int not null,
	ThanhTien int default 0 NOT NULL,
	primary key (MAHD,MaLaptop),
	foreign key (MaHD) references HoaDonNhap(MaHD),
	foreign key (Malaptop) references Kho(MaLaptop)
)


-- LAPTOP 



-- bán

create table HoaDonBan (
	MaHD varchar(10) primary key not null,
	MaKH varchar(10) foreign key (MaKH) references KhachHang(MaKH),
	TenKh nvarchar(225) not null,
	MaNV varchar(10) foreign key (MaNV) references NhanVien(MaNv),
	TenNV nvarchar(225) not null,
	TongTien int default 0 not null,
	NgayLap varchar(200),
	TinhTrang int default 0, 
	-- 3 tình trạng : 0 Mới , 1 Chờ thanh toán, 2 Thanh toán thành công
)


create table HoaDonBanChiTiet(
	MaHD varchar(10),
	MaLaptop varchar(10),
	TenLaptop varchar(225) not null,
	SoLuong int not null,
	GiaBan int not null,
	ThanhTien int default 0,
	primary key (MaHD,MaLaptop),
	foreign key (MaLaptop) references Kho(MaLaptop),
	foreign key (MaHD) references HoaDonBan(MaHD) on delete cascade,
)

Insert into NhaCungCap values('NC101',N'Trung Quốc',N'Long Xuyên, An Giang','0588749912')

Insert into LoaiLaptop values('LH01','NC101',N'VivoBook')
Insert into LoaiLaptop values('LH02','NC101',N'VivoBook')

Insert into NhanVien values('NV01',N'Nguyễn Văn A',N'Lấp Vò,Đồng Tháp','0588749902','1223',1)
Insert into NhanVien values('NV02',N'Nguyễn Văn A',N'Lấp Vò,Đồng Tháp','0588749902','1223',1)
	
Insert into KhachHang values('KH01',N'Nguyễn Văn A',N'Lấp Vò,Đồng Tháp','0588749902')

Insert into laptop values ('LT01','LH01',N'LapTop Asus VivoBook DK102','10GB','256GB','Intel Core I5 115884g7',N'Card đồ họa tích hợp Intel UHD Graphics','Windows 10',1,100,1000000000,1200000000)
Insert into laptop values ('LT02','LH01',N'LapTop Asus VivoBook DK102','10GB','256GB','Intel Core I5 115884g7',N'Card đồ họa tích hợp Intel UHD Graphics','Windows 10',1,100,1000000000,1200000000)

Insert into HoaDonBan values ('HD01','KH01',1000000,12-10-2021)

Insert into HoaDonBanChiTiet values ('NV01','HD01','LT01',1,100000)
Insert into HoaDonChiTiet values ('NV01','HD01','LT02',1,100000)
Select *from LoaiLaptop
Select *from NhaCungCap
Select *from NhanVien
Select *from KhachHang
Select *from Laptop
Select *from HoaDonBANChiTiet
Select *from LichSuLogin

SELECT *FROM HOADONBAN

Delete from laptop where MaLaptop = 'LT01'

Delete from LichSuLogin where TinhTrang = N'Th?t b?i'


delete from NhanVien where MaNV = 'NV01'
delete from NhanVien where MaNV = 'NV01'

update NhanVien set Quyen = 1 where MaNV = 'NV02'

Insert into LichSuLogin values (1,'NV01',CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)
Insert into LichSuLogin values ('NV01',CURRENT_TIMESTAMP)


Insert into LichSuLogin values ('NV01',CURRENT_TIMESTAMP)

Update NhaCungCap set TenNCC=N'MSI' where MaNCC = 'NC101'

Select *from NhaCungCap where MaNCC = 'NC101'

SELECT * FROM NhaCungCap
WHERE MaNCC LIKE 'NC101%'
SET IDENTITY_INSERT dbo.LichSuLogin ON
Select MatKhau from NhanVien where MaNV = 'NV01'
Insert into LichSuLogin(STT,MaNv,TinhTrang) values (0,'NV01','20/10/2021')
Insert into LichSuLogin(STT,MaNv,TinhTrang) values ('NV01','20/10/2021')

select COUNT(STT)  as STT from LichSuLogin where MAnv = 'NV01'

delete from LichSuLogin

Update LichSuLogin set Giora = '20/10/2021' where stt = 1
Insert into TrungTamBaoHanh values('TT01',N'Long Xuyên An Giang','0588748812')

Select *from TrungTamBaoHanh where MaTTBH = 'TT01'4

Delete From TrungTamBaoHanh where MaTTBH='TT01'

Select *from TrungTamBaoHanh
Select COUNT(malaptop) as SoLuongLaptop from Laptop
Select TenLaptop from Laptop where SoLuong <= 20


Insert into HoaDonBan values ('HD02','KH01','NV01',0,'20/10/2021')

Select GETDATE()
SELECT FORMAT(GETDATE() , 'dd/MM/yyyy HH:mm:ss')
 Insert into HoaDonBanChiTiet values ('HD01','LT01',1,1000,100)
  Insert into HoaDonBanChiTiet values ('H01','LT01',1,1000,100)
  Insert into HoaDonBanChiTiet values ('H01','LT02',1,1000,100)
 Select *from HoaDonBanChiTiet
 delete from HoaDonBanChiTiet where MaHD = 'HD01'

 Select tenlaptop from Laptop where MaLaptop = 'LT01'

 Select malaptop from Laptop where MaLaptop = 'LT01'

Select sum(TongTien) from HoaDonBan WHERE MaHD = 'HD01'

select sum(ThanhTien) AS 'ThanhTien' from HoaDonBanChiTiet WHERE MaHD = 'HD01'

update HoaDonBan set TongTien = 0 where MaHD ='HD01'
update HoaDonBan set TongTien = 0 where MaHD ='HD02'

Select *from HoaDonBanChiTiet where MaLaptop = 'LT01'

Select *from HoaDonBan


create trigger Them_DuLieuHDCT on HoaDonBanChiTiet
for insert, update
as
begin
	declare @malaptop varchar(5);
	set @malaptop = (select malaptop from inserted)

	update HoaDonBan set TongTien = 
	(select sum(hdct.ThanhTien) from HoaDonBanChiTiet hdct, inserted 
	 where inserted.MaHD = hdct.MaHD) where MaHD = (select MaHD from inserted)
	 -- trừ ở kho
	 update Kho set SoLuongTon = SoLuongTon -
	(select inserted.SoLuong from inserted) where MaLaptop = @malaptop

	 update Kho set SoLuongBan = SoLuongBan +
	(select inserted.SoLuong from inserted) where MaLaptop = @malaptop
end;

create trigger Bot_DuLieuHDCT on HoaDonBanChiTiet
for delete
as
begin
	declare @malaptop varchar(5);
	set @malaptop = (select malaptop from deleted)
	update HoaDonBan set TongTien = 
	(select sum(hdct.ThanhTien) from HoaDonBanChiTiet hdct, deleted 
	 where deleted.MaHD = hdct.MaHD) where MaHD = (select MaHD from deleted)
	 -- CỘNG LẠI Ở KHO
	 update Kho set SoLuongTon = SoLuongTon +
	(select deleted.SoLuong from deleted) where MaLaptop = @malaptop

	 update Kho set SoLuongBan = SoLuongBan -
	(select deleted.SoLuong from deleted) where MaLaptop = @malaptop
end;


Select *from HoaDonBan

Select *from HoaDonBanChiTiet

update HoaDonBanChiTiet set SoLuong = 3 where MaLaptop = 'LT01' and MaHD = 'hd01'




UPDATE HoaDonBan SET TongTien = 0 WHERE MaHD = 'HD01'

sELECT *FROM HoaDonBan

delete from HoaDonBanChiTiet where MaHD = 'hd01'

Insert into LichSuLogin values (1,'NV01',CURRENT_TIMESTAMP,CURRENT_TIMESTAMP,N'Thành công')

Select *from HoaDonBan where MaHD = 'HD01' and TongTien > 0

Insert into laptop values('LT03','LH01','Asus ADm Ryzen 5550u')

select *from Kho


Select COunt(STT)+1  AS STT from Kho

Insert into Kho values (COunt(kO.STT)+1,'LT01','SASASASA',0,0)

Select *from Kho

Insert into Kho values(2,'LT03','Laptop acer aspire rryzen 121212',0,0)

Insert into Kho Values ('3', 'LT04' ,'Acer aspire r3' '0' , '0')

Insert into HoaDonBan values('HD01','KH01','NV01',0,'25/10/2021')

Insert into HoaDonBanChiTiet values('HD01','LT01',1,1000000,10000000)
Insert into HoaDonBanChiTiet values('HD01','LT03',1,1000000,10000000)
Insert into HoaDonBanChiTiet values('HD01','LT05',1,1000000,10000000)

Insert into HoaDonBanChiTiet values('HD01','LT01','Acerapire 10',1,1000000,10000000)

Insert into HoaDonBanChiTiet values('HD04','LT01','Acerapire 10',1,1000000,10000000)
Select *from HoaDonNhap

Select *from laptop

Insert into HoaDonNhap values ('HD01' ,'ma_NCC','NV01','0','31/05/2021 12:58:09 CH')

Insert into HoaDonNhapChiTiet values('HD04','LT01','Acerapire 10',1,1000000,10000000)

Update HoaDonNhap set TinhTrang = 1 where Mahd ='HD01'

Select SoLuong FROM HoaDonNhapChiTiet where MaHD = 'HD01' and MaLaptop = 'LT02'
Update KHo set SoLuongTon = SoLuongTon + (Select SoLuong FROM HoaDonNhapChiTiet where MaHD = 'HD01' and MaLaptop = 'LT02') where MaLaptop = 'LT02'
UPDATE KHO SET SoLuongBan = 0

SELECT *FROM Kho



create trigger Them_DuLieuHDNCT on HoaDonNhapChiTiet
for insert, update
as
begin
	declare @malaptop varchar(5);
	set @malaptop = (select malaptop from inserted)

	update HoaDonNhap set TongTien =
	(select sum(hdct.ThanhTien) from HoaDonNhapChiTiet hdct, inserted 
	 where inserted.MaHD = hdct.MaHD) where MaHD = (select MaHD from inserted)
	 -- trừ ở kho
	 update Kho set SoLuongTon = SoLuongTon +
	(select inserted.SoLuong from inserted) where MaLaptop = @malaptop
end;

create trigger Bot_DuLieuHDNCT on HoaDonNhapChiTiet
for delete
as
begin
	declare @malaptop varchar(5);
	set @malaptop = (select malaptop from deleted)
	update HoaDonNhap set TongTien = 
	(select sum(hdct.ThanhTien) from HoaDonNhapChiTiet hdct, deleted 
	 where deleted.MaHD = hdct.MaHD) where MaHD = (select MaHD from deleted)
	 -- 
	 update Kho set SoLuongTon = SoLuongTon -
	(select deleted.SoLuong from deleted) where MaLaptop = @malaptop
end;

Insert into HoaDonnhapChiTiet values ('HD04','LT01','FDSFSDFSDFSDFSD',4,10000000,40000000)

Insert into HoaDonnhapChiTiet values ('HD04','LT01','FDSFSDFSDFSDFSD',1,1000000,1000000)

Insert into HoaDonnhapChiTiet values ('HD04','LT01','FDSFSDFSDFSDFSD',1,15000000,15000000)

Select *from HoaDonNhap
Select *from HoaDonNhapChiTiet
Select *froM Kho

Insert into HoaDonnhapChiTiet values ('HD02','LT01','Acer aspire 5',1,14124124,14124124)

 update laptop set GiaBan = 
	(select (GiaBan + 1000000))

	Select *from HoaDonNhap where TinhTrang = 0

	Update HoaDonNhap set TongTien = 0 Where MaHD ='HD05'

	Select MaHD from HoaDonNhap where MaHD ='HD01'

Update HoaDonBan SET TongTien = 0 Where MaHD = 'HD07'

Select TenKH from HoaDonBan where  MaHD = 'hd01'

Select *from Kho
Select *from HoaDonNhap

Select TenNCC from HoaDonNhap where MaHD = 'HD01'
Select *from Laptop
Select *from Laptop Where GiaBan between 11000000 and 12000000