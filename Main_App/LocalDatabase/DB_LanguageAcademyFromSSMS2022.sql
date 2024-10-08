USE [Db_Zabansara]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[LevelCount] [tinyint] NOT NULL,
	[Tuition] [char](10) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Year] [smallint] NOT NULL,
	[Term] [tinyint] NOT NULL,
	[LevelCourse] [tinyint] NOT NULL,
	[Tuition] [nchar](10) NOT NULL,
	[WeekPlan] [nvarchar](100) NOT NULL,
	[ClassNumber] [smallint] NOT NULL,
	[ID_FK_Teacher] [int] NOT NULL,
	[ID_FK_Course] [int] NOT NULL,
 CONSTRAINT [PK_CourseGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseSelect](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityScore] [decimal](18, 2) NOT NULL,
	[FinalScore] [decimal](18, 2) NOT NULL,
	[AttendScore] [decimal](18, 0) NOT NULL,
	[ID_FK_CourseGroup] [int] NOT NULL,
	[ID_FK_Student] [int] NOT NULL,
 CONSTRAINT [PK_CourseSelect] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Degree]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Degree](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Degree] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TracingID] [char](10) NOT NULL,
	[Amount] [char](10) NOT NULL,
	[PaymentDate] [char](10) NOT NULL,
	[DocNumber] [char](15) NOT NULL,
	[ID_FK_Bank] [int] NOT NULL,
	[ID_FK_PayType] [int] NOT NULL,
	[ID_FK_Student] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PayType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserState] [nvarchar](50) NOT NULL,
	[AddUser] [bit] NOT NULL,
	[DeleteUser] [bit] NOT NULL,
	[EditUser] [bit] NOT NULL,
	[SelectUser] [bit] NOT NULL,
	[PaymentManage] [bit] NOT NULL,
	[CourseManage] [bit] NOT NULL,
	[StudentManage] [bit] NOT NULL,
	[TeacherManage] [bit] NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[ID] [int] NULL,
	[Name] [nchar](10) NULL,
	[FileName] [nvarchar](50) NULL,
	[Type] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecurityQuestion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_SecurityQuestion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NationalCode] [char](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[ID_FK_Degree] [int] NOT NULL,
	[Sex] [tinyint] NOT NULL,
	[DateOfBirth] [char](10) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Image] [varchar](100) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NationalCode] [char](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[ID_FK_Degree] [int] NOT NULL,
	[DateOfBirth] [char](10) NOT NULL,
	[Sex] [tinyint] NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[ID_FK_Permission] [int] NOT NULL,
	[ID_FK_SecurityQuestion] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseGroup]  WITH CHECK ADD  CONSTRAINT [FK_CourseGroup_Course] FOREIGN KEY([ID_FK_Course])
REFERENCES [dbo].[Course] ([ID])
GO
ALTER TABLE [dbo].[CourseGroup] CHECK CONSTRAINT [FK_CourseGroup_Course]
GO
ALTER TABLE [dbo].[CourseGroup]  WITH CHECK ADD  CONSTRAINT [FK_CourseGroup_Teacher] FOREIGN KEY([ID_FK_Teacher])
REFERENCES [dbo].[Teacher] ([ID])
GO
ALTER TABLE [dbo].[CourseGroup] CHECK CONSTRAINT [FK_CourseGroup_Teacher]
GO
ALTER TABLE [dbo].[CourseSelect]  WITH CHECK ADD  CONSTRAINT [FK_CourseSelect_CourseGroup] FOREIGN KEY([ID_FK_CourseGroup])
REFERENCES [dbo].[CourseGroup] ([ID])
GO
ALTER TABLE [dbo].[CourseSelect] CHECK CONSTRAINT [FK_CourseSelect_CourseGroup]
GO
ALTER TABLE [dbo].[CourseSelect]  WITH CHECK ADD  CONSTRAINT [FK_CourseSelect_Student] FOREIGN KEY([ID_FK_Student])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[CourseSelect] CHECK CONSTRAINT [FK_CourseSelect_Student]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Bank] FOREIGN KEY([ID_FK_Bank])
REFERENCES [dbo].[Bank] ([ID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Bank]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_PayType] FOREIGN KEY([ID_FK_PayType])
REFERENCES [dbo].[PayType] ([ID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_PayType]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Student] FOREIGN KEY([ID_FK_Student])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Degree] FOREIGN KEY([ID_FK_Degree])
REFERENCES [dbo].[Degree] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Degree]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Degree] FOREIGN KEY([ID_FK_Degree])
REFERENCES [dbo].[Degree] ([ID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Degree]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Permission] FOREIGN KEY([ID_FK_Permission])
REFERENCES [dbo].[Permission] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Permission]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_SecurityQuestion] FOREIGN KEY([ID_FK_SecurityQuestion])
REFERENCES [dbo].[SecurityQuestion] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_SecurityQuestion]
GO
/****** Object:  StoredProcedure [dbo].[App_Open]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   procedure [dbo].[App_Open]
@userName  nvarchar(50),
@password nvarchar(100)
as
 if exists( select ID from Users where UserName=@userName  and Password=@password)
  return 1
  else
  return 0
GO
/****** Object:  StoredProcedure [dbo].[SelectCourseAll]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SelectCourseAll]

	@Tbl_Input AS Tbltype_SelectCourse READONLY
AS
BEGIN

 INSERT INTO CourseSelect(ActivityScore,AttendScore,FinalScore,ID_FK_CourseGroup,ID_FK_Student)
            SELECT 0,0,0,ID_SelectCourse ,ID_Student
			FROM @Tbl_Input
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for deleting a specific row from Bank  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteBank]
    @ID int
AS

DELETE FROM [dbo].[Bank]
 WHERE 
    [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Delete By Field  from Bank  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldBank]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Bank] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for Delete By Field  from Course  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteByFieldCourse]
    @FieldName varchar(100),
    @Value varchar(1000)
AS
BEGIN 
    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Course] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for Delete By Field  from CourseGroup  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteByFieldCourseGroup]
    @FieldName varchar(100),
    @Value varchar(1000)
AS
BEGIN
    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[CourseGroup] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for Delete By Field  from CourseSelect  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteByFieldCourseSelect]
    @FieldName varchar(100),
    @Value varchar(1000)
AS
BEGIN

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[CourseSelect] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldPayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for Delete By Field  from Payment  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldPayment]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Payment] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldPayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Delete By Field  from PayType  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldPayType]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[PayType] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldPermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 DeleteByFieldSPPermission
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for Delete By Field  from Permission  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldPermission]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Permission] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 DeleteByFieldSPSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for Delete By Field  from SecurityQuestion  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldSecurityQuestion]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[SecurityQuestion] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for Delete By Field  from Student  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteByFieldStudent]
    @FieldName varchar(100),
    @Value varchar(1000)
AS
BEGIN
    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Student] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for Delete By Field  from Teacher  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteByFieldTeacher]
    @FieldName varchar(100),
    @Value varchar(1000)
AS
BEGIN
    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Teacher] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteByFieldUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 DeleteByFieldSPUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for Delete By Field  from Users  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteByFieldUsers]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Users] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDeleteCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for deleting a specific row from Course  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteCourse]
    @ID int
AS
BEGIN
DELETE FROM [dbo].[Course]
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for deleting a specific row from CourseGroup  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteCourseGroup]
    @ID int
AS
BEGIN
DELETE FROM [dbo].[CourseGroup]
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for deleting a specific row from CourseSelect  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteCourseSelect]
    @ID int
AS
BEGIN
DELETE FROM [dbo].[CourseSelect]
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteDegree]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spDeleteDegree]
@ID int
AS
BEGIN
delete from degree
where ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeletePayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeletePayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for deleting a specific row from Payment  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeletePayment]
    @ID int
AS

DELETE FROM [dbo].[Payment]
 WHERE 
    [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDeletePayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeletePayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for deleting a specific row from PayType  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeletePayType]
    @ID int
AS

DELETE FROM [dbo].[PayType]
 WHERE 
    [ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[spDeletePermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeletePermission
-- Author:		AmirAsefi
-- Create date:	1403/06/02
--Description: 	This stored procedure is intended for deleting a specific row from Permission  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeletePermission]
	@ID int
AS

DELETE FROM [dbo].[Permission]
 WHERE 
	[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeleteSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for deleting a specific row from SecurityQuestion  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteSecurityQuestion]
	@ID int
AS

DELETE FROM [dbo].[SecurityQuestion]
 WHERE 
	[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for deleting a specific row from Student  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteStudent]
    @ID int
AS
BEGIN
DELETE FROM [dbo].[Student]
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for deleting a specific row from Teacher  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDeleteTeacher]
    @ID int
AS
BEGIN
DELETE FROM [dbo].[Teacher]
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeleteUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for deleting a specific row from Users  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDeleteUsers]
	@ID int
AS

DELETE FROM [dbo].[Users]
 WHERE 
	[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDetailsBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:      This stored procedure is intended for selecting a specific row from Bank  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsBank]
    @ID int
AS

    SELECT 
        [ID], [Name]
    FROM [dbo].[Bank]
    WHERE 
            [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Select By Field  from Bank  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldBank]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT [ID], [Name] FROM [dbo].[Bank] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for Select By Field  from Course  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsByFieldCourse]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS
BEGIN
    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT top(20) [ID], [Title], [LevelCount], [Tuition] FROM [dbo].[Course] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for Select By Field  from CourseGroup  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsByFieldCourseGroup]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS
BEGIN
    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT top(100) Course.Title, Teacher.Name + '''+' '+ ''' +  Teacher.LastName as '''+'teacherName'+''',
       [CourseGroup].[ID], [Year], [Term], [LevelCourse], [CourseGroup].[Tuition], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
	   , [WeekPlan] FROM [dbo].[CourseGroup] right join Teacher 
	on  [CourseGroup].ID_FK_Teacher =Teacher.ID   join Course
	on Course.ID=CourseGroup.ID_FK_Course
	 WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for Select By Field  from CourseSelect  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsByFieldCourseSelect]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS
BEGIN

    DECLARE @query nvarchar(2000);

    SET @query = ' SELECT top (10)
	      Student.Name+ '''+' '+ ''' +Student.LastName as '''+'StudentName'+''',Course.Title,Teacher.Name+ '''+' '+ ''' +Teacher.LastName as '''+'teacherName'+'''
         ,LevelCourse,CourseGroup.Tuition,[CourseSelect]. [ID],Year,Term, [ActivityScore], [FinalScore], [AttendScore],[ActivityScore]+ [FinalScore]+ [AttendScore] as '''+'Score'+''', [ID_FK_CourseGroup], [ID_FK_Student]
		, ClassNumber,WeekPlan FROM [dbo].[CourseSelect] left join  Student 
	    on CourseSelect.ID_FK_Student =Student.ID join CourseGroup
		on CourseGroup.ID =CourseSelect.ID_FK_CourseGroup join Teacher
		on Teacher.ID=CourseGroup.ID_FK_Teacher join Course
		on CourseGroup.ID_FK_Course=Course.ID WHERE ' + @FieldName  + ' like ''' + @Value + '%'''+' order by [CourseSelect]. [ID] desc'
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for Select By Field  from Payment  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldPayment]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT Student.Name +'' ''+Student.LastName as  ''StudentName'', [Payment].[ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [ID_FK_Student]
      , Bank.Name as ''Bank''   , PayType.PaymentType , [Payment].[Description]  FROM [dbo].[Payment] left join   Student
	     on Payment.ID_FK_Student=Student.ID left join  Bank
		 on Payment.ID_FK_Bank=Bank.ID  left join PayType
		 on  Payment.ID_FK_PayType=PayType.ID WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Select By Field  from PayType  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldPayType]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT [ID], [PaymentType], [Description] FROM [dbo].[PayType] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsByFieldPermission
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for Select By Field  from Permission  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldPermission]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT 	ROW_NUMBER() OVER (ORDER BY [ID]) AS '''+'RowNumber'+''',[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage] FROM [dbo].[Permission] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsByFieldSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for Select By Field  from SecurityQuestion  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldSecurityQuestion]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT [ID], [question], [Description] FROM [dbo].[SecurityQuestion] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for Select By Field  from Student  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsByFieldStudent]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS
BEGIN
    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT Student.ID, [NationalCode], [Name],ID_FK_Degree, [LastName], Degree.Title as '''+'Degree'+''',
				  case  [Sex] when 0 then '''+'زن'+''' when 1 then '''+'مرد'+''' end  as Sex ,
				  [DateofBirth], [Phone], [Image], [Address]  FROM [dbo].[Student] join Degree
	              on Student.ID_FK_Degree=Degree.ID  WHERE ' + @FieldName  + ' like ''%' + @Value + '%'''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for Select By Field  from Teacher  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsByFieldTeacher]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS
BEGIN
    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT  top(200) 
 [Teacher].[ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth],  Degree.Title as '''+'Degree'+''',
				case  [Sex] when 0 then '''+'زن'+''' when 1 then '''+'مرد'+''' end  as Sex , [Phone], [Address] FROM [dbo].[Teacher] join Degree
	     on [Teacher].ID_FK_Degree=Degree.ID
	 WHERE ' + @FieldName  + ' like ''%' + @Value + '%'''
    EXEC(@query)
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsByFieldUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name: spDetailsByFieldUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for Select By Field  from Users  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsByFieldUsers]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT 	[UserName],[Users].[ID], [Name], [LastName],Permission.UserState, [Answer], [Password],  [ID_FK_Permission], [ID_FK_SecurityQuestion]
                           ,SecurityQuestion.question FROM [dbo].[Users] inner join SecurityQuestion
	                       on  Users.ID_FK_SecurityQuestion=SecurityQuestion.ID inner join Permission
	                   	   on Permission.ID=Users.ID_FK_Permission WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO
/****** Object:  StoredProcedure [dbo].[spDetailsCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:      This stored procedure is intended for selecting a specific row from Course  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsCourse]
    @ID int
AS
BEGIN
    SELECT 
        [ID], [Title], [LevelCount], [Tuition]
    FROM [dbo].[Course]
    WHERE 
            [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:      This stored procedure is intended for selecting a specific row from CourseGroup  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsCourseGroup]
    @ID int
AS
BEGIN
    SELECT 
        [ID], [Year], [Term], [LevelCourse], [Tuition], [WeekPlan], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
    FROM [dbo].[CourseGroup]
    WHERE 
            [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:      This stored procedure is intended for selecting a specific row from CourseSelect  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsCourseSelect]
    @ID int
AS
BEGIN
    SELECT 
        [ID], [ActivityScore], [FinalScore], [AttendScore], [ID_FK_CourseGroup], [ID_FK_Student]
    FROM [dbo].[CourseSelect]
    WHERE 
            [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsPayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:      This stored procedure is intended for selecting a specific row from Payment  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsPayment]
    @ID int
AS

    SELECT 
        [ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [Description], [ID_FK_Student]
    FROM [dbo].[Payment]
    WHERE 
            [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDetailsPayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:      This stored procedure is intended for selecting a specific row from PayType  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsPayType]
    @ID int
AS

    SELECT 
        [ID], [PaymentType], [Description]
    FROM [dbo].[PayType]
    WHERE 
            [ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[spDetailsPermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsPermission
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description:  	This stored procedure is intended for selecting a specific row from Permission  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsPermission]
	@ID int
AS

	SELECT 
		[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage]
	FROM [dbo].[Permission]
	WHERE 
			[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDetailsSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description:  	This stored procedure is intended for selecting a specific row from SecurityQuestion  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsSecurityQuestion]
	@ID int
AS

	SELECT 
		[ID], [question], [Description]
	FROM [dbo].[SecurityQuestion]
	WHERE 
			[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spDetailsStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:      This stored procedure is intended for selecting a specific row from Student  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsStudent]
    @ID int
AS
BEGIN
    SELECT 
        [ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [Sex], [DateofBirth], [Address], [Phone], [Image]
    FROM [dbo].[Student]
    WHERE 
            [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:      This stored procedure is intended for selecting a specific row from Teacher  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spDetailsTeacher]
    @ID int
AS
BEGIN
    SELECT 
        [ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth], [Sex], [Phone], [Address]
    FROM [dbo].[Teacher]
    WHERE 
            [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description:  	This stored procedure is intended for selecting a specific row from Users  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spDetailsUsers]
	@ID int
AS

	SELECT 
		[ID], [Name], [LastName], [Answer], [Password], [UserName], [ID_FK_Permission], [ID_FK_SecurityQuestion]
	FROM [dbo].[Users]
	WHERE 
			[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spGetListBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for selecting all rows from Bank  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListBank]
AS

    SELECT 
[ID], [Name]

    FROM [dbo].[Bank]

GO
/****** Object:  StoredProcedure [dbo].[spGetListCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for selecting all rows from Course  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spGetListCourse]
AS
BEGIN
    SELECT top(10)
[ID], [Title], [LevelCount], [Tuition]

    FROM [dbo].[Course]
END
GO
/****** Object:  StoredProcedure [dbo].[spGetListCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for selecting all rows from CourseGroup  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spGetListCourseGroup]
AS
BEGIN
    SELECT top (10)
	   Course.Title, Teacher.Name +' '+Teacher.LastName as 'teacherName',
       [CourseGroup].[ID], [Year], [Term], [LevelCourse], [CourseGroup].[Tuition], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
	   , [WeekPlan]
	 

    FROM [dbo].[CourseGroup] right join Teacher 
	on  [CourseGroup].ID_FK_Teacher =Teacher.ID   join Course
	on Course.ID=CourseGroup.ID_FK_Course
	order by  [CourseGroup].[ID] Desc

END
GO
/****** Object:  StoredProcedure [dbo].[spGetListCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourseSelect
-- Author:		AmriAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for selecting all rows from CourseSelect  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spGetListCourseSelect]
AS
BEGIN
    SELECT top (10)
	      Student.Name+' '+Student.LastName as 'StudentName',Course.Title,Teacher.Name +' '+Teacher.LastName as 'teacherName'

         ,LevelCourse,CourseGroup.Tuition,[CourseSelect]. [ID],Year,Term, [ActivityScore], [FinalScore], [AttendScore],[ActivityScore]+ [FinalScore]+ [AttendScore] as 'Score', [ID_FK_CourseGroup], [ID_FK_Student]
		, ClassNumber,WeekPlan
		
    FROM [dbo].[CourseSelect] left join  Student 
	    on CourseSelect.ID_FK_Student =Student.ID join CourseGroup
		on CourseGroup.ID =CourseSelect.ID_FK_CourseGroup join Teacher
		on Teacher.ID=CourseGroup.ID_FK_Teacher join Course
		on CourseGroup.ID_FK_Course=Course.ID

		order by [CourseSelect]. [ID] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[spGetListDegree]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetListDegree]
AS
SELECT ID,Title 
FROM Degree
GO
/****** Object:  StoredProcedure [dbo].[spGetListPayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for selecting all rows from Payment  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListPayment]
AS

    SELECT 
     Student.Name +' '+Student.LastName as  'StudentName', [Payment].[ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [ID_FK_Student]
      , Bank.Name as 'Bank'
      , PayType.PaymentType , [Payment].[Description] 

    FROM [dbo].[Payment] left join   Student
	     on Payment.ID_FK_Student=Student.ID left join  Bank
		 on Payment.ID_FK_Bank=Bank.ID  left join PayType
		 on  Payment.ID_FK_PayType=PayType.ID

GO
/****** Object:  StoredProcedure [dbo].[spGetListPayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for selecting all rows from PayType  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListPayType]
AS

    SELECT 
[ID], [PaymentType], [Description]

    FROM [dbo].[PayType]


GO
/****** Object:  StoredProcedure [dbo].[spGetListPermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spGetListPermission
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description:  This stored procedure is intended for selecting all rows from Permission  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListPermission]
AS

	SELECT 

		[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage]

	FROM [dbo].[Permission]

GO
/****** Object:  StoredProcedure [dbo].[spGetListSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spGetListSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01 
--Description:  This stored procedure is intended for selecting all rows from SecurityQuestion  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListSecurityQuestion]
AS

	SELECT 
[ID], [question], [Description]

	FROM [dbo].[SecurityQuestion]

GO
/****** Object:  StoredProcedure [dbo].[spGetListStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/2
--Description:  This stored procedure is intended for selecting all rows from Student  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spGetListStudent]
AS
BEGIN
    SELECT top (10)
                Student.ID, [NationalCode], [Name] , ID_FK_Degree , [LastName],Degree.Title as 'Degree' ,
				CASE [Sex] WHEN 0 THEN 'زن' WHEN 1 THEN 'مرد' END AS Sex, [DateofBirth], [Phone], [Image], [Address]
    FROM [dbo].[Student] JOIN Degree
		ON Student.ID_FK_Degree = Degree.ID
	order by Student.ID DESC
END
GO
/****** Object:  StoredProcedure [dbo].[spGetListTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for selecting all rows from Teacher  Table
-- ==========================================================================================

CREATE PROCEDURE [dbo].[spGetListTeacher]
AS
BEGIN
    SELECT top(10)
 [Teacher].[ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth],  Degree.Title as 'Degree',
				case  [Sex] when 0 then 'زن' when 1 then 'مرد' end  as Sex , [Phone], [Address]

    FROM [dbo].[Teacher] join Degree
	     on [Teacher].ID_FK_Degree=Degree.ID
	order by [Teacher].ID Desc
END
GO
/****** Object:  StoredProcedure [dbo].[spGetListUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spGetListUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description:  This stored procedure is intended for selecting all rows from Users  Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spGetListUsers]
AS

	SELECT 

	 [UserName],[Users].[ID], [Name], [LastName],Permission.UserState, [Answer], [Password],  [ID_FK_Permission], [ID_FK_SecurityQuestion]
           ,SecurityQuestion.question
	FROM [dbo].[Users] inner join SecurityQuestion
	     on  Users.ID_FK_SecurityQuestion=SecurityQuestion.ID inner join Permission
		 on Permission.ID=Users.ID_FK_Permission

GO
/****** Object:  StoredProcedure [dbo].[spInsertBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for inserting values to Bank    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertBank]
    @ID int output,
    @Name nvarchar(50) = null 

AS

INSERT [dbo].[Bank]
(
    [Name]

)
VALUES
(
    @Name

)
    SELECT @ID=SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[spInsertCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for inserting values to Course    Table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[spInsertCourse]
    @ID int output,
    @Title nvarchar(50) = null ,
    @LevelCount tinyint = null ,
    @Tuition char(10) = null 

AS
BEGIN
INSERT [dbo].[Course]
(
    [Title],
    [LevelCount],
    [Tuition]

)
VALUES
(
    @Title,
    @LevelCount,
    @Tuition

)
    SELECT @ID=SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for inserting values to CourseGroup    Table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[spInsertCourseGroup]
    @ID int output,
    @Year int = null ,
    @Term tinyint = null ,
    @LevelCourse tinyint = null ,
    @Tuition char(10) = null ,
    @WeekPlan nvarchar(100) = null ,
    @ClassNumber smallint = null ,
    @ID_FK_Teacher int = null ,
    @ID_FK_Course int = null 

AS
BEGIN
INSERT [dbo].[CourseGroup]
(
    [Year],
    [Term],
    [LevelCourse],
    [Tuition],
    [WeekPlan],
    [ClassNumber],
    [ID_FK_Teacher],
    [ID_FK_Course]

)
VALUES
(
    @Year,
    @Term,
    @LevelCourse,
    @Tuition,
    @WeekPlan,
    @ClassNumber,
    @ID_FK_Teacher,
    @ID_FK_Course

)
    SELECT @ID=SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for inserting values to CourseSelect    Table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[spInsertCourseSelect]
    @ID int output,
    @ActivityScore decimal = null ,
    @FinalScore decimal = null ,
    @AttendScore decimal = null ,
    @ID_FK_CourseGroup int = null ,
    @ID_FK_Student int = null 

AS
BEGIN
INSERT [dbo].[CourseSelect]
(
    [ActivityScore],
    [FinalScore],
    [AttendScore],
    [ID_FK_CourseGroup],
    [ID_FK_Student]

)
VALUES
(
    @ActivityScore,
    @FinalScore,
    @AttendScore,
    @ID_FK_CourseGroup,
    @ID_FK_Student

)
    SELECT @ID=SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertDegree]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertDegree]
@ID int output,
@Title nvarchar(50) output
AS
BEGIN
insert into Degree VALUES(@Title)

select @ID = Scope_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertPayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for inserting values to Payment    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertPayment]
    @ID int output,
    @TracingID char(10) = null ,
    @Amount char(10) = null ,
    @PaymentDate char(10) = null ,
    @DocNumber char(15) = null ,
    @ID_FK_PayType int = null ,
    @ID_FK_Bank int = null ,
    @Description nvarchar(MAX) = null ,
    @ID_FK_Student int = null 

AS

INSERT [dbo].[Payment]
(
    [TracingID],
    [Amount],
    [PaymentDate],
    [DocNumber],
    [ID_FK_PayType],
    [ID_FK_Bank],
    [Description],
    [ID_FK_Student]

)
VALUES
(
    @TracingID,
    @Amount,
    @PaymentDate,
    @DocNumber,
    @ID_FK_PayType,
    @ID_FK_Bank,
    @Description,
    @ID_FK_Student

)
    SELECT @ID=SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[spInsertPayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for inserting values to PayType    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertPayType]
    @ID int output,
    @PaymentType nvarchar(50) = null ,
    @Description nvarchar(100) = null 

AS

INSERT [dbo].[PayType]
(
    [PaymentType],
    [Description]

)
VALUES
(
    @PaymentType,
    @Description

)
    SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[spInsertPermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spInsertPermission
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for inserting values to Permission    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertPermission]
	@ID int output,
	@UserState nvarchar(50) = null ,
	@Adduser bit = null ,
	@DeleteUser bit = null ,
	@EditUser bit = null ,
	@SelectUser bit = null ,
	@PaymentManage bit = null ,
	@CourseManage bit = null ,
	@StudentManage bit = null ,
	@TeacherManage bit = null 

AS

INSERT [dbo].[Permission]
(
	[UserState],
	[Adduser],
	[DeleteUser],
	[EditUser],
	[SelectUser],
	[PaymentManage],
	[CourseManage],
	[StudentManage],
	[TeacherManage]

)
VALUES
(
	@UserState,
	@Adduser,
	@DeleteUser,
	@EditUser,
	@SelectUser,
	@PaymentManage,
	@CourseManage,
	@StudentManage,
	@TeacherManage

)
	SELECT @ID=SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[spInsertSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spInsertSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for inserting values to SecurityQuestion    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertSecurityQuestion]
	@ID int output,
	@question nvarchar(150) = null ,
	@Description nvarchar(MAX) = null 

AS

INSERT [dbo].[SecurityQuestion]
(
	[question],
	[Description]

)
VALUES
(
	@question,
	@Description

)
	SELECT @ID=SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[spInsertStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for inserting values to Student    Table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[spInsertStudent]
    @ID int output,
    @NationalCode char(10) ,
    @Name nvarchar(50) ,
    @LastName nvarchar(50) ,
    @ID_FK_Degree int = null ,
    @Sex tinyint = null ,
    @DateofBirth char(10) = null ,
    @Address nvarchar(200) = null ,
    @Phone char(11) = null ,
    @Image varchar(100) = null 

AS
BEGIN
INSERT [dbo].[Student]
(
    [NationalCode],
    [Name],
    [LastName],
    [ID_FK_Degree],
    [Sex],
    [DateofBirth],
    [Address],
    [Phone],
    [Image]

)
VALUES
(
    @NationalCode,
    @Name,
    @LastName,
    @ID_FK_Degree,
    @Sex,
    @DateofBirth,
    @Address,
    @Phone,
    @Image

)
    SELECT @ID=SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for inserting values to Teacher    Table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[spInsertTeacher]
    @ID int output,
    @NationalCode char(10) = null ,
    @Name nvarchar(50) = null ,
    @LastName nvarchar(50) = null ,
    @ID_FK_Degree int = null ,
    @DateOfBirth char(10) = null ,
    @Sex tinyint = null ,
    @Phone char(11) = null ,
    @Address nvarchar(200) = null 

AS
BEGIN
INSERT [dbo].[Teacher]
(
    [NationalCode],
    [Name],
    [LastName],
    [ID_FK_Degree],
    [DateOfBirth],
    [Sex],
    [Phone],
    [Address]

)
VALUES
(
    @NationalCode,
    @Name,
    @LastName,
    @ID_FK_Degree,
    @DateOfBirth,
    @Sex,
    @Phone,
    @Address

)
    SELECT @ID=SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spInsertUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for inserting values to Users    Table
-- ==========================================================================================
CREATE   PROCEDURE [dbo].[spInsertUsers]
	@ID int output,
	@Name nvarchar(50) = null ,
	@LastName nvarchar(50) = null ,
	@Answer nvarchar(50) = null ,
	@Password nvarchar(100) = null ,
	@UserName nvarchar(50) = null ,
	@ID_FK_Permission int = null ,
	@ID_FK_SecurityQuestion int = null 

AS

INSERT [dbo].[Users]
(
	[Name],
	[LastName],
	[Answer],
	[Password],
	[UserName],
	[ID_FK_Permission],
	[ID_FK_SecurityQuestion]

)
VALUES
(
	@Name,
	@LastName,
	@Answer,
	@Password,
	@UserName,
	@ID_FK_Permission,
	@ID_FK_SecurityQuestion

)
	SELECT @ID=SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[spUpdateBank]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateBank
-- Author:      Amir Asefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for updating Bank    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateBank]
    @ID int,
    @Name nvarchar(50) = null

AS

UPDATE [dbo].[Bank]
SET
    [Name] = @Name
 WHERE 
    [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spUpdateCourse]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for updating Course    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateCourse]
    @ID int,
    @Title nvarchar(50) = null,
    @LevelCount tinyint = null,
    @Tuition char(10) = null

AS
BEGIN
UPDATE [dbo].[Course]
SET
    [Title] = @Title,
    [LevelCount] = @LevelCount,
    [Tuition] = @Tuition
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCourseGroup]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for updating CourseGroup    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateCourseGroup]
    @ID int,
    @Year int = null,
    @Term tinyint = null,
    @LevelCourse tinyint = null,
    @Tuition char(10) = null,
    @WeekPlan nvarchar(100) = null,
    @ClassNumber smallint = null,
    @ID_FK_Teacher int = null,
    @ID_FK_Course int = null

AS
BEGIN
UPDATE [dbo].[CourseGroup]
SET
    [Year] = @Year,
    [Term] = @Term,
    [LevelCourse] = @LevelCourse,
    [Tuition] = @Tuition,
    [WeekPlan] = @WeekPlan,
    [ClassNumber] = @ClassNumber,
    [ID_FK_Teacher] = @ID_FK_Teacher,
    [ID_FK_Course] = @ID_FK_Course
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCourseSelect]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for updating CourseSelect    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateCourseSelect]
    @ID int,
    @ActivityScore decimal = null,
    @FinalScore decimal = null,
    @AttendScore decimal = null,
    @ID_FK_CourseGroup int = null,
    @ID_FK_Student int = null

AS
BEGIN
UPDATE [dbo].[CourseSelect]
SET
    [ActivityScore] = @ActivityScore,
    [FinalScore] = @FinalScore,
    [AttendScore] = @AttendScore,
    [ID_FK_CourseGroup] = @ID_FK_CourseGroup,
    [ID_FK_Student] = @ID_FK_Student
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateDegree]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateDegree] 
@ID int ,
@Title nvarchar(50)
as
if(select COUNT(ID) from Degree where ID=@ID) > 0
BEGIN

update Degree
SET Title = @Title
where ID = @ID

return @ID

END
return 0
GO
/****** Object:  StoredProcedure [dbo].[spUpdatePayment]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdatePayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for updating Payment    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdatePayment]
    @ID int,
    @TracingID char(10) = null,
    @Amount char(10) = null,
    @PaymentDate char(10) = null,
    @DocNumber char(15) = null,
    @ID_FK_PayType int = null,
    @ID_FK_Bank int = null,
    @Description nvarchar(MAX) = null,
    @ID_FK_Student int = null

AS

UPDATE [dbo].[Payment]
SET
    [TracingID] = @TracingID,
    [Amount] = @Amount,
    [PaymentDate] = @PaymentDate,
    [DocNumber] = @DocNumber,
    [ID_FK_PayType] = @ID_FK_PayType,
    [ID_FK_Bank] = @ID_FK_Bank,
    [Description] = @Description,
    [ID_FK_Student] = @ID_FK_Student
 WHERE 
    [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spUpdatePayType]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdatePayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for updating PayType    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdatePayType]
    @ID int,
    @PaymentType nvarchar(50) = null,
    @Description nvarchar(100) = null

AS

UPDATE [dbo].[PayType]
SET
    [PaymentType] = @PaymentType,
    [Description] = @Description
 WHERE 
    [ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[spUpdatePermission]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:	 spUpdatePermission
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for updating Permission    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdatePermission]
	@ID int,
	@UserState nvarchar(50) = null,
	@Adduser bit = null,
	@DeleteUser bit = null,
	@EditUser bit = null,
	@SelectUser bit = null,
	@PaymentManage bit = null,
	@CourseManage bit = null,
	@StudentManage bit = null,
	@TeacherManage bit = null

AS

UPDATE [dbo].[Permission]
SET
	[UserState] = @UserState,
	[Adduser] = @Adduser,
	[DeleteUser] = @DeleteUser,
	[EditUser] = @EditUser,
	[SelectUser] = @SelectUser,
	[PaymentManage] = @PaymentManage,
	[CourseManage] = @CourseManage,
	[StudentManage] = @StudentManage,
	[TeacherManage] = @TeacherManage
 WHERE 
	[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spUpdateSecurityQuestion]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:	 spUpdateSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for updating SecurityQuestion    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateSecurityQuestion]
	@ID int,
	@question nvarchar(150) = null,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[SecurityQuestion]
SET
	[question] = @question,
	[Description] = @Description
 WHERE 
	[ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[spUpdateStudent]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for updating Student    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateStudent]
    @ID int,
    @NationalCode char(10),
    @Name nvarchar(50),
    @LastName nvarchar(50),
    @ID_FK_Degree int = null,
    @Sex tinyint = null,
    @DateofBirth char(10) = null,
    @Address nvarchar(200) = null,
    @Phone char(11) = null,
    @Image varchar(100) = null

AS
BEGIN
UPDATE [dbo].[Student]
SET
    [NationalCode] = @NationalCode,
    [Name] = @Name,
    [LastName] = @LastName,
    [ID_FK_Degree] = @ID_FK_Degree,
    [Sex] = @Sex,
    [DateofBirth] = @DateofBirth,
    [Address] = @Address,
    [Phone] = @Phone,
    [Image] = @Image
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTeacher]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for updating Teacher    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateTeacher]
    @ID int,
    @NationalCode char(10) = null,
    @Name nvarchar(50) = null,
    @LastName nvarchar(50) = null,
    @ID_FK_Degree int = null,
    @DateOfBirth char(10) = null,
    @Sex tinyint = null,
    @Phone char(11) = null,
    @Address nvarchar(200) = null

AS
BEGIN
UPDATE [dbo].[Teacher]
SET
    [NationalCode] = @NationalCode,
    [Name] = @Name,
    [LastName] = @LastName,
    [ID_FK_Degree] = @ID_FK_Degree,
    [DateOfBirth] = @DateOfBirth,
    [Sex] = @Sex,
    [Phone] = @Phone,
    [Address] = @Address
 WHERE 
    [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUsers]    Script Date: 06/06/1403 09:02:45 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:	 spUpdateUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for updating Users    Table
-- ==========================================================================================

CREATE   PROCEDURE [dbo].[spUpdateUsers]
	@ID int,
	@Name nvarchar(50) = null,
	@LastName nvarchar(50) = null,
	@Answer nvarchar(50) = null,
	@Password nvarchar(100) = null,
	@UserName nvarchar(50) = null,
	@ID_FK_Permission int = null,
	@ID_FK_SecurityQuestion int = null

AS

UPDATE [dbo].[Users]
SET
	[Name] = @Name,
	[LastName] = @LastName,
	[Answer] = @Answer,
	[Password] = @Password,
	[UserName] = @UserName,
	[ID_FK_Permission] = @ID_FK_Permission,
	[ID_FK_SecurityQuestion] = @ID_FK_SecurityQuestion
 WHERE 
	[ID] = @ID

GO
