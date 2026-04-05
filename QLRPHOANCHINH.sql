/* =====================================================
   HỆ THỐNG QUẢN LÝ RẠP CHIẾU PHIM (HOÀN CHỈNH - BẢN GỘP VÉ)
===================================================== 
*/

USE master;
GO

IF DB_ID('CinemaManagement') IS NOT NULL
BEGIN
    ALTER DATABASE CinemaManagement SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CinemaManagement;
END
GO

CREATE DATABASE CinemaManagement;
GO

USE CinemaManagement;
GO

/* =====================================================
   PHẦN 1: TẠO CÁC BẢNG (TABLES)
===================================================== */

-- 1. BẢNG THỂ LOẠI
CREATE TABLE TheLoai (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE
);

-- 2. BẢNG PHIM (Có cột Poster)
CREATE TABLE Phim (
    MaPhim INT IDENTITY(1,1) PRIMARY KEY,
    TenPhim NVARCHAR(200) NOT NULL,
    ThoiLuong INT NOT NULL CHECK (ThoiLuong > 0),
    NgayKhoiChieu DATE,
    MoTa NVARCHAR(MAX),
    Poster NVARCHAR(MAX) DEFAULT 'default.jpg', 
    MaTheLoai INT NOT NULL,
    CONSTRAINT FK_Phim_TheLoai FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)
);

-- 3. BẢNG PHÒNG CHIẾU
CREATE TABLE PhongChieu (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(50) NOT NULL UNIQUE,
    SoLuongGhe INT NOT NULL CHECK (SoLuongGhe > 0)
);

-- 4. BẢNG GHẾ
CREATE TABLE Ghe (
    MaGhe INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    TenGhe NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_Ghe_Phong FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong),
    CONSTRAINT UQ_Ghe UNIQUE (MaPhong, TenGhe)
);

-- 5. BẢNG SUẤT CHIẾU
CREATE TABLE SuatChieu (
    MaSuatChieu INT IDENTITY(1,1) PRIMARY KEY,
    MaPhim INT NOT NULL,
    MaPhong INT NOT NULL,
    GioBatDau DATETIME NOT NULL,
    GiaVe DECIMAL(10,2) NOT NULL CHECK (GiaVe > 0),
    CONSTRAINT FK_SuatChieu_Phim FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim),
    CONSTRAINT FK_SuatChieu_Phong FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong)
);

-- 6. BẢNG NHÂN VIÊN
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(15),
    TaiKhoan NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL CHECK (LEN(MatKhau) >= 6),
    VaiTro NVARCHAR(50) NOT NULL CHECK (VaiTro IN ('Admin','BanVe')),
    HinhAnh NVARCHAR(MAX) DEFAULT 'default.png'
);

-- 7. BẢNG KHÁCH HÀNG
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(15) UNIQUE
);

-- 8. BẢNG VÉ
CREATE TABLE Ve (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaSuatChieu INT NOT NULL,
    MaGhe INT NOT NULL,
    TrangThai TINYINT DEFAULT 0 CHECK (TrangThai IN (0,1,2)), -- 0: Trống, 1: Đã bán, 2: Hủy
    CONSTRAINT FK_Ve_SuatChieu FOREIGN KEY (MaSuatChieu) REFERENCES SuatChieu(MaSuatChieu),
    CONSTRAINT FK_Ve_Ghe FOREIGN KEY (MaGhe) REFERENCES Ghe(MaGhe),
    CONSTRAINT UQ_Ve UNIQUE (MaSuatChieu, MaGhe)
);

-- 9. BẢNG HÓA ĐƠN
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien INT,
    MaKhachHang INT,
    NgayLap DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(12,2) DEFAULT 0,
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- 10. CHI TIẾT HÓA ĐƠN
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT NOT NULL,
    MaVe INT NOT NULL,
    GiaVe DECIMAL(10,2) NOT NULL CHECK (GiaVe > 0),
    PRIMARY KEY (MaHoaDon, MaVe),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_CTHD_Ve FOREIGN KEY (MaVe) REFERENCES Ve(MaVe)
);
GO

/* --- 2. PROCEDURES & TRIGGERS QUẢN LÝ --- */


CREATE PROCEDURE TaoGheTheoPhong
    @MaPhong INT,
    @SoLuongGhe INT
AS
BEGIN
    DECLARE @i INT = 1
    WHILE @i <= @SoLuongGhe
    BEGIN
        INSERT INTO Ghe(MaPhong, TenGhe)
        VALUES(@MaPhong, CONCAT('G', @i))
        SET @i = @i + 1
    END
END
GO

-- 2. Trigger tự động cập nhật tổng tiền cho hóa đơn
CREATE TRIGGER trg_UpdateTongTien
ON ChiTietHoaDon
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE HoaDon
    SET TongTien = (
        SELECT ISNULL(SUM(GiaVe),0)
        FROM ChiTietHoaDon
        WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
    )
    WHERE MaHoaDon IN (SELECT MaHoaDon FROM inserted UNION SELECT MaHoaDon FROM deleted)
END
GO

-- 3. Procedure tạo hóa đơn trống (Lấy mã Hóa Đơn chung)
CREATE PROCEDURE USP_CreateEmptyBill
    @MaNhanVien INT,
    @MaKhachHang INT
AS
BEGIN
    INSERT INTO HoaDon (MaNhanVien, MaKhachHang, NgayLap, TongTien) 
    VALUES (@MaNhanVien, @MaKhachHang, GETDATE(), 0)
    
    SELECT SCOPE_IDENTITY()
END
GO

-- 4. Procedure thêm từng vé vào hóa đơn chung
CREATE PROCEDURE USP_AddTicketToBill
    @MaHoaDon INT,
    @MaSuatChieu INT,
    @MaGhe INT,
    @GiaVe DECIMAL(10,2)
AS
BEGIN
    -- Tạo vé đánh dấu đã bán
    INSERT INTO Ve (MaSuatChieu, MaGhe, TrangThai) VALUES (@MaSuatChieu, @MaGhe, 1)
    DECLARE @MaVe INT = SCOPE_IDENTITY()
    
    -- Thêm vào chi tiết hóa đơn
    INSERT INTO ChiTietHoaDon (MaHoaDon, MaVe, GiaVe) VALUES (@MaHoaDon, @MaVe, @GiaVe)
END
GO

/* --- 3. BÁO CÁO DOANH THU (CHỈNH SỬA THEO YÊU CẦU) --- */

-- Báo cáo từ đầu năm (Dùng CTE để không bị sót tháng)
GO

CREATE PROCEDURE USP_DoanhThu_Ngay
    @Ngay DATE
AS
BEGIN
    SELECT 
        CAST(hd.NgayLap AS DATE) AS Ngay,     -- ✔️ giữ dạng DateTime cho RDLC
        '' AS Phim,                           -- ✔️ tránh NULL lỗi
        COUNT(cthd.MaVe) AS SoHoaDon,
        ISNULL(SUM(cthd.GiaVe), 0) AS DoanhThu
    FROM HoaDon hd
    JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon
    WHERE CAST(hd.NgayLap AS DATE) = @Ngay
    GROUP BY CAST(hd.NgayLap AS DATE)
END
GO 
CREATE PROC USP_DoanhThu_TuDauNam
    @Nam INT
AS
BEGIN
    DECLARE @ThangHT INT = MONTH(GETDATE())
    
    ;WITH ThangTable AS (
        SELECT 1 AS Thang
        UNION ALL
        SELECT Thang + 1 FROM ThangTable WHERE Thang < @ThangHT
    )
    SELECT 
        N'Tháng ' + CAST(T.Thang AS NVARCHAR(2)) AS [Ngay], 
        ISNULL(COUNT(H.MaHoaDon), 0) AS [SoHoaDon], 
        ISNULL(SUM(H.TongTien), 0) AS [DoanhThu],
        '' AS [Phim]
    FROM ThangTable T
    LEFT JOIN HoaDon H ON MONTH(H.NgayLap) = T.Thang AND YEAR(H.NgayLap) = @Nam
    GROUP BY T.Thang
    ORDER BY T.Thang
END
GO

-- Báo cáo Phim (Dùng cho Chart tròn)
CREATE PROC USP_DoanhThu_Phim AS
BEGIN
    SELECT CAST(GETDATE() AS DATE) AS Ngay, p.TenPhim AS Phim,
           COUNT(cthd.MaVe) AS SoHoaDon, SUM(cthd.GiaVe) AS DoanhThu
    FROM Phim p
    JOIN SuatChieu sc ON p.MaPhim = sc.MaPhim
    JOIN Ve v ON sc.MaSuatChieu = v.MaSuatChieu
    JOIN ChiTietHoaDon cthd ON v.MaVe = cthd.MaVe
    GROUP BY p.TenPhim
END
GO

/* --- 4. DỮ LIỆU MẪU --- */
INSERT INTO TheLoai (TenTheLoai) VALUES (N'Hành động'), (N'Hoạt hình'), (N'Tình Cảnh'), (N'Kinh dị');
INSERT INTO PhongChieu (TenPhong, SoLuongGhe) VALUES (N'Phòng 1', 30), (N'Phòng 2', 20), (N'Phòng 3', 10);
EXEC TaoGheTheoPhong 1, 30;
EXEC TaoGheTheoPhong 2, 20;
EXEC TaoGheTheoPhong 3, 10;
INSERT INTO NhanVien (TenNhanVien, TaiKhoan, MatKhau, VaiTro) VALUES (N'Admin', 'admin', '123456', 'Admin');
INSERT INTO KhachHang (TenKhachHang) VALUES (N'Khách lẻ');
INSERT INTO Phim (TenPhim, ThoiLuong, NgayKhoiChieu, MoTa, Poster, MaTheLoai)
VALUES 
(N'Quỷ Nhập Tràng 2', 120, '2026-03-31', N'Phim siu cấp kinh dị', 'quynhaptrang2.jpg', 4),
(N'Hoppers Cuộc Phiêu Lưu Kỳ Thú', 123, '2026-03-31', N'Lần đầu làm gấu', 'hoppers.jpg', 2),
(N'Hẹn Em Ngày Nhật Thực', 100, '2026-03-31', N'Tình cảnh sến súa', 'henemngaynhatthuc.jpg', 3),
(N'Tài', 110, '2026-03-31', N'Phim hài hước hành động mãn con nhãn', 'tai.jpg', 1);
INSERT INTO SuatChieu (MaPhim, MaPhong, GioBatDau, GiaVe)
VALUES 
(1, 1, '2026-04-01 18:00', 90000),
(2, 2, '2026-04-01 20:00', 80000),
(3, 3, '2026-04-01 20:00', 99000);



PRINT N'✔️ ĐÃ XONG!';