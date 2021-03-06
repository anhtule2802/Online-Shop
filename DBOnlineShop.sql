USE [master]
GO
/****** Object:  Database [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23]    Script Date: 4/30/2019 6:02:12 PM ******/
CREATE DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KTTKPM_DHKTPM12A_BAITAPLON_NHOM23', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\KTTKPM_DHKTPM12A_BAITAPLON_NHOM23.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KTTKPM_DHKTPM12A_BAITAPLON_NHOM23_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\KTTKPM_DHKTPM12A_BAITAPLON_NHOM23_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ARITHABORT OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET  MULTI_USER 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 4/30/2019 6:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[UserID] [int] NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 4/30/2019 6:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[CategoryID] [int] NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Sorting] [int] NULL,
	[Meta Title] [nchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 4/30/2019 6:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[CreateAt] [date] NULL,
	[Status] [nchar](10) NULL,
	[ShipName] [nvarchar](50) NULL,
	[ShipMobile] [nvarchar](50) NULL,
	[ShipAddress] [nvarchar](50) NULL,
	[ShipEmail] [nvarchar](50) NULL,
 CONSTRAINT [PK__HOADON__C3905BAF0CE15A77] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 4/30/2019 6:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
	[Email] [nvarchar](30) NULL,
	[Username] [nvarchar](30) NULL,
	[Password] [nvarchar](30) NULL,
	[Role] [nchar](10) NULL,
	[Status] [nvarchar](10) NULL,
 CONSTRAINT [PK__NGUOIDUN__3214EC070CF695E6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 4/30/2019 6:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[Name] [nvarchar](30) NULL,
	[Description] [nvarchar](300) NULL,
	[Price] [int] NULL,
	[CategoryName] [nvarchar](30) NULL,
	[ImageName] [nvarchar](30) NULL,
	[MetaTitle] [nchar](30) NULL,
	[CreateDays] [date] NULL,
 CONSTRAINT [PK__SANPHAM__3214EC0751865472] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (2, 2, 1, 2, 500000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (2, 3, 2, 2, 1000000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (14, 1, 1, 2, 500000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (14, 2, 1, 2, 500000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (14, 3, 1, 2, 550000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (15, 3, 1, 2, 220000)
INSERT [dbo].[CHITIETHOADON] ([OrderID], [ProductID], [Quantity], [UserID], [Price]) VALUES (15, 16, 1, 2, 304000)
INSERT [dbo].[DANHMUC] ([CategoryID], [Name], [Sorting], [Meta Title]) VALUES (1, N'Modem Wifi', 1, N'modem-wifi                    ')
INSERT [dbo].[DANHMUC] ([CategoryID], [Name], [Sorting], [Meta Title]) VALUES (2, N'Card Wifi', 2, N'card-wifi                     ')
INSERT [dbo].[DANHMUC] ([CategoryID], [Name], [Sorting], [Meta Title]) VALUES (3, N'Kích Sóng Wifi', 3, N'kich-song-wifi                ')
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([OrderID], [UserID], [CreateAt], [Status], [ShipName], [ShipMobile], [ShipAddress], [ShipEmail]) VALUES (2, 2, CAST(0x993F0B00 AS Date), N'true      ', N'Lê Anh Tú', N'785600625', N'87/3 Bưng Ông Thoàn', N'anhtule2802@gmail.com')
INSERT [dbo].[HOADON] ([OrderID], [UserID], [CreateAt], [Status], [ShipName], [ShipMobile], [ShipAddress], [ShipEmail]) VALUES (3, 2, CAST(0x993F0B00 AS Date), N'true      ', N'Lê Anh Tú', N'785600625', N'87/3 Bưng Ông Thoàn', N'nrisle1998@gmail.com')
INSERT [dbo].[HOADON] ([OrderID], [UserID], [CreateAt], [Status], [ShipName], [ShipMobile], [ShipAddress], [ShipEmail]) VALUES (14, 2, CAST(0x993F0B00 AS Date), N'true      ', N'Lê Anh Tú', N'0778835069', N'87/3 Bưng Ông Thoàn', N'thanhthanh23@gmail.com')
INSERT [dbo].[HOADON] ([OrderID], [UserID], [CreateAt], [Status], [ShipName], [ShipMobile], [ShipAddress], [ShipEmail]) VALUES (15, 2, CAST(0x993F0B00 AS Date), N'false     ', N'Lê Anh Tú', N'0778835069', N'87/3 Bưng Ông Thoàn', N'nrisle1998@gmail.com')
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 

INSERT [dbo].[NGUOIDUNG] ([Id], [FirstName], [LastName], [Email], [Username], [Password], [Role], [Status]) VALUES (1, N'Tu', N'Anh', N'anhtule2802@gmail.com', N'admin', N'admin', N'MOD       ', N'true')
INSERT [dbo].[NGUOIDUNG] ([Id], [FirstName], [LastName], [Email], [Username], [Password], [Role], [Status]) VALUES (2, N'Tuan', N'Anh', N'anhtuan0704@gmail.com', N'anhtuan', N'anhtuan', N'Customer  ', N'true')
INSERT [dbo].[NGUOIDUNG] ([Id], [FirstName], [LastName], [Email], [Username], [Password], [Role], [Status]) VALUES (3, N'le', N'tu', N'anhtu123@gmail.com', N'anhtu', N'anhtu123', N'Customer  ', N'true')
INSERT [dbo].[NGUOIDUNG] ([Id], [FirstName], [LastName], [Email], [Username], [Password], [Role], [Status]) VALUES (4, N'anh', N'tu', N'anhtu1@gmail.com', N'anhtu1', N'anhtu123', N'Customer  ', N'true')
INSERT [dbo].[NGUOIDUNG] ([Id], [FirstName], [LastName], [Email], [Username], [Password], [Role], [Status]) VALUES (5, N'thanh', N'thanh', N'thanhthanh@gmail.com', N'thanhthanh', N'thanhthanh', N'Customer  ', N'true')
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (1, 1, N'Modem TenDa', N'Sản phẩm dùng để phát wifi', 300000, N'Modem Wifi', N'1.jpg', N'modem-tenda                   ', CAST(0x5D3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (2, 1, N'Modem ToToLink', N'Sản phẩm dùng để phát wifi', 150000, N'Modem Wifi', N'2.jpg', N'modem-totolink                ', CAST(0x793F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (3, 1, N'Modem Viettel', N'Sản phẩm dùng để phát wifi, kết nối wifi', 220000, N'Modem Wifi', N'3.jpg', N'modem-viettel                 ', CAST(0x993F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (4, 2, N'Card TenM', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 230000, N'Card Wifi', N'4.jpg', N'card-tenm                     ', CAST(0x6C3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (5, 2, N'Card TenM TT30', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 110000, N'Card Wifi', N'5.jpg', N'card-tenm-tt30                ', CAST(0x7D3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (6, 2, N'Card Totolink 4g', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 340000, N'Card Wifi', N'6.jpg', N'totolink-4g                   ', CAST(0x503F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (7, 3, N'Mercury 2 râu', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 274000, N'Kích Sóng Wifi', N'mercury2.jpg', N'mercury-2                     ', CAST(0x7B3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (8, 3, N'Xiaomi Gen2', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 150000, N'Kích Sóng Wifi', N'xiaomigen2.jpg', N'xiaomi-gen2                   ', CAST(0x7B3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (9, 3, N'TotoLink N300RH', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 320000, N'Kích Sóng Wifi', N'n300rh.jpg', N'totolink-n300rh               ', CAST(0x7B3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (11, 1, N'Modem TenDa AC6', N'Sản phẩm dùng để phát wifi', 600000, N'Modem Wifi', N'tendaac6.jpg', N'modem-tenda-ac6               ', CAST(0x813F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (12, 1, N'Tenda F3', N'Sản phẩm dùng để phát wifi', 230000, N'Modem Wifi', N'tendaf3.jpg', N'tenda-f3                      ', CAST(0x8B3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (13, 1, N'Tenda N301', N'Sản phẩm dùng để phát wifi', 430000, N'Modem Wifi', N'tendan301.jpg', N'tenda-n301                    ', CAST(0x863F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (14, 2, N'Tenda O1', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 210000, N'Card Wifi', N'tendao1.jpg', N'tenda-o1                      ', CAST(0x6C3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (15, 1, N'Tenda W302R', N'Sản phẩm dùng để phát wifi', 120000, N'Modem Wifi', N'tendaw302r.jpg', N'tenda-w302r                   ', CAST(0x923F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (16, 3, N'Totolink WN781ND', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 304000, N'Card Wifi', N'tl-wn781nd.jpg', N'totolink-wn781nd              ', CAST(0x713F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (17, 3, N'Totolink WA850RE', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 450000, N'Card Wifi', N'tlwa850re.jpg', N'totolink-wa850re              ', CAST(0x923F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (18, 1, N'TP-Link Archerc 7', N'Sản phẩm dùng để phát wifi', 240000, N'Modem Wifi', N'archerc7.jpg', N'tplink-archerc7               ', CAST(0x8E3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (19, 1, N'Huawei WS318', N'Sản phẩm dùng để phát wifi', 300000, N'Modem Wifi', N'huaweiws318.jpg', N'huawei-ws318.jpg              ', CAST(0x8D3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (20, 2, N'TP-Link Archer 05', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 250000, N'Card Wifi', N'archer05.jpg', N'archer-05                     ', CAST(0x8B3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (21, 2, N'Hackintosh', N'Sản phẩm bổ trợ wifi cho máy tính bàn', 120000, N'Card Wifi', N'hackintosh.jpg', N'hackintosh                    ', CAST(0x8A3F0B00 AS Date))
INSERT [dbo].[SANPHAM] ([Id], [CategoryID], [Name], [Description], [Price], [CategoryName], [ImageName], [MetaTitle], [CreateDays]) VALUES (22, 3, N'Tenda A9', N'Sản phẩm dùng để kích sóng wifi trong nhà bạn', 250000, N'Kích Sóng Wifi', N'tendarepatera9.jpg', N'tenda-a9                      ', CAST(0x863F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETHO__Order__3B75D760] FOREIGN KEY([OrderID])
REFERENCES [dbo].[HOADON] ([OrderID])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK__CHITIETHO__Order__3B75D760]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETHO__Produ__3C69FB99] FOREIGN KEY([ProductID])
REFERENCES [dbo].[SANPHAM] ([Id])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK__CHITIETHO__Produ__3C69FB99]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETHO__UserI__3D5E1FD2] FOREIGN KEY([UserID])
REFERENCES [dbo].[NGUOIDUNG] ([Id])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK__CHITIETHO__UserI__3D5E1FD2]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__UserID__267ABA7A] FOREIGN KEY([UserID])
REFERENCES [dbo].[NGUOIDUNG] ([Id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__UserID__267ABA7A]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK__SANPHAM__Categor__38996AB5] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[DANHMUC] ([CategoryID])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK__SANPHAM__Categor__38996AB5]
GO
USE [master]
GO
ALTER DATABASE [KTTKPM_DHKTPM12A_BAITAPLON_NHOM23] SET  READ_WRITE 
GO
