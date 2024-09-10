USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsPermission]    Script Date: 6/22/2024 3:52:46 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDetailsPermission]
	@ID int
AS

	SELECT 
		[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage]
	FROM [dbo].[Permission]
	WHERE 
			[ID] = @ID

GO

