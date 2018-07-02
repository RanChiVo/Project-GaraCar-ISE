/****** Object:  Table [dbo].[tblBAOCAODOANHTHU]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBAOCAODOANHTHU](
	[MaBaoCaoDoanhThu] [nchar](10) NOT NULL,
	[BienSoXe] [nchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[tblBAOCAOTON]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBAOCAOTON](
	[MaBaoCaoTon] [nchar](10) NOT NULL,
	[Thang] [nchar](10) NOT NULL,
	[MaLoaiPhuTung] [nchar](10) NOT NULL,
	[TonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_tblBAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTPHIEUSUACHUA]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPHIEUSUACHUA](
	[MaCTPhieuSuaChua] [nchar](10) NOT NULL,
	[MaPhieuSuaChua] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[MaLoaiPhuTung] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaLoaiTienCong] [nchar](10) NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [PK_tblCTPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKHACHHANG]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKHACHHANG](
	[MaKH] [nchar](20) NOT NULL,
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
/****** Object:  Table [dbo].[tblLOAIHIEUXE]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLOAIHIEUXE](
	[MaLoaiHieuXe] [nchar](10) NOT NULL,
	[TenLoaiHieuXe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLOAIHIEUXE] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHieuXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLOAITIENCONG]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLOAITIENCONG](
	[MaLoaiTienCong] [nchar](10) NOT NULL,
	[TenLoaiTienCong] [nvarchar](50) NOT NULL,
	[MucTien] [money] NOT NULL,
 CONSTRAINT [PK_tblLOAITIENCONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTienCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUSUACHUA]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUSUACHUA](
	[MaPhieuSuaChua] [nchar](10) NOT NULL,
	[BienSoXe] [nchar](10) NOT NULL,
	[NgaySuaChua] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblPHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPHIEUTHUTIEN]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPHIEUTHUTIEN](
	[MaPhieuThuTien] [nchar](10) NOT NULL,
	[MaPhieuSuaChua] [nchar](10) NOT NULL,
	[NgayThuTien] [smalldatetime] NOT NULL,
	[SoTienThu] [money] NOT NULL,
 CONSTRAINT [PK_tblPHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTHAMSO]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTHAMSO](
	[SLXeToiDaMoiNgay] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVATTUPHUTUNG]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVATTUPHUTUNG](
	[MaLoaiPhuTung] [nchar](10) NOT NULL,
	[TenLoaiPhuTung] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_tblVATTUPHUTUNG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXE]    Script Date: 6/1/2018 11:33:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXE](
	[BienSoXe] [nchar](10) NOT NULL,
	[MaKH] [nchar](20) NOT NULL,
	[MaLoaiHieuXe] [nchar](10) NOT NULL,
	[NgayTiepNhan] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblXE] PRIMARY KEY CLUSTERED 
(
	[BienSoXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'1         ', N'Toyota')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'10        ', N'Bentley')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'2         ', N'HonDa')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'3         ', N'SuZuKi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'4         ', N'Ford')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'5         ', N'BMW')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'6         ', N'Audi')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'7         ', N'Lexus')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'8         ', N'Mercedes-Benz')
INSERT [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe]) VALUES (N'9         ', N'Lamborghini')
INSERT [dbo].[tblTHAMSO] ([SLXeToiDaMoiNgay]) VALUES (30)
ALTER TABLE [dbo].[tblBAOCAODOANHTHU]  WITH CHECK ADD  CONSTRAINT [FK_tblBAOCAODOANHTHU_tblXE] FOREIGN KEY([BienSoXe])
REFERENCES [dbo].[tblXE] ([BienSoXe])
GO
ALTER TABLE [dbo].[tblBAOCAODOANHTHU] CHECK CONSTRAINT [FK_tblBAOCAODOANHTHU_tblXE]
GO
ALTER TABLE [dbo].[tblBAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_tblBAOCAOTON_tblVATTUPHUTUNG] FOREIGN KEY([MaLoaiPhuTung])
REFERENCES [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung])
GO
ALTER TABLE [dbo].[tblBAOCAOTON] CHECK CONSTRAINT [FK_tblBAOCAOTON_tblVATTUPHUTUNG]
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblLOAITIENCONG] FOREIGN KEY([MaLoaiTienCong])
REFERENCES [dbo].[tblLOAITIENCONG] ([MaLoaiTienCong])
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA] CHECK CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblLOAITIENCONG]
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblPHIEUSUACHUA] FOREIGN KEY([MaPhieuSuaChua])
REFERENCES [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA] CHECK CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblPHIEUSUACHUA]
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblVATTUPHUTUNG] FOREIGN KEY([MaLoaiPhuTung])
REFERENCES [dbo].[tblVATTUPHUTUNG] ([MaLoaiPhuTung])
GO
ALTER TABLE [dbo].[tblCTPHIEUSUACHUA] CHECK CONSTRAINT [FK_tblCTPHIEUSUACHUA_tblVATTUPHUTUNG]
GO
ALTER TABLE [dbo].[tblPHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_tblPHIEUSUACHUA_tblXE] FOREIGN KEY([BienSoXe])
REFERENCES [dbo].[tblXE] ([BienSoXe])
GO
ALTER TABLE [dbo].[tblPHIEUSUACHUA] CHECK CONSTRAINT [FK_tblPHIEUSUACHUA_tblXE]
GO
ALTER TABLE [dbo].[tblPHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_tblPHIEUTHUTIEN_tblPHIEUSUACHUA] FOREIGN KEY([MaPhieuSuaChua])
REFERENCES [dbo].[tblPHIEUSUACHUA] ([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[tblPHIEUTHUTIEN] CHECK CONSTRAINT [FK_tblPHIEUTHUTIEN_tblPHIEUSUACHUA]
GO
ALTER TABLE [dbo].[tblXE]  WITH CHECK ADD  CONSTRAINT [FK_tblXE_tblKHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[tblXE] CHECK CONSTRAINT [FK_tblXE_tblKHACHHANG]
GO
ALTER TABLE [dbo].[tblXE]  WITH CHECK ADD  CONSTRAINT [FK_tblXE_tblLOAIHIEUXE] FOREIGN KEY([MaLoaiHieuXe])
REFERENCES [dbo].[tblLOAIHIEUXE] ([MaLoaiHieuXe])
GO
ALTER TABLE [dbo].[tblXE] CHECK CONSTRAINT [FK_tblXE_tblLOAIHIEUXE]
GO
