USE QuanLyChuoiCuaHangMinistop;
GO
--Tao phieu nhap hang
CREATE PROCEDURE sp_InPhieuNhap
    @MaPhieuNhap VARCHAR(10)
AS
BEGIN
    SELECT 
        PN.MaPhieuNhap,
        PN.NgayNhap,
        PN.MaCuaHang,
        CH.TenCuaHang,
		CH.DiaChi,
        PN.MaNCC,
        NCC.TenNCC,
        PN.MaNhanVien,
        NV.HoTen,
        SP.TenSanPham,
        CT.SoLuong,
        CT.GiaNhap,
        CT.SoLuong * CT.GiaNhap AS TongTien
    FROM 
        PhieuNhap PN
    INNER JOIN ChiTietNhapHang CT ON PN.MaPhieuNhap = CT.MaPhieuNhap
    INNER JOIN SanPham SP ON CT.MaSanPham = SP.MaSanPham
    INNER JOIN NhaCungCap NCC ON PN.MaNCC = NCC.MaNCC
    INNER JOIN NhanVien NV ON PN.MaNhanVien = NV.MaNhanVien
    INNER JOIN CuaHang CH ON PN.MaCuaHang = CH.MaCuaHang
    WHERE 
        PN.MaPhieuNhap = @MaPhieuNhap
END
GO
--Tao phieu xuat hang
CREATE PROCEDURE sp_GetPhieuXuatTheoMa
    @MaPhieuXuat VARCHAR(10)
AS
BEGIN
    SELECT 
        px.MaPhieuXuat,
        px.MaCuaHang,
        ch.TenCuaHang,
		ch.DiaChi,
        px.MaNhanVien,
		nv.HoTen,
        px.NgayXuat,
        px.LoaiXuat,
        sp.TenSanPham,
        ctx.SoLuong,
        ctx.GiaXuat,
        (ctx.SoLuong * ctx.GiaXuat) AS ThanhTien,
        ctx.GhiChu,
        (
            SELECT SUM(SoLuong * GiaXuat)
            FROM ChiTietXuatHang
            WHERE MaPhieuXuat = px.MaPhieuXuat
        ) AS TongTien --Tinh tong tien cua tat ca
    FROM PhieuXuat px
    INNER JOIN CuaHang ch ON px.MaCuaHang = ch.MaCuaHang 
	INNER JOIN NhanVien nv ON px.MaNhanVien = nv.MaNhanVien
    INNER JOIN ChiTietXuatHang ctx ON px.MaPhieuXuat = ctx.MaPhieuXuat
    INNER JOIN SanPham sp ON ctx.MaSanPham = sp.MaSanPham
    WHERE px.MaPhieuXuat = @MaPhieuXuat;
END


--drop PROCEDURE sp_GetPhieuXuatTheoMa
GO
--Tao hoa don
CREATE PROCEDURE sp_GetThongTinHoaDon
    @MaHoaDon VARCHAR(10)
AS
BEGIN
    SELECT 
        hd.MaHoaDon,
        hd.MaCuaHang,
        ch.TenCuaHang,
        ch.DiaChi AS DiaChiCuaHang,
        hd.MaNhanVien,
        nv.HoTen AS HoTenNhanVien,
        hd.NgayLap,
        hd.TongTien
    FROM HoaDon hd
    INNER JOIN CuaHang ch ON hd.MaCuaHang = ch.MaCuaHang
    INNER JOIN NhanVien nv ON hd.MaNhanVien = nv.MaNhanVien
    WHERE hd.MaHoaDon = @MaHoaDon;
END
GO
CREATE PROCEDURE sp_GetChiTietHoaDon
    @MaHoaDon VARCHAR(10)
AS
BEGIN
    SELECT 
		hd.MaHoaDon,
        sp.TenSanPham,
        cthd.SoLuong,
        cthd.GiaBan,
        cthd.ThanhTien
    FROM ChiTietHoaDon cthd
    INNER JOIN SanPham sp ON cthd.MaSanPham = sp.MaSanPham
	JOIN HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon
    WHERE cthd.MaHoaDon = @MaHoaDon;
END
--drop PROCEDURE sp_GetChiTietHoaDon
