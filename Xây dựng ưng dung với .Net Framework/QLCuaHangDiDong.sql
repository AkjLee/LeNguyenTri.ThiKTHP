USE [QLCuaHangDiDong]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 1/1/2022 8:28:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NULL,
	[SoLuong] [nvarchar](50) NULL,
	[MaHD] [nvarchar](50) NULL,
	[DaMua] [bit] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/1/2022 8:28:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NULL,
	[NgayMua] [date] NULL,
	[Damua] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/1/2022 8:28:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[STD] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 1/1/2022 8:28:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/1/2022 8:28:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[MaLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaSP], [SoLuong], [MaHD], [DaMua]) VALUES (N'1', N'SP1', N'1', N'HD01', 1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayMua], [Damua]) VALUES (N'HD01', N'KH01', CAST(N'2021-01-01' AS Date), 1)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [STD], [Email], [UserName], [Password]) VALUES (N'KH01', N'Trí', N'Huế', N'0123213', N'Tri@gmail.com', N'Tri', N'123')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [STD], [Email], [UserName], [Password]) VALUES (N'KH02', N'Ngàn', N'Huế', N'0123412', N'Ngan@gmail.com', N'Ngan', N'123')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [STD], [Email], [UserName], [Password]) VALUES (N'KH03', N'Dương', N'Huế', N'0123123', N'Duong@gmail.com', N'Duong', N'123')
GO
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (N'', NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (N'ML1', N'Oppo')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (N'ML2 ', N'Iphone')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (N'ML3', N'XiaoMi')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (N'ML4', N'SamSung')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'ML13', N'Iphone10', NULL, N'7500000', NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP1', N'Iphone13', NULL, N'15000000', NULL, N'ML2')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP10', N'SamSungNote40', NULL, N'4800000', NULL, N'ML4')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP12', N'SamSung20', NULL, N'3500000', NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP2', N'RedmiNote7', NULL, N'5000000', NULL, N'ML3')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP3', N'Iphone10', NULL, N'10000000', NULL, N'ML2')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP4', N'Iphone7', NULL, N'5000000', NULL, N'ML2')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP5', N'Oppo A94', NULL, N'2900000', NULL, N'ML1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP6', N'Oppo A93', NULL, N'2350000', NULL, N'ML1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP7', N'RedMi5C', NULL, N'3590000', NULL, N'ML3')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP8', N'RedmiNote10', NULL, N'3990000', NULL, N'ML3')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Anh], [Gia], [MoTa], [MaLoai]) VALUES (N'SP9', N'SamSungNote10', NULL, N'5200000', NULL, N'ML4')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_Loai]
GO
