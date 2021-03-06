USE [master]
GO
/****** Object:  Database [StockMS]    Script Date: 8/2/2018 4:24:36 AM ******/
CREATE DATABASE [StockMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockMS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockMS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StockMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StockMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockMS] SET  MULTI_USER 
GO
ALTER DATABASE [StockMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockMS] SET QUERY_STORE = OFF
GO
USE [StockMS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [StockMS]
GO
/****** Object:  Table [dbo].[category]    Script Date: 8/2/2018 4:24:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(101,1) NOT NULL,
	[name] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company]    Script Date: 8/2/2018 4:24:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[id] [int] IDENTITY(101,1) NOT NULL,
	[name] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item]    Script Date: 8/2/2018 4:24:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[id] [int] IDENTITY(101,1) NOT NULL,
	[name] [nvarchar](150) NULL,
	[reorderlevel] [int] NULL,
	[categoryId] [int] NULL,
	[companyId] [int] NULL,
	[date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name]) VALUES (101, N'Stationary')
INSERT [dbo].[category] ([id], [name]) VALUES (102, N'Baverages')
INSERT [dbo].[category] ([id], [name]) VALUES (103, N'Foods')
INSERT [dbo].[category] ([id], [name]) VALUES (104, N'Furniture')
INSERT [dbo].[category] ([id], [name]) VALUES (105, N'Vehicles')
INSERT [dbo].[category] ([id], [name]) VALUES (106, N'ByCycle')
INSERT [dbo].[category] ([id], [name]) VALUES (107, N'Car')
INSERT [dbo].[category] ([id], [name]) VALUES (108, N'Electronics')
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[company] ON 

INSERT [dbo].[company] ([id], [name]) VALUES (101, N'RFL Company')
INSERT [dbo].[company] ([id], [name]) VALUES (102, N'Gazi')
INSERT [dbo].[company] ([id], [name]) VALUES (103, N'Square Ltd')
INSERT [dbo].[company] ([id], [name]) VALUES (104, N'Uniliver Ltd')
INSERT [dbo].[company] ([id], [name]) VALUES (105, N'Bangladesh Mills')
SET IDENTITY_INSERT [dbo].[company] OFF
SET IDENTITY_INSERT [dbo].[item] ON 

INSERT [dbo].[item] ([id], [name], [reorderlevel], [categoryId], [companyId], [date]) VALUES (101, N'fan', 10, 101, 101, CAST(N'2018-08-02' AS Date))
INSERT [dbo].[item] ([id], [name], [reorderlevel], [categoryId], [companyId], [date]) VALUES (102, N'All time pen', 15, 101, 101, CAST(N'2018-08-02' AS Date))
INSERT [dbo].[item] ([id], [name], [reorderlevel], [categoryId], [companyId], [date]) VALUES (103, N'Coco Cola', 20, 103, 104, CAST(N'2018-08-02' AS Date))
SET IDENTITY_INSERT [dbo].[item] OFF
ALTER TABLE [dbo].[item] ADD  DEFAULT (getdate()) FOR [date]
GO
USE [master]
GO
ALTER DATABASE [StockMS] SET  READ_WRITE 
GO
