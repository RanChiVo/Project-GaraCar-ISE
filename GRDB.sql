USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='GRDB')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'GRDB') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [GRDB]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [GRDB]
GO

USE [GRDB]
GO

/****** Object:  Table [dbo].[tblBAOCAODOANHTHU]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBAOCAODOANHTHU](
	[MaBaoCaoDoanhThu] [nvarchar](10) NOT NULL,
	[BienSoXe] [nvarchar](10) NOT NULL,
	[Thang] [int] NOT NULL,
	[SoLuotSua] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[TyLe] [float] NOT NULL,
 CONSTRAINT [PK_tblBAOCAODOANHTHU] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoDoanhThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBAOCAOTON]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBAOCAOTON](
	[MaBaoCaoTon] [nvarchar](10) NOT NULL,
	[Thang] [nvarchar](10) NOT NULL,
	[MaLoaiPhuTung] [int] NOT NULL,
	[TonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_tblBAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTPHIEUSUACHUA]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPHIEUSUACHUA](
	[MaCTPhieuSuaChua] [nvarchar](10) NOT NULL,
	[MaPhieuSuaChua] [nvarchar](10) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[MaLoaiPhuTung] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaLoaiTienCong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_tblCTPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKHACHHANG]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKHACHHANG](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[TienNo] [money] NOT NULL,
 CONSTRAINT [PK_tblKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLOAIHIEUXE]    Script Date: 6/11/2018 11:24:00 PM ******/
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
/****** Object:  Table [dbo].[tblLOAITIENCONG]    Script Date: 6/11/2018 11:24:00 PM ******/
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
/****** Object:  Table [dbo].[tblPHIEUSUACHUA]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUSUACHUA](
	[MaPhieuSuaChua] [nvarchar](10) NOT NULL,
	[BienSoXe] [nvarchar](10) NOT NULL,
	[NgaySuaChua] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUTHUTIEN]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUTHUTIEN](
	[MaPhieuThuTien] [nvarchar](10) NOT NULL,
	[MaPhieuSuaChua] [nvarchar](10) NOT NULL,
	[NgayThuTien] [smalldatetime] NOT NULL,
	[SoTienThu] [int] NOT NULL,
 CONSTRAINT [PK_tblPHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTHAMSO]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTHAMSO](
	[SLXeToiDaMoiNgay] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVATTUPHUTUNG]    Script Date: 6/11/2018 11:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVATTUPHUTUNG](
	[MaLoaiPhuTung] [int] NOT NULL,
	[TenLoaiPhuTung] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_tblVATTUPHUTUNG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXE]    Script Date: 6/11/2018 11:24:00 PM ******/
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
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (1, N'Toyota')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (2, N'HonDa')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (3, N'SuZuKi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (4, N'Ford')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (5, N'BMW')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (6, N'Audi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (7, N'Lexus')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (8, N'Mercedes-Benz')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (9, N'Lamborghini')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (10, N'Bentley')
INSERT [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien]) VALUES (0, N'Loai Tien cong 0', 10000)
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
INSERT [dbo].[tblTHAMSO] ([SLXeToiDaMoiNgay]) VALUES (30)
