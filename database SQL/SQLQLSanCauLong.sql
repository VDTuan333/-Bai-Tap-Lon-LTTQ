create DATABASE QuanLySanCauLong;
GO

use QuanLySanCauLong;
go

CREATE TABLE NhanVien
(
    MaNV VARCHAR(20) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL
);
GO

CREATE TABLE SanCauLong
(
    MaSan VARCHAR(20) PRIMARY KEY,
    TenSan NVARCHAR(100) NOT NULL,
    LoaiSan NVARCHAR(50),
    DonGia DECIMAL(12, 2) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Trống'
);
GO




INSERT INTO NhanVien
    (MaNV, TenNV, TenDangNhap, MatKhau)
VALUES
    ('NV001', N'Nguyễn Văn An', 'admin', '123456'),
    ('NV002', N'Trần Thị Bình', 'nv002', '123456');

INSERT INTO SanCauLong
    (MaSan, TenSan, LoaiSan, DonGia, TrangThai)
VALUES
    ('S001', N'Sân cầu lông 1', N'Tiêu chuẩn', 80000, N'Trống'),
    ('S002', N'Sân cầu lông 2', N'Tiêu chuẩn', 80000, N'Trống'),
    ('S003', N'Sân cầu lông 3', N'Cao cấp', 100000, N'Trống');
GO

select * from NhanVien