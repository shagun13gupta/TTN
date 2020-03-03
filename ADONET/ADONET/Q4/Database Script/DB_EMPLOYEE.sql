CREATE DATABASE [DB_EMPLOYEE]
GO

USE [DB_EMPLOYEE]
GO
/****** Object:  UserDefinedFunction [dbo].[GETNAME]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GETNAME](@RNO INT)
RETURNS VARCHAR(20)
AS
BEGIN
  RETURN (SELECT NAME from student where ROLL_NO=@RNO)
END
GO
/****** Object:  Table [dbo].[SALARY]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALARY](
	[EMP_ID] [int] NULL,
	[MONTHS] [varchar](20) NULL,
	[SALARY] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[salary_view]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[salary_view] as
select emp_id,sum(salary) total
from SALARY
group by EMP_ID
GO
/****** Object:  Table [dbo].[test]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[name] [varchar](20) NULL,
	[age] [int] NULL,
	[city] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[test_view]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[test_view] as
select name,city
from test
GO
/****** Object:  Table [dbo].[student]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[ROLL_NO] [int] NULL,
	[NAME] [varchar](20) NULL,
	[MARKS] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GETSTUDENT]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GETSTUDENT](@MARK INT)
RETURNS TABLE
AS
  RETURN (SELECT *FROM student where MARKS>=@MARK)
GO
/****** Object:  Table [dbo].[copy_test]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[copy_test](
	[username] [varchar](20) NULL,
	[age] [int] NULL,
	[city] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[EMP_ID] [int] IDENTITY(100,1) NOT NULL,
	[EMP_NAME] [varchar](50) NULL,
	[MOBILE_NO] [varchar](20) NULL,
	[DOB] [date] NULL,
	[EMP_ADDRESS] [varchar](20) NULL,
	[SALARY] [money] NULL,
	[ZIP_CODE] [int] NULL,
	[IS_ACTIVE] [bit] NULL,
	[CREATED_DATE] [datetime] NULL,
	[MODIFIED_DATE] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[copy_test] ([username], [age], [city]) VALUES (N'shagun', 22, N'delhi')
GO
INSERT [dbo].[copy_test] ([username], [age], [city]) VALUES (N'sonal', 21, N'allahabad')
GO
INSERT [dbo].[copy_test] ([username], [age], [city]) VALUES (N'punita', 23, N'faridabad')
GO
INSERT [dbo].[copy_test] ([username], [age], [city]) VALUES (N'neha', 24, N'akshardham')
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON 
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (100, N'shagun', N'9868940221', CAST(N'1997-02-13' AS Date), N'Badarpur', 135000.0000, 110044, 1, CAST(N'2020-02-26T16:53:26.090' AS DateTime), NULL)
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (101, N'punita', N'8800996677', CAST(N'1996-04-05' AS Date), N'Faridabad', 55000.0000, 110042, 1, CAST(N'2020-02-26T16:56:09.390' AS DateTime), NULL)
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (102, N'latika', N'9878906567', CAST(N'1995-06-23' AS Date), N'Janakpuri', 83000.0000, 110032, 1, CAST(N'2020-02-26T16:57:43.850' AS DateTime), NULL)
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (103, N'neha', N'9475986567', CAST(N'1995-10-23' AS Date), N'Akshardham', 50000.0000, 220032, 1, CAST(N'2020-02-26T21:30:32.670' AS DateTime), NULL)
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (104, N'sonal', N'8878506598', CAST(N'1998-11-13' AS Date), N'Allahabad', 84000.0000, 230466, 1, CAST(N'2020-02-26T21:31:35.700' AS DateTime), NULL)
GO
INSERT [dbo].[EMPLOYEE] ([EMP_ID], [EMP_NAME], [MOBILE_NO], [DOB], [EMP_ADDRESS], [SALARY], [ZIP_CODE], [IS_ACTIVE], [CREATED_DATE], [MODIFIED_DATE]) VALUES (105, N'arpit', N'7878306467', CAST(N'1998-12-10' AS Date), N'Ghaziabad', 131000.0000, 230032, 1, CAST(N'2020-02-26T21:32:31.297' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (101, N'JAN', 30000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (101, N'FEB', 25000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (102, N'MARCH', 32000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (102, N'APRIL', 22000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (102, N'SEPT', 29000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (100, N'JAN', 25000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (100, N'FEB', 32000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (100, N'MARCH', 38000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (100, N'APRIL', 40000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (103, N'JAN', 15000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (103, N'MARCH', 22000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (103, N'APRIL', 13000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (104, N'JULY', 12000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (104, N'AUG', 18000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (104, N'OCT', 25000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (104, N'NOV', 29000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (105, N'MAY', 33000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (105, N'JUNE', 39000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (105, N'JULY', 21000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (105, N'AUG', 29000.0000)
GO
INSERT [dbo].[SALARY] ([EMP_ID], [MONTHS], [SALARY]) VALUES (105, N'SEPT', 9000.0000)
GO
INSERT [dbo].[student] ([ROLL_NO], [NAME], [MARKS]) VALUES (1, N'SHAGUN', 90)
GO
INSERT [dbo].[student] ([ROLL_NO], [NAME], [MARKS]) VALUES (2, N'GAURAV', 98)
GO
INSERT [dbo].[student] ([ROLL_NO], [NAME], [MARKS]) VALUES (3, N'RAAZ', 80)
GO
INSERT [dbo].[student] ([ROLL_NO], [NAME], [MARKS]) VALUES (4, N'VAIBHAV', 95)
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'shagun', 22, N'delhi')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'gaurav', 21, N'allahabad')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'punita', 23, N'faridabad')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'neha', 24, N'akshardham')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'isrg', 23, N'GK')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'shivangi', 22, N'delhi')
GO
INSERT [dbo].[test] ([name], [age], [city]) VALUES (N'shraddha', 22, N'delhi')
GO
ALTER TABLE [dbo].[EMPLOYEE] ADD  DEFAULT (NULL) FOR [SALARY]
GO
ALTER TABLE [dbo].[EMPLOYEE] ADD  DEFAULT (getdate()) FOR [CREATED_DATE]
GO
ALTER TABLE [dbo].[SALARY]  WITH CHECK ADD FOREIGN KEY([EMP_ID])
REFERENCES [dbo].[EMPLOYEE] ([EMP_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD CHECK  ((len([ZIP_CODE])=(6)))
GO
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [TENDIGITS] CHECK  (([MOBILE_NO] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [TENDIGITS]
GO
/****** Object:  StoredProcedure [dbo].[CallUpdate_proc]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CallUpdate_proc]
(
 @TName varchar(20),
 @TAge int
)
as
begin
exec UpdateTest_proc @Name=@TName , @Age=@TAge
end
GO
/****** Object:  StoredProcedure [dbo].[proc1]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc1]
as
begin
 select * from test
end
GO
/****** Object:  StoredProcedure [dbo].[proc2]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc2]
as
begin
  exec proc1
end
GO
/****** Object:  StoredProcedure [dbo].[TestShow_proc]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[TestShow_proc]
@Age int,
@Name varchar(20)
as 
begin
select * from test where age=@Age and name like @Name + '%'
end 
GO
/****** Object:  StoredProcedure [dbo].[UpdateTest_proc]    Script Date: 02-03-2020 08:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateTest_proc]
(@Name varchar(20),
 @Age int
)
as
begin
update test set name=@Name where age=@Age
end
GO
