USE [master]
GO
/****** Object:  Database [Asm]    Script Date: 3/6/2023 3:23:17 PM ******/
CREATE DATABASE [Asm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Asm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Asm.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Asm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Asm_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Asm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Asm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Asm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Asm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Asm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Asm] SET ARITHABORT OFF 
GO
ALTER DATABASE [Asm] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Asm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Asm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Asm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Asm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Asm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Asm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Asm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Asm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Asm] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Asm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Asm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Asm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Asm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Asm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Asm] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Asm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Asm] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Asm] SET  MULTI_USER 
GO
ALTER DATABASE [Asm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Asm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Asm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Asm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Asm] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Asm] SET QUERY_STORE = OFF
GO
USE [Asm]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Publisher] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NOT NULL,
	[YearPublished] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[Total] [float] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 3/6/2023 3:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](max) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220815092424_1', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220815092736_2', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220815160225_3', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816013942_4', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816020239_5', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816032906_6', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816034001_first', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817095544_7', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817124112_8', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817133827_10', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817140415_11', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817143326_12', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220817145107_13', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220818022456_new4', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220818023158_h1', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220818024932_new5', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220819160649_final', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220819161057_final1', N'3.1.26')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220819161233_final2', N'3.1.26')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'Admin', N'496b7fc1-1846-4f88-9a2c-e35885262c8d')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'StoreOwner', N'StoreOwner', N'15925a31-532f-41ca-97fd-9ab9aa4c76b8')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Customer', N'Customer', N'48fcba8b-8fa9-44cd-936e-37605329e0f4')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3', N'3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ae620006-4c0d-4366-a0cd-deb3670a4b72', N'3')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1', N'admin@gmail.com', N'admin@gmail.com', N'admin@gmail.com', NULL, 0, N'AQAAAAEAACcQAAAAEE5R9wSzlxTeXAgFuPNnFsaoCHAJKE6jUTC5PFkVolK+p4H3L75zGeOAzGrnTgyw7A==', N'd2a78f4f-469b-4d49-8983-3927f3553a21', N'0bf03bd0-2dac-4826-b87c-d9cc7e9b7146', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2', N'storeowner@gmail.com', N'storeowner@gmail.com', N'storeowner@gmail.com', NULL, 0, N'AQAAAAEAACcQAAAAEKbE5KyavbdCRp0ckHk+2/8BMXqP/ec2Bd2OHRgBTRm/VW0Y5BFMf/8kBmDyufUiDg==', N'c7908ebe-3c55-4ed4-8992-bec5b811ce46', N'eccd2ab5-074f-4840-a131-c231d8a92c67', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3', N'customer@gmail.com', N'customer@gmail.com', N'customer@gmail.com', NULL, 0, N'AQAAAAEAACcQAAAAEMFng5tz6PfWBRAddRnRnNpg0N/fC29w0AnXqfrU4CgRoZytC/SMPaTPe21JZX/ZVg==', N'2028f719-22d6-4e6e-bce5-21c7b6c047f5', N'c7f65d94-084f-41e2-85f9-26b0892ac623', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ae620006-4c0d-4366-a0cd-deb3670a4b72', N'viet123@gmail.com', N'VIET123@GMAIL.COM', N'viet123@gmail.com', N'VIET123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEM5QGId5bv482oZxzIrU5AIwzNBZAXqPZ7ilk4aXlREub+9gKmIOsVYNlsdPUzTnqQ==', N'4BSBWEQYBMEYXHOAXMPYZVYEXT2JKIGS', N'2faa2e7f-ab62-4e96-86da-297e4433a21d', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Title], [Publisher], [Author], [YearPublished], [Image], [Price], [Quantity], [CategoryId]) VALUES (1, N'Harry Potter Vol 1', N'Bloomsbury', N'J.K. Rowling', 1997, N'https://images-na.ssl-images-amazon.com/images/I/515iJ1-+IvL.jpg', 11.99, 98, 1)
INSERT [dbo].[Book] ([Id], [Title], [Publisher], [Author], [YearPublished], [Image], [Price], [Quantity], [CategoryId]) VALUES (2, N'Sherlock Holmes Vol 1', N'Kim Dong', N'Conan Doyle', 1892, N'https://images-na.ssl-images-amazon.com/images/I/41Di3v-DFZL._SX363_BO1,204,203,200_.jpg', 10, 99, 2)
INSERT [dbo].[Book] ([Id], [Title], [Publisher], [Author], [YearPublished], [Image], [Price], [Quantity], [CategoryId]) VALUES (3, N'DoraBase', N'Kim Dong', N'Mugiwara', 2008, N'https://images.thuvienpdf.com/LVAq31.webp', 6, 45, 4)
INSERT [dbo].[Book] ([Id], [Title], [Publisher], [Author], [YearPublished], [Image], [Price], [Quantity], [CategoryId]) VALUES (4, N'IT - Gã Hề Ma Quái', N'Thanh Niên', N'Stephen King', 2022, N'https://cdn0.fahasa.com/media/catalog/product/8/9/8936066693349-1_2.jpg', 15, 49, 3)
INSERT [dbo].[Book] ([Id], [Title], [Publisher], [Author], [YearPublished], [Image], [Price], [Quantity], [CategoryId]) VALUES (5, N'Đắc Nhân Tâm', N'NXB Trẻ', N'Dale Carnagie', 2012, N'https://s.memehay.com/files/posts/20201216/cuon-sach-dak-nhan-tam-dark-nhan-tam.png', 15, 2000, 5)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Fantasy')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Detective')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Horror')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Manga')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (5, N'Business')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [UserId], [Total], [Status]) VALUES (3, N'ae620006-4c0d-4366-a0cd-deb3670a4b72', 10, 0)
INSERT [dbo].[Order] ([Id], [UserId], [Total], [Status]) VALUES (4, N'ae620006-4c0d-4366-a0cd-deb3670a4b72', 6, 0)
INSERT [dbo].[Order] ([Id], [UserId], [Total], [Status]) VALUES (5, N'ae620006-4c0d-4366-a0cd-deb3670a4b72', 24, 0)
INSERT [dbo].[Order] ([Id], [UserId], [Total], [Status]) VALUES (6, N'ae620006-4c0d-4366-a0cd-deb3670a4b72', 11.99, 0)
INSERT [dbo].[Order] ([Id], [UserId], [Total], [Status]) VALUES (7, N'ae620006-4c0d-4366-a0cd-deb3670a4b72', 26.990000000000002, 0)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (4, 1, 3, 2, 10)
INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (5, 1, 4, 3, 6)
INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (6, 4, 5, 3, 24)
INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (7, 1, 6, 1, 11.99)
INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (8, 1, 7, 1, 11.99)
INSERT [dbo].[OrderDetail] ([Id], [Quantity], [OrderId], [BookId], [Total]) VALUES (9, 1, 7, 4, 15)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Book_CategoryId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Book_CategoryId] ON [dbo].[Book]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_BookId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_BookId] ON [dbo].[OrderDetail]
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_OrderId]    Script Date: 3/6/2023 3:23:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_OrderId] ON [dbo].[OrderDetail]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category_CategoryId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Book_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Book_BookId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order_OrderId]
GO
USE [master]
GO
ALTER DATABASE [Asm] SET  READ_WRITE 
GO
