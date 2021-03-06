USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLGR')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLGR') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLGR]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLGR]
GO

USE [QLGR]
GO

USE [QLGR]
GO
/****** Object:  Table [dbo].[tblCTPHIEUSUACHUA]    Script Date: 7/2/2018 3:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPHIEUSUACHUA](
	[MaCTPhieuSuaChua] [int] NOT NULL,
	[MaPhieuSuaChua] [int] NOT NULL,
	[MaLoaiPhuTung] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tblCTPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKHACHHANG]    Script Date: 7/2/2018 3:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKHACHHANG](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [char](20) NOT NULL,
	[TienNo] [int] NOT NULL,
 CONSTRAINT [PK_tblKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLOAIHIEUXE]    Script Date: 7/2/2018 3:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLOAIHIEUXE](
	[MaLoaiHieuXe] [int] NOT NULL,
	[TenLoaiHieuXe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLOAIHIEUXE] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHieuXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLOAITIENCONG]    Script Date: 7/2/2018 3:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLOAITIENCONG](
	[MaLoaiTienCong] [int] NOT NULL,
	[TenLoaiTienCong] [nvarchar](50) NOT NULL,
	[MucTien] [int] NOT NULL,
 CONSTRAINT [PK_tblLOAITIENCONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTienCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUSUACHUA]    Script Date: 7/2/2018 3:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUSUACHUA](
	[MaPhieuSuaChua] [int] NOT NULL,
	[BienSoXe] [nvarchar](10) NOT NULL,
	[NgaySuaChua] [smalldatetime] NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[MaLoaiTienCong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_tblPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUTHUTIEN]    Script Date: 7/2/2018 3:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUTHUTIEN](
	[MaPhieuThuTien] [nvarchar](10) NOT NULL,
	[MaPhieuSuaChua] [int] NOT NULL,
	[NgayThuTien] [smalldatetime] NOT NULL,
	[SoTienThu] [int] NOT NULL,
 CONSTRAINT [PK_tblPHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTAIKHOAN]    Script Date: 7/2/2018 3:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTAIKHOAN](
	[username] [nvarchar](20) NOT NULL,
	[pass] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTHAMSO]    Script Date: 7/2/2018 3:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTHAMSO](
	[SLXeToiDaMoiNgay] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVATTUPHUTUNG]    Script Date: 7/2/2018 3:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVATTUPHUTUNG](
	[MaLoaiPhuTung] [int] NOT NULL,
	[TenLoaiPhuTung] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayNhap] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblVATTUPHUTUNG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXE]    Script Date: 7/2/2018 3:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXE](
	[BienSoXe] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](20) NOT NULL,
	[MaLoaiHieuXe] [int] NOT NULL,
	[NgayTiepNhan] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblXE] PRIMARY KEY CLUSTERED 
(
	[BienSoXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (333, 2, 1, 2)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (334, 5, 0, 15)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (335, 6, 0, 15)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (336, 1, 3, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (337, 1, 4, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (338, 1, 2, 40)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (339, 2, 2, 2)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (340, 1, 1, 10)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (341, 7, 3, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (342, 8, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (343, 9, 8, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (344, 10, 5, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (345, 10, 6, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (346, 10, 8, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (347, 10, 2, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (348, 10, 2, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (349, 11, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (350, 11, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (351, 11, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (352, 12, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (353, 12, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (354, 12, 1, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (355, 13, 4, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (356, 13, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (357, 14, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (358, 14, 4, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (359, 14, 6, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (360, 14, 6, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (361, 14, 6, 20)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (362, 15, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (363, 16, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (364, 16, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (365, 16, 1, 60)
INSERT [dbo].[tblCTPHIEUSUACHUA] ([MaCTPhieuSuaChua], [MaPhieuSuaChua], [MaLoaiPhuTung], [SoLuong]) VALUES (366, 3, 1, 60)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'gdfg', N's', N'rêw', N'r?                  ', 545235)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR000001', N'Nguyễn Văn Khánh', N'Nam Định', N'098765543           ', 301109)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR000002', N'Lê Văn', N'Nam Định', N'09876554            ', 228240005)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR000004', N'dffs', N'fs', N'53345               ', 5345)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR000005', N'Lê Văn Nghĩa', N'4234', N'24343434            ', 243434)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR000006', N'Lê Văn Thành', N'4234', N'24343434            ', 6707023)
INSERT [dbo].[tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo]) VALUES (N'GR00004', N'Lê Văn Thành', N'4234', N'24343434            ', 243434)
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (1, N'Toyota')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (2, N'Honda')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (3, N'SuZuKi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (4, N'Ford')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (5, N'BMW')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (6, N'Audi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (7, N'Lexus')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (8, N'Mercedes-Benz')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (9, N'Lamborghini')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (10, N'Bentley')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (11, N'JDG')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (12, N'KHT')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (13, N'Mesudi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (14, N'Cambri')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (15, N'Renault')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (16, N'VOlvo')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (17, N'Chery')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (18, N'Mini')
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (0, N'Loai Tien cong 1', 10000)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (1, N'Loai Tien cong 1', 10100)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (2, N'Loai Tien cong 2', 10200)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (3, N'Loai Tien cong 3', 10300)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (4, N'Loai Tien cong 4', 10400)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (5, N'Loai Tien cong 5', 10500)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (6, N'Loai Tien cong 6', 10600)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (7, N'Loai Tien cong 7', 10700)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (8, N'Loai Tien cong 8', 10800)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (9, N'Loai Tien cong 9', 10900)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (10, N'Loai Tien cong 10', 11000)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (11, N'Loai Tien cong 11', 11100)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (12, N'Loai Tien cong 12', 11200)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (13, N'Loai Tien cong 13', 11300)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (14, N'Loai Tien cong 14', 11400)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (15, N'Loai Tien cong 15', 11500)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (16, N'Loai Tien cong 16', 11600)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (17, N'Loai Tien cong 17', 11700)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (18, N'Loai Tien cong 18', 11800)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (19, N'Loai Tien cong 19', 11900)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (20, N'Loai Tien cong 20', 12000)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (21, N'Loai Tien cong 21', 12100)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (22, N'Loai Tien cong 22', 12200)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (23, N'Loai Tien cong 23', 12300)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (24, N'Loai Tien cong 24', 12400)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (25, N'Loai Tien cong 25', 12500)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (26, N'Loai Tien cong 26', 12600)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (27, N'Loai Tien cong 27', 12700)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (28, N'Loai Tien cong 28', 12800)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (29, N'Loai Tien cong 29', 12900)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (30, N'Loai Tien cong 30', 13000)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (31, N'Loai Tien cong 31', 13100)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (32, N'Loai Tien cong 32', 13200)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (33, N'Loai Tien cong 33', 13300)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (34, N'Loai Tien cong 34', 13400)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (35, N'Loai Tien cong 35', 13500)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (36, N'Loai Tien cong 36', 13600)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (37, N'Loai Tien cong 37', 13700)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (38, N'Loai Tien cong 38', 13800)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (39, N'Loai Tien cong 39', 13900)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (40, N'Loai Tien cong 40', 14000)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (41, N'Loai Tien cong 41', 14100)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (42, N'Loai Tien cong 42', 14200)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (43, N'Loai Tien cong 43', 14300)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (44, N'Loai Tien cong 44', 14400)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (45, N'Loai Tien cong 45', 14500)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (46, N'Loai Tien cong 46', 14600)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (47, N'Loai Tien cong 47', 14700)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (48, N'Loai Tien cong 48', 14800)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (49, N'Loai Tien cong 49', 14900)
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (50, N'Loai Tien cong 50', 15000)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (1, N'A123', CAST(N'2018-07-01T13:17:00' AS SmallDateTime), N' Hu L?p', 23, 99012300)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (2, N'A123', CAST(N'2018-07-01T13:17:00' AS SmallDateTime), N' Hu L?p', 23, 4712300)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (3, N'A12318', CAST(N'2018-07-01T13:17:00' AS SmallDateTime), N' Hu L?p', 0, 3434)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (4, N'A1243', CAST(N'2018-07-01T13:17:00' AS SmallDateTime), N'Hư Lốp Xe', 1, 3234234)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (5, N'', CAST(N'2018-07-01T20:01:00' AS SmallDateTime), N'Hư thắng trước', 10200, 18010200)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (6, N'GR000002', CAST(N'2018-07-01T21:55:00' AS SmallDateTime), N'hư xe', 11700, 18011700)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (7, N'A123', CAST(N'2018-07-02T03:29:00' AS SmallDateTime), N'Hư gạt', 21, 24012100)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (8, N'A123', CAST(N'2018-07-02T03:52:00' AS SmallDateTime), N'HƯ bánh', 24, 26012400)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (9, N'A123', CAST(N'2018-07-02T03:53:00' AS SmallDateTime), N'Quẹo cổ', 18, 14011800)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (10, N'A123', CAST(N'2018-07-02T03:53:00' AS SmallDateTime), N'hư đủ thứ', 43, 216014300)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (11, N'A123', CAST(N'2018-07-02T03:54:00' AS SmallDateTime), N'hư nhiều', 25, 78012500)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (12, N'A123', CAST(N'2018-07-02T03:58:00' AS SmallDateTime), N'', 23, 78012300)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (13, N'A123', CAST(N'2018-07-02T03:58:00' AS SmallDateTime), N'Hư nhiều đồ', 23, 98012300)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (14, N'A123', CAST(N'2018-07-02T04:00:00' AS SmallDateTime), N'hư', 22, 552012200)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (15, N'A123', CAST(N'2018-07-02T04:00:00' AS SmallDateTime), N'', 22, 78012200)
INSERT [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]) VALUES (16, N'A123', CAST(N'2018-07-02T04:04:00' AS SmallDateTime), N'hư', 27, 234012700)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000001', 3, CAST(N'2018-06-30T01:18:00' AS SmallDateTime), 1223)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000002', 3, CAST(N'2018-06-30T01:28:00' AS SmallDateTime), 1222)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000003', 3, CAST(N'2018-06-30T01:28:00' AS SmallDateTime), 233)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000004', 2, CAST(N'2018-06-30T01:45:00' AS SmallDateTime), 0)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000005', 3, CAST(N'2018-06-30T02:10:00' AS SmallDateTime), 1122)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000006', 3, CAST(N'2018-06-30T02:16:00' AS SmallDateTime), 122)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000007', 3, CAST(N'2018-06-30T02:23:00' AS SmallDateTime), 123)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000008', 3, CAST(N'2018-06-30T02:26:00' AS SmallDateTime), 123)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000009', 3, CAST(N'2018-06-30T02:26:00' AS SmallDateTime), 12312)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000010', 3, CAST(N'2018-06-30T02:29:00' AS SmallDateTime), 21332)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000011', 3, CAST(N'2018-06-30T02:34:00' AS SmallDateTime), 1)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000012', 4, CAST(N'2018-06-30T02:53:00' AS SmallDateTime), 23)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000013', 3, CAST(N'2018-06-30T02:54:00' AS SmallDateTime), 14232)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000014', 3, CAST(N'2018-07-01T03:37:00' AS SmallDateTime), 1212)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000015', 1, CAST(N'2018-07-01T03:39:00' AS SmallDateTime), 132132)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000016', 4, CAST(N'2018-07-01T13:23:00' AS SmallDateTime), 2323)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000017', 3, CAST(N'2018-07-01T13:25:00' AS SmallDateTime), 10000)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000018', 1, CAST(N'2018-07-01T13:32:00' AS SmallDateTime), 1000)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000019', 1, CAST(N'2018-07-01T13:37:00' AS SmallDateTime), 1000)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000020', 1, CAST(N'2018-07-01T13:37:00' AS SmallDateTime), 1000)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000021', 1, CAST(N'2018-07-01T14:02:00' AS SmallDateTime), 1)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000022', 1, CAST(N'2018-07-01T14:04:00' AS SmallDateTime), 1)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000023', 1, CAST(N'2018-07-01T14:07:00' AS SmallDateTime), 1)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000024', 2, CAST(N'2018-07-02T00:24:00' AS SmallDateTime), 2324)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000025', 1, CAST(N'2018-07-02T00:25:00' AS SmallDateTime), 434)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000026', 1, CAST(N'2018-07-02T00:26:00' AS SmallDateTime), 332)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000027', 1, CAST(N'2018-07-02T00:29:00' AS SmallDateTime), 423)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000028', 8, CAST(N'2018-07-02T05:09:00' AS SmallDateTime), 244)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000029', 4, CAST(N'2018-07-02T06:02:00' AS SmallDateTime), 1332)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000030', 1, CAST(N'2018-07-02T14:31:00' AS SmallDateTime), 1224)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000031', 4, CAST(N'2018-07-02T14:31:00' AS SmallDateTime), 1224)
INSERT [dbo].[tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu]) VALUES (N'PT000032', 1, CAST(N'2018-07-02T15:00:00' AS SmallDateTime), 12424)
INSERT [dbo].[tblTAIKHOAN] ([username], [pass]) VALUES (N'ADMIN', N'1234')
INSERT [dbo].[tblTHAMSO] ([SLXeToiDaMoiNgay]) VALUES (30)
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (1, N'Bố thắng trước', 1300000, 60, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (2, N'Bố thắng sau', 1050000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (3, N'Lọc gió', 1200000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (4, N'Lốp trước', 1000000, 60, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (5, N'Lốp sau', 1100000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (6, N'Mâm ép', 6900000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (7, N'Lọc nhiên liệu', 171000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (8, N'Búp sen thắng sau', 700000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong], [NgayNhap]) VALUES (9, N'Đuôi cá', 2200000, 20, CAST(N'2018-07-02T04:04:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'A123', N'GR000002', 4, CAST(N'2018-06-11T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'A12318', N'GR000001', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'A1243', N'GR000006', 2, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'A312', N'GR000001', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'A443', N'GR000002', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'dfdf', N'GR000003', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'gfdet', N'GR000005', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'gfdg', N'GR000005', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'KF', N'GR00004', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'KF4', N'GR000006', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'KFH', N'GR000005', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'KFHF', N'GR000005', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'kjkgj', N'GR000005', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tblXE] ([BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan]) VALUES (N'rư', N'gdfg', 1, CAST(N'2018-06-07T00:00:00' AS SmallDateTime))
