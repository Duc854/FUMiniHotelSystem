USE [master]
GO
/****** Object:  Database [FUMiniHotelManagement]    Script Date: 2/25/2025 10:20:48 AM ******/
CREATE DATABASE [FUMiniHotelManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FUMiniHotelManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUC\MSSQL\DATA\FUMiniHotelManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FUMiniHotelManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUC\MSSQL\DATA\FUMiniHotelManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FUMiniHotelManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FUMiniHotelManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FUMiniHotelManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FUMiniHotelManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FUMiniHotelManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FUMiniHotelManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FUMiniHotelManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [FUMiniHotelManagement] SET  MULTI_USER 
GO
ALTER DATABASE [FUMiniHotelManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FUMiniHotelManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FUMiniHotelManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FUMiniHotelManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FUMiniHotelManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FUMiniHotelManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FUMiniHotelManagement', N'ON'
GO
ALTER DATABASE [FUMiniHotelManagement] SET QUERY_STORE = OFF
GO
USE [FUMiniHotelManagement]
GO
/****** Object:  Table [dbo].[BookingDetail]    Script Date: 2/25/2025 10:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingDetail](
	[BookingReservationID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ActualPrice] [money] NULL,
 CONSTRAINT [PK_BookingDetail] PRIMARY KEY CLUSTERED 
(
	[BookingReservationID] ASC,
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingReservation]    Script Date: 2/25/2025 10:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingReservation](
	[BookingReservationID] [int] NOT NULL,
	[BookingDate] [date] NULL,
	[TotalPrice] [money] NULL,
	[CustomerID] [int] NOT NULL,
	[BookingStatus] [tinyint] NULL,
 CONSTRAINT [PK_BookingReservation] PRIMARY KEY CLUSTERED 
(
	[BookingReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/25/2025 10:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(3,1) NOT NULL,
	[CustomerFullName] [nvarchar](50) NULL,
	[Telephone] [nvarchar](12) NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[CustomerBirthday] [date] NULL,
	[CustomerStatus] [tinyint] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomInformation]    Script Date: 2/25/2025 10:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomInformation](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](50) NOT NULL,
	[RoomDetailDescription] [nvarchar](220) NULL,
	[RoomMaxCapacity] [int] NULL,
	[RoomTypeID] [int] NOT NULL,
	[RoomStatus] [tinyint] NULL,
	[RoomPricePerDay] [money] NULL,
 CONSTRAINT [PK_RoomInformation] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 2/25/2025 10:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[RoomTypeID] [int] IDENTITY(1,1) NOT NULL,
	[RoomTypeName] [nvarchar](50) NOT NULL,
	[TypeDescription] [nvarchar](250) NULL,
	[TypeNote] [nvarchar](250) NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[RoomTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetail_BookingReservation] FOREIGN KEY([BookingReservationID])
REFERENCES [dbo].[BookingReservation] ([BookingReservationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookingDetail] CHECK CONSTRAINT [FK_BookingDetail_BookingReservation]
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetail_RoomInformation] FOREIGN KEY([RoomID])
REFERENCES [dbo].[RoomInformation] ([RoomID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookingDetail] CHECK CONSTRAINT [FK_BookingDetail_RoomInformation]
GO
ALTER TABLE [dbo].[BookingReservation]  WITH CHECK ADD  CONSTRAINT [FK_BookingReservation_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookingReservation] CHECK CONSTRAINT [FK_BookingReservation_Customer]
GO
ALTER TABLE [dbo].[RoomInformation]  WITH CHECK ADD  CONSTRAINT [FK_RoomInformation_RoomType] FOREIGN KEY([RoomTypeID])
REFERENCES [dbo].[RoomType] ([RoomTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoomInformation] CHECK CONSTRAINT [FK_RoomInformation_RoomType]
GO
USE [master]
GO
ALTER DATABASE [FUMiniHotelManagement] SET  READ_WRITE 
GO
