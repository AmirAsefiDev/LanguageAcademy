USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertPermission]    Script Date: 6/22/2024 3:57:43 PM ******/
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
CREATE OR ALTER PROCEDURE [dbo].[spInsertPermission]
	@ID int output,
	@UserState nvarchar(50) = null ,
	@Adduser bit = null ,
	@DeleteUser bit = null ,
	@EditUser bit = null ,
	@SelectUser bit = null ,
	@paymentMange bit = null ,
	@Coursemange bit = null ,
	@Studentmange bit = null ,
	@TeacherMange bit = null 

AS

INSERT [dbo].[Permission]
(
	[UserState],
	[Adduser],
	[DeleteUser],
	[EditUser],
	[SelectUser],
	[paymentManage],
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
	@paymentMange,
	@Coursemange,
	@Studentmange,
	@TeacherMange

)
	SELECT @ID=SCOPE_IDENTITY();


GO

