CREATE DATABASE [LoginDB]
GO

USE [LoginDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17-03-2020 10:23:53 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 17-03-2020 10:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NULL,
	[Role] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17-03-2020 10:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[Name] [varchar](20) NULL,
	[Marks] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([UserName], [Password], [Role]) VALUES (N'admin', N'123', N'admin')
GO
INSERT [dbo].[Login] ([UserName], [Password], [Role]) VALUES (N'shagun', N'ttn', N'admin')
GO
INSERT [dbo].[Student] ([Id], [Name], [Marks]) VALUES (1, N'shagun', 98)
GO
INSERT [dbo].[Student] ([Id], [Name], [Marks]) VALUES (2, N'gaurav', 100)
GO
INSERT [dbo].[Student] ([Id], [Name], [Marks]) VALUES (3, N'arpit', 95)
GO
INSERT [dbo].[Student] ([Id], [Name], [Marks]) VALUES (4, N'Neha', 90)
GO
INSERT [dbo].[Student] ([Id], [Name], [Marks]) VALUES (5, N'Isrg', 98)
GO
