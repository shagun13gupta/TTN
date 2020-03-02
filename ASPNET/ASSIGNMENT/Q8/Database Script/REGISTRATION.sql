CREATE DATABASE [REGISTRATION]
GO

USE [REGISTRATION]
GO
/****** Object:  Table [dbo].[login]    Script Date: 01-03-2020 19:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[uname] [varchar](50) NULL,
	[pass] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[register]    Script Date: 01-03-2020 19:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[fname] [varchar](20) NULL,
	[lname] [varchar](20) NULL,
	[gen] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[addresses] [varchar](50) NULL,
	[phoneno] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 01-03-2020 19:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[fname] [varchar](20) NULL,
	[lname] [varchar](20) NULL,
	[gen] [varchar](20) NULL,
	[age] [int] NULL,
	[email] [varchar](50) NULL,
	[addresses] [varchar](50) NULL,
	[phoneno] [varchar](20) NULL,
	[pass] [varchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[login] ([uname], [pass]) VALUES (N'shagun.gupta@tothenew.com', N'shagun123')
GO
INSERT [dbo].[login] ([uname], [pass]) VALUES (N'shagun.gupta@tothenew.com', N'shagun123')
GO
INSERT [dbo].[login] ([uname], [pass]) VALUES (N'gupta.gaurav2503@gmail.com', N'gaurav@1234')
GO
INSERT [dbo].[login] ([uname], [pass]) VALUES (N'neha@tothenew.com', N'123456')
GO
INSERT [dbo].[register] ([fname], [lname], [gen], [email], [addresses], [phoneno]) VALUES (N'shagun ', N'gupta', N'Female', N'shagun.gupta@tothenew.com', N'A/25 badarpur', N'9868940221')
GO
INSERT [dbo].[register] ([fname], [lname], [gen], [email], [addresses], [phoneno]) VALUES (N'Gaurav', N'Gupta', N'Male', N'gupta.gaurav2503@gmail.com', N'A/20 Sarita vihar Noida', N'7982846134')
GO
INSERT [dbo].[register] ([fname], [lname], [gen], [email], [addresses], [phoneno]) VALUES (N'shagun ', N'gupta', N'Female', N'shagun.gupta@tothenew.com', N'A/25 badarpur', N'9868940221')
GO
INSERT [dbo].[register] ([fname], [lname], [gen], [email], [addresses], [phoneno]) VALUES (N'Gaurav', N'Gupta', N'Male', N'gupta.gaurav2503@gmail.com', N'A/20 Sarita vihar Noida', N'7982846134')
GO
INSERT [dbo].[student] ([fname], [lname], [gen], [age], [email], [addresses], [phoneno], [pass]) VALUES (N'shagun', N'gupta', N'Female', 20, N'shagungupta@tothenew.com', N'H.no A/25 Shakti vihar', N'9876778211', N'123')
GO
