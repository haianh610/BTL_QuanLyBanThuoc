USE [QuanLyKhoThuocTay]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHD]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDHD]()
RETURNS VARCHAR(5)
AS
BEGIN
    DECLARE @ID VARCHAR(4)

    IF (SELECT COUNT(*) FROM tblHoaDon) = 0
        SET @ID = '0'
    ELSE
        SELECT @ID = MAX(RIGHT(sMaHD,2)) FROM tblHoaDon

    SELECT @ID = CASE
        WHEN @ID >= 0 AND @ID < 9 THEN 'DH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
        WHEN @ID >= 9 THEN 'DH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
    END

    RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDLH]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDLH]()
RETURNS VARCHAR(4)
AS
BEGIN
    DECLARE @ID VARCHAR(4)

    IF (SELECT COUNT(*) FROM tblLoaiHang) = 0
        SET @ID = '0'
    ELSE
        SELECT @ID = MAX(RIGHT(sMaLH,2)) FROM tblLoaiHang

    SELECT @ID = CASE
        WHEN @ID >= 0 AND @ID < 9 THEN 'LH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
        WHEN @ID >= 9 THEN 'LH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
    END

    RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDPN]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[AUTO_IDPN]()
RETURNS VARCHAR(4)
AS
BEGIN
    DECLARE @ID VARCHAR(4)

    IF (SELECT COUNT(*) FROM tblPhieuNhap) = 0
        SET @ID = '0'
    ELSE
        SELECT @ID = MAX(RIGHT(sMaPN,2)) FROM tblPhieuNhap

    SELECT @ID = CASE
        WHEN @ID >= 0 AND @ID < 9 THEN 'PN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
        WHEN @ID >= 9 THEN 'PN' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
    END

    RETURN @ID
END
GO
/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDon](
	[sMaHD] [varchar](20) NOT NULL,
	[sMaHang] [varchar](20) NOT NULL,
	[iSoLuong] [int] NULL,
	[fThanhTien] [float] NULL,
 CONSTRAINT [PK_tblChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[sMaHD] ASC,
	[sMaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[sMaHD] [varchar](20) NOT NULL,
	[sMaNV] [varchar](20) NOT NULL,
	[sMaKH] [varchar](20) NULL,
	[dNgayLap] [datetime] NULL,
	[fTongTienHD] [float] NULL,
	[iTrangThai] [int] NOT NULL,
	[iPhuongThucThanhToan] [int] NULL,
	[fKhachThanhToan] [float] NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[sMaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[sMaKH] [varchar](20) NOT NULL,
	[sTenKH] [nvarchar](300) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSDT] [varchar](11) NULL,
	[iNamsinh] [int] NULL,
	[iGioiTinh] [int] NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[sMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiHang](
	[sMaLH] [varchar](20) NOT NULL,
	[sTenLH] [nvarchar](300) NULL,
	[iTrangThai] [int] NULL,
 CONSTRAINT [PK_tblLoaiHang] PRIMARY KEY CLUSTERED 
(
	[sMaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[sMaNCC] [varchar](20) NOT NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSdtNCC] [varchar](11) NULL,
	[sTenNCC] [nvarchar](300) NULL,
	[iTrangThai] [int] NULL,
	[sMaSoThue] [varchar](50) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[sMaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[sMaNV] [varchar](20) NOT NULL,
	[sTenNV] [nvarchar](300) NULL,
	[iGioiTinh] [int] NULL,
	[dNgaySinh] [datetime] NULL,
	[sChucVu] [nvarchar](30) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[dNgayVaoLam] [datetime] NULL,
	[sSDT] [varchar](11) NULL,
	[iTrangThai] [int] NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMatHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMatHang](
	[sMaHang] [varchar](20) NOT NULL,
	[sMaLH] [varchar](20) NULL,
	[sTenHang] [nvarchar](300) NULL,
	[sHangSX] [nvarchar](50) NULL,
	[sDVT] [nvarchar](20) NULL,
	[fDonGia] [float] NULL,
	[iSoLuong] [int] NULL,
	[sMaNCC] [varchar](20) NULL,
	[iTrangThai] [int] NULL,
 CONSTRAINT [PK_tblMatHang] PRIMARY KEY CLUSTERED 
(
	[sMaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwHoaDonBanHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwHoaDonBanHang]
as
	select
	CTHD.sMaHD as [Mã Hóa Đơn],
	dNgayLap as [Ngày Lập],
	sTenKH as [Tên Khách Hàng],
	sTenNV as [Người Nhập],
	sTenLH as [Loại Hàng], 
	sTenHang as [Mặt Hàng], 
	CTHD.iSoLuong as [Số Lượng], 
	sDVT as [Đơn Vị], 
	fDonGia as [Đơn Giá], 
	sHangSX as [Hãng SX],
	sTenNCC as [Nhà Cung Cấp],
	fTongTienHD as [Tổng Tiền]
	from tblChiTietHoaDon as CTHD
	join tblHoaDon as HD on CTHD.sMaHD = HD.sMaHD
	join tblNhanVien as NV on HD.sMaNV = NV.sMaNV
	join tblKhachHang as KH on HD.sMaKH = KH.sMaKH
	join tblMatHang as MH on CTHD.sMaHang = MH.sMaHang
	join tblLoaiHang as LH on MH.sMaLH = LH.sMaLH
	join tblNhaCungCap as NCC on MH.sMaNCC = NCC.sMaNCC
GO
/****** Object:  View [dbo].[vwNhaCungCap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vwNhaCungCap]
as
	select 
	sMaNCC as [Mã Nhà Cung Cấp] , 
	sTenNCC as [Tên Nhà Cung Cấp], 
	sDiaChi as [Địa Chỉ], 
	sSdtNCC as [Số Điện Thoại],
	iTrangThai AS [Trạng Thái],
    sMaSoThue AS [Mã số thuế]
	from tblNhaCungCap
GO
/****** Object:  View [dbo].[vwMatHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwMatHang]
as
	select 
	sMaHang as [Mã Mặt Hàng],
	sTenLH as [Phân Loại], 
	sTenHang as [Tên Mặt Hàng], 
	iSoLuong as [Số Lượng], 
	sDVT as [Đơn Vị], 
	fDonGia as [Đơn Giá], 
	sHangSX as [Hãng SX],
	sTenNCC as [Nhà Cung Cấp],
	MH.iTrangThai AS [Trạng Thái] 

	
	from tblMatHang as MH
	join tblLoaiHang as LH on MH.sMaLH = LH.sMaLH
	join tblNhaCungCap as NCC on MH.sMaNCC = NCC.sMaNCC
GO
/****** Object:  View [dbo].[vwLoaiHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwLoaiHang]
as
	select 
	sMaLH AS [Mã Loại Hàng],
    sTenLH AS [Tên Loại Hàng],
    iTrangThai AS [Trạng Thái] 
	from tblLoaiHang
GO
/****** Object:  View [dbo].[VW_SoLanMuaHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SoLanMuaHang]
AS
	SELECT tblKhachHang.sMaKH, sTenKH , COUNT(tblKhachHang.sMaKH) AS [Số lần mua]
	FROM tblKhachHang INNER JOIN tblHoaDon ON tblKhachHang.sMaKH = tblHoaDon.sMaKH
	GROUP BY tblKhachHang.sMaKH, sTenKH
GO
/****** Object:  View [dbo].[VW_KH_MuaHangNhieuNhat]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_KH_MuaHangNhieuNhat]
AS
SELECT KH.sMaKH , sTenKH , COUNT(sMaHD) AS [Số Lần Mua] FROM tblKhachHang AS KH
JOIN tblHoaDon AS HD ON KH.sMaKH = HD.sMaKH
GROUP BY KH.sMaKH , sTenKH
HAVING COUNT(sMaHD) = ( SELECT MAX(SHD) FROM ( SELECT COUNT(sMaHD) AS SHD FROM tblHoaDon GROUP BY sMaKH ) as ListSHD )
GO
/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[sMaPN] [varchar](20) NOT NULL,
	[sMaHang] [varchar](20) NOT NULL,
	[fGiaNhap] [float] NULL,
	[iSoLuong] [int] NULL,
	[fThanhTien] [float] NULL,
	[dNSX] [datetime] NULL,
	[dHSD] [datetime] NULL,
 CONSTRAINT [PK_tblChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[sMaPN] ASC,
	[sMaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[sMaPN] [varchar](20) NOT NULL,
	[sMaNV] [varchar](20) NULL,
	[dNgayNhap] [datetime] NULL,
	[sMaNCC] [varchar](20) NULL,
	[fTongTienPN] [float] NULL,
	[iTrangThai] [int] NULL,
	[iPhuongThucThanhToan] [int] NULL,
	[fKhachThanhToan] [float] NULL,
 CONSTRAINT [PK_tblPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[sMaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_TongTienHang_MatHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TongTienHang_MatHang]
AS
	SELECT PN.sMaPN,sMaNV,SUM(fGiaNhap*iSoLuong) AS [Tổng tiền hàng], SUM(iSoLuong) AS [Tổng Mặt Hàng] FROM tblPhieuNhap AS PN 
	LEFT JOIN tblChiTietPhieuNhap AS CTPN ON PN.sMaPN = CTPN.sMaPN
	GROUP BY PN.sMaPN,sMaNV
GO
/****** Object:  View [dbo].[VW_SoMatHang_LoaiHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SoMatHang_LoaiHang]
AS
	SELECT sTenLH, SUM(iSoLuong) AS [Số Lượng] FROM tblLoaiHang 
	LEFT JOIN tblMatHang ON tblLoaiHang.sMaLH = tblMatHang.sMaLH
	GROUP BY tblLoaiHang.sMaLH, tblLoaiHang.sTenLH
GO
/****** Object:  View [dbo].[VW_SoLuongLoaiHangDaBan]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SoLuongLoaiHangDaBan]
AS
	SELECT tblLoaiHang.sTenLH, SUM(tblChiTietHoaDon.iSoLuong) AS [Tổng số lượng] FROM tblHoaDon, tblChiTietHoaDon, tblMatHang, tblLoaiHang
	WHERE tblHoaDon.sMaHD = tblChiTietHoaDon.sMaHD
	AND tblChiTietHoaDon.sMaHang = tblMatHang.sMaHang
	AND tblMatHang.sMaLH = tblLoaiHang.sMaLH
	AND YEAR(tblHoaDon.dNgayLap) = 2022
	GROUP BY tblHoaDon.sMaHD, tblLoaiHang.sTenLH
GO
/****** Object:  View [dbo].[VW_DoanhThuTheoNam]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_DoanhThuTheoNam]
AS
	SELECT YEAR(tblHoaDon.dNgayLap) AS [Năm], SUM(fThanhTien) AS [Doanh Thu] FROM tblHoaDon 
	JOIN tblChiTietHoaDon AS CTHD ON tblHoaDon.sMaHD = CTHD.sMaHD
	WHERE YEAR(tblHoaDon.dNgayLap) = 2022
	GROUP BY YEAR(tblHoaDon.dNgayLap)
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[sMaNV] [varchar](20) NOT NULL,
	[sPassword] [varchar](12) NOT NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH01', N'M01L04', 1, 3600)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH01', N'M02L04', 2, 4800)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH02', N'M01L02', 1, 1500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH02', N'M01L04', 4, 14400)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH03', N'M02L04', 2, 4800)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH03', N'M03L03', 3, 29400)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH04', N'M02L05', 1, 6000)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH04', N'M03L03', 5, 49000)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH05', N'M01L02', 1, 1500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH09                ', N'M01L01              ', 1, 7500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH12                ', N'M01L02              ', 1, 1500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH14                ', N'M01L02              ', 1, 1500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH15                ', N'M01L05              ', 1, 7000)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH15                ', N'M02L01              ', 1, 2500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH16                ', N'M01L01              ', 1, 7500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH16                ', N'M01L02              ', 1, 1500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH16                ', N'M01L05              ', 1, 7000)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH16                ', N'M02L01              ', 1, 2500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH17                ', N'M01L05              ', 3, 21000)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH18', N'M01L01', 3, 22500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH18                ', N'M02L01              ', 1, 2500)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH18', N'M03L02', 1, 6600)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH20                ', N'M01L04              ', 2, 7200)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH21                ', N'M03L02              ', 2, 13200)
INSERT [dbo].[tblChiTietHoaDon] ([sMaHD], [sMaHang], [iSoLuong], [fThanhTien]) VALUES (N'DH21                ', N'M03L04              ', 1, 2500)
GO
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN01', N'M01L04', 3000, 10, 30000, CAST(N'2022-06-15T00:00:00.000' AS DateTime), CAST(N'2024-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN01', N'M02L04', 2000, 12, 24000, CAST(N'2022-07-15T00:00:00.000' AS DateTime), CAST(N'2024-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN02', N'M02L05', 5500, 9, 49500, CAST(N'2022-12-24T00:00:00.000' AS DateTime), CAST(N'2024-12-24T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN02', N'M03L05', 8000, 8, 64000, CAST(N'2022-12-22T00:00:00.000' AS DateTime), CAST(N'2024-12-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN03', N'M01L02', 1000, 13, 13000, CAST(N'2022-10-05T00:00:00.000' AS DateTime), CAST(N'2024-10-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN04', N'M03L02', 6000, 9, 54000, CAST(N'2022-12-05T00:00:00.000' AS DateTime), CAST(N'2024-12-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN05', N'M02L01', 2000, 12, 24000, CAST(N'2022-03-13T00:00:00.000' AS DateTime), CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN05', N'M03L03', 9000, 10, 90000, CAST(N'2022-08-18T00:00:00.000' AS DateTime), CAST(N'2024-08-18T00:00:00.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN06', N'M01L02', 2000, 2, 4000, CAST(N'2024-04-03T01:22:55.000' AS DateTime), CAST(N'2029-07-13T01:22:55.000' AS DateTime))
INSERT [dbo].[tblChiTietPhieuNhap] ([sMaPN], [sMaHang], [fGiaNhap], [iSoLuong], [fThanhTien], [dNSX], [dHSD]) VALUES (N'PN06', N'M01L03', 200, 1, 200, CAST(N'2024-04-18T01:35:39.000' AS DateTime), CAST(N'2029-11-23T01:35:39.000' AS DateTime))
GO
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH01', N'BH01', N'KH01', CAST(N'2023-10-21T00:00:00.000' AS DateTime), 8400, 1, 1, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH02', N'BH02', N'KH02', CAST(N'2023-10-10T00:00:00.000' AS DateTime), 15900, 1, 2, 15900)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH03', N'BH03', N'KH03', CAST(N'2022-12-24T00:00:00.000' AS DateTime), 34200, 1, 3, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH04', N'BH01', N'KH04', CAST(N'2023-05-25T00:00:00.000' AS DateTime), 55000, 1, 1, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH05', N'BH02', N'KH05', CAST(N'2023-05-21T00:00:00.000' AS DateTime), 1500, 1, 2, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH06', N'BH01                ', NULL, CAST(N'2024-03-28T00:13:33.000' AS DateTime), 0, 2, 0, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH09', N'BH01                ', NULL, CAST(N'2024-03-28T00:40:49.000' AS DateTime), 7500, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH10', N'BH01                ', NULL, CAST(N'2024-03-28T01:00:07.000' AS DateTime), 0, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH11', N'BH01                ', NULL, CAST(N'2024-03-28T01:03:33.000' AS DateTime), 0, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH12', N'BH01                ', N'KH07                ', CAST(N'2024-03-28T01:14:26.000' AS DateTime), 1500, 1, 2, 2000)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH13', N'BH01                ', NULL, CAST(N'2024-03-28T10:39:04.000' AS DateTime), 0, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH14', N'BH01                ', N'KH04                ', CAST(N'2024-03-28T10:40:19.000' AS DateTime), 1500, 1, 0, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH15', N'BH01                ', NULL, CAST(N'2024-03-28T10:47:56.000' AS DateTime), 9500, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH16', N'BH02', NULL, CAST(N'2024-03-29T22:22:48.000' AS DateTime), 18500, 0, 0, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH17', N'BH03                ', N'KH02                ', CAST(N'2024-04-01T10:07:37.000' AS DateTime), 21000, 1, 1, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH18', N'BH01                ', NULL, CAST(N'2024-04-15T23:36:54.000' AS DateTime), 31600, 0, 1, 0)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH19', N'BH01', NULL, CAST(N'2024-04-16T11:42:56.000' AS DateTime), 0, 2, 0, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH20', N'BH01', NULL, CAST(N'2025-05-17T16:15:54.000' AS DateTime), 7200, 0, 0, NULL)
INSERT [dbo].[tblHoaDon] ([sMaHD], [sMaNV], [sMaKH], [dNgayLap], [fTongTienHD], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'DH21', N'BH01', NULL, CAST(N'2025-05-17T16:19:39.000' AS DateTime), 15700, 0, 0, NULL)
GO
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH01', N'Nguyễn Thế Công', N'Can Lộc-Hà Tĩnh', N'0755123456', 2004, 1)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH02', N'Nguyễn Văn Huy', N'Hoàng Mai-Hà Nội', N'0755123555', 1999, 1)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH03', N'Trần Văn Anh', N'Cầu Giấy-Hà Nội', N'0799123456', 1992, 1)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH04', N'Nguyễn Thị Hoa', N'Mỹ Đình-Hà Nội', N'0855123456', 2000, 0)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH05', N'Trần Thị Mai', N'Hoàng Mai-Hà Nội', N'0955123456', 1998, 0)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH06', N'Nguyễn Yến Nhi', N'Hoàng Mai-Hà Nội', N'0755123123', 1997, 0)
INSERT [dbo].[tblKhachHang] ([sMaKH], [sTenKH], [sDiaChi], [sSDT], [iNamsinh], [iGioiTinh]) VALUES (N'KH07', N'Lê Thành Nam', N'Hoàng Mai-Hà Nội', N'0666123123', 2004, 1)
GO
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH01', N'Hệ hô hấp', 1)
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH02', N'Hệ cơ xương', 1)
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH03', N'Dị ứng & Hệ miễn dịch', 1)
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH04', N'Hệ tim mạch và máu', 2)
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH05', N'Thuốc mắt', 1)
INSERT [dbo].[tblLoaiHang] ([sMaLH], [sTenLH], [iTrangThai]) VALUES (N'LH06', N'Thuốc ga', 0)
GO
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M01L01', N'LH01', N'Siro Ambroxol Danapha', N'HSX01', N'Hộp', 7500, 1, N'CC01', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M01L02', N'LH02', N'Calcium - D S.Pharm', N'HSX05', N'Hộp', 1500, 12, N'CC05', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M01L03', N'LH03', N'Siro Deslotid OPV', N'HSX03', N'Chai', 5300, 17, N'CC03', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M01L04', N'LH04', N'Clopidogrel 75 - MV USP', N'HSX04', N'Hộp', 3600, 2, N'CC04', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M01L05', N'LH05', N'Thuốc nhỏ mắt Eyemiru 40 EX', N'HSX01', N'Lọ', 7000, 6, N'CC01', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M02L01', N'LH01', N'Siro HoAstex OPC', N'HSX01', N'Hộp', 2500, 15, N'CC01', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M02L02', N'LH02', N'Alpha-Chymotrypsin Euvipharm', N'HSX05', N'Hộp', 1900, 15, N'CC05', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M02L03', N'LH03', N'Thuốc Histalong - L 5mg Dr. Reddy', N'HSX03', N'Hộp', 6400, 19, N'CC03', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M02L04', N'LH04', N'Viên nén Losartan 25mg TV.Pharm', N'HSX05', N'Hộp', 2400, 12, N'CC05', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M02L05', N'LH05                ', N'Thuốc nhỏ mắt V.Rohto Vitamin', N'HSX06', N'Lọ', 6000, 3, N'CC06      ', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M03L01', N'LH01', N'Dung dịch VS mũi Nasomom', N'HSX02', N'Lọ', 3000, 15, N'CC02', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M03L02', N'LH02', N'Calcium Corbière Extra Sanofi', N'HSX05', N'Hộp', 6600, 17, N'CC05', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M03L03', N'LH03', N'Telfast HD 180mg Sanofi', N'HSX02', N'Hộp', 9800, 12, N'CC02', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M03L04', N'LH04', N'Dacolfort Danapha', N'HSX06', N'Hộp', 2500, 10, N'CC06', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M03L05', N'LH05', N'Thuốc nhỏ mắt, mũi Natri Clorid', N'HSX06', N'Lọ', 9000, 16, N'CC06', 1)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M04L01', N'LH01', N'Siro Ambroxol Danapha', N'HSX02', N'Hộp', 4000, 15, N'CC02', 2)
INSERT [dbo].[tblMatHang] ([sMaHang], [sMaLH], [sTenHang], [sHangSX], [sDVT], [fDonGia], [iSoLuong], [sMaNCC], [iTrangThai]) VALUES (N'M05L01', N'LH01', N'Eugica MEGA', N'HSX02', N'Hộp', 8000, 15, N'CC02', 0)
GO
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC0', N'Hồ Chí Minh', N'0666123354', N'CTCP Thảo Dược An Nhiên', 1, N'T08')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC01', N'Yên Bái', N'0888123888', N'CTCP Dược Phẩm Yên Bái - Ypharco', 1, N'T01')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC02', N'Hà Nội', N'0777123777', N'CTCP Dưỡng Dược Vĩnh Kim', 1, N'T02')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC03', N'Đà Nẵng', N'0888123555', N'CTCP Dược Phẩm Tâm Sen', 1, N'T03')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC04', N'Đà Nẵng', N'0888123333', N'CTCP TM Dược Phẩm Ngọc Đông', 2, N'T04')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC05', N'Bắc Ninh', N'0666123666', N'CTCP Y Dược Thita', 1, N'T05')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC06', N'Hà Nội', N'0666123334', N'CTCP Thảo Dược An Bình', 1, N'T07')
INSERT [dbo].[tblNhaCungCap] ([sMaNCC], [sDiaChi], [sSdtNCC], [sTenNCC], [iTrangThai], [sMaSoThue]) VALUES (N'CC08', N'Hồ Chí Minh', N'0666123354', N'CTCP Thảo Dược An Nhiên', 2, N'T08')
GO
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'BH01', N'Nguyễn Thế Nam', 0, CAST(N'2003-10-06T00:00:00.000' AS DateTime), N'Nhân viên bán hàng', N'Hà Nội', CAST(N'2023-10-10T00:00:00.000' AS DateTime), N'0799123456', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'BH02', N'Nguyễn Thị Hà', 1, CAST(N'2002-10-05T00:00:00.000' AS DateTime), N'Nhân viên bán hàng', N'Hải Dương', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'07991234551', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'BH03', N'Nguyễn Thúy Hằng', 1, CAST(N'1995-03-10T00:00:00.000' AS DateTime), N'Nhân viên bán hàng', N'Hà Nội', CAST(N'2023-01-01T00:00:00.000' AS DateTime), N'07991234441', 2)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'BH04', N'Nguyễn Hoàng Hải Anh', 0, CAST(N'2004-10-06T00:00:00.000' AS DateTime), N'Nhân viên bán hàng', N'Hà Nội', CAST(N'2024-04-16T00:00:00.000' AS DateTime), N'0369061004', 2)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'BH05', N'Nguyễn Hoàng Xuân Lâm', 0, CAST(N'2003-12-08T00:00:00.000' AS DateTime), N'Nhân viên bán hàng', N'Hà Nội', CAST(N'2024-04-16T00:00:00.000' AS DateTime), N'0904006069', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'NH01', N'Trần Sỹ Việt', 0, CAST(N'1993-04-07T00:00:00.000' AS DateTime), N'Nhân viên nhập hàng', N'Hà Tĩnh', CAST(N'2021-01-10T00:00:00.000' AS DateTime), N'07991236661', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'NH02', N'Nguyễn Thế Chiến', 0, CAST(N'1999-04-15T00:00:00.000' AS DateTime), N'Nhân viên nhập hàng', N'Hà Tĩnh', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'09991234551', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'NH03', N'Trần Hữu Duy', 0, CAST(N'2004-04-07T00:00:00.000' AS DateTime), N'Nhân viên nhập hàng', N'Hà Nam', CAST(N'2023-01-10T00:00:00.000' AS DateTime), N'09991236661', 1)
INSERT [dbo].[tblNhanVien] ([sMaNV], [sTenNV], [iGioiTinh], [dNgaySinh], [sChucVu], [sDiaChi], [dNgayVaoLam], [sSDT], [iTrangThai]) VALUES (N'QL01', N'Nguyễn Ngọc Nhung', 1, CAST(N'2002-11-09T00:00:00.000' AS DateTime), N'Quản lý', N'Hà Nội', CAST(N'2023-01-12T00:00:00.000' AS DateTime), N'06661236661', 1)
GO
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN01', N'NH01', CAST(N'2023-10-10T00:00:00.000' AS DateTime), N'CC01', 54000, 1, 1, 60000)
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN02', N'NH02', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'CC02', 113500, 1, 2, 113500)
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN03', N'NH03', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'CC03', 13000, 1, 3, 13000)
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN04', N'NH01', CAST(N'2023-09-22T00:00:00.000' AS DateTime), N'CC04', 54000, 1, 1, 60000)
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN05', N'NH02', CAST(N'2023-03-17T00:00:00.000' AS DateTime), N'CC05', 114000, 2, 1, 120000)
INSERT [dbo].[tblPhieuNhap] ([sMaPN], [sMaNV], [dNgayNhap], [sMaNCC], [fTongTienPN], [iTrangThai], [iPhuongThucThanhToan], [fKhachThanhToan]) VALUES (N'PN06', N'BH01                ', CAST(N'2024-04-19T00:31:14.000' AS DateTime), N'CC04                ', 200, 2, 1, 200)
GO
INSERT [dbo].[tblUser] ([sMaNV], [sPassword]) VALUES (N'BH02', N'babara123')
INSERT [dbo].[tblUser] ([sMaNV], [sPassword]) VALUES (N'BH03', N'thuyhang1603')
INSERT [dbo].[tblUser] ([sMaNV], [sPassword]) VALUES (N'NH01', N'binbin')
INSERT [dbo].[tblUser] ([sMaNV], [sPassword]) VALUES (N'NH03', N'thd070404')
INSERT [dbo].[tblUser] ([sMaNV], [sPassword]) VALUES (N'QL01', N'246135      ')
GO
ALTER TABLE [dbo].[tblHoaDon] ADD  CONSTRAINT [DEFAULT_tblHoaDon_sMaHD]  DEFAULT ([DBO].[AUTO_IDHD]()) FOR [sMaHD]
GO
ALTER TABLE [dbo].[tblHoaDon] ADD  CONSTRAINT [DEFAULT_tblHoaDon_fTongTienHD]  DEFAULT ((0)) FOR [fTongTienHD]
GO
ALTER TABLE [dbo].[tblHoaDon] ADD  CONSTRAINT [DEFAULT_tblHoaDon_iTrangThai]  DEFAULT ((0)) FOR [iTrangThai]
GO
ALTER TABLE [dbo].[tblHoaDon] ADD  CONSTRAINT [DEFAULT_tblHoaDon_iPhuongThucThanhToan]  DEFAULT ((0)) FOR [iPhuongThucThanhToan]
GO
ALTER TABLE [dbo].[tblLoaiHang] ADD  CONSTRAINT [DEFAULT_tblLoaiHang_sMaLH]  DEFAULT ([dbo].[AUTO_IDLH]()) FOR [sMaLH]
GO
ALTER TABLE [dbo].[tblLoaiHang] ADD  CONSTRAINT [DEFAULT_tblLoaiHang_iTrangThai]  DEFAULT ((0)) FOR [iTrangThai]
GO
ALTER TABLE [dbo].[tblMatHang] ADD  CONSTRAINT [DEFAULT_tblMatHang_iTrangThai]  DEFAULT ((0)) FOR [iTrangThai]
GO
ALTER TABLE [dbo].[tblNhaCungCap] ADD  CONSTRAINT [DEFAULT_tblNhaCungCap_iTrangThai]  DEFAULT ((0)) FOR [iTrangThai]
GO
ALTER TABLE [dbo].[tblPhieuNhap] ADD  CONSTRAINT [DEFAULT_tblPhieuNhap_sMaPN]  DEFAULT ([DBO].[AUTO_IDPN]()) FOR [sMaPN]
GO
ALTER TABLE [dbo].[tblPhieuNhap] ADD  CONSTRAINT [DEFAULT_tblPhieuNhap_fTongTienPN]  DEFAULT ((0)) FOR [fTongTienPN]
GO
ALTER TABLE [dbo].[tblPhieuNhap] ADD  CONSTRAINT [DEFAULT_tblPhieuNhap_iTrangThai]  DEFAULT ((0)) FOR [iTrangThai]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MatHang] FOREIGN KEY([sMaHang])
REFERENCES [dbo].[tblMatHang] ([sMaHang])
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MatHang]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTHoaDon_HoaDon] FOREIGN KEY([sMaHD])
REFERENCES [dbo].[tblHoaDon] ([sMaHD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietTHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_MatHang] FOREIGN KEY([sMaHang])
REFERENCES [dbo].[tblMatHang] ([sMaHang])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_MatHang]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([sMaPN])
REFERENCES [dbo].[tblPhieuNhap] ([sMaPN])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([sMaKH])
REFERENCES [dbo].[tblKhachHang] ([sMaKH])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[tblNhanVien] ([sMaNV])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[tblMatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiHang] FOREIGN KEY([sMaLH])
REFERENCES [dbo].[tblLoaiHang] ([sMaLH])
GO
ALTER TABLE [dbo].[tblMatHang] CHECK CONSTRAINT [FK_MatHang_LoaiHang]
GO
ALTER TABLE [dbo].[tblMatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_NhaCungCap] FOREIGN KEY([sMaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([sMaNCC])
GO
ALTER TABLE [dbo].[tblMatHang] CHECK CONSTRAINT [FK_MatHang_NhaCungCap]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([sMaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([sMaNCC])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[tblNhanVien] ([sMaNV])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblNhanVien] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[tblNhanVien] ([sMaNV])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblNhanVien]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [CK_SoLuongNhap] CHECK  (([iSoLuong]>(0)))
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [CK_SoLuongNhap]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [CK_dNgayLap] CHECK  (([dNgayLap]<=getdate()))
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [CK_dNgayLap]
GO
ALTER TABLE [dbo].[tblMatHang]  WITH CHECK ADD  CONSTRAINT [CK_DonGia] CHECK  (([fDonGia]>=(0)))
GO
ALTER TABLE [dbo].[tblMatHang] CHECK CONSTRAINT [CK_DonGia]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [CK_TuoiNhanVien] CHECK  ((datediff(day,[dNgaySinh],[dNgayVaoLam])/(365)>=(18)))
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [CK_TuoiNhanVien]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [CK_NgayNhap] CHECK  (([dNgayNhap]<=getdate()))
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [CK_NgayNhap]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoHangHoaNhapXuat]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BaoCaoHangHoaNhapXuat]
(@NgayBD datetime, @NgayKT datetime, @NguoiLap nvarchar(100))
as
begin
	select
	@NgayBD as [Ngày bắt đầu],
	@NgayKT as [Ngày kết thúc],
	@NguoiLap as [Người lập],
	--CONCAT(@NgayBD, '_', @NgayKT) as [Thời gian],
	MH.sTenHang as [Tên mặt hàng],
	sum(case when PN.dNgayNhap between @NgayBD and @NgayKT 
		then CTPN.iSoLuong else 0 end) as [Tổng SL nhập],
	sum(case when PN.dNgayNhap between @NgayBD and @NgayKT
		then PN.fTongTienPN else 0 end) as [Tổng tiền nhập],
	sum(case when HD.dNgayLap between @NgayBD and @NgayKT 
		then CTHD.iSoLuong else 0 end) as [Tổng SL xuất],
	sum(case when HD.dNgayLap between @NgayBD and @NgayKT
		then HD.fTongTienHD else 0 end) as [Tổng tiền xuất]
	
	from tblMatHang				as MH 
	left join tblChiTietPhieuNhap	as CTPN on MH.sMaHang = CTPN.sMaHang
	left join tblPhieuNhap			as PN	on CTPN.sMaPN = PN.sMaPN
	left join tblChiTietHoaDon		as CTHD	on MH.sMaHang = CTHD.sMaHang
	left join tblHoaDon				as HD	on CTHD.sMaHD = HD.sMaHD
	group by MH.sTenHang
end
GO
/****** Object:  StoredProcedure [dbo].[HoaDonBanHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HoaDonBanHang]
(@sMaHD char(20))
as
begin
	select
	CTHD.sMaHD as [Mã Hóa Đơn],
	dNgayLap as [Ngày Lập],
	sTenKH as [Tên Khách Hàng],
	KH.sDiaChi as [Địa Chỉ],
	KH.sSdt as [Số Điện Thoại],
	sTenNV as [Người Nhập],
	sTenLH as [Loại Hàng], 
	sTenHang as [Mặt Hàng], 
	CTHD.iSoLuong as [Số Lượng], 
	sDVT as [Đơn Vị], 
	fDonGia as [Đơn Giá], 
	sHangSX as [Hãng SX],
	sTenNCC as [Nhà Cung Cấp],
	CTHD.fThanhTien as [Thành Tiền],
	fTongTienHD as [Tổng Tiền]
	from tblChiTietHoaDon as CTHD
	join tblHoaDon as HD on CTHD.sMaHD = HD.sMaHD
	join tblNhanVien as NV on HD.sMaNV = NV.sMaNV
	join tblKhachHang as KH on HD.sMaKH = KH.sMaKH
	join tblMatHang as MH on CTHD.sMaHang = MH.sMaHang
	join tblLoaiHang as LH on MH.sMaLH = LH.sMaLH
	join tblNhaCungCap as NCC on MH.sMaNCC = NCC.sMaNCC
	where CTHD.sMaHD = @sMaHD
end
GO
/****** Object:  StoredProcedure [dbo].[pr_HuyPN]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_HuyPN]
    @MaPN CHAR(20)
AS
BEGIN
    UPDATE tblPhieuNhap
    SET
    --Trạng thái hủy
        iTrangThai = 2
    WHERE sMaPN = @MaPN
END
GO
/****** Object:  StoredProcedure [dbo].[prTimKiemTheoTen]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[prTimKiemTheoTen]
@sTenLH Nvarchar(30)
as
begin
	select * from tblLoaiHang where sTenLH like '%'+ @sTenLH+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon]
    @maHD CHAR(20)
AS
BEGIN
    SELECT cthd.sMaHD,
           cthd.sMaHang AS [Mã hàng],
           mh.sTenHang AS [Tên hàng],
           mh.fDonGia AS [Đơn giá],
           cthd.iSoLuong AS [Số lượng],
           cthd.fThanhTien AS [Thành tiền]
    FROM tblChiTietHoaDon cthd
    JOIN tblMatHang mh ON cthd.sMaHang = mh.sMaHang
    WHERE cthd.sMaHD = @maHD;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ChiTietPhieuNhap]
    @maPN CHAR(20)
AS
BEGIN
    SELECT ctpn.sMaPN,
           ctpn.sMaHang AS [Mã hàng],
           mh.sTenHang AS [Tên hàng],
		   ctpn.fGiaNhap AS [Giá nhập vào],
           ctpn.iSoLuong AS [Số lượng],
           ctpn.fThanhTien AS [Thành tiền],
		   ctpn.dNSX AS [Ngày sản xuất],
		   ctpn.dHSD AS [Hạn sử dụng]
    FROM tblChiTietPhieuNhap ctpn
    JOIN tblMatHang mh ON ctpn.sMaHang = mh.sMaHang
    WHERE ctpn.sMaPN = @maPN;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InHangNCC]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_InHangNCC](@maNCC VARCHAR(20))
AS
BEGIN
SELECT 
    tblMatHang.*
FROM 
    tblMatHang
WHERE tblMatHang.sMaNCC = @maNCC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_InHoaDon](@maHD VARCHAR(20))
AS
BEGIN
SELECT 
    tblHoaDon.sMaHD, 
    tblHoaDon.sMaNV,
    tblNhanVien.sTenNV, 
    tblHoaDon.sMaKH,
    tblKhachHang.sTenKH, 
    tblHoaDon.dNgayLap,
    tblHoaDon.fTongTienHD,
    tblHoaDon.iPhuongThucThanhToan,
    tblHoaDon.fKhachThanhToan, 
    tblChiTietHoaDon.sMaHang,
    tblMatHang.sTenHang,
    tblChiTietHoaDon.iSoLuong,
    tblMatHang.fDonGia,
    tblChiTietHoaDon.fThanhTien
FROM 
    tblHoaDon 
INNER JOIN 
    tblNhanVien ON tblHoaDon.sMaNV = tblNhanVien.sMaNV 
INNER JOIN 
    tblKhachHang ON tblHoaDon.sMaKH = tblKhachHang.sMaKH
INNER JOIN 
    tblChiTietHoaDon ON tblHoaDon.sMaHD = tblChiTietHoaDon.sMaHD
INNER JOIN 
    tblMatHang ON tblChiTietHoaDon.sMaHang = tblMatHang.sMaHang
WHERE 
    tblHoaDon.sMaHD = @maHD;
END
GO
/****** Object:  StoredProcedure [dbo].[suaLoaiHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suaLoaiHang] 
(@sMaLH varchar(20) , @sTenLHmoi nvarchar(300))
as
begin
	update tblLoaiHang
	set sTenLH = 
		case
			when @sTenLHmoi is not null then @sTenLHmoi 
			else sTenLH
		end
	where
		sMaLH = @sMaLH
end
GO
/****** Object:  StoredProcedure [dbo].[suaMatHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suaMatHang]
(@sMaHang char(20),@sMaLHmoi char(20), @sTenHangmoi nvarchar(50), @sDVTmoi nvarchar(20), @fDonGiamoi float, @iSoLuongmoi int, @sHangSXmoi nvarchar(50), @sMaNCCmoi char(10) )
as
begin
	update tblMatHang
	set 
		sMaLH = COALESCE (@sMaLHmoi, sMaLH),
        sTenHang = COALESCE(@sTenHangmoi, sTenHang),
		iSoLuong = COALESCE(@iSoLuongmoi, iSoLuong),
        sDVT = COALESCE(@sDVTmoi, sDVT),
        fDonGia = COALESCE(@fDonGiamoi, fDonGia),
		sHangSX = COALESCE(@sHangSXmoi, sHangSX),
		sMaNCC = COALESCE(@sMaNCCmoi, sMaNCC)

    where
        sMaHang = @sMaHang;
	
end
GO
/****** Object:  StoredProcedure [dbo].[suaNhaCungCap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suaNhaCungCap]
(@sMaNCC varchar(20) , @sTenNCCmoi nvarchar(300), @sDiaChimoi nvarchar(50), @sSdtNCCmoi varchar(11),@sMaSoThue VARCHAR(50))
as
begin
	update tblNhaCungCap
	set 
        sTenNCC = COALESCE(@sTenNCCmoi, sTenNCC),
        sDiaChi = COALESCE(@sDiaChimoi, sDiaChi),
        sSdtNCC = COALESCE(@sSdtNCCmoi, sSdtNCC),
        sMaSoThue = COALESCE(@sMaSoThue, sMaSoThue)
    where
        sMaNCC = @sMaNCC;
	
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiem_DonGia]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[TimKiem_DonGia]
(@fDonGiaBD float, @fDonGiaKT float)
as
begin
	select * from tblMatHang
	where fDonGia between @fDonGiaBD and @fDonGiaKT 
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiem_TenHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[TimKiem_TenHang]
(@sTenHang nvarchar(50))
as
begin
		select * from tblMatHang where sTenHang like '%' + @sTenHang + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemLH]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[TimKiemLH]
    @inputValue NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    -- Tìm kiếm các mặt hàng tương tự trong bảng Mặt Hàng
    SELECT *
    FROM vwLoaiHang
    WHERE 
		[Mã Loại Hàng] like '%' + @inputValue + '%'
		or
		[Tên Loại Hàng] LIKE '%' + @inputValue + '%'
		
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemMH]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimKiemMH]
    @inputValue NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    -- Tìm kiếm các mặt hàng tương tự trong bảng Mặt Hàng
    SELECT *
    FROM vwMatHang
    WHERE 
		[Mã Mặt Hàng] like '%' + @inputValue + '%'
		or
		[Phân Loại] like '%' + @inputValue + '%'
		or
		[Tên Mặt Hàng] LIKE '%' + @inputValue + '%'
		or
		[Hãng SX] LIKE '%' + @inputValue + '%'
		or
		[Nhà Cung Cấp] LIKE '%' + @inputValue + '%'
		or
        -- Ví dụ: Kiểu dữ liệu int
        CAST([Số Lượng] AS NVARCHAR(MAX)) LIKE '%' + @inputValue + '%'
        OR
		[Đơn Vị] LIKE '%' + @inputValue + '%'
		or
		CAST([Đơn Giá] AS nvarchar(Max)) LIKE '%' + @inputValue + '%'
        -- Ví dụ: Kiểu dữ liệu datetime (sử dụng FORMAT để chuyển đổi datetime thành chuỗi)
        --FORMAT(column_datetime, 'yyyy-MM-dd HH:mm:ss') LIKE '%' + @inputValue + '%'
        -- Thêm điều kiện tương tự cho các kiểu dữ liệu khác nếu cần
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNCC]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimKiemNCC]
    @inputValue NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    -- Tìm kiếm các mặt hàng tương tự trong bảng Mặt Hàng
    SELECT *
    FROM vwNhaCungCap
    WHERE 
		[Mã Nhà Cung Cấp] like '%' + @inputValue + '%'
		or
		[Tên Nhà Cung Cấp] like '%' + @inputValue + '%'
		or
		[Địa Chỉ] LIKE '%' + @inputValue + '%'
		or
		[Số Điện Thoại] LIKE '%' + @inputValue + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[UP_CacMatHangKhongBanDuoc]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_CacMatHangKhongBanDuoc]
	(@month INT, @year INT)
AS
BEGIN
	SELECT * FROM tblMatHang
	WHERE tblMatHang.sMaHang NOT IN 
	(
	SELECT sMaHang FROM tblHoaDon AS HD, tblChiTietHoaDon AS CTHD 
	WHERE HD.sMaHD = CTHD.sMaHD
	AND MONTH(HD.dNgayLap) = @month
	AND YEAR(hd.dNgayLap) = @year
	GROUP BY CTHD.sMaHang
	)
END
GO
/****** Object:  StoredProcedure [dbo].[UP_CapNhapGia]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_CapNhapGia]
	(@MaHang CHAR(30), @DonGiaMoi FLOAT)
AS
BEGIN
	UPDATE tblMatHang SET fDonGia = @DonGiaMoi
	WHERE sMaHang = @MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[UP_HuyHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_HuyHoaDon]
    @maHD VARCHAR(20)
AS
BEGIN
    UPDATE tblHoaDon
    SET
    --Trạng thái hủy
        iTrangThai = 2
    WHERE sMaHD = @maHD
END
GO
/****** Object:  StoredProcedure [dbo].[UP_HuyThoiViecNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_HuyThoiViecNhanVien]
    @maNV VARCHAR(50)
AS
BEGIN
    UPDATE tblNhanVien
    SET
    --Trạng thái hủy
        iTrangThai = 1
    WHERE sMaNV = @maNV
END
GO
/****** Object:  StoredProcedure [dbo].[UP_NCCHangHoaTrongNam]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_NCCHangHoaTrongNam]
(@TenNhaCungCap NVARCHAR(30),@month INT , @year INT)
AS
BEGIN
	IF EXISTS (SELECT * FROM tblNhaCungCap WHERE @TenNhaCungCap NOT IN (SELECT sTenNCC from tblNhaCungCap) )
	PRINT N'Không tồn tại nhà cung cấp ' + @TenNhaCungCap
	ELSE
		BEGIN
			SELECT	sTenNCC,
					CONCAT(@month,'-',@year) AS [Thời Gian],
					SUM(CTPN.iSoLuong) AS [Tổng Hàng Nhập],
					SUM(CTPN.fGiaNhap * iSoLuong) AS [Tổng Tiền NH] 
			FROM tblPhieuNhap AS PN
			LEFT JOIN tblChiTietPhieuNhap AS CTPN	ON PN.sMaPN = CTPN.sMaPN
			LEFT JOIN tblNhaCungCap	AS NCC	ON PN.sMaNCC = NCC.sMaNCC
--			WHERE PN.sMaNCC = (SELECT sMaNCC FROM tblNhaCungCap WHERE NCC.sTenNCC = @TenNhaCungCap)
			WHERE NCC.sTenNCC = @TenNhaCungCap
			AND MONTH(PN.dNgayNhap) = @month
			AND YEAR(PN.dNgayNhap) = @year
			GROUP BY NCC.sTenNCC
		END
END
GO
/****** Object:  StoredProcedure [dbo].[UP_SuaChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UP_SuaChiTietPhieuNhap]
(@maPN VARCHAR(20),
    @maHang VARCHAR(20), 
	@giaNhap float,
    @soLuong INT, 
    @thanhTien float,
	@NSX DATETIME,
	@HSD DATETIME)
as
begin
	update tblChiTietPhieuNhap
	set 
		sMaPN = COALESCE(@maPN, sMaPN),
        sMaHang = COALESCE(@maHang, sMaHang),
		fGiaNhap = COALESCE(@giaNhap, fGiaNhap),
        iSoLuong = COALESCE(@soLuong, iSoLuong),
        fThanhTien = COALESCE(@thanhTien, fThanhTien),
		dNSX = COALESCE(@NSX, dNSX),
		dHSD = COALESCE(@HSD, dHSD)
    where
        sMaPN = @maPN;
	
end
GO
/****** Object:  StoredProcedure [dbo].[UP_SuaHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_SuaHoaDon]
	(@maHD CHAR(20),
    @maNV CHAR(20)=null, 
    @maKH CHAR(20)=NULL, 
    @ngayLap DATETIME,
    @tongTien FLOAT,
    @trangThai INT,
    @phuongThuc INT,
    @khachThanhToan FLOAT)
AS
BEGIN
    UPDATE tblHoaDon
    SET 
    sMaNV = @maNV,
    sMaKH = @maKH,
    dNgayLap = @ngayLap,
    fTongTienHD = @tongTien,
    iTrangThai = @trangThai,
    iPhuongThucThanhToan = @phuongThuc,
    fKhachThanhToan = @khachThanhToan
    WHERE sMaHD = @maHD
END
GO
/****** Object:  StoredProcedure [dbo].[UP_SuaNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_SuaNhanVien]
	(@maNV VARCHAR(20),
    @tenNV NVARCHAR(50), 
    @gioiTinh INT, 
    @ngaySinh DATETIME,
    @chucVu NVARCHAR(30),
    @diaChi NVARCHAR(50),
    @sdt CHAR(10),
    @ngayVaoLam DATE,
    @trangThai INT)
AS
BEGIN
    UPDATE tblNhanVien
    SET 
    sTenNV = @tenNV,
    iGioiTinh = @gioiTinh,
    dNgaySinh = @ngaySinh,
    sChucVu = @chucVu,
    sDiaChi = @diaChi,
    sSDT = @sdt,
    dNgayVaoLam = @ngayVaoLam,
    iTrangThai = @trangThai
    WHERE @maNV = sMaNV
END

GO
/****** Object:  StoredProcedure [dbo].[UP_SuaPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_SuaPhieuNhap]
	(@maPN CHAR(20),
    @maNV CHAR(20)=null, 
    @maNCC CHAR(20)=NULL, 
    @ngayNhap DATETIME,
    @tongTienPN FLOAT,
    @trangThai INT,
    @phuongThuc INT,
    @khachThanhToan FLOAT)
AS
BEGIN
    UPDATE tblPhieuNhap
    SET 
    sMaNV = @maNV,
    sMaNCC = @maNCC,
    dNgayNhap = @ngayNhap,
    fTongTienPN = @tongTienPN,
    iTrangThai = @trangThai,
    iPhuongThucThanhToan = @phuongThuc,
    fKhachThanhToan = @khachThanhToan
	WHERE sMaPN = @maPN
END
GO
/****** Object:  StoredProcedure [dbo].[UP_ThanhTienChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_ThanhTienChiTietPhieuNhap]
AS
BEGIN
    -- Tính toán thành tiền cho từng mặt hàng trong bảng ChiTietPhieuNhap
    INSERT INTO tblChiTietPhieuNhap(sMaPN, sMaHang, fGiaNhap, iSoLuong, fThanhTien, dNSX, dHSD)
    SELECT sMaPN, sMaHang, fGiaNhap, iSoLuong, fGiaNhap * iSoLuong AS fThanhTien, dNSX, dHSD
    FROM tblChiTietPhieuNhap
END
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemChiTietHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_ThemChiTietHoaDon]
	(@maHD CHAR(20),
    @maHang CHAR(20), 
    @soLuong INT)
AS
BEGIN
    INSERT INTO tblChiTietHoaDon(sMaHD,sMaHang,iSoLuong)
    VALUES (@maHD,@maHang,@soLuong)
END
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UP_ThemChiTietPhieuNhap]
	(@maPN VARCHAR(20),
    @maHang VARCHAR(20), 
	@giaNhap float,
    @soLuong INT, 
	@NSX DATETIME,
	@HSD DATETIME)

AS
BEGIN
    INSERT INTO tblChiTietPhieuNhap(sMaPN,sMaHang,fGiaNhap,iSoLuong, dNSX,dHSD)
    VALUES (@maPN,@maHang,@giaNhap,@soLuong,@NSX,@HSD)
END
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_ThemHoaDon]
    @maNV VARCHAR(20),
    @ngayLap DATETIME,
    @newMaHD VARCHAR(20) OUTPUT
AS
BEGIN
    -- Insert new record into tblHoaDon
    INSERT INTO tblHoaDon (sMaNV, dNgayLap) VALUES (@maNV, @ngayLap);

    -- Get the newly generated sMaHD
    SELECT @newMaHD =  MAX(sMaHD) FROM tblHoaDon; -- Assuming sMaHD is an identity column
END

GO
/****** Object:  StoredProcedure [dbo].[UP_ThemLH]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UP_ThemLH]
(@sTenLH nvarchar(300), @iTrangThai int)
as
begin
	insert into tblLoaiHang (sTenLH , iTrangThai)
	values					(@sTenLH, @iTrangThai)
end
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemMH]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[UP_ThemMH]
(@sMaLH varchar(20) , @sMaHang varchar(20), @sTenHang nvarchar(300), @sDVT nvarchar(20), @fDonGia float, @iSoLuong int, @sHangSX nvarchar(50), @sMaNCC varchar(20), @iTrangThai int)
as
begin
	insert into tblMatHang(sMaLH,sMaHang,sTenHang,iSoLuong,sDVT,fDonGia,sHangSX,sMaNCC, iTrangThai)
	values(@sMaLH, @sMaHang, @sTenHang, @iSoLuong, @sDVT, @fDonGia, @sHangSX, @sMaNCC, @iTrangThai)
end
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemNCC]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UP_ThemNCC]
(@sMaNCC varchar(20) , @sTenNCC nvarchar(300), @sDiaChi nvarchar(50), @sSdtNCC varchar(11), @iTrangThai int,@sMaSoThue varchar(50))
as
begin
	insert into tblNhaCungCap(sMaNCC, sTenNCC, sDiaChi, sSdtNCC, iTrangThai,sMaSoThue)
	values					(@sMaNCC, @sTenNCC, @sDiaChi,@sSdtNCC, @iTrangThai,@sMaSoThue)
end
GO
/****** Object:  StoredProcedure [dbo].[UP_ThemNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_ThemNhanVien]
	(@maNV VARCHAR(20),
    @tenNV NVARCHAR(50), 
    @gioiTinh INT, 
    @ngaySinh DATETIME,
    @chucVu NVARCHAR(30),
    @diaChi NVARCHAR(50),
    @sdt CHAR(10),
    @ngayVaoLam DATE,
    @trangThai INT)
AS
BEGIN
    INSERT INTO tblNhanVien(sMaNV, sTenNV, iGioiTinh, dNgaySinh, sChucVu, sDiaChi, sSDT, dNgayVaoLam,iTrangThai)
    VALUES (@maNV,@tenNV,@gioiTinh,@ngaySinh,@chucVu,@diaChi,@sdt,@ngayVaoLam,@trangThai)
END

GO
/****** Object:  StoredProcedure [dbo].[UP_ThemPN]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UP_ThemPN]
    @maNV CHAR(20),
    @ngayNhap DATETIME,
    @newMaPN VARCHAR(20) OUTPUT
AS
BEGIN
    -- Insert new record into tblHoaDon
    INSERT INTO tblPhieuNhap(sMaNV, dNgayNhap) VALUES (@maNV, @ngayNhap);

    -- Get the newly generated sMaHD
    SELECT @newMaPN =  MAX(sMaPN) FROM tblPhieuNhap; -- Assuming sMaHD is an identity column
END

GO
/****** Object:  StoredProcedure [dbo].[UP_ThemUser]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UP_ThemUser]
(@sUsername char(50), @sHoten nvarchar(60),@sSDT char(10),  @dNgaySinh datetime, @sPassword char(12))
as
begin
	insert into tblUser (sUsername, sHoten, sSDT, dNgaySinh, sPassword)
	values				(@sUsername, @sHoten , @sSDT ,  @dNgaySinh , @sPassword )
end
GO
/****** Object:  StoredProcedure [dbo].[UP_ThoiViecNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_ThoiViecNhanVien]
    @maNV VARCHAR(50)
AS
BEGIN
    UPDATE tblNhanVien
    SET
    --Trạng thái hủy
        iTrangThai = 2
    WHERE sMaNV = @maNV
END
GO
/****** Object:  StoredProcedure [dbo].[UP_TongTienHangTrongThangNam]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_TongTienHangTrongThangNam] 
(@year INT , @month INT)
AS
BEGIN
	SELECT CONCAT(@month, '-' , @year ) AS [Thời Gian], SUM(cthd.fThanhTien) AS [Tổng Tiền] 
		FROM tblHoaDon AS hd, tblChiTietHoaDon AS cthd
	WHERE hd.sMaHD = cthd.sMaHD
	AND YEAR(hd.dNgayLap) = @year
	AND MONTH(hd.dNgayLap) = @month
	GROUP BY YEAR(hd.dNgayLap) , MONTH(hd.dNgayLap)
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaChiTietHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UP_XoaChiTietHoaDon]
(@maHD VARCHAR(20), @maHang VARCHAR(20))
AS
BEGIN
    DELETE FROM tblChiTietHoaDon
    WHERE sMaHD = @maHD AND sMaHang = @maHang
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaChiTietPhieuNhap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[UP_XoaChiTietPhieuNhap]
(@maPN VARCHAR(20), @maHang VARCHAR(20))
AS
BEGIN
    DELETE FROM tblChiTietHoaDon
    WHERE sMaHD = @maPN AND sMaHang = @maHang
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_XoaHoaDon]
(@maHD VARCHAR(20))
AS
BEGIN
    DELETE FROM tblHoaDon
    WHERE sMaHD = @maHD
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaNhanVien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_XoaNhanVien]
(@maNV VARCHAR(20))
AS
BEGIN
    DELETE FROM tblNhanVien
    WHERE sMaNV = @maNV
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaPN]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UP_XoaPN]
(@maPN VARCHAR(20))
AS
BEGIN
    DELETE FROM tblPhieuNhap
    WHERE sMaPN = @maPN
END
GO
/****** Object:  StoredProcedure [dbo].[UP_XoaTatCaChiTietHoaDon]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UP_XoaTatCaChiTietHoaDon]
(@maHD VARCHAR(20))
AS
BEGIN
    DELETE FROM tblChiTietHoaDon
    WHERE sMaHD = @maHD 
END
GO
/****** Object:  StoredProcedure [dbo].[xoaLoaiHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaLoaiHang]
(@sMaLH char(20) , @sTenLH nvarchar(20))
as
begin
	delete from tblLoaiHang
	where sMaLH = @sMaLH
end
GO
/****** Object:  StoredProcedure [dbo].[xoaMatHang]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[xoaMatHang]
(@sMaHang char(20))
as
begin
	delete from tblMatHang 
	where sMaHang = @sMaHang
end
GO
/****** Object:  StoredProcedure [dbo].[xoaNhaCungCap]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaNhaCungCap]
(@sMaNCC char(20) , @sTenNCC nvarchar(50))
as
begin
	delete from tblNhaCungCap
	where sMaNCC = @sMaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[XoaTheoDieuKien]    Script Date: 17/05/25 16:41:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaTheoDieuKien]
( @TenBang VARCHAR(100), @TenCot VARCHAR(100), @GiaTri sql_variant = null)
AS
BEGIN
  DECLARE @Sql NVARCHAR(MAX);
  DECLARE @Sql1 NVARCHAR(MAX);
  DECLARE @iTrangThai int;

  set @Sql1 = 'Select ' + CAST(@iTrangThai AS NVARCHAR(10)) + ' = iTrangThai from ' + QUOTENAME(@TenBang) + ' WHERE ' + QUOTENAME(@TenCot) + ' = @GiaTri '
  EXEC sp_executesql @Sql1, N'@GiaTri sql_variant', @GiaTri;

  if(@iTrangThai = 0)
  begin
	IF @GiaTri IS NULL
	begin
	SET @Sql = 'DELETE FROM ' + QUOTENAME(@TenBang) + ' WHERE ' +  QUOTENAME(@TenCot) + ' IS NULL';
	end
	ELSE
	begin
	SET @Sql = 'DELETE FROM ' + QUOTENAME(@TenBang) + ' WHERE ' +  QUOTENAME(@TenCot) + ' = @GiaTri';
	end
  end
  else
  begin
	IF @GiaTri IS NULL
	begin
	SET @Sql = 'UPDATE ' + QUOTENAME(@TenBang) + ' SET iTrangThai = 2 WHERE ' + QUOTENAME(@TenCot) + ' IS NULL AND iTrangThai <> 2 ';
	end
	ELSE
	begin
	-- Tạo câu lệnh DELETE dynamic từ các tham số
	SET @Sql = 'UPDATE ' + QUOTENAME(@TenBang) + ' SET iTrangThai = 2 WHERE ' + QUOTENAME(@TenCot) + '= @GiaTri AND iTrangThai <> 2 ';
	-- Hàm QUOTENAME trong SQL Server được sử dụng để đặt dấu ngoặc kép ([ ]) xung quanh một chuỗi, giúp bảo vệ tên đối tượng khỏi các vấn đề liên quan đến ký tự đặc biệt hoặc xâm nhập SQL
	-- Thực thi câu lệnh DELETE dynamic
	end
  end
	EXEC sp_executesql @Sql, N'@GiaTri sql_variant', @GiaTri;
	-- sp_executesql là một hàm trong SQL Server được sử dụng để thực thi các câu lệnh SQL được xây dựng dynamic
 
END
GO
