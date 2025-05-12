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
INSERT INTO NhanVien VALUES
('AD001', N'Nguyễn Văn A', N'Nam', '1990-01-01', '0901111222', '2025-01-01', 'admin1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),
 ('AD002', N'Trần Thị B', N'Nữ', '1991-02-02', '0902222333', '2025-01-01', 'admin2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),
 ('AD003', N'Lê Văn C', N'Nam', '1992-03-03', '0903333444', '2025-01-01', 'admin3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'Admin', NULL),

-- 6 Quản lý
 ('QL001', N'Phạm Văn D', N'Nam', '1988-04-04', '0904444555', '2025-01-01', 'ql1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH001'),
 ('QL002', N'Ngô Thị E', N'Nữ', '1989-05-05', '0905555666', '2025-01-01', 'ql2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH002'),
 ('QL003', N'Đỗ Văn F', N'Nam', '1990-06-06', '0906666777', '2025-01-01', 'ql3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH003'),
 ('QL004', N'Hoàng Thị G', N'Nữ', '1991-07-07', '0907777888', '2025-01-01', 'ql4', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH004'),
 ('QL005', N'Huỳnh Văn H', N'Nam', '1992-08-08', '0908888999', '2025-01-01', 'ql5', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH005'),
 ('QL006', N'Đinh Thị I', N'Nữ', '1993-09-09', '0909999000', '2025-01-01', 'ql6', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'QuanLy', 'CH006'),

-- 12 Nhân viên cửa hàng (2 người/cửa hàng)
 ('NV004', N'Lâm Văn J', N'Nam', '1995-01-01', '0910000001', '2025-01-01', 'nv1', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH001'),
 ('NV005', N'Tạ Thị K', N'Nữ', '1995-02-01', '0910000002', '2025-01-01', 'nv2', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH001'),
 ('NV006', N'Bùi Văn L', N'Nam', '1995-03-01', '0910000003', '2025-01-01', 'nv3', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH002'),
 ('NV007', N'Trịnh Thị M', N'Nữ', '1995-04-01', '0910000004', '2025-01-01', 'nv4', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH002'),
 ('NV008', N'Lý Văn N', N'Nam', '1995-05-01', '0910000005', '2025-01-01', 'nv5', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH003'),
 ('NV009', N'Châu Thị O', N'Nữ', '1995-06-01', '0910000006', '2025-01-01', 'nv6', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH003'),
 ('NV010', N'Võ Văn P', N'Nam', '1995-07-01', '0910000007', '2025-01-01', 'nv7', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH004'),
 ('NV011', N'Đặng Thị Q', N'Nữ', '1995-08-01', '0910000008', '2025-01-01', 'nv8', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH004'),
 ('NV012', N'Phan Văn R', N'Nam', '1995-09-01', '0910000009', '2025-01-01', 'nv9', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH005'),
 ('NV013', N'Mai Thị S', N'Nữ', '1995-10-01', '0910000010', '2025-01-01', 'nv10', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH005'),
('NV014', N'Lưu Văn T', N'Nam', '1995-11-01', '0910000011', '2025-01-01', 'nv11', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH006'),
 ('NV015', N'Cao Thị U', N'Nữ', '1995-12-01', '0910000012', '2025-01-01', 'nv12', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=', 'NhanVien', 'CH006')
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
 INSERT INTO SanPham VALUES('SP001', N'Nước suối Aquafina', 8000, N'Chai', N'Nước giải khát'),--NCC003
 ('SP002', N'Coca-Cola 500ml', 10000, N'Chai', N'Nước giải khát'),--NCC003
 ('SP003', N'Sting dâu', 9000, N'Chai', N'Nước giải khát'),--NCC003
 ('SP004', N'Mì Hảo Hảo', 4000, N'Gói', N'Mì gói'),--NCC008
 ('SP005', N'Mì Omachi', 5000, N'Gói', N'Mì gói'),--NCC008
 ('SP006', N'Kẹo Alpenliebe', 7000, N'Bịch', N'Bánh kẹo'),--NCC002
 ('SP007', N'Bánh Oreo', 9000, N'Bịch', N'Bánh kẹo'),--NCC002
 ('SP008', N'Sữa Vinamilk 180ml', 6500, N'Hộp', N'Sữa'),--NCC004
 ('SP009', N'Sữa Fami', 5500, N'Hộp', N'Sữa'),--NCC004
 ('SP0010', N'Sữa chua TH True Yogurt', 8000, N'Hộp', N'Sữa'),--NCC005
 ('SP0011', N'Thịt hộp Tulip', 45000, N'Lon', N'Đồ hộp'),--NCC001
 ('SP0012', N'Cá hộp 3 Cô Gái', 35000, N'Lon', N'Đồ hộp'),--NCC001
 ('SP0013', N'Sữa Milo', 7000, N'Hộp', N'Sữa'),--NCC004
 ('SP0014', N'Sữa đậu nành TH True', 5000, N'Hộp', N'Sữa'),--NCC005
 ('SP0015', N'Pepsi 330ml', 10000, N'Chai', N'Nước giải khát'),--NCC006
 ('SP0016', N'Sữa Dutch Lady', 6500, N'Hộp', N'Sữa'),--NCC005
 ('SP0017', N'Kẹo cao su Doublemint', 4000, N'Bịch', N'Bánh kẹo'),--NCC002
 ('SP0018', N'Mì Cung Đình', 6000, N'Gói', N'Mì gói'),--NCC008
 ('SP0019', N'Nước tăng lực Red Bull', 12000, N'Chai', N'Nước giải khát'),--NCC003
 ('SP0020', N'Nước chanh muối', 9000, N'Chai', N'Nước giải khát')--NCC003
 GO

SELECT * FROM SanPham 
GO 

-- PHIẾU NHẬP
INSERT INTO PhieuNhap (MaPhieuNhap, MaNCC, MaCuaHang, NgayNhap, MaNhanVien) VALUES
--CH001
('PN001', 'NCC001', 'CH001', '2025-01-02', 'QL001'), 
('PN002', 'NCC002', 'CH001', '2025-01-02', 'QL001'), 
('PN003', 'NCC003', 'CH001', '2025-01-02', 'QL001'), 
('PN004', 'NCC004', 'CH001', '2025-01-02', 'QL001'), 
('PN005', 'NCC005', 'CH001', '2025-01-02', 'QL001'), 
('PN006', 'NCC006', 'CH001', '2025-01-02', 'QL001'),
('PN007', 'NCC008', 'CH001', '2025-01-02', 'QL001'),

--CH002
('PN008', 'NCC001', 'CH002', '2025-01-02', 'QL002'), 
('PN009', 'NCC002', 'CH002', '2025-01-02', 'QL002'), 
('PN0010', 'NCC003', 'CH002', '2025-01-02', 'QL002'), 
('PN0011', 'NCC004', 'CH002', '2025-01-02', 'QL002'), 
('PN0012', 'NCC005', 'CH002', '2025-01-02', 'QL002'), 
('PN0013', 'NCC006', 'CH002', '2025-01-02', 'QL002'),
('PN0014', 'NCC008', 'CH002', '2025-01-02', 'QL002'),
--CH003
('PN0015', 'NCC001', 'CH003', '2025-01-02', 'QL003'), 
('PN0016', 'NCC002', 'CH003', '2025-01-02', 'QL003'), 
('PN0017', 'NCC003', 'CH003', '2025-01-02', 'QL003'), 
('PN0018', 'NCC004', 'CH003', '2025-01-02', 'QL003'), 
('PN0019', 'NCC005', 'CH003', '2025-01-02', 'QL003'), 
('PN0020', 'NCC006', 'CH003', '2025-01-02', 'QL003'),
('PN0021', 'NCC008', 'CH003', '2025-01-02', 'QL003'),
--CH004
('PN0022', 'NCC001', 'CH004', '2025-01-02', 'QL004'), 
('PN0023', 'NCC002', 'CH004', '2025-01-02', 'QL004'), 
('PN0024', 'NCC003', 'CH004', '2025-01-02', 'QL004'), 
('PN0025', 'NCC004', 'CH004', '2025-01-02', 'QL004'), 
('PN0026', 'NCC005', 'CH004', '2025-01-02', 'QL004'), 
('PN0027', 'NCC006', 'CH004', '2025-01-02', 'QL004'),
('PN0028', 'NCC008', 'CH004', '2025-01-02', 'QL004'),
--CH005
('PN0029', 'NCC001', 'CH005', '2025-01-02', 'QL005'), 
('PN0030', 'NCC002', 'CH005', '2025-01-02', 'QL005'), 
('PN0031', 'NCC003', 'CH005', '2025-01-02', 'QL005'), 
('PN0032', 'NCC004', 'CH005', '2025-01-02', 'QL005'), 
('PN0033', 'NCC005', 'CH005', '2025-01-02', 'QL005'), 
('PN0034', 'NCC006', 'CH005', '2025-01-02', 'QL005'),
('PN0035', 'NCC008', 'CH005', '2025-01-02', 'QL005'),
--CH006
('PN0036', 'NCC001', 'CH006', '2025-01-02', 'QL006'), 
('PN0037', 'NCC002', 'CH006', '2025-01-02', 'QL006'), 
('PN0038', 'NCC003', 'CH006', '2025-01-02', 'QL006'), 
('PN0039', 'NCC004', 'CH006', '2025-01-02', 'QL006'), 
('PN0040', 'NCC005', 'CH006', '2025-01-02', 'QL006'), 
('PN0041', 'NCC006', 'CH006', '2025-01-02', 'QL006'),
('PN0042', 'NCC008', 'CH006', '2025-01-02', 'QL006')
GO
SELECT * FROM PhieuNhap 
GO 

-- CH001 (PN001)
INSERT INTO ChiTietNhapHang (MaPhieuNhap, MaSanPham, SoLuong, GiaNhap, GhiChu) VALUES
--CH001
--NCC001
('PN001', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN001', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN002', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN002', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN002', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN003', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN003', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN003', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN003', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN003', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN004', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN004', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN004', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN005', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN005', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN005', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN006', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN007', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN007', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN007', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ'),

--CH002
--NCC001
('PN008', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN008', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN009', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN009', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN009', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN0010', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0010', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0010', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0010', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0010', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN0011', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0011', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0011', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN0012', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0012', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0012', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN0013', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN0014', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0014', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0014', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ'),

--CH003
--NCC001
('PN0015', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0015', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN0016', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0016', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0016', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN0017', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0017', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0017', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0017', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0017', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN0018', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0018', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0018', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN0019', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0019', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0019', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN0020', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN0021', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0021', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0021', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ'),

--CH004
--NCC001
('PN0022', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0022', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN0023', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0023', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0023', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN0024', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0024', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0024', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0024', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0024', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN0025', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0025', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0025', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN0026', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0026', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0026', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN0027', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN0028', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0028', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0028', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ'),


--CH005
--NCC001
('PN0029', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0029', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN0030', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0030', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0030', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN0031', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0031', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0031', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0031', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0031', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN0032', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0032', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0032', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN0033', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0033', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0033', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN004', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN0035', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0035', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0035', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ'),


--CH006
--NCC001
('PN0036', 'SP0011', 100, 45000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0036', 'SP0012', 100, 35000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC002
('PN0037', 'SP006', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0037', 'SP007', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0037', 'SP0017', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC003
('PN0038', 'SP001', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0038', 'SP002', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0038', 'SP003', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0038', 'SP0019', 100, 12000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0038', 'SP0020', 100, 9000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC004
('PN0039', 'SP008', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0039', 'SP009', 100, 5500 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0039', 'SP0013', 100, 7000 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC005
('PN0040', 'SP0010', 100, 8000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0040', 'SP0014', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0040', 'SP0016', 100, 6500 * 0.8, N'Nhập hàng đầu kỳ'),
--NCC006
('PN0041', 'SP0015', 100, 10000 * 0.8, N'Nhập hàng đầu kỳ'),

--NCC008
('PN0042', 'SP004', 100, 4000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0042', 'SP005', 100, 5000 * 0.8, N'Nhập hàng đầu kỳ'),
('PN0042', 'SP0018', 100, 6000 * 0.8, N'Nhập hàng đầu kỳ')
GO


SELECT * FROM ChiTietNhapHang 
GO 

-- CHI TIẾT KHO
 INSERT INTO ChiTietKho VALUES
 -- Cua Hang 1
('CTK001', 'CH001', 'SP001', 100, 8000),
('CTK002', 'CH001', 'SP002', 100, 10000),
('CTK003', 'CH001', 'SP003', 100, 9000),
('CTK004', 'CH001', 'SP004', 100, 4000),
('CTK005', 'CH001', 'SP005', 100, 5000),
('CTK006', 'CH001', 'SP006', 100, 7000),
('CTK007', 'CH001', 'SP007', 100, 9000),
('CTK008', 'CH001', 'SP008', 100, 6500),
('CTK009', 'CH001', 'SP009', 100, 5500),
('CTK0010', 'CH001', 'SP0010', 100, 8000),
('CTK0011', 'CH001', 'SP0011', 100, 45000),
('CTK0012', 'CH001', 'SP0012', 100, 35000),
('CTK0013', 'CH001', 'SP0013', 100, 7000),
('CTK0014', 'CH001', 'SP0014', 100, 5000),
('CTK0015', 'CH001', 'SP0015', 100, 10000),
('CTK0016', 'CH001', 'SP0016', 100, 6500),
('CTK0017', 'CH001', 'SP0017', 100, 4000),
('CTK0018', 'CH001', 'SP0018', 100, 6000),
('CTK0019', 'CH001', 'SP0019', 100, 12000),
('CTK0020', 'CH001', 'SP0020', 100, 9000),
 -- Cua Hang 2
('CTK0021', 'CH002', 'SP001', 100, 8000),
('CTK0022', 'CH002', 'SP002', 100, 10000),
('CTK0023', 'CH002', 'SP003', 100, 9000),
('CTK0024', 'CH002', 'SP004', 100, 4000),
('CTK0025', 'CH002', 'SP005', 100, 5000),
('CTK0026', 'CH002', 'SP006', 100, 7000),
('CTK0027', 'CH002', 'SP007', 100, 9000),
('CTK0028', 'CH002', 'SP008', 100, 6500),
('CTK0029', 'CH002', 'SP009', 100, 5500),
('CTK0030', 'CH002', 'SP0010', 100, 8000),
('CTK0031', 'CH002', 'SP0011', 100, 45000),
('CTK0032', 'CH002', 'SP0012', 100, 35000),
('CTK0033', 'CH002', 'SP0013', 100, 7000),
('CTK0034', 'CH002', 'SP0014', 100, 5000),
('CTK0035', 'CH002', 'SP0015', 100, 10000),
('CTK0036', 'CH002', 'SP0016', 100, 6500),
('CTK0037', 'CH002', 'SP0017', 100, 4000),
('CTK0038', 'CH002', 'SP0018', 100, 6000),
('CTK0039', 'CH002', 'SP0019', 100, 12000),
('CTK0040', 'CH002', 'SP0020', 100, 9000),
 -- Cua Hang 3
('CTK0041', 'CH003', 'SP001', 100, 8000),
('CTK0042', 'CH003', 'SP002', 100, 10000),
('CTK0043', 'CH003', 'SP003', 100, 9000),
('CTK0044', 'CH003', 'SP004', 100, 4000),
('CTK0045', 'CH003', 'SP005', 100, 5000),
('CTK0046', 'CH003', 'SP006', 100, 7000),
('CTK0047', 'CH003', 'SP007', 100, 9000),
('CTK0048', 'CH003', 'SP008', 100, 6500),
('CTK0049', 'CH003', 'SP009', 100, 5500),
('CTK0050', 'CH003', 'SP0010', 100, 8000),
('CTK0051', 'CH003', 'SP0011', 100, 45000),
('CTK0052', 'CH003', 'SP0012', 100, 35000),
('CTK0053', 'CH003', 'SP0013', 100, 7000),
('CTK0054', 'CH003', 'SP0014', 100, 5000),
('CTK0055', 'CH003', 'SP0015', 100, 10000),
('CTK0056', 'CH003', 'SP0016', 100, 6500),
('CTK0057', 'CH003', 'SP0017', 100, 4000),
('CTK0058', 'CH003', 'SP0018', 100, 6000),
('CTK0059', 'CH003', 'SP0019', 100, 12000),
('CTK0060', 'CH003', 'SP0020', 100, 9000),
 -- Cua Hang 4
('CTK0061', 'CH004', 'SP001', 100, 8000),
('CTK0062', 'CH004', 'SP002', 100, 10000),
('CTK0063', 'CH004', 'SP003', 100, 9000),
('CTK0064', 'CH004', 'SP004', 100, 4000),
('CTK0065', 'CH004', 'SP005', 100, 5000),
('CTK0066', 'CH004', 'SP006', 100, 7000),
('CTK0067', 'CH004', 'SP007', 100, 9000),
('CTK0068', 'CH004', 'SP008', 100, 6500),
('CTK0069', 'CH004', 'SP009', 100, 5500),
('CTK0070', 'CH004', 'SP0010', 100, 8000),
('CTK0071', 'CH004', 'SP0011', 100, 45000),
('CTK0072', 'CH004', 'SP0012', 100, 35000),
('CTK0073', 'CH004', 'SP0013', 100, 7000),
('CTK0074', 'CH004', 'SP0014', 100, 5000),
('CTK0075', 'CH004', 'SP0015', 100, 10000),
('CTK0076', 'CH004', 'SP0016', 100, 6500),
('CTK0077', 'CH004', 'SP0017', 100, 4000),
('CTK0078', 'CH004', 'SP0018', 100, 6000),
('CTK0079', 'CH004', 'SP0019', 100, 12000),
('CTK0080', 'CH004', 'SP0020', 100, 9000),
 -- Cua Hang 5
('CTK0081', 'CH005', 'SP001', 100, 8000),
('CTK0082', 'CH005', 'SP002', 100, 10000),
('CTK0083', 'CH005', 'SP003', 100, 9000),
('CTK0084', 'CH005', 'SP004', 100, 4000),
('CTK0085', 'CH005', 'SP005', 100, 5000),
('CTK0086', 'CH005', 'SP006', 100, 7000),
('CTK0087', 'CH005', 'SP007', 100, 9000),
('CTK0088', 'CH005', 'SP008', 100, 6500),
('CTK0089', 'CH005', 'SP009', 100, 5500),
('CTK0090', 'CH005', 'SP0010', 100, 8000),
('CTK0091', 'CH005', 'SP0011', 100, 45000),
('CTK0092', 'CH005', 'SP0012', 100, 35000),
('CTK0093', 'CH005', 'SP0013', 100, 7000),
('CTK0094', 'CH005', 'SP0014', 100, 5000),
('CTK0095', 'CH005', 'SP0015', 100, 10000),
('CTK0096', 'CH005', 'SP0016', 100, 6500),
('CTK0097', 'CH005', 'SP0017', 100, 4000),
('CTK0098', 'CH005', 'SP0018', 100, 6000),
('CTK0099', 'CH005', 'SP0019', 100, 12000),
('CTK00100', 'CH005', 'SP0020', 100, 9000),
 -- Cua Hang 6
('CTK00101', 'CH006', 'SP001', 100, 8000),
('CTK00102', 'CH006', 'SP002', 100, 10000),
('CTK00103', 'CH006', 'SP003', 100, 9000),
('CTK00104', 'CH006', 'SP004', 100, 4000),
('CTK00105', 'CH006', 'SP005', 100, 5000),
('CTK00106', 'CH006', 'SP006', 100, 7000),
('CTK00107', 'CH006', 'SP007', 100, 9000),
('CTK00108', 'CH006', 'SP008', 100, 6500),
('CTK00109', 'CH006', 'SP009', 100, 5500),
('CTK00110', 'CH006', 'SP0010', 100, 8000),
('CTK00111', 'CH006', 'SP0011', 100, 45000),
('CTK00112', 'CH006', 'SP0012', 100, 35000),
('CTK00113', 'CH006', 'SP0013', 100, 7000),
('CTK00114', 'CH006', 'SP0014', 100, 5000),
('CTK00115', 'CH006', 'SP0015', 100, 10000),
('CTK00116', 'CH006', 'SP0016', 100, 6500),
('CTK00117', 'CH006', 'SP0017', 100, 4000),
('CTK00118', 'CH006', 'SP0018', 100, 6000),
('CTK00119', 'CH006', 'SP0019', 100, 12000),
('CTK00120', 'CH006', 'SP0020', 100, 9000)

GO 
SELECT * FROM ChiTietKho 
GO 

-- KHUYẾN MÃI
INSERT INTO KhuyenMai VALUES 
('KM001', N'Tết Sale Khủng', 2000, '2025-01-01', '2025-01-15', N'Sản phẩm', NULL, 1),
('KM002', N'Mua nhiều giảm nhiều', 1000, '2025-02-01', '2025-02-28', N'Sản phẩm', NULL, 0),
('KM003', N'Sữa khuyến mãi tháng 3', 1500, '2025-03-01', '2025-03-31', N'Sản phẩm', NULL, 0),
('KM004', N'Khuyến mãi nước ngọt', 1000, '2025-04-01', '2025-04-15', N'Sản phẩm', NULL, 0)
GO
SELECT * FROM KhuyenMai 
GO 

-- CHI TIẾT KHUYẾN MÃI
-- KM001 - Tết Sale Khủng
 INSERT INTO KhuyenMai_SanPham VALUES
('KM001', 'SP001', 2, 1),
('KM001', 'SP004', 5, 2),

-- KM002 - Mua nhiều giảm nhiều
('KM002', 'SP006', 3, 1),
('KM002', 'SP007', 3, 1),

-- KM003 - Sữa khuyến mãi
('KM003', 'SP008', 2, 1),
('KM003', 'SP0010', 2, 1),

-- KM004 - Nước ngọt
('KM004', 'SP002', 2, 1),
('KM004', 'SP003', 2, 1),
('KM004', 'SP0019', 2, 1),
('KM004', 'SP0020', 2, 1),
('KM004', 'SP0015', 2, 1)
GO
SELECT * FROM KhuyenMai_SanPham
GO 

-- HOÁ ĐƠN
 INSERT INTO HoaDon VALUES
 ('HD001', 'CH001', 'NV004', '2025-01-03', 0),
 ('HD002', 'CH001', 'NV004', '2025-01-04', 0),
 ('HD003', 'CH001', 'NV005', '2025-01-05', 0),
 ('HD004', 'CH001', 'NV005', '2025-01-06', 0),
 ('HD005', 'CH001', 'NV004', '2025-01-07', 0),

 ('HD006', 'CH002', 'NV006', '2025-01-03', 0),
 ('HD007', 'CH002', 'NV007', '2025-01-04', 0),
 ('HD008', 'CH002', 'NV006', '2025-01-05', 0),
 ('HD009', 'CH002', 'NV007', '2025-01-06', 0),
 ('HD0010', 'CH002', 'NV006', '2025-01-07', 0),

 ('HD0011', 'CH003', 'NV009', '2025-01-03', 0),
 ('HD0012', 'CH003', 'NV008', '2025-01-04', 0),
 ('HD0013', 'CH003', 'NV008', '2025-01-05', 0),
 ('HD0014', 'CH003', 'NV009', '2025-01-06', 0),
 ('HD0015', 'CH003', 'NV008', '2025-01-07', 0),

 ('HD0016', 'CH004', 'NV010', '2025-01-03', 0),
 ('HD0017', 'CH004', 'NV010', '2025-01-04', 0),
 ('HD0018', 'CH004', 'NV011', '2025-01-05', 0),
 ('HD0019', 'CH004', 'NV011', '2025-01-06', 0),
 ('HD0020', 'CH004', 'NV010', '2025-01-07', 0),

 ('HD0021', 'CH005', 'NV012', '2025-01-03', 0),
 ('HD0022', 'CH005', 'NV012', '2025-01-04', 0),
 ('HD0023', 'CH005', 'NV012', '2025-01-05', 0),
 ('HD0024', 'CH005', 'NV013', '2025-01-06', 0),
 ('HD0025', 'CH005', 'NV013', '2025-01-07', 0),

 ('HD0026', 'CH006', 'NV014', '2025-01-03', 0),
 ('HD0027', 'CH006', 'NV014', '2025-01-04', 0),
 ('HD0028', 'CH006', 'NV015', '2025-01-05', 0),
 ('HD0029', 'CH006', 'NV015', '2025-01-06', 0),
 ('HD0030', 'CH006', 'NV015', '2025-01-07', 0)
GO
SELECT * FROM HoaDon 
GO 

-- CHI TIẾT HOÁ ĐƠN
 INSERT INTO ChiTietHoaDon VALUES
 ('CTHD001', 'HD001', 'SP001', 10, 6000,0),
 ('CTHD002', 'HD001', 'SP004', 6, 2000,0),

 ('CTHD003', 'HD002', 'SP002', 9, 10000,0),
 ('CTHD004', 'HD002', 'SP005', 20, 5000,0),

 ('CTHD005', 'HD003', 'SP006', 25, 7000,0),
 ('CTHD006', 'HD003', 'SP007', 10, 9000,0),

 ('CTHD007', 'HD004', 'SP008', 10, 6500,0),
 ('CTHD008', 'HD004', 'SP0010', 10, 8000,0),

 ('CTHD009', 'HD005', 'SP009', 30, 5500,0),
 ('CTHD010', 'HD005', 'SP0011', 5, 45000,0),

 ('CTHD0011', 'HD006', 'SP0012', 8, 35000,0),
 ('CTHD0012', 'HD006', 'SP0016', 10, 6500,0),

 ('CTHD0013', 'HD007', 'SP0012', 8, 35000,0),
 ('CTHD0014', 'HD007', 'SP0016', 10, 6500,0),

 ('CTHD0015', 'HD008', 'SP003', 8, 9000,0),
 ('CTHD0016', 'HD008', 'SP002', 1, 10000,0),

 ('CTHD0017', 'HD009', 'SP001', 1, 8000,0),
 ('CTHD0018', 'HD009', 'SP0011', 1, 45000,0),

 ('CTHD0019', 'HD0010', 'SP0012', 8, 35000,0),
 ('CTHD0020', 'HD0010', 'SP0016', 10, 6500,0),

 ('CTHD0021', 'HD0011', 'SP002', 8, 10000,0),
 ('CTHD0022', 'HD0011', 'SP0020', 10, 9000,0),

 ('CTHD0023', 'HD0012', 'SP0011', 8, 45000,0),
 ('CTHD0024', 'HD0012', 'SP0013', 11, 7000,0),

 ('CTHD0025', 'HD0013', 'SP009', 3, 5500,0),
 ('CTHD0026', 'HD0013', 'SP005', 10, 5000,0),

 ('CTHD0027', 'HD0014', 'SP0012', 8, 35000,0),
 ('CTHD0028', 'HD0014', 'SP0016', 10, 6500,0),

 ('CTHD0029', 'HD0015', 'SP0010', 8, 8000,0),
 ('CTHD0030', 'HD0015', 'SP008', 10, 6500,0),

 ('CTHD0031', 'HD0016', 'SP0012', 8, 35000,0),
 ('CTHD0032', 'HD0016', 'SP0014', 10, 6500,0),

 ('CTHD0033', 'HD0017', 'SP0012', 2, 35000,0),
 ('CTHD0034', 'HD0017', 'SP0016', 1, 6500,0),

 ('CTHD0035', 'HD0018', 'SP0011', 8, 45000,0),
 ('CTHD0036', 'HD0018', 'SP0018', 10, 6000,0),

 ('CTHD0037', 'HD0019', 'SP009', 2, 5500,0),
 ('CTHD0038', 'HD0019', 'SP0010', 8, 8000,0),
   
 ('CTHD0039', 'HD0020', 'SP003', 2, 9000,0),
 ('CTHD0040', 'HD0020', 'SP0019', 10, 12000,0),

 ('CTHD0041', 'HD0021', 'SP0011', 8, 45000,0),
 ('CTHD0042', 'HD0021', 'SP004', 10, 2000,0),

 ('CTHD0043', 'HD0022', 'SP0014', 8, 5000,0),

 ('CTHD0044', 'HD0023', 'SP0016', 10, 6500,0),

 ('CTHD0045', 'HD0024', 'SP0011', 4, 45000,0),

 ('CTHD0046', 'HD0025', 'SP0020', 10, 9000,0),

 ('CTHD0047', 'HD0026', 'SP002', 9, 10000,0),
 ('CTHD0048', 'HD0026', 'SP003', 10, 9000,0),

 ('CTHD0049', 'HD0027', 'SP0015', 10, 10000,0),
 ('CTHD0050', 'HD0028', 'SP0016', 10, 6500,0),

 ('CTHD0051', 'HD0029', 'SP0011', 2, 45000,0),
 ('CTHD0052', 'HD0030', 'SP0016', 10, 6500,0)
GO
SELECT * FROM ChiTietHoaDon 
GO 
-- Cập nhập thành tiền cho chi tiết hoá đơn 
UPDATE ChiTietHoaDon 
SET ThanhTien = SoLuong * GiaBan 
go
SELECT * FROM ChiTietHoaDon 
GO 
-- Cập nhập tổng tiền của hoá đơn 
UPDATE HOADON
SET TongTien = kq.TongTien
FROM HoaDon hd 
JOIN (
SELECT cthd.MaHoaDon, SUM(cthd.ThanhTien) AS TongTien
FROM ChiTietHoaDon cthd
GROUP BY  cthd.MaHoaDon
) AS kq ON hd.MaHoaDon = kq.MaHoaDon
GO 
SELECT * FROM HoaDon 
GO 
-- Cập nhập lại chi tiết kho 
UPDATE ChiTietKho 
SET SoLuongTon =  (Ctk.SoLuongTon - cthd.SoLuong)
FROM ChiTietKho ctk , HoaDon hd , ChiTietHoaDon cthd 
WHERE ctk.MaCuaHang = hd.MaCuaHang AND hd.MaHoaDon= cthd.MaHoaDon AND ctk.MaSanPham = cthd.MaSanPham AND ctk.SoLuongTon >= cthd.SoLuong
go

-- KIỂM KHO
 INSERT INTO KiemKho VALUES('KK001', 'CH001', 'NV004', '2025-01-16'),
 ('KK002', 'CH002', 'NV006', '2025-01-16'),
 ('KK003', 'CH003', 'NV008', '2025-01-16'),
 ('KK004', 'CH004', 'NV010', '2025-01-16'),
 ('KK005', 'CH005', 'NV012', '2025-01-26'),
 ('KK006', 'CH006', 'NV014', '2025-01-26')
GO
SELECT * FROM KiemKho 
GO 
-- CHI TIẾT KIỂM KHO
 INSERT INTO ChiTietKiemKho VALUES
 --CH001
('KK001', 'SP001', 90, 88, N'Thiếu',-2, N''),
('KK001', 'SP002', 91, 91, N'Khớp',0, N''),
('KK001', 'SP003', 100, 100, N'Khớp',0, N''),
('KK001', 'SP004', 94, 94, N'Khớp',0, N''),
('KK001', 'SP005', 80, 80, N'Khớp',0, N''),
('KK001', 'SP006', 75, 75, N'Khớp',0, N''),
('KK001', 'SP007', 90, 90, N'Khớp',0, N''),
('KK001', 'SP008', 90, 90, N'Khớp',0, N''),
('KK001', 'SP009', 70, 70, N'Khớp',0, N''),
('KK001', 'SP0010', 90, 90, N'Khớp',0, N''),
('KK001', 'SP0011', 95, 95, N'Khớp',0, N''),
('KK001', 'SP0012', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0013', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0014', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0015', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0016', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK001', 'SP0018', 100, 200, N'Khớp',0, N''),
('KK001', 'SP0019', 100, 200, N'Khớp',0, N''),
('KK001', 'SP0020', 100, 100, N'Khớp',0, N''),
 --CH002
('KK002', 'SP001', 99, 99, N'Khớp',0, N''),
('KK002', 'SP002', 99, 99, N'Khớp',0, N''),
('KK002', 'SP003', 92, 92, N'Khớp',0, N''),
('KK002', 'SP004', 100, 100, N'Khớp',0, N''),
('KK002', 'SP005', 100, 97, N'Thiếu',-3, N''),
('KK002', 'SP006', 100, 100, N'Khớp',0, N''),
('KK002', 'SP007', 100, 100, N'Khớp',0, N''),
('KK002', 'SP008', 100, 100, N'Khớp',0, N''),
('KK002', 'SP009', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0010', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0011', 99, 99, N'Khớp',0, N''),
('KK002', 'SP0012', 92, 92, N'Khớp',0, N''),
('KK002', 'SP0013', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0014', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0015', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0016', 90, 90, N'Khớp',0, N''),
('KK002', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0018', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0019', 100, 100, N'Khớp',0, N''),
('KK002', 'SP0020', 100, 100, N'Khớp',0, N''),
 --CH003
('KK003', 'SP001', 100, 100, N'Khớp',0, N''),
('KK003', 'SP002', 92, 92, N'Khớp',0, N''),
('KK003', 'SP003', 100, 100, N'Khớp',0, N''),
('KK003', 'SP004', 100, 100, N'Khớp',0, N''),
('KK003', 'SP005', 90, 90, N'Khớp',0, N''),
('KK003', 'SP006', 100, 100, N'Khớp',0, N''),
('KK003', 'SP007', 100, 99, N'Thiếu',-1, N''),
('KK003', 'SP008', 90, 90, N'Khớp',0, N''),
('KK003', 'SP009', 97, 97, N'Khớp',0, N''),
('KK003', 'SP0010', 92, 92, N'Khớp',0, N''),
('KK003', 'SP0011', 92, 92, N'Khớp',0, N''),
('KK003', 'SP0012', 92, 92, N'Khớp',0, N''),
('KK003', 'SP0013', 89, 89, N'Khớp',0, N''),
('KK003', 'SP0014', 100, 100, N'Khớp',0, N''),
('KK003', 'SP0015', 100, 100, N'Khớp',0, N''),
('KK003', 'SP0016', 90, 90, N'Khớp',0, N''),
('KK003', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK003', 'SP0018', 100, 100, N'Khớp',0, N''),
('KK003', 'SP0019', 100, 100, N'Khớp',0, N''),
('KK003', 'SP0020', 90, 90, N'Khớp',0, N''),
 --CH004
('KK004', 'SP001', 100, 100, N'Khớp',0, N''),
('KK004', 'SP002', 100, 100, N'Khớp',0, N''),
('KK004', 'SP003', 98, 98, N'Khớp',0, N''),
('KK004', 'SP004', 100, 100, N'Khớp',0, N''),
('KK004', 'SP005', 100, 100, N'Khớp',0, N''),
('KK004', 'SP006', 100, 100, N'Khớp',0, N''),
('KK004', 'SP007', 100, 100, N'Khớp',0, N''),
('KK004', 'SP008', 100, 100, N'Khớp',0, N''),
('KK004', 'SP009', 98, 98, N'Khớp',0, N''),
('KK004', 'SP0010', 92, 92, N'Khớp',0, N''),
('KK004', 'SP0011', 92, 92, N'Khớp',0, N''),
('KK004', 'SP0012', 92, 92, N'Khớp',0, N''),
('KK004', 'SP0013', 100, 100, N'Khớp',0, N''),
('KK004', 'SP0014', 90, 90, N'Khớp',0, N''),
('KK004', 'SP0015', 100, 100, N'Khớp',0, N''),
('KK004', 'SP0016', 99, 99, N'Khớp',0, N''),
('KK004', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK004', 'SP0018', 90, 90, N'Khớp',0, N''),
('KK004', 'SP0019', 90, 90, N'Khớp',0, N''),
('KK004', 'SP0020', 100, 100, N'Khớp',0, N''),
 --CH005
('KK005', 'SP001', 100, 100, N'Khớp',0, N''),
('KK005', 'SP002', 100, 100, N'Khớp',0, N''),
('KK005', 'SP003', 100, 100, N'Khớp',0, N''),
('KK005', 'SP004', 90, 90, N'Khớp',0, N''),
('KK005', 'SP005', 100, 100, N'Khớp',0, N''),
('KK005', 'SP006', 100, 100, N'Khớp',0, N''),
('KK005', 'SP007', 100, 100, N'Khớp',0, N''),
('KK005', 'SP008', 100, 100, N'Khớp',0, N''),
('KK005', 'SP009', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0010', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0011', 92, 92, N'Khớp',0, N''),
('KK005', 'SP0012', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0013', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0014', 92, 92, N'Khớp',0, N''),
('KK005', 'SP0015', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0016', 90, 90, N'Khớp',0, N''),
('KK005', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0018', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0019', 100, 100, N'Khớp',0, N''),
('KK005', 'SP0020', 90, 90, N'Khớp',0, N''),
 --CH006
('KK006', 'SP001', 100, 100, N'Khớp',0, N''),
('KK006', 'SP002', 91, 91, N'Khớp',0, N''),
('KK006', 'SP003', 90, 90, N'Khớp',0, N''),
('KK006', 'SP004', 100, 100, N'Khớp',0, N''),
('KK006', 'SP005', 100, 100, N'Khớp',0, N''),
('KK006', 'SP006', 100, 100, N'Khớp',0, N''),
('KK006', 'SP007', 100, 100, N'Khớp',0, N''),
('KK006', 'SP008', 100, 100, N'Khớp',0, N''),
('KK006', 'SP009', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0010', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0011', 98, 98, N'Khớp',0, N''),
('KK006', 'SP0012', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0013', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0014', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0015', 90, 90, N'Khớp',0, N''),
('KK006', 'SP0016', 90, 90, N'Khớp',0, N''),
('KK006', 'SP0017', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0018', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0019', 100, 100, N'Khớp',0, N''),
('KK006', 'SP0020', 100, 100, N'Khớp',0, N'')
GO
SELECT * FROM ChiTietKiemKho
GO 

-- XUẤT HÀNG
INSERT INTO PhieuXuat VALUES 
('PX001', 'CH001', 'NV004', '2025-01-11', N'Hư hỏng'),
('PX002', 'CH002', 'NV006', '2025-01-11', N'Hư hỏng'),
('PX003', 'CH003', 'NV008', '2025-01-11', N'Hư hỏng')
GO
SELECT * FROM PhieuXuat 
GO 

-- CHI TIẾT XUẤT HÀNG
 INSERT INTO ChiTietXuatHang VALUES
 ('PX001', 'SP001', 2, 8000, N'Sản phẩm bị hư hỏng'),

 ('PX002', 'SP005', 3, 5000, N'Sản phẩm bị hư hỏng'),

 ('PX003', 'SP007', 1, 9000, N'Sản phẩm bị hư hỏng')
GO
--CapNhapChiTietKho
UPDATE ChiTietKho 
SET SoLuongTon =  (Ctk.SoLuongTon - ctxh.SoLuong)
FROM ChiTietKho ctk , PhieuXuat xh , ChiTietXuatHang ctxh 
WHERE ctk.MaCuaHang = xh.MaCuaHang AND xh.MaPhieuXuat = ctxh.MaPhieuXuat AND ctk.MaSanPham = ctxh.MaSanPham
go

SELECT * FROM ChiTietKho 
GO 
SELECT * FROM ChiTietXuatHang
GO 




INSERT INTO LichSuKho VALUES
--CH001
--Chi tiết nhập
--PN001
('LSK0011','CTK0011','2025-01-02',100,'Nhap','PN001'),
('LSK0012','CTK0012','2025-01-02',100,'Nhap','PN001'),
--PN002
('LSK006','CTK006','2025-01-02',100,'Nhap','PN002'),
('LSK007','CTK007','2025-01-02',100,'Nhap','PN002'),
('LSK0017','CTK0017','2025-01-02',100,'Nhap','PN002'),
--PN003
('LSK001','CTK001','2025-01-02',100,'Nhap','PN003'),
('LSK002','CTK002','2025-01-02',100,'Nhap','PN003'),
('LSK003','CTK003','2025-01-02',100,'Nhap','PN003'),
('LSK0019','CTK0019','2025-01-02',100,'Nhap','PN003'),
('LSK0020','CTK0020','2025-01-02',100,'Nhap','PN003'),
--PN004
('LSK008','CTK008','2025-01-02',100,'Nhap','PN004'),
('LSK009','CTK009','2025-01-02',100,'Nhap','PN004'),
('LSK0013','CTK0013','2025-01-02',100,'Nhap','PN004'),
--PN005
('LSK0010','CTK0010','2025-01-02',100,'Nhap','PN005'),
('LSK0014','CTK0014','2025-01-02',100,'Nhap','PN005'),
('LSK0016','CTK0016','2025-01-02',100,'Nhap','PN005'),
--PN006
('LSK0015','CTK0015','2025-01-02',100,'Nhap','PN006'),
--PN007
('LSK004','CTK004','2025-01-02',100,'Nhap','PN007'),
('LSK005','CTK005','2025-01-02',100,'Nhap','PN007'),
('LSK0018','CTK0018','2025-01-02',100,'Nhap','PN007'),
--Chi tiết xuất
('LSK0021','CTK001','2025-01-11',-2,'Xuat','PX001'),
--Chi tiết kiểm kho
('LSK0022','CTK001','2025-01-16',-2,'Kiem','KK001'),
--Bán hàng
--HD001
('LSK0023','CTK001','2025-01-03',-10,'Ban','HD001'),
('LSK0024','CTK004','2025-01-03',-6,'Ban','HD001'),
--HD002
('LSK0025','CTK002','2025-01-04',-9,'Ban','HD002'),
('LSK0026','CTK005','2025-01-04',-20,'Ban','HD002'),
--HD003
('LSK0027','CTK006','2025-01-05',-25,'Ban','HD003'),
('LSK0028','CTK007','2025-01-05',-10,'Ban','HD003'),
--HD004
('LSK0029','CTK008','2025-01-06',-10,'Ban','HD004'),
('LSK0030','CTK0010','2025-01-06',-10,'Ban','HD004'),
--HD005
('LSK0031','CTK009','2025-01-07',-30,'Ban','HD005'),
('LSK00178','CTK0011','2025-01-07',-3,'Ban','HD005'),

--CH002
--Chi tiết nhập
--PN008
('LSK0032','CTK0031','2025-01-02',100,'Nhap','PN008'),
('LSK0033','CTK0032','2025-01-02',100,'Nhap','PN008'),
--PN009
('LSK0034','CTK0026','2025-01-02',100,'Nhap','PN009'),
('LSK0035','CTK0027','2025-01-02',100,'Nhap','PN009'),
('LSK0036','CTK0037','2025-01-02',100,'Nhap','PN009'),
--PN0010
('LSK0037','CTK0021','2025-01-02',100,'Nhap','PN0010'),
('LSK0038','CTK0022','2025-01-02',100,'Nhap','PN0010'),
('LSK0039','CTK0023','2025-01-02',100,'Nhap','PN0010'),
('LSK0040','CTK0039','2025-01-02',100,'Nhap','PN0010'),
('LSK0041','CTK0040','2025-01-02',100,'Nhap','PN0010'),
--PN0011
('LSK0042','CTK0028','2025-01-02',100,'Nhap','PN0011'),
('LSK0043','CTK0029','2025-01-02',100,'Nhap','PN0011'),
('LSK0044','CTK0033','2025-01-02',100,'Nhap','PN0011'),
--PN0012
('LSK0045','CTK0030','2025-01-02',100,'Nhap','PN0012'),
('LSK0046','CTK0034','2025-01-02',100,'Nhap','PN0012'),
('LSK0047','CTK0036','2025-01-02',100,'Nhap','PN0012'),
--PN0013
('LSK0048','CTK0035','2025-01-02',100,'Nhap','PN0013'),
--PN0014
('LSK0049','CTK0024','2025-01-02',100,'Nhap','PN0014'),
('LSK0050','CTK0025','2025-01-02',100,'Nhap','PN0014'),
('LSK0051','CTK0038','2025-01-02',100,'Nhap','PN0014'),
--Chi tiết xuất
('LSK0052','CTK0025','2025-01-11',-3,'Xuat','PX002'),
--Chi tiết kiểm kho
('LSK0053','CTK0025','2025-01-16',-3,'Kiem','KK002'),
--Bán hàng
--HD006
('LSK0054','CTK0032','2025-01-03',-8,'Ban','HD006'),
('LSK0055','CTK0036','2025-01-03',-10,'Ban','HD006'),
--HD007
('LSK0056','CTK0032','2025-01-04',-8,'Ban','HD007'),
('LSK0057','CTK0036','2025-01-04',-10,'Ban','HD007'),
--HD008
('LSK0058','CTK0023','2025-01-05',-8,'Ban','HD008'),
('LSK0059','CTK0022','2025-01-05',-1,'Ban','HD008'),
--HD009
('LSK0060','CTK0021','2025-01-06',-1,'Ban','HD009'),
('LSK0061','CTK0031','2025-01-06',-1,'Ban','HD009'),
--HD0010
('LSK0062','CTK0032','2025-01-07',-8,'Ban','HD0010'),
('LSK0063','CTK0036','2025-01-07',-10,'Ban','HD0010'),

--CH003
--Chi tiết nhập
--PN008
('LSK0064','CTK0051','2025-01-02',100,'Nhap','PN0015'),
('LSK0065','CTK0052','2025-01-02',100,'Nhap','PN0015'),
--PN009
('LSK0066','CTK0046','2025-01-02',100,'Nhap','PN0016'),
('LSK0067','CTK0047','2025-01-02',100,'Nhap','PN0016'),
('LSK0068','CTK0057','2025-01-02',100,'Nhap','PN0016'),
--PN0010
('LSK0069','CTK0041','2025-01-02',100,'Nhap','PN0017'),
('LSK0070','CTK0042','2025-01-02',100,'Nhap','PN0017'),
('LSK0071','CTK0043','2025-01-02',100,'Nhap','PN0017'),
('LSK0072','CTK0059','2025-01-02',100,'Nhap','PN0017'),
('LSK0073','CTK0060','2025-01-02',100,'Nhap','PN0017'),
--PN0011
('LSK0074','CTK0048','2025-01-02',100,'Nhap','PN0018'),
('LSK0075','CTK0049','2025-01-02',100,'Nhap','PN0018'),
('LSK0076','CTK0053','2025-01-02',100,'Nhap','PN0018'),
--PN0012
('LSK0077','CTK0050','2025-01-02',100,'Nhap','PN0019'),
('LSK0078','CTK0054','2025-01-02',100,'Nhap','PN0019'),
('LSK0079','CTK0056','2025-01-02',100,'Nhap','PN0019'),
--PN0013
('LSK0080','CTK0055','2025-01-02',100,'Nhap','PN0020'),
--PN0014
('LSK0081','CTK0044','2025-01-02',100,'Nhap','PN0021'),
('LSK0082','CTK0045','2025-01-02',100,'Nhap','PN0021'),
('LSK0083','CTK0058','2025-01-02',100,'Nhap','PN0021'),
--Chi tiết xuất
('LSK0084','CTK0047','2025-01-11',-1,'Xuat','PX003'),
--Chi tiết kiểm kho
('LSK0085','CTK0047','2025-01-16',-1,'Kiem','KK003'),
--Bán hàng
--HD0011
('LSK0086','CTK0042','2025-01-03',-8,'Ban','HD0011'),
('LSK0087','CTK0060','2025-01-03',-10,'Ban','HD0011'),
--HD0012
('LSK0088','CTK0051','2025-01-04',-8,'Ban','HD0012'),
('LSK0089','CTK0053','2025-01-04',-11,'Ban','HD0012'),
--HD0013
('LSK0090','CTK0023','2025-01-05',-3,'Ban','HD0013'),
('LSK0091','CTK0022','2025-01-05',-10,'Ban','HD0013'),
--HD0014
('LSK0092','CTK0049','2025-01-06',-1,'Ban','HD0014'),
('LSK0093','CTK0045','2025-01-06',-1,'Ban','HD0014'),
--HD0015
('LSK0094','CTK0052','2025-01-07',-8,'Ban','HD0015'),
('LSK0095','CTK0056','2025-01-07',-10,'Ban','HD0015'),

--CH004
--Chi tiết nhập
--PN0022
('LSK0096','CTK0071','2025-01-02',100,'Nhap','PN0022'),
('LSK0097','CTK0072','2025-01-02',100,'Nhap','PN0022'),
--PN0023
('LSK0098','CTK0066','2025-01-02',100,'Nhap','PN0023'),
('LSK0099','CTK0067','2025-01-02',100,'Nhap','PN0023'),
('LSK00100','CTK0077','2025-01-02',100,'Nhap','PN0023'),
--PN0024
('LSK00101','CTK0061','2025-01-02',100,'Nhap','PN0024'),
('LSK00102','CTK0062','2025-01-02',100,'Nhap','PN0024'),
('LSK00103','CTK0063','2025-01-02',100,'Nhap','PN0024'),
('LSK00104','CTK0079','2025-01-02',100,'Nhap','PN0024'),
('LSK00105','CTK0080','2025-01-02',100,'Nhap','PN0024'),
--PN0025
('LSK00106','CTK0068','2025-01-02',100,'Nhap','PN0025'),
('LSK00107','CTK0069','2025-01-02',100,'Nhap','PN0025'),
('LSK00108','CTK0073','2025-01-02',100,'Nhap','PN0025'),
--PN0026
('LSK00109','CTK0070','2025-01-02',100,'Nhap','PN0026'),
('LSK00110','CTK0074','2025-01-02',100,'Nhap','PN0026'),
('LSK00111','CTK0076','2025-01-02',100,'Nhap','PN0026'),
--PN0027
('LSK00112','CTK0075','2025-01-02',100,'Nhap','PN0027'),
--PN0028
('LSK00113','CTK0064','2025-01-02',100,'Nhap','PN0028'),
('LSK00114','CTK0065','2025-01-02',100,'Nhap','PN0028'),
('LSK00115','CTK0078','2025-01-02',100,'Nhap','PN0028'),

--Bán hàng
--HD0016
('LSK00116','CTK0072','2025-01-03',-8,'Ban','HD0016'),
('LSK00117','CTK0074','2025-01-03',-10,'Ban','HD0016'),
--HD0017
('LSK00118','CTK0072','2025-01-04',-2,'Ban','HD0017'),
('LSK00119','CTK0076','2025-01-04',-1,'Ban','HD0017'),
--HD0018
('LSK00120','CTK0071','2025-01-05',-8,'Ban','HD0018'),
('LSK00121','CTK0078','2025-01-05',-10,'Ban','HD0018'),
--HD0019
('LSK00122','CTK0069','2025-01-06',-2,'Ban','HD0019'),
('LSK00123','CTK0070','2025-01-06',-8,'Ban','HD0019'),
--HD0020
('LSK00124','CTK0063','2025-01-07',-2,'Ban','HD0020'),
('LSK00125','CTK0079','2025-01-07',-10,'Ban','HD0020'),

--CH005
--Chi tiết nhập
--PN0029
('LSK00126','CTK0091','2025-01-02',100,'Nhap','PN0029'),
('LSK00127','CTK0092','2025-01-02',100,'Nhap','PN0029'),
--PN0030
('LSK00128','CTK0086','2025-01-02',100,'Nhap','PN0030'),
('LSK00129','CTK0087','2025-01-02',100,'Nhap','PN0030'),
('LSK00130','CTK0097','2025-01-02',100,'Nhap','PN0030'),
--PN0031
('LSK00131','CTK0081','2025-01-02',100,'Nhap','PN0031'),
('LSK00132','CTK0082','2025-01-02',100,'Nhap','PN0031'),
('LSK00133','CTK0083','2025-01-02',100,'Nhap','PN0031'),
('LSK00134','CTK0099','2025-01-02',100,'Nhap','PN0031'),
('LSK00135','CTK00100','2025-01-02',100,'Nhap','PN0031'),
--PN0032
('LSK00136','CTK0088','2025-01-02',100,'Nhap','PN0032'),
('LSK00137','CTK0089','2025-01-02',100,'Nhap','PN0032'),
('LSK00138','CTK0093','2025-01-02',100,'Nhap','PN0032'),
--PN0033
('LSK00139','CTK0090','2025-01-02',100,'Nhap','PN0033'),
('LSK00140','CTK0094','2025-01-02',100,'Nhap','PN0033'),
('LSK00141','CTK0096','2025-01-02',100,'Nhap','PN0033'),
--PN0034
('LSK00142','CTK0095','2025-01-02',100,'Nhap','PN0034'),
--PN0035
('LSK00143','CTK0084','2025-01-02',100,'Nhap','PN0035'),
('LSK00144','CTK0085','2025-01-02',100,'Nhap','PN0035'),
('LSK00145','CTK0098','2025-01-02',100,'Nhap','PN0035'),

--Bán hàng
--HD0021
('LSK00146','CTK0091','2025-01-03',-8,'Ban','HD0021'),
('LSK00147','CTK0084','2025-01-03',-10,'Ban','HD0021'),
--HD0022
('LSK00148','CTK0094','2025-01-04',-8,'Ban','HD0022'),
--HD0023
('LSK00149','CTK0096','2025-01-05',-10,'Ban','HD0023'),
--HD0024
('LSK00150','CTK0091','2025-01-06',-4,'Ban','HD0024'),
--HD0025
('LSK00151','CTK00100','2025-01-07',-10,'Ban','HD0025'),

--CH006
--Chi tiết nhập
--PN0029
('LSK00152','CTK00111','2025-01-02',100,'Nhap','PN0029'),
('LSK00153','CTK00112','2025-01-02',100,'Nhap','PN0029'),
--PN0030
('LSK00154','CTK00106','2025-01-02',100,'Nhap','PN0030'),
('LSK00155','CTK00107','2025-01-02',100,'Nhap','PN0030'),
('LSK00156','CTK00117','2025-01-02',100,'Nhap','PN0030'),
--PN0031
('LSK00157','CTK00101','2025-01-02',100,'Nhap','PN0031'),
('LSK00158','CTK00102','2025-01-02',100,'Nhap','PN0031'),
('LSK00159','CTK00103','2025-01-02',100,'Nhap','PN0031'),
('LSK00160','CTK00119','2025-01-02',100,'Nhap','PN0031'),
('LSK00161','CTK00120','2025-01-02',100,'Nhap','PN0031'),
--PN0032
('LSK00162','CTK00108','2025-01-02',100,'Nhap','PN0032'),
('LSK00163','CTK00109','2025-01-02',100,'Nhap','PN0032'),
('LSK00164','CTK00113','2025-01-02',100,'Nhap','PN0032'),
--PN0033
('LSK00165','CTK00110','2025-01-02',100,'Nhap','PN0033'),
('LSK00166','CTK00114','2025-01-02',100,'Nhap','PN0033'),
('LSK00167','CTK00116','2025-01-02',100,'Nhap','PN0033'),
--PN0034
('LSK00168','CTK00115','2025-01-02',100,'Nhap','PN0034'),
--PN0035
('LSK00169','CTK00104','2025-01-02',100,'Nhap','PN0035'),
('LSK00170','CTK00105','2025-01-02',100,'Nhap','PN0035'),
('LSK00171','CTK00118','2025-01-02',100,'Nhap','PN0035'),

--Bán hàng
--HD0026
('LSK00172','CTK00102','2025-01-03',-9,'Ban','HD0026'),
('LSK00173','CTK00103','2025-01-03',-10,'Ban','HD0026'),
--HD0027
('LSK00174','CTK00115','2025-01-04',-10,'Ban','HD0027'),
--HD0028
('LSK00175','CTK00116','2025-01-05',-10,'Ban','HD0028'),
--HD0029
('LSK00176','CTK00111','2025-01-06',-2,'Ban','HD0029'),
--HD0030
('LSK00177','CTK00116','2025-01-07',-10,'Ban','HD0030')
GO

SELECT * FROM LichSuKho 
GO