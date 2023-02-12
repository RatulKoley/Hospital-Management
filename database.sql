USE [master]
GO
/****** Object:  Database [HospitalManagement]    Script Date: 13-02-2023 02:54:55 AM ******/
CREATE DATABASE [HospitalManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalManagement', FILENAME = N'D:\Installed Apps\sql server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HospitalManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HospitalManagement_log', FILENAME = N'D:\Installed Apps\sql server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HospitalManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HospitalManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HospitalManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HospitalManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HospitalManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HospitalManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HospitalManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HospitalManagement] SET QUERY_STORE = OFF
GO
USE [HospitalManagement]
GO
/****** Object:  Table [dbo].[Allergy]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allergy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Center]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Center](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Center] [varchar](50) NULL,
	[Place_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostics]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostics](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[District] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Doctor] [varchar](50) NULL,
	[Center_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[CR_Number] [bigint] IDENTITY(2563451487461,1) NOT NULL,
	[Aadhar_No] [bigint] NULL,
	[First_Name] [varchar](50) NULL,
	[Middle_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Relative] [varchar](50) NULL,
	[Relative_Name] [varchar](50) NULL,
	[Age_Year] [int] NULL,
	[Age_Month] [int] NULL,
	[Blood_Group] [varchar](50) NULL,
	[Marital_Status] [varchar](50) NULL,
	[Mobile] [bigint] NULL,
	[Email] [varchar](50) NULL,
	[Picture] [varchar](max) NULL,
	[Gender] [char](1) NULL,
	[Address] [varchar](max) NULL,
	[District_Name] [int] NULL,
	[Place] [int] NULL,
	[PIN] [bigint] NULL,
	[Registration_Date] [date] NULL,
	[Admin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CR_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Case]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Case](
	[Case_No] [bigint] IDENTITY(64532654,2) NOT NULL,
	[Patient_ID] [bigint] NULL,
	[Gender] [char](1) NULL,
	[Mobile] [bigint] NULL,
	[Medical_Records] [varchar](max) NULL,
	[Exam_Category] [varchar](50) NULL,
	[Examination_def] [varchar](max) NULL,
	[Allergy_Name] [int] NULL,
	[Allergy_Status] [varchar](10) NULL,
	[Allergy_Duration] [varchar](50) NULL,
	[Allergy_Severity] [varchar](50) NULL,
	[Allergy_Def] [varchar](max) NULL,
	[Problem_Name] [int] NULL,
	[Problem_Defination] [varchar](50) NULL,
	[Diagnostics_Name] [int] NULL,
	[District_Name] [int] NULL,
	[Place] [int] NULL,
	[Center_Name] [int] NULL,
	[Doctor_Name] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Case_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Place]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Place] [varchar](50) NULL,
	[Dist_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Problems]    Script Date: 13-02-2023 02:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Problems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[District] ON 
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (1, N'Hooghly')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (2, N'Howrah')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (3, N'Purba Bardhaman')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (5, N'Bankura')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (6, N'Birbhum')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (7, N'Purulia')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (8, N'Purba Mednipur')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (9, N'Paschim Medinipur')
GO
INSERT [dbo].[District] ([ID], [District]) VALUES (10, N'Paschim Bardhaman')
GO
SET IDENTITY_INSERT [dbo].[District] OFF
GO
SET IDENTITY_INSERT [dbo].[Place] ON 
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (1, N'Arambag', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (2, N'Chanditala', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (3, N'Chinsurah', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (4, N'Goghat', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (5, N'Khanakul', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (6, N'Serampore', 1)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (7, N'Amta', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (8, N'Bagnan', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (9, N'Uluberia', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (10, N'Shyampur', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (11, N'Domjur', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (12, N'Panchla', 2)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (13, N'Bardhaman', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (14, N'Katwa', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (15, N'Kalna', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (16, N'Memari', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (17, N'Jamalpur', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (18, N'Bhatar', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (19, N'Ketugram', 3)
GO
INSERT [dbo].[Place] ([ID], [Place], [Dist_ID]) VALUES (20, N'Kolkata', 2)
GO
SET IDENTITY_INSERT [dbo].[Place] OFF
GO
ALTER TABLE [dbo].[Center]  WITH CHECK ADD FOREIGN KEY([Place_ID])
REFERENCES [dbo].[Place] ([ID])
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD FOREIGN KEY([Center_ID])
REFERENCES [dbo].[Center] ([ID])
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD FOREIGN KEY([District_Name])
REFERENCES [dbo].[District] ([ID])
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD FOREIGN KEY([Place])
REFERENCES [dbo].[Place] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Allergy_Name])
REFERENCES [dbo].[Allergy] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Center_Name])
REFERENCES [dbo].[Center] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Diagnostics_Name])
REFERENCES [dbo].[Diagnostics] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([District_Name])
REFERENCES [dbo].[District] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Doctor_Name])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([CR_Number])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Place])
REFERENCES [dbo].[Place] ([ID])
GO
ALTER TABLE [dbo].[Patient_Case]  WITH CHECK ADD FOREIGN KEY([Problem_Name])
REFERENCES [dbo].[Problems] ([ID])
GO
ALTER TABLE [dbo].[Place]  WITH CHECK ADD FOREIGN KEY([Dist_ID])
REFERENCES [dbo].[District] ([ID])
GO
USE [master]
GO
ALTER DATABASE [HospitalManagement] SET  READ_WRITE 
GO
