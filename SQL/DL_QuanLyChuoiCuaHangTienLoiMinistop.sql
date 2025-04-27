SET DATEFORMAT DMY 
GO

-- CỬA HÀNG
INSERT INTO CuaHang VALUES ('CH001', N'Ministop Quận 1', N'1 Lê Lợi, Q1, HCM', '0901111111',NULL),
 ('CH002', N'Ministop Quận 3', N'3 Pasteur, Q3, HCM', '0902222222', NULL),
 ('CH003', N'Ministop Gò Vấp', N'123 Phan Văn Trị, Gò Vấp', '0903333333', NULL),
 ('CH004', N'Ministop Bình Thạnh', N'456 Bạch Đằng, Bình Thạnh', '0904444444', NULL),
 ('CH005', N'Ministop Tân Bình', N'789 Cộng Hòa, Tân Bình', '0905555555', NULL),
 ('CH006', N'Ministop Thủ Đức', N'10 Võ Văn Ngân, Thủ Đức', '0906666666', NULL)
GO

SELECT * FROM CuaHang 
GO 

-- NHÂN VIÊN
-- 3 Admin
INSERT INTO NhanVien VALUES ('AD001', N'Nguyễn Văn A', N'Nam', '1990-01-01', '0901111222', '2023-01-01', 'admin1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),
 ('AD002', N'Trần Thị B', N'Nữ', '1991-02-02', '0902222333', '2023-01-01', 'admin2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),
 ('AD003', N'Lê Văn C', N'Nam', '1992-03-03', '0903333444', '2023-01-01', 'admin3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),

-- 6 Quản lý
 ('QL001', N'Phạm Văn D', N'Nam', '1988-04-04', '0904444555', '2023-01-01', 'ql1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH001'),
 ('QL002', N'Ngô Thị E', N'Nữ', '1989-05-05', '0905555666', '2023-01-01', 'ql2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH002'),
 ('QL003', N'Đỗ Văn F', N'Nam', '1990-06-06', '0906666777', '2023-01-01', 'ql3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH003'),
 ('QL004', N'Hoàng Thị G', N'Nữ', '1991-07-07', '0907777888', '2023-01-01', 'ql4', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH004'),
 ('QL005', N'Huỳnh Văn H', N'Nam', '1992-08-08', '0908888999', '2023-01-01', 'ql5', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH005'),
 ('QL006', N'Đinh Thị I', N'Nữ', '1993-09-09', '0909999000', '2023-01-01', 'ql6', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH006'),

-- 12 Nhân viên cửa hàng (2 người/cửa hàng)
 ('NV004', N'Lâm Văn J', N'Nam', '1995-01-01', '0910000001', '2023-01-01', 'nv1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH001'),
 ('NV005', N'Tạ Thị K', N'Nữ', '1995-02-01', '0910000002', '2023-01-01', 'nv2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH001'),
 ('NV006', N'Bùi Văn L', N'Nam', '1995-03-01', '0910000003', '2023-01-01', 'nv3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH002'),
 ('NV007', N'Trịnh Thị M', N'Nữ', '1995-04-01', '0910000004', '2023-01-01', 'nv4', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH002'),
 ('NV008', N'Lý Văn N', N'Nam', '1995-05-01', '0910000005', '2023-01-01', 'nv5', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH003'),
 ('NV009', N'Châu Thị O', N'Nữ', '1995-06-01', '0910000006', '2023-01-01', 'nv6', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH003'),
 ('NV010', N'Võ Văn P', N'Nam', '1995-07-01', '0910000007', '2023-01-01', 'nv7', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH004'),
 ('NV011', N'Đặng Thị Q', N'Nữ', '1995-08-01', '0910000008', '2023-01-01', 'nv8', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH004'),
 ('NV012', N'Phan Văn R', N'Nam', '1995-09-01', '0910000009', '2023-01-01', 'nv9', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH005'),
 ('NV013', N'Mai Thị S', N'Nữ', '1995-10-01', '0910000010', '2023-01-01', 'nv10', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH005'),
('NV014', N'Lưu Văn T', N'Nam', '1995-11-01', '0910000011', '2023-01-01', 'nv11', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH006'),
 ('NV015', N'Cao Thị U', N'Nữ', '1995-12-01', '0910000012', '2023-01-01', 'nv12', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH006')
 GO 
 SELECT * FROM NhanVien 
 GO 

 -- CẬP NHẬP NGƯỜI QUẢN LÝ CHO CỬA HÀNG
 UPDATE CuaHang 
 SET MaQuanLy = 'QL001'
 WHERE MaCuaHang = 'CH001'
 GO
  UPDATE CuaHang 
 SET MaQuanLy = 'QL002'
 WHERE MaCuaHang = 'CH002'
 GO
  UPDATE CuaHang 
 SET MaQuanLy = 'QL003'
 WHERE MaCuaHang = 'CH003'
 GO
  UPDATE CuaHang 
 SET MaQuanLy = 'QL004'
 WHERE MaCuaHang = 'CH004'
 GO
  UPDATE CuaHang 
 SET MaQuanLy = 'QL005'
 WHERE MaCuaHang = 'CH005'
 GO
  UPDATE CuaHang 
 SET MaQuanLy = 'QL006'
 WHERE MaCuaHang = 'CH006'
 GO

 -- NHÀ CUNG CẤP
INSERT INTO NhaCungCap VALUES ('NCC001', N'Công Ty Thực Phẩm ABC', N'1 Nguyễn Văn Cừ, Q1', '0933000001', 'abc@food.vn'),
 ('NCC002', N'Công Ty Bánh Kẹo A', N'22 Lê Lợi, Q1', '0933000002', 'bk@company.vn'),
 ('NCC003', N'Công Ty Nước Giải Khát B', N'3 CMT8, Q3', '0933000003', 'nuocgk@company.vn'),
 ('NCC004', N'Công Ty Vinamilk', N'4 Phổ Quang, Q.Tân Bình', '0933000004', 'contact@vinamilk.com'),
 ('NCC005', N'Công Ty TH True Milk', N'5 Điện Biên Phủ, Q.BT', '0933000005', 'info@thmilk.vn'),
 ('NCC006', N'Công Ty PepsiCo VN', N'6 Nguyễn Văn Linh, Q7', '0933000006', 'info@pepsico.vn'),
 ('NCC007', N'Công Ty Nestle', N'7 Nguyễn Thị Minh Khai', '0933000007', 'nestle@vn.com'),
 ('NCC008', N'Công Ty Acecook', N'8 Trường Chinh, Q12', '0933000008', 'contact@acecook.vn'),
 ('NCC009', N'Công Ty Trung Nguyên', N'9 Phan Xích Long, Q.PN', '0933000009', 'contact@tncoffee.vn'),
 ('NCC010', N'Công Ty Hải Sản Biển Đông', N'10 Lê Văn Việt, Q9', '0933000010', 'haisan@biendong.vn')
 GO

SELECT * FROM NhaCungCap 
GO 

-- SẢN PHẨM
-- Mỗi loại có đơn vị phù hợp: Chai, Gói, Hộp, Bịch, Lon
 INSERT INTO SanPham VALUES('SP001', N'Nước suối Aquafina', 8000, N'Chai', N'Nước giải khát'),
 ('SP002', N'Coca-Cola 500ml', 10000, N'Chai', N'Nước giải khát'),
 ('SP003', N'Sting dâu', 9000, N'Chai', N'Nước giải khát'),
 ('SP004', N'Mì Hảo Hảo', 4000, N'Gói', N'Mì gói'),
 ('SP005', N'Mì Omachi', 5000, N'Gói', N'Mì gói'),
 ('SP006', N'Kẹo Alpenliebe', 7000, N'Bịch', N'Bánh kẹo'),
 ('SP007', N'Bánh Oreo', 9000, N'Bịch', N'Bánh kẹo'),
 ('SP008', N'Sữa Vinamilk 180ml', 6500, N'Hộp', N'Sữa'),
 ('SP009', N'Sữa Fami', 5500, N'Hộp', N'Sữa'),
 ('SP010', N'Sữa chua TH True Yogurt', 8000, N'Hộp', N'Sữa'),
 ('SP011', N'Thịt hộp Tulip', 45000, N'Lon', N'Đồ hộp'),
 ('SP012', N'Cá hộp 3 Cô Gái', 35000, N'Lon', N'Đồ hộp'),
 ('SP013', N'Sữa Milo', 7000, N'Hộp', N'Sữa'),
 ('SP014', N'Sữa đậu nành Soymen', 5000, N'Hộp', N'Sữa'),
 ('SP015', N'Pepsi 330ml', 10000, N'Chai', N'Nước giải khát'),
 ('SP016', N'Sữa Dutch Lady', 6500, N'Hộp', N'Sữa'),
 ('SP017', N'Kẹo cao su Doublemint', 4000, N'Bịch', N'Bánh kẹo'),
 ('SP018', N'Mì Cung Đình', 6000, N'Gói', N'Mì gói'),
 ('SP019', N'Nước tăng lực Red Bull', 12000, N'Chai', N'Nước giải khát'),
 ('SP020', N'Nước chanh muối', 9000, N'Chai', N'Nước giải khát')
 GO

SELECT * FROM SanPham 
GO 

-- PHIẾU NHẬP
 INSERT INTO PhieuNhap VALUES('PN001', 'NCC001', 'CH001', '2024-01-05', 'QL001'),
 ('PN002', 'NCC002', 'CH001', '2024-01-07', 'QL001'),
 ('PN003', 'NCC003', 'CH002', '2024-01-08', 'QL002'),
 ('PN004', 'NCC004', 'CH002', '2024-01-10', 'QL002'),
 ('PN005', 'NCC005', 'CH003', '2024-01-12', 'QL003'),
 ('PN006', 'NCC006', 'CH003', '2024-01-15', 'QL003'),
 ('PN007', 'NCC007', 'CH004', '2024-01-17', 'QL004'),
 ('PN008', 'NCC008', 'CH005', '2024-01-20', 'QL005'),
 ('PN009', 'NCC009', 'CH005', '2024-01-22', 'QL005'),
 ('PN010', 'NCC010', 'CH006', '2024-01-25', 'QL006'),
 ('PN0012', 'NCC001', 'CH001', '2024-01-05', 'QL001'),
 ('PN0013', 'NCC002', 'CH001', '2024-01-07', 'QL001'),
 ('PN0014', 'NCC003', 'CH002', '2024-01-08', 'QL002'),
 ('PN0015', 'NCC004', 'CH002', '2024-01-10', 'QL002'),
 ('PN0016', 'NCC005', 'CH003', '2024-01-12', 'QL003'),
 ('PN0017', 'NCC006', 'CH003', '2024-01-15', 'QL003'),
 ('PN0018', 'NCC007', 'CH004', '2024-01-17', 'QL004'),
 ('PN0019', 'NCC008', 'CH005', '2024-01-20', 'QL005'),
 ('PN0020', 'NCC009', 'CH005', '2024-01-22', 'QL005'),
 ('PN0021', 'NCC010', 'CH006', '2024-01-25', 'QL006')
GO

SELECT * FROM PhieuNhap 
GO 
-- CHI TIẾT PHIẾU NHẬP 
 INSERT INTO ChiTietNhapHang VALUES('PN001', 'SP001', 100, 6000, N''),
 ('PN001', 'SP004', 200, 3000, N''),

 ('PN002', 'SP006', 150, 5000, N''),
 ('PN002', 'SP007', 120, 6000, N''),

 ('PN003', 'SP002', 100, 8000, N''),
 ('PN003', 'SP005', 150, 3500, N''),

 ('PN004', 'SP008', 180, 5000, N''),
 ('PN004', 'SP010', 170, 6000, N''),

 ('PN005', 'SP013', 160, 5500, N''),
 ('PN005', 'SP014', 200, 4000, N''),

 ('PN006', 'SP015', 140, 8000, N''),
 ('PN006', 'SP019', 130, 10000, N''),

 ('PN007', 'SP003', 110, 7000, N''),
 ('PN007', 'SP017', 200, 3000, N''),

 ('PN008', 'SP009', 160, 4000, N''),
 ('PN008', 'SP011', 90, 38000, N''),

 ('PN009', 'SP012', 100, 30000, N''),
 ('PN009', 'SP018', 180, 4500, N''),

 ('PN010', 'SP016', 140, 5000, N''),
 ('PN010', 'SP020', 170, 7000, N''),

 -- PN0012
 ('PN0012', 'SP003', 100, 7000, N''), 
 ('PN0012', 'SP005', 80, 3500, N''),

-- PN0013
 ('PN0013', 'SP006', 90, 5000, N''),

-- PN0014
 ('PN0014', 'SP002', 100, 8500, N''),

-- PN0015
 ('PN0015', 'SP010', 50, 6500, N''),

-- PN0016
 ('PN0016', 'SP013', 70, 6000, N''),

-- PN0017
 ('PN0017', 'SP019', 60, 10000, N''),

-- PN0018
 ('PN0018', 'SP004', 150, 3500, N''),

-- PN0019
 ('PN0019', 'SP011', 60, 42000, N''),

-- PN0020
 ('PN0020', 'SP018', 110, 4800, N''),

-- PN021
 ('PN0021', 'SP016', 90, 6200, N'')
GO


SELECT * FROM ChiTietNhapHang 
GO 

-- CHI TIẾT KHO
 INSERT INTO ChiTietKho VALUES('CTK001', 'CH001', 'SP001', 100, 8000),
 ('CTK002', 'CH001', 'SP004', 200, 4000),

 ('CTK003', 'CH002', 'SP002', 100, 10000),
 ('CTK004', 'CH002', 'SP005', 150, 5000),

 ('CTK005', 'CH003', 'SP006', 150, 7000),
 ('CTK006', 'CH003', 'SP007', 120, 9000),

 ('CTK007', 'CH004', 'SP008', 180, 6500),
 ('CTK008', 'CH004', 'SP010', 170, 8000),

 ('CTK009', 'CH005', 'SP009', 160, 5500),
 ('CTK010', 'CH005', 'SP011', 90, 45000),

 ('CTK011', 'CH006', 'SP012', 100, 35000),
 ('CTK012', 'CH006', 'SP016', 140, 6500)

GO 

SELECT * FROM ChiTietKho 
GO 

-- XUẤT HÀNG
INSERT INTO PhieuXuat VALUES ('PX001', 'CH001', 'NV004', '2024-01-08', N'HetHan'),
('PX002', 'CH002', 'NV006', '2024-01-10', N'KiemKeLech'),
('PX003', 'CH003', 'NV008', '2024-01-15', N'HuHong'),
('PX004', 'CH004', 'NV010', '2024-01-18', N'HetHan'),
('PX005', 'CH005', 'NV012', '2024-01-20', N'KiemKeLech'),
('PX006', 'CH006', 'NV014', '2024-01-22', N'HetHan')
GO
SELECT * FROM PhieuXuat 
GO 

-- CHI TIẾT XUẤT HÀNG
 INSERT INTO ChiTietXuatHang VALUES('PX001', 'SP001', 20, 8000, N''),
 ('PX001', 'SP004', 30, 4000, N''),

 ('PX002', 'SP002', 25, 10000, N''),
 ('PX002', 'SP005', 40, 5000, N''),

 ('PX003', 'SP006', 35, 7000, N''),
 ('PX003', 'SP007', 20, 9000, N''),

 ('PX004', 'SP008', 50, 6500, N''),
 ('PX004', 'SP010', 40, 8000, N''),

 ('PX005', 'SP009', 30, 5500, N''),
 ('PX005', 'SP011', 15, 45000, N''),

 ('PX006', 'SP012', 20, 35000, N''),
 ('PX006', 'SP016', 35, 6500, N'')
GO
SELECT * FROM ChiTietXuatHang
GO 

-- KIỂM KHO
 INSERT INTO KiemKho VALUES('KK001', 'CH001', 'NV004', '2024-01-09'),
 ('KK002', 'CH002', 'NV006', '2024-01-11'),
 ('KK003', 'CH003', 'NV008', '2024-01-16'),
 ('KK004', 'CH004', 'NV010', '2024-01-19'),
 ('KK005', 'CH005', 'NV012', '2024-01-21'),
 ('KK006', 'CH006', 'NV014', '2024-01-23')
GO
SELECT * FROM KiemKho 
GO 

-- CHI TIẾT KIỂM KHO
 INSERT INTO ChiTietKiemKho VALUES('KK001', 'SP001', 100, 98, N'Thiếu',-2, N''),
 ('KK001', 'SP004', 200, 200, N'Khớp',0, N''),

 ('KK002', 'SP002', 100, 100, N'Khớp',0, N''),
 ('KK002', 'SP005', 150, 147, N'Thiếu',-3, N''),

 ('KK003', 'SP006', 150, 150, N'Khớp',0, N''),
 ('KK003', 'SP007', 120, 121, N'Dư',1, N''),

 ('KK004', 'SP008', 180, 179, N'Thiếu',-1, N''),

 ('KK005', 'SP009', 160, 160, N'Khớp',0, N''),

 ('KK006', 'SP012', 100, 100, N'Khớp',0, N''),
 ('KK006', 'SP016', 140, 139, N'Thiếu',-1, N'')

GO
SELECT * FROM ChiTietKiemKho
GO 

-- HOÁ ĐƠN
 INSERT INTO HoaDon VALUES('HD001', 'CH001', 'NV004', '2024-01-08', 320000),
 ('HD002', 'CH002', 'NV006', '2024-01-10', 250000),
 ('HD003', 'CH003', 'NV008', '2024-01-15', 310000),
 ('HD004', 'CH004', 'NV010', '2024-01-18', 460000),
 ('HD005', 'CH005', 'NV012', '2024-01-20', 570000),
 ('HD006', 'CH006', 'NV014', '2024-01-22', 300000)
GO
SELECT * FROM HoaDon 
GO 

-- CHI TIẾT HOÁ ĐƠN
 INSERT INTO ChiTietHoaDon VALUES('CTHD001', 'HD001', 'SP001', 20, 8000),
 ('CTHD002', 'HD001', 'SP004', 30, 4000),

 ('CTHD003', 'HD002', 'SP002', 15, 10000),
 ('CTHD004', 'HD002', 'SP005', 20, 5000),

 ('CTHD005', 'HD003', 'SP006', 25, 7000),
 ('CTHD006', 'HD003', 'SP007', 10, 9000),

 ('CTHD007', 'HD004', 'SP008', 50, 6500),
 ('CTHD008', 'HD004', 'SP010', 20, 8000),

 ('CTHD009', 'HD005', 'SP009', 30, 5500),
 ('CTHD010', 'HD005', 'SP011', 5, 45000),

 ('CTHD011', 'HD006', 'SP012', 8, 35000),
 ('CTHD012', 'HD006', 'SP016', 10, 6500)
GO
SELECT * FROM ChiTietHoaDon 
GO 

-- KHUYẾN MÃI
INSERT INTO KhuyenMai VALUES 
('KM001', N'Tết Sale Khủng', 2000, '2024-01-01', '2024-01-15', N'Sản phẩm', NULL, 1),
('KM002', N'Mua nhiều giảm nhiều', 1000, '2024-02-01', '2024-02-28', N'Sản phẩm', NULL, 1),
('KM003', N'Sữa khuyến mãi tháng 3', 1500, '2024-03-01', '2024-03-31', N'Sản phẩm', NULL, 1),
('KM004', N'Khuyến mãi nước ngọt', 1000, '2024-04-01', '2024-04-15', N'Sản phẩm', NULL, 1)
GO
SELECT * FROM KhuyenMai 
GO 

-- CHI TIẾT KHUYẾN MÃI
-- KM001 - Tết Sale Khủng
 INSERT INTO KhuyenMai_SanPham VALUES('KM001', 'SP001', 2, 1),
 ('KM001', 'SP004', 5, 2),

-- KM002 - Mua nhiều giảm nhiều
 ('KM002', 'SP006', 3, 1),
 ('KM002', 'SP007', 3, 1),

-- KM003 - Sữa khuyến mãi
 ('KM003', 'SP008', 2, 1),
 ('KM003', 'SP010', 2, 1),

-- KM004 - Nước ngọt
 ('KM004', 'SP002', 2, 1),
 ('KM004', 'SP015', 2, 1)
GO
SELECT * FROM KhuyenMai_SanPham
GO 

-- LỊCH SỬ THAY ĐỔI GIÁ
INSERT INTO LichSuThayDoiGia VALUES 
('LSG001', 'SP001', 'CH001', 8000, 8500, 'QL001', N'Tăng giá dịp Tết', ' 01-01-2024'),
('LSG002', 'SP004', 'CH002', 4000, 3800, 'QL002', N'Khuyến mãi cuối năm', '10-01-2024'),
('LSG003', 'SP008', 'CH003', 6500, 7000, 'QL003', N'Thị trường biến động', '15-01-2024'),
('LSG004', 'SP010', 'CH004', 8000, 7500, 'QL004', N'Giảm giá cạnh tranh', '20-01-2024')
GO
SELECT * FROM LichSuThayDoiGia
GO

-- LỊCH SỬ KHO
-- Nhập hàng
 INSERT INTO LichSuKho VALUES('LSK001', 'CTK001', '2024-01-05', 100, N'Nhap', 'PN001'),
 ('LSK002', 'CTK002', '2024-01-06', 200, N'Nhap', 'PN002'),

-- Xuất hàng
 ('LSK003', 'CTK001', '2024-01-08', -20, N'Xuat', 'PX001'),
 ('LSK004', 'CTK002', '2024-01-10', -30, N'Xuat', 'PX002'),

-- Kiểm kho
 ('LSK005', 'CTK001', '2024-01-09', -2, N'Kiem', 'KK001'),
 ('LSK006', 'CTK002', '2024-01-11', 0, N'Kiem', 'KK002')

SELECT * FROM LichSuKho 
GO