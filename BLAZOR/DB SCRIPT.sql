CREATE DATABASE [BlazorDb]
GO

USE [BlazorDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11-04-2020 16:58:29 ******/
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
/****** Object:  Table [dbo].[Logins]    Script Date: 11-04-2020 16:58:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NavBarInfo]    Script Date: 11-04-2020 16:58:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NavBarInfo](
	[NavId] [int] IDENTITY(1,1) NOT NULL,
	[LinkName] [varchar](100) NULL,
	[LinkAddress] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NavId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11-04-2020 16:58:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](10) NULL,
	[Course] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200409173058_Initial', N'3.1.3')
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 
GO
INSERT [dbo].[Logins] ([Id], [UserName], [Password]) VALUES (1, N'shagun', N'ttn')
GO
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[NavBarInfo] ON 
GO
INSERT [dbo].[NavBarInfo] ([NavId], [LinkName], [LinkAddress]) VALUES (1, N'Home', N'Index')
GO
INSERT [dbo].[NavBarInfo] ([NavId], [LinkName], [LinkAddress]) VALUES (2, N'List Students', N'liststudent')
GO
INSERT [dbo].[NavBarInfo] ([NavId], [LinkName], [LinkAddress]) VALUES (3, N'Counter', N'counter')
GO
SET IDENTITY_INSERT [dbo].[NavBarInfo] OFF
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [Gender], [Course], [Address]) VALUES (1, N'Shagun', N'gupta', 22, N'Female', N'MCA', N'Badarpur New Delhi')
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [Gender], [Course], [Address]) VALUES (2, N'Gaurav', N'Gupta', 18, N'Male', N'Secondary schoo', N'Badarpur New Delhi')
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [Gender], [Course], [Address]) VALUES (3, N'Neha', N'Goyal', 24, N'Female', N'TTN', N'Akshardham New Delhi 110044')
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [Gender], [Course], [Address]) VALUES (4, N'punita', N'yadav', 23, N'Female', N'bca', N'faridabad')
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [Gender], [Course], [Address]) VALUES (5, N'hitesh', N'kumar', 7, N'Female', N'yu', N'rt')
GO

