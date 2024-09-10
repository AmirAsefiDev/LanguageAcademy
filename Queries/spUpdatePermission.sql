USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdatePermission]    Script Date: 6/22/2024 4:00:29 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spUpdatePermission]
	@ID int,
	@UserState nvarchar(50) = null,
	@Adduser bit = null,
	@DeleteUser bit = null,
	@EditUser bit = null,
	@SelectUser bit = null,
	@paymentMange bit = null,
	@Coursemange bit = null,
	@Studentmange bit = null,
	@TeacherMange bit = null

AS

UPDATE [dbo].[Permission]
SET
	[UserState] = @UserState,
	[Adduser] = @Adduser,
	[DeleteUser] = @DeleteUser,
	[EditUser] = @EditUser,
	[SelectUser] = @SelectUser,
	[paymentManage] = @paymentMange,
	[CourseManage] = @Coursemange,
	[StudentManage] = @Studentmange,
	[TeacherManage] = @TeacherMange
 WHERE 
	[ID] = @ID

GO

