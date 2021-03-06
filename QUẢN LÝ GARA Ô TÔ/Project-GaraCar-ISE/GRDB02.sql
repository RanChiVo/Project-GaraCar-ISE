USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLGR02')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLGR02') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLGR02]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLGR02]
GO

USE [QLGR02]
GO


/****** Object:  Table [dbo].[tblBAOCAODOANHTHU]    Script Date: 6/9/2018 12:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBAOCAODOANHTHU](
	[MaBaoCaoDoanhThu] [nvarchar](10) NOT NULL,
	[BienSoXe] [nvarchar](10) NOT NULL,
	[Thang] [int] NOT NULL,
	[SoLuotSua] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[TyLe] [float] NOT NULL,
 CONSTRAINT [PK_tblBAOCAODOANHTHU] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoDoanhThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBAOCAOTON]    Script Date: 6/9/2018 12:31:11 PM ******/
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
/****** Object:  Table [dbo].[tblCTPHIEUSUACHUA]    Script Date: 6/9/2018 12:31:12 PM ******/
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
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [PK_tblCTPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLOAIHIEUXE]    Script Date: 6/9/2018 12:31:12 PM ******/
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
/****** Object:  Table [dbo].[tblLOAITIENCONG]    Script Date: 6/9/2018 12:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLOAITIENCONG](
	[MaLoaiTienCong] [int] NOT NULL,
	[TenLoaiTienCong] [nvarchar](50) NOT NULL,
	[MucTien] [money] NOT NULL,
 CONSTRAINT [PK_tblLOAITIENCONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTienCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUSUACHUA]    Script Date: 6/9/2018 12:31:12 PM ******/
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
/****** Object:  Table [dbo].[tblPHIEUTHUTIEN]    Script Date: 6/9/2018 12:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUTHUTIEN](
	[MaPhieuThuTien] [nvarchar](10) NOT NULL,
	[MaPhieuSuaChua] [nvarchar](10) NOT NULL,
	[NgayThuTien] [smalldatetime] NOT NULL,
	[SoTienThu] [money] NOT NULL,
 CONSTRAINT [PK_tblPHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTHAMSO]    Script Date: 6/9/2018 12:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTHAMSO](
	[SLXeToiDaMoiNgay] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVATTUPHUTUNG]    Script Date: 6/9/2018 12:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVATTUPHUTUNG](
	[MaLoaiPhuTung] [int] NOT NULL,
	[TenLoaiPhuTung] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_tblVATTUPHUTUNG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXE]    Script Date: 6/9/2018 12:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXE](
	[BienSoXe] [nvarchar](10) NOT NULL,
	[MaLoaiHieuXe] [int] NOT NULL,
	[NgayTiepNhan] [smalldatetime] NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[TienNo] [money] NOT NULL,
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
INSERT [dbo].[tblTHAMSO] ([SLXeToiDaMoiNgay]) VALUES (30)
