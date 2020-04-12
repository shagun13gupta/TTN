CREATE DATABASE [UserDB]
GO

USE [UserDB]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12-04-2020 18:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](10) NULL,
	[Phone] [varchar](20) NULL,
	[City] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12-04-2020 18:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Roles] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (1, N'Shagun Gupta', 22, N'Female', N'9868940221', N'Delhi')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (2, N'Punita', 23, N'Female', N'8869940221', N'Faridabad')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (3, N'Latika', 23, N'Female', N'7869940221', N'Janakpuri')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (4, N'arpit', 21, N'Male', N'787587745', N'new delhi')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (5, N'Neha', 24, N'Female', N'7847874583', N'akshardham')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Age], [Gender], [Phone], [City]) VALUES (6, N'Raaz', 18, N'Male', N'78784362666', N'Tuglakabad')
GO
INSERT [dbo].[Login] ([Id], [UserName], [Password], [Roles]) VALUES (1, N'shagun', N'ttn', N'admin')
GO
INSERT [dbo].[Login] ([Id], [UserName], [Password], [Roles]) VALUES (2, N'gaurav', N'123', N'user')
GO
