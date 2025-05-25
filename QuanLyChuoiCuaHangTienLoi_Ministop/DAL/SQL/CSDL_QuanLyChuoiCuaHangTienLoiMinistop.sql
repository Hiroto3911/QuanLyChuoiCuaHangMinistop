
CREATE DATABASE QuanLyChuoiCuaHangMinistop;
GO

USE QuanLyChuoiCuaHangMinistop;
GO

-- 1. CỬA HÀNG
CREATE TABLE CuaHang (
    MaCuaHang VARCHAR(10) PRIMARY KEY,
    TenCuaHang NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    MaQuanLy VARCHAR(10) 
	
);
GO

-- 2. NHÂN VIÊN
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(5),
    NgaySinh DATE,
    SoDienThoai VARCHAR(15),
    NgayLamViec DATE,
    TaiKhoan VARCHAR(50) UNIQUE,
    MatKhau VARCHAR(100),
    VaiTro VARCHAR(20), -- Admin / QuanLy / NhanVien
    MaCuaHang VARCHAR(10),
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang)
);
GO

-- 3. NHÀ CUNG CẤP
CREATE TABLE NhaCungCap (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    Email NVARCHAR(100)
);
GO

-- 4. SẢN PHẨM
CREATE TABLE SanPham (
    MaSanPham VARCHAR(10) PRIMARY KEY,
    TenSanPham NVARCHAR(100),
    GiaMacDinh DECIMAL(18,0),
    DonViTinh NVARCHAR(20),
    LoaiSanPham NVARCHAR(50)
);
GO

-- 5. CHI TIẾT KHO
CREATE TABLE ChiTietKho (
    MaChiTietKho VARCHAR(20) PRIMARY KEY,
    MaCuaHang VARCHAR(10),
    MaSanPham VARCHAR(10),
    SoLuongTon INT,
    GiaBan DECIMAL(18,0),
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 6. NHẬP HÀNG
CREATE TABLE PhieuNhap (
    MaPhieuNhap VARCHAR(10) PRIMARY KEY,
    MaNCC VARCHAR(10),
    MaCuaHang VARCHAR(10),
    NgayNhap DATE,
    MaNhanVien VARCHAR(10),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 7. CHI TIẾT NHẬP HÀNG
CREATE TABLE ChiTietNhapHang (
    MaPhieuNhap VARCHAR(10),
    MaSanPham VARCHAR(10),
    SoLuong INT,
    GiaNhap DECIMAL(18,0),
    TongTien AS (SoLuong * GiaNhap) PERSISTED,
    GhiChu NVARCHAR(255),
    PRIMARY KEY (MaPhieuNhap, MaSanPham),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 8. XUẤT HÀNG
CREATE TABLE PhieuXuat (
    MaPhieuXuat VARCHAR(10) PRIMARY KEY,
    MaCuaHang VARCHAR(10),
    MaNhanVien VARCHAR(10),
    NgayXuat DATE ,
    LoaiXuat NVARCHAR(50),-- LOẠI XUẤT GỒM HỎNG, KIỂM KÊ LỆCH , HẾT HẠN
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 9. CHI TIẾT XUẤT HÀNG
CREATE TABLE ChiTietXuatHang (
    MaPhieuXuat VARCHAR(10),
    MaSanPham VARCHAR(10),
    SoLuong INT,
    GiaXuat DECIMAL(18,0),
    TongTien AS (SoLuong * GiaXuat) PERSISTED,
    GhiChu NVARCHAR(255),
    PRIMARY KEY (MaPhieuXuat, MaSanPham),
    FOREIGN KEY (MaPhieuXuat) REFERENCES PhieuXuat(MaPhieuXuat),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 10. KIỂM KHO
CREATE TABLE KiemKho (
    MaKiemKho VARCHAR(10) PRIMARY KEY,
    MaCuaHang VARCHAR(10),
    MaNhanVien VARCHAR(10),
    NgayKiem DATE,
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 11. CHI TIẾT KIỂM KHO
CREATE TABLE ChiTietKiemKho (
    MaKiemKho VARCHAR(10),
    MaSanPham VARCHAR(10),
    SoLuongHeThong INT,
    SoLuongThucTe INT,
    TrangThai NVARCHAR(50),
	ChenhLech INT ,
    GhiChu NVARCHAR(255),
    PRIMARY KEY (MaKiemKho, MaSanPham),
    FOREIGN KEY (MaKiemKho) REFERENCES KiemKho(MaKiemKho),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 12. HÓA ĐƠN
CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(10) PRIMARY KEY,
    MaCuaHang VARCHAR(10),
    MaNhanVien VARCHAR(10),
    NgayLap DATE,
    TongTien DECIMAL(18,0),
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 13. CHI TIẾT HÓA ĐƠN
CREATE TABLE ChiTietHoaDon (
    MaChiTietHD VARCHAR(15) PRIMARY KEY,
    MaHoaDon VARCHAR(10),
    MaSanPham VARCHAR(10),
    SoLuong INT,
    GiaBan DECIMAL(18,0),
    ThanhTien DECIMAL(18,0),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 14. KHUYẾN MÃI
CREATE TABLE KhuyenMai (
    MaKhuyenMai VARCHAR(10) PRIMARY KEY,
    TenKhuyenMai NVARCHAR(100),
    MucGiamGia DECIMAL(18,0),
    NgayBatDau DATE,
    NgayKetThuc DATE,
	LoaiApDung NVARCHAR (20),
    DieuKienApDung DECIMAL Null,
	TrangThai INT -- "0 hoac 1"
);
GO

-- 15. KHUYẾN MÃI - SẢN PHẨM
CREATE TABLE KhuyenMai_SanPham (
    MaKhuyenMai VARCHAR(10),
    MaSanPham VARCHAR(10),
	SoLuongToiThieu INT,
	DoUuTien INT, -- 1 la do uu tien cao nhat, neu cung san pham thi khong trung do uu tien
    PRIMARY KEY (MaKhuyenMai, MaSanPham),
    FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
GO

-- 16. LỊCH SỬ THAY ĐỔI GIÁ
CREATE TABLE LichSuThayDoiGia (
    MaLichSu VARCHAR(15) PRIMARY KEY,
    MaSanPham VARCHAR(10),
    MaCuaHang VARCHAR(10),
    GiaCu DECIMAL(18,0),
    GiaMoi DECIMAL(18,0),
    NguoiThayDoi VARCHAR(10),
    LyDo NVARCHAR(255),
    NgayThayDoi DATE,
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    FOREIGN KEY (MaCuaHang) REFERENCES CuaHang(MaCuaHang),
    FOREIGN KEY (NguoiThayDoi) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 17. LỊCH SỬ KHO
CREATE TABLE LichSuKho (
    MaLichSuKho VARCHAR(15) PRIMARY KEY,
    MaChiTietKho VARCHAR(20),
    NgayThayDoi DATE,
    SoLuongThayDoi INT,
    LoaiThayDoi NVARCHAR(50), -- Nhap, Xuat, Kiem
    MaThamChieu NVARCHAR(20)null,-- co the null hoac lien ke toi ma cua loai thay doi
    FOREIGN KEY (MaChiTietKho) REFERENCES ChiTietKho(MaChiTietKho)
);
GO

-- Add foreign key: Manager (MaQuanLy) in CuaHang refers to NhanVien
ALTER TABLE CuaHang
ADD CONSTRAINT FK_CH_NV FOREIGN KEY (MaQuanLy) REFERENCES NhanVien(MaNhanVien);
GO
