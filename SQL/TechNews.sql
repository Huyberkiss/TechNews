USE [master]
GO
/****** Object:  Database [TechNews]    Script Date: 11/1/2020 1:21:35 PM ******/
CREATE DATABASE [TechNews]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechNews', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TechNews.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechNews_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TechNews_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TechNews] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechNews].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechNews] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechNews] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechNews] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechNews] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechNews] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechNews] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechNews] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechNews] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechNews] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechNews] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechNews] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechNews] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechNews] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechNews] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechNews] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechNews] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechNews] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechNews] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechNews] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechNews] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechNews] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechNews] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechNews] SET RECOVERY FULL 
GO
ALTER DATABASE [TechNews] SET  MULTI_USER 
GO
ALTER DATABASE [TechNews] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechNews] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechNews] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechNews] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechNews] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TechNews', N'ON'
GO
ALTER DATABASE [TechNews] SET QUERY_STORE = OFF
GO
USE [TechNews]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[aID] [int] IDENTITY(1,1) NOT NULL,
	[aUsername] [varchar](50) NULL,
	[aPassword] [varchar](32) NULL,
	[aFullname] [varchar](100) NULL,
	[aBirthday] [date] NULL,
	[aGender] [int] NULL,
	[aPhone] [int] NULL,
	[aEmail] [varchar](100) NULL,
	[aAddress] [varchar](125) NULL,
	[aStatus] [int] NULL,
	[aDateAdded] [date] NULL,
	[roleID] [int] NULL,
	[countryID] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[aID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[cateID] [int] NOT NULL,
	[cateName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[cateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[commentID] [int] IDENTITY(1,1) NOT NULL,
	[commentContent] [ntext] NULL,
	[aID] [int] NULL,
	[postID] [int] NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[commentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[countryID] [int] NOT NULL,
	[countryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[countryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[hID] [int] IDENTITY(1,1) NOT NULL,
	[dateSubmited] [date] NULL,
	[dateAccepted] [date] NULL,
	[typeAccept] [int] NULL,
	[censorID] [int] NULL,
	[posterID] [int] NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[hID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[pictureID] [int] NOT NULL,
	[urlPicture] [nvarchar](100) NOT NULL,
	[postID] [int] NULL,
 CONSTRAINT [PK_Picture] PRIMARY KEY CLUSTERED 
(
	[pictureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[postID] [int] IDENTITY(1,1) NOT NULL,
	[postTitle] [nvarchar](100) NOT NULL,
	[postContent] [ntext] NOT NULL,
	[postStatus] [int] NOT NULL,
	[cateID] [int] NOT NULL,
	[hID] [int] NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[postID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/1/2020 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleID] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](30) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aBirthday], [aGender], [aPhone], [aEmail], [aAddress], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (1, N'phucth', N'e10adc3949ba59abbe56e057f20f883e', N'Tran Hoang Phuc', CAST(N'2000-10-28' AS Date), 0, 987654321, N'phuc@gmail.com', N'Vinh Long', 0, CAST(N'2020-10-26' AS Date), 1, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aBirthday], [aGender], [aPhone], [aEmail], [aAddress], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (2, N'quith', N'e10adc3949ba59abbe56e057f20f883e', N'Tran Hoang Qui', CAST(N'2000-10-01' AS Date), 0, 123456789, N'qui@gmail.com', N'Tra Vinh', 0, CAST(N'2020-10-26' AS Date), 2, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aBirthday], [aGender], [aPhone], [aEmail], [aAddress], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (3, N'thinhbnp', N'e10adc3949ba59abbe56e057f20f883e', N'Bach Nguyen Phuc Thinh', CAST(N'2000-01-01' AS Date), 0, 131234123, N'thinh@gmail.com', N'Can Tho', 0, CAST(N'2020-10-26' AS Date), 3, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aBirthday], [aGender], [aPhone], [aEmail], [aAddress], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (4, N'huyndq', N'e10adc3949ba59abbe56e057f20f883e', N'Nguyen Duy Quang Huy', CAST(N'2000-10-01' AS Date), 0, 987654321, N'huy@gmail.com', N'Can Tho', 0, CAST(N'2020-09-26' AS Date), 4, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aBirthday], [aGender], [aPhone], [aEmail], [aAddress], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (5, N'khang', N'123', N'a', CAST(N'2000-10-01' AS Date), 0, 987654321, N'khang@gmai.com', N'Can Tho', 0, CAST(N'2020-09-26' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
INSERT [dbo].[Country] ([countryID], [countryName]) VALUES (1, N'Viet Nam')
INSERT [dbo].[Country] ([countryID], [countryName]) VALUES (2, N'My')
GO
SET IDENTITY_INSERT [dbo].[History] ON 

INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'2020-10-26' AS Date), 1, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (2, CAST(N'2020-10-26' AS Date), CAST(N'2020-10-26' AS Date), 1, 4, 3)
SET IDENTITY_INSERT [dbo].[History] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (2, N'User')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (3, N'Poster')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (4, N'Censor')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([countryID])
REFERENCES [dbo].[Country] ([countryID])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([roleID])
REFERENCES [dbo].[Role] ([roleID])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Account] FOREIGN KEY([aID])
REFERENCES [dbo].[Account] ([aID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Account]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([aID])
REFERENCES [dbo].[Account] ([aID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([postID])
REFERENCES [dbo].[Post] ([postID])
GO
ALTER TABLE [dbo].[Picture]  WITH CHECK ADD FOREIGN KEY([postID])
REFERENCES [dbo].[Post] ([postID])
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD FOREIGN KEY([cateID])
REFERENCES [dbo].[Category] ([cateID])
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD FOREIGN KEY([hID])
REFERENCES [dbo].[History] ([hID])
GO
USE [master]
GO
ALTER DATABASE [TechNews] SET  READ_WRITE 
GO
