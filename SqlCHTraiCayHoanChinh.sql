CREATE DATABASE CHTraiCay
GO
USE CHTraiCay

CREATE TABLE TraiCay
(
	MaTraiCay varchar(10),
	TenTraiCay nvarchar(50),
	Mau nvarchar(20),
	MaLoaiTraiCay varchar(10),
	XuatXu nvarchar(50),
	GiaTien int,
	HinhAnh varchar(50),
	SoLuong int,
	MaNhaCungCap varchar(10),
	TrangThai int
	CONSTRAINT pk_TraiCay PRIMARY KEY(MaTraiCay)
)

CREATE TABLE NhanVien
(
	MaNhanVien varchar(10),
	HoNhanVien nvarchar(10),
	TenNhanVien nvarchar(20),
	MaLoaiNhanVien varchar(10),
	MatKhau varchar(20),
	GioiTinh nvarchar(10),
	NgaySinh date,
	DiaChi nvarchar(MAX),
	SDT varchar(20),
	Luong int,
	HinhAnh varchar(50),
	TrangThai int
	CONSTRAINT pk_NhanVien PRIMARY KEY(MaNhanVien)
)

CREATE TABLE LoaiNhanVien
(
	MaLoaiNhanVien varchar(10),
	LoaiNhanVien nvarchar(20),
	TrangThai int
	CONSTRAINT pk_LoaiNhanVien PRIMARY KEY(MaLoaiNhanVien)
)

CREATE TABLE LoaiTraiCay
(
	MaLoaiTraiCay varchar(10),
	TenLoaiTraiCay nvarchar(20),
	TrangThai int
	CONSTRAINT pk_LoaiTraiCay PRIMARY KEY(MaLoaiTraiCay)
)

CREATE TABLE NhaCungCap
(
	MaNhaCungCap varchar(10),
	TenNhaCungCap nvarchar(100),
	DiaChi nvarchar(50),
	SDT varchar(20),
	Email varchar(50),
	TrangThai int
	CONSTRAINT pk_tblNhaCungCap PRIMARY KEY(MaNhaCungCap)
)

create table KhachHang
(
	MaKhachHang varchar(10),
	TenKhachHang nvarchar(50),
	DiaChi nvarchar(50),
	SDT varchar(20),
	TrangThai int
	CONSTRAINT pk_KhachHang PRIMARY KEY(MaKhachHang)
)

CREATE TABLE HoaDonNhap
(
	MaHoaDonNhap varchar(10),
	MaNhanVien varchar(10),
	NgayNhap date,
	TongTien int,
	TrangThai int
	CONSTRAINT pk_HoaDonNhap PRIMARY KEY(MaHoaDonNhap)
)

CREATE TABLE ChiTietHoaDonNhap
(
	MaCTHoaDonNhap varchar(10),
	MaTraiCay varchar(10),
	NgayNhap date,
	GiaNhap int,
	SoLuong nvarchar(10),
	TrangThai int
	CONSTRAINT pk_ChiTietHoaDonNhap PRIMARY KEY(MaCTHoaDonNhap,MaTraiCay)
)

CREATE TABLE HoaDonXuat
(
	MaHoaDonXuat varchar(10),
	MaNhanVien varchar(10),
	TongTien int,
	NgayXuat date,
	TrangThai int
	CONSTRAINT pk_HoaDonXuat PRIMARY KEY(MaHoaDonXuat)
)

CREATE TABLE ChiTietHoaDonXuat
(
	MaCTHoaDonXuat varchar(10),
	MaTraiCay varchar(10),
	GiaBan int,
	SoLuong int,
	DiaChi nvarchar(MAX),
	TrangThai int
	PRIMARY KEY(MaCTHoaDonXuat, MaTraiCay)
)

--Rang buoc khoa ngoai
---RB bang TraiCay
ALTER TABLE TraiCay
ADD CONSTRAINT fk_TraiCay_LoaiTraiCay FOREIGN KEY (MaLoaiTraiCay) REFERENCES LoaiTraiCay(MaLoaiTraiCay)
ALTER TABLE TraiCay
ADD CONSTRAINT fk_TraiCay_NhaCungCap FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)

--RB bang NhanVien
ALTER TABLE NhanVien
ADD CONSTRAINT fk_NhanVien_LoaiNhanVien FOREIGN KEY (MaLoaiNhanVien) REFERENCES LoaiNhanVien(MaLoaiNhanVien)

--RB bang tblTaiKhoan
--ALTER TABLE tblTaiKhoan
--ADD CONSTRAINT fk_tblTaiKhoan_LoaiTaiKhoan FOREIGN KEY (MaLoaiTaiKhoan) REFERENCES tblLoaiTaiKhoan(MaLoaiTaiKhoan)

--RB bang HoaDonNhap
ALTER TABLE HoaDonNhap
ADD CONSTRAINT fk_HoaDonNhap_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

--RB bang HoaDonNhap
ALTER TABLE HoaDonXuat
ADD CONSTRAINT fk_HoaDonXuat_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

--RB bang ChiTietHoaDonNhap
ALTER TABLE ChiTietHoaDonNhap
ADD CONSTRAINT fk_ChiTietHoaDonNhap_HoaDonNhap FOREIGN KEY (MaCTHoaDonNhap) REFERENCES HoaDonNhap(MaHoaDonNhap)
ALTER TABLE ChiTietHoaDonNhap
ADD CONSTRAINT fk_ChiTietHoaDonNhap_TraiCay FOREIGN KEY (MaTraiCay) REFERENCES TraiCay(MaTraiCay)

--RB bang ChiTietHoaDonXuat
ALTER TABLE ChiTietHoaDonXuat
ADD CONSTRAINT fk_ChiTietHoaDonXuat_HoaDonXuat FOREIGN KEY (MaCTHoaDonXuat) REFERENCES HoaDonXuat(MaHoaDonXuat)
ALTER TABLE ChiTietHoaDonXuat
ADD CONSTRAINT fk_ChiTietHoaDonXuat_TraiCay FOREIGN KEY (MaTraiCay) REFERENCES TraiCay(MaTraiCay)

--------------------Nhap Du Lieu Cac Bang-----------------------
--Nhap DL LoaiNhanVien
INSERT INTO LoaiNhanVien (MaLoaiNhanVien,LoaiNhanVien,TrangThai)
VALUES ('LNV0001',N'Quản lý',1)
INSERT INTO LoaiNhanVien (MaLoaiNhanVien,LoaiNhanVien,TrangThai)
VALUES ('LNV0002',N'Nhân viên bán hàng',1)
INSERT INTO LoaiNhanVien (MaLoaiNhanVien,LoaiNhanVien,TrangThai)
VALUES ('LNV0003',N'Nhân viên thủ kho',1)

--Nhap DL NhanVien
INSERT INTO NhanVien (MaNhanVien,HoNhanVien,TenNhanVien,MaLoaiNhanVien,MatKhau,GioiTinh,NgaySinh,DiaChi,SDT,Luong,HinhAnh,TrangThai)
VALUES ('NV0001','Dang Thanh','Son','LNV0001','123456','Nam','07/06/1996','78 duong 21A','01279821665','10000000','NhanVien/0306141363.jpg',1)
INSERT INTO NhanVien (MaNhanVien,HoNhanVien,TenNhanVien,MaLoaiNhanVien,MatKhau,GioiTinh,NgaySinh,DiaChi,SDT,Luong,HinhAnh,TrangThai)
VALUES ('NV0002','Dang Minh','Tri','LNV0002','123456','Nam','07/06/1996','78 duong 21A','01279821665','10000000','NhanVien/0306141382.jpg',1)

--Nhap DL LoaiTraiCay
INSERT INTO LoaiTraiCay(MaLoaiTraiCay,TenLoaiTraiCay,TrangThai)
VALUES('LTC0001',N'Loại thường',1)
INSERT INTO LoaiTraiCay(MaLoaiTraiCay,TenLoaiTraiCay,TrangThai)
VALUES('LTC0002',N'Loại cao cấp',1)


--Nhap DL NhaCungCap
INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,DiaChi,SDT,Email,TrangThai)
VALUES('NCC0001',N'Nguyen Thi A',N'Cu Chi','01653231537','nguyenthia96@gmail.com',1)
INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,DiaChi,SDT,Email,TrangThai)
VALUES('NCC0002',N'Nguyen Thi B',N'Bình Tân','01653231538','nguyenthib96@gmail.com',1)
INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,DiaChi,SDT,Email,TrangThai)
VALUES('NCC0003',N'Nguyen Thi C',N'Q1','01653231539','nguyenthic96@gmail.com',1)

--Nhap DL TraiCay
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0001',N'Mận',N'Ðỏ','LTC0001',N'Bình Tân','20000','HinhTC/Hinh1.jpg','2','NCC0001',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0002',N'Thanh Long',N'Ðỏ','LTC0001',N'Bình Thuận','10000','HinhTC/Hinh2.jpg','5','NCC0002',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0003',N'Nho',N'Ðỏ','LTC0001',N'Bình Dương','120000','HinhTC/Hinh3.jpg','6','NCC0001',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0004',N'Ổi',N'Xanh','LTC0002',N'Long An','15000','HinhTC/Hinh4.jpg','4','NCC0002',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0005',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh5.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0006',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh6.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0007',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh7.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0008',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh8.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0009',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh9.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0010',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh10.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0011',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh11.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0012',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh12.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0013',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh13.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0014',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh14.jpg','5','NCC0003',1)
INSERT INTO TraiCay(MaTraiCay,TenTraiCay,Mau,MaLoaiTraiCay,XuatXu,GiaTien,HinhAnh,SoLuong,MaNhaCungCap,TrangThai)
VALUES('TC0015',N'Bưởi',N'Xanh','LTC0002',N'Bình Phước','65000','HinhTC/Hinh15.jpg','5','NCC0003',1)

--Nhap DL KhachHang
INSERT INTO KhachHang (MaKhachHang,TenKhachHang,DiaChi,SDT,TrangThai)
VALUES ('KH0001',N'Phan Thanh Huy',N'Hai Bà Trưng','01694590025',1)
INSERT INTO KhachHang (MaKhachHang,TenKhachHang,DiaChi,SDT,TrangThai)
VALUES ('KH0002',N'Đặng Vi Vân',N'Cao Phú P.3 Q.6','01289975102',1)
INSERT INTO KhachHang (MaKhachHang,TenKhachHang,DiaChi,SDT,TrangThai)
VALUES ('KH0003',N'Phan Minh Trí',N'Long An','09068437934',1)

--Nhap DL HoaDonNhap
INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, NgayNhap, TongTien, TrangThai)
VALUES('HND0001', 'NV0001', '11/11/2016', '200000', 1)

--Nhap DL ChiTietHoaDonNhap
INSERT INTO ChiTietHoaDonNhap (MaCTHoaDonNhap, MaTraiCay, NgayNhap, GiaNhap, SoLuong, TrangThai)
VALUES('HDN0001', 'TC0001', '11/11/2016', '10000', '10', 1)

--Nhap DL HoaDonXuat


--Nhap DL ChiTietHoaDonXuat