CREATE DATABASE QUANLYCUAHANGGIAY
USE QUANLYCUAHANGGIAY
create table NhomQuyen(
MaNhomQuyen int identity(1,1) primary key not null,
TenNhomQuyen nvarchar(50),
TrangThai int
)
create table ChucNang(
MaChucNang int  identity(1,1) primary key not null,
TenChucNang nvarchar(50),
TrangThai int)
----
create table NhanVien(
MaNhanVien int identity(1,1) primary key not null,
TenNhanVien nvarchar(50),
Tuoi int,
SoDienThoai nvarchar(10),
HinhAnh image,
TrangThai int
)
----
create table TaiKhoan(
MaTaiKhoan int primary key not null,
MaNhomQuyen int,
TenTaiKhoan nvarchar(50),
MatKhau nvarchar(50),
TrangThai int
)
ALTER TABLE TaiKhoan ADD constraint FK_NhomQuyen foreign key (MaNhomQuyen) references NhomQuyen(MaNhomQuyen)
ALTER TABLE TaiKhoan ADD constraint FK_NhanVien foreign key (MaTaiKhoan) references NhanVien(MaNhanVien)
----
create table ChiTietQuyen(
Id int identity(1,1) primary key not null,
MaNhomQuyen int not null,
MaChucNang int not null,
HanhDong nvarchar(50)
)
select * from ChiTietQuyen
ALTER TABLE ChiTietQuyen ADD constraint FK_ChiTietQuyen_NhomQuyen foreign key (MaNhomQuyen) references NhomQuyen(MaNhomQuyen)
ALTER TABLE ChiTietQuyen ADD constraint FK_ChiTietQuyen_ChucNang foreign key (MaChucNang) references ChucNang(MaChucNang)
----

create table MauSac(
MaMau int identity(1,1) primary key not null,
TenMau nvarchar(50),
TrangThai int
)
create table KichCo(
MaKichCo int identity(1,1) not null primary key,
TenKichCo nvarchar(50),
TrangThai int
)
create table ChatLieu(
MaChatLieu int identity(1,1) primary key not null,
TenChatLieu nvarchar(50),
TrangThai int
)
create table TheLoai(
MaTheLoai int identity(1,1) primary key not null,
TenTheLoai nvarchar(50),
TrangThai int
)
create table ThuongHieu(
MaThuongHieu int identity(1,1) primary key not null,
TenThuongHieu nvarchar(50),
TrangThai int
)
----
CREATE TABLE SanPham
(
	MaSanPham INT  PRIMARY KEY NOT NULL,
	MaThuongHieu INT NOT NULL,
	MaTheLoai INT NOT NULL,
	MaChatLieu INT NOT NULL,
	TenSanPham NVARCHAR(250),
	GiaSanPham FLOAT,
	GiaNhap FLOAT,
	SoLuongNhap INT,
	SoLuongTon INT,
	TrangThai INT,
)
ALTER TABLE SanPham ADD constraint FK_ThuongHieu foreign key (MaThuongHieu) references ThuongHieu(MaThuongHieu)
ALTER TABLE SanPham ADD constraint FK_TheLoai foreign key (MaTheLoai) references TheLoai(MaTheLoai)
ALTER TABLE SanPham ADD constraint FK_ChatLieu foreign key (MaChatLieu) references ChatLieu(MaChatLieu)
----
create table ChiTietSanPham(
MaChiTietSanPham int identity (1,1)  primary key not null,
MaSanPham int,
MaMauSac int,
MaKichCo int,
HinhAnh image,
SoLuongNhap int,
SoLuongTon int,
TrangThai int
)
ALTER TABLE ChiTietSanPham ADD constraint FK_ChiTietSanPham_SanPham foreign key (MaSanPham) references SanPham(MaSanPham)
ALTER TABLE ChiTietSanPham ADD constraint FK_ChiTietSanPham_MauSac foreign key (MaMauSac) references MauSac(MaMau)
ALTER TABLE ChiTietSanPham ADD constraint FK_ChiTietSanPham_KichCo foreign key (MaKichCo) references KichCo(MaKichCo)
----
create table KhachHang(
MaKhachHang int primary key not null,
TenKhachHang nvarchar(50),
Tuoi int null,
SoDienThoai nvarchar(10),
DiaChi nvarchar(100) null,
TrangThai int
)
create Table NhaCungCap(
MaNhaCungCap int identity(1,1) primary key not null,
TenNhaCungCap nvarchar(50),
DiaChi nvarchar(200),
SoDienThoai nvarchar(10),
TrangThai int
)
----
create table PhieuNhap(
MaPhieuNhap int primary key not null,
MaNhaCungCap int,
MaNhanVien int,
NgayNhap datetime,
TenPhieuNhap nvarchar(50),
TongTienNhap float,
TrangThai int
)
ALTER TABLE PhieuNhap ADD constraint FK_NhaCungCap foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap) 
ALTER TABLE PhieuNhap ADD constraint FK_PhieuNhap_NhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien) 
----
create table ChiTietPhieuNhap(
MaPhieuNhap int,
MaChiTietSanPham int,
SoLuongNhap int,
DonVi nvarchar(50),
TienNhap float,
ThanhTien float
)
ALTER TABLE ChiTietPhieuNhap ALTER COLUMN  MaPhieuNhap int not null
ALTER TABLE ChiTietPhieuNhap ALTER COLUMN  MaChiTietSanPham int not null
ALTER TABLE ChiTietPhieuNhap ADD constraint FK_ChiTietPhieuNhap foreign key (MaPhieuNhap) references PhieuNhap(MaPhieuNhap) 
ALTER TABLE ChiTietPhieuNhap ADD constraint FK_ChiTietPhieuNhap_ChiTietSanPham foreign key (MaChiTietSanPham) references ChiTietSanPham(MaChiTietSanPham) 
----
create table Thue(
MaThue int identity(1,1) primary key not null,
TenThue nvarchar(50),
MucThue float,
TrangThai int
)
----
create table KhuyenMai(
MaKhuyenMai int identity(1,1) primary key not null,
MucKhuyenMai float,
DieuKien nvarchar(250),
ThoiGianBatDau datetime,
ThoiGianKetThuc datetime,
TinhTrang int
)
----
create table HoaDon(
MaHoaDon int primary key not null,
MaKhachHang int,
MaNhanVien int,
MaKhuyenMai int null,
MaThue int null,
TenHoaDon nvarchar(250),
NgayLapHoaDon datetime,
TongTien float,
TongTienKhuyenMai float,
TongTienThue float,
HinhThucThanhToan nvarchar(250),
ThanhTien float,
TrangThai int
)
ALTER TABLE HoaDon ADD constraint FK_HoanDon_NhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien)
ALTER TABLE HoaDon ADD constraint FK_HoanDon_KhachHang foreign key (MaKhachHang) references KhachHang(MaKhachHang)
ALTER TABLE HoaDon ADD constraint FK_HoanDon_KhuyenMai foreign key (MaKhuyenMai) references KhuyenMai(MaKhuyenMai)
ALTER TABLE HoaDon ADD constraint FK_HoanDon_Thue foreign key (MaThue) references Thue(MaThue)
----
create table ChiTietHoaDon(
MaHoaDon int not null,
MaChiTietSanPham int not null,
GiaSanPham float,
SoLuong int,
ThanhTien float
)
ALTER TABLE ChiTietHoaDon ADD constraint FK_ChiTietHoanDon_HoaDon foreign key (MaHoaDon) references HoaDon(MaHoaDon)
ALTER TABLE ChiTietHoaDon ADD constraint FK_ChiTietHoanDon_ChiTietSanPham foreign key (MaChiTietSanPham) references ChiTietSanPham(MaChiTietSanPham)
----
create table PhieuTra(
MaPhieuTra int primary key not null,
MaNhanVien int,
MaHoaDon int,
NgayTra datetime,
TongSoLuongTra int,
TongTienTra float,
TrangThai int
)
ALTER TABLE PhieuTra ADD constraint FK_PhieuTra_NhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien)
ALTER TABLE PhieuTra ADD constraint FK_PhieuTra_HoaDon foreign key (MaHoaDon) references HoaDon(MaHoaDon)
----
create table ChiTietPhieuTra(
MaPhieuTra int not null,
MaChiTietSanPham int not null,
LyDoTra nvarchar(250),
GiaSanPham float,
SoLuong int,
ThanhTien float
)
select * from ChiTietPhieuTra
ALTER TABLE ChiTietPhieuTra ADD constraint FK_ChiTietPhieuTra_PhieuTra foreign key (MaPhieuTra) references PhieuTra(MaPhieuTra)
ALTER TABLE ChiTietPhieuTra ADD constraint FK_ChiTietPhieuTra_ChiTietSanPham foreign key (MaChiTietSanPham) references ChiTietSanPham(MaChiTietSanPham)
-----
-----
create proc Select_DanhSachSanPham
as
SELECT SanPham.MaSanPham,SanPham.TenSanPham, MauSac.TenMau, KichCo.TenKichCo, SanPham.GiaNhap FROM SanPham 
                JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau 
                JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo where SanPham.TrangThai=1
--
create proc Select_DanhSachChiTietSanPham
@MaSanPham int
as
begin
SELECT sp.TenSanPham, ms.TenMau, kc.TenKichCo, tl.TenTheLoai, th.TenThuongHieu,cl.TenChatLieu, ctsp.SoLuongTon,ctsp.MaChiTietSanPham FROM ChiTietSanPham ctsp JOIN
                 SanPham sp ON ctsp.MaSanPham = sp.MaSanPham 
                JOIN ChatLieu cl ON sp.MaChatLieu = cl.MaChatLieu JOIN TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai JOIN ThuongHieu th ON sp.MaThuongHieu = th.MaThuongHieu JOIN MauSac ms ON 
                ctsp.MaMauSac = ms.MaMau JOIN KichCo kc ON ctsp.MaKichCo = kc.MaKichCo where sp.MaSanPham=@MaSanPham
end
----
create proc Select_DanhSachSanPhamBan
as
SELECT SanPham.MaSanPham, TenSanPham, TheLoai.TenTheLoai, ChatLieu.TenChatLieu, ThuongHieu.TenThuongHieu, MauSac.TenMau, KichCo.TenKichCo, SanPham.GiaSanPham,ChiTietSanPham.SoLuongTon,ChiTietSanPham.MaChiTietSanPham FROM SanPham 
                JOIN ChatLieu ON SanPham.MaChatLieu = ChatLieu.MaChatLieu JOIN TheLoai ON SanPham.MaTheLoai = TheLoai.MaTheLoai 
                JOIN ThuongHieu ON SanPham.MaThuongHieu = ThuongHieu.MaThuongHieu JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham 
                JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo where SanPham.GiaSanPham>0 and ChiTietSanPham.SoLuongTon>0
--
create proc Select_ChiTietHoaDon
@MaHoaDon int
as
SELECT ctsp.MaChiTietSanPham ,sp.TenSanPham , ms.TenMau ,kc.TenKichCo, cthd.SoLuong ,sp.GiaSanPham ,cthd.ThanhTien FROM ChiTietSanPham ctsp 
                JOIN SanPham sp ON ctsp.MaSanPham = sp.MaSanPham 
                JOIN MauSac ms ON ctsp.MaMauSac = ms.MaMau JOIN KichCo kc ON ctsp.MaKichCo = kc.MaKichCo 
                JOIN ChiTietHoaDon cthd ON ctsp.MaChiTietSanPham = cthd.MaChiTietSanPham 
                JOIN HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon where cthd.MaHoaDon=@MaHoaDon
--
create proc Select_SanPham
as
select * from SanPham where TrangThai=1
--
create proc Select_PhieuNhap
as 
select * from PhieuNhap where TrangThai=1
--
create proc Select_PhieuTra
as
select * from PhieuTra where TrangThai=1
--
create proc Select_HoaDon
as
select * from HoaDon where TrangThai = 1
--
create proc Select_ChatLieu
as
select * from ChatLieu where TrangThai=1
---
create proc Select_DanhSachChiTietPhieuNhap
@MaPhieuNhap int
as
begin
SELECT ChiTietSanPham.MaChiTietSanPham,SanPham.TenSanPham,MauSac.TenMau,KichCo.TenKichCo,ChiTietPhieuNhap.SoLuongNhap,ChiTietPhieuNhap.DonVi,ChiTietPhieuNhap.TienNhap,ChiTietPhieuNhap.ThanhTien 
                FROM ChiTietSanPham 
                JOIN SanPham ON ChiTietSanPham.MaSanPham = SanPham.MaSanPham JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo JOIN ChiTietPhieuNhap 
                ON ChiTietSanPham.MaChiTietSanPham = ChiTietPhieuNhap.MaChiTietSanPham 
                JOIN PhieuNhap ON PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap where PhieuNhap.MaPhieuNhap=@MaPhieuNhap
end
--
create proc Select_ChiTietQuyen
as
select * from ChiTietQuyen
--
create proc Select_ChiTietSanPham
as
select * from ChiTietSanPham where TrangThai=1
---
create proc Select_ChucNang
as
select * from ChucNang where TrangThai=1
--
create proc Select_KhachHang
as
select * from KhachHang
--
create proc Select_KhuyenMai
as
select * from KhuyenMai where TinhTrang=1
--
create proc Select_KichCo
as
select * from KichCo where TrangThai=1
--
create proc Select_MauSac
as
select * from MauSac where TrangThai=1
--
create proc Select_NhaCungCap
as
select * from NhaCungCap where TrangThai=1
--
create proc Select_NhanVien
as
select * from NhanVien where TrangThai=1
--
create proc Select_NhomQuyen
as
select * from NhomQuyen where TrangThai=1
--
create proc Select_TaiKhoan
as
select * from TaiKhoan where TrangThai=1
--
create proc Select_TheLoai
as
select * from TheLoai where TrangThai=1
--
create proc Select_Thue
as
select * from Thue where TrangThai=1
--
create proc Select_ThuongHieu
as
select * from ThuongHieu where TrangThai=1
--
create proc Select_MaChiTietSanPham
@MaSanPham int,
@MaKichCo int,
@MaMauSac int
as
begin
select MaChiTietSanPham from ChiTietSanPham where MaSanPham=@MaSanPham and MaKichCo=@MaKichCo and MaMauSac=@MaMauSac
end
--
create proc Select_ChiTietPhieuNhap
as
select * from ChiTietPhieuNhap
--
create proc ThongKe_SanPhamTon
as
select TenSanPham,SUM(SoLuongTon) AS SL from SanPham GROUP BY TenSanPham
--
create proc ThongKe_SanPhamBan
as
SELECT TenSanPham, SUM(SoLuong) AS SL FROM SanPham JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham
                 JOIN ChiTietHoaDon ON ChiTietSanPham.MaChiTietSanPham = ChiTietHoaDon.MaChiTietSanPham GROUP BY TenSanPham
--
SELECT SanPham.TenSanPham, SUM(SoLuong) AS SL FROM SanPham JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham
                JOIN ChiTietHoaDon ON ChiTietSanPham.MaChiTietSanPham = ChiTietHoaDon.MaChiTietSanPham GROUP BY TenSanPham
--
create proc ThongKe_SanPhamPhoBien
as
select TOP 3 TenSanPham,SUM(SoLuong) AS SL from SanPham join ChiTietSanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham join ChiTietHoaDon 
on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham join HoaDon on HoaDon.MaHoaDon=ChiTietHoaDon.MaHoaDon  group by TenSanPham order by SL DESC
--
create proc ThongKe_ChiTietSanPhamBan
as
select concat(SanPham.TenSanPham,'-',MauSac.TenMau,'-',KichCo.TenKichCo) AS SanPham,SUM(SoLuong) AS SL from ChiTietHoaDon join ChiTietSanPham 
on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham 
join SanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham
join MauSac on ChiTietSanPham.MaMauSac=MauSac.MaMau
join KichCo on ChiTietSanPham.MaKichCo=KichCo.MaKichCo
group by ChiTietSanPham.MaChiTietSanPham,SanPham.MaSanPham,SanPham.TenSanPham,KichCo.TenKichCo,MauSac.TenMau
--
create proc ThongKe_ChiTietSanPhamNhap
as
select concat(SanPham.TenSanPham,'-',MauSac.TenMau,'-',KichCo.TenKichCo) AS SanPham,SUM(ChiTietPhieuNhap.SoLuongNhap) AS SL from PhieuNhap join ChiTietPhieuNhap on PhieuNhap.MaPhieuNhap=ChiTietPhieuNhap.MaPhieuNhap join ChiTietSanPham 
on ChiTietSanPham.MaChiTietSanPham=ChiTietPhieuNhap.MaChiTietSanPham
join SanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham 
join MauSac on MauSac.MaMau=ChiTietSanPham.MaMauSac
join KichCo on KichCo.MaKichCo=ChiTietSanPham.MaKichCo
group by ChiTietSanPham.MaChiTietSanPham,SanPham.MaSanPham,SanPham.TenSanPham,KichCo.TenKichCo,MauSac.TenMau
--
create proc ThongKe_ChiTietSanPhamTon
as
select concat(SanPham.TenSanPham,'-',MauSac.TenMau,'-',KichCo.TenKichCo) AS SanPham,SUM(ChiTietSanPham.SoLuongTon) AS SL  from SanPham join ChiTietSanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham join MauSac 
on MauSac.MaMau=ChiTietSanPham.MaMauSac join KichCo on KichCo.MaKichCo=ChiTietSanPham.MaKichCo 
group by ChiTietSanPham.MaChiTietSanPham,SanPham.MaSanPham,SanPham.TenSanPham,KichCo.TenKichCo,MauSac.TenMau
--
create proc ThongKe_ChiTietSanPhamPhoBien
as
select concat(SanPham.TenSanPham,'-',MauSac.TenMau,'-',KichCo.TenKichCo) AS SanPham,SUM(ChiTietHoaDon.SoLuong) AS SL from ChiTietSanPham join
(select TOP 3 ChiTietSanPham.MaSanPham,SUM(SoLuong) AS SL from SanPham join ChiTietSanPham 
on SanPham.MaSanPham=ChiTietSanPham.MaSanPham join ChiTietHoaDon 
on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham join HoaDon 
on HoaDon.MaHoaDon=ChiTietHoaDon.MaHoaDon  group by ChiTietSanPham.MaSanPham order by SL DESC)
AS PhoBien on ChiTietSanPham.MaSanPham=PhoBien.MaSanPham join ChiTietHoaDon
on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham join HoaDon 
on ChiTietHoaDon.MaHoaDon=HoaDon.MaHoaDon join MauSac on MauSac.MaMau=ChiTietSanPham.MaMauSac
join KichCo on KichCo.MaKichCo=ChiTietSanPham.MaKichCo join SanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham
group by ChiTietSanPham.MaChiTietSanPham,SanPham.MaSanPham,SanPham.TenSanPham,KichCo.TenKichCo,MauSac.TenMau
-----------
select * from ChucNang
update ChucNang set TrangThai=1 where MaChucNang=3
select * from KhachHang