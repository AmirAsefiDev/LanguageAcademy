USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListPermission]    Script Date: 6/22/2024 3:55:19 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spGetListPermission]
AS

	SELECT 

		[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage]

	FROM [dbo].[Permission]

GO

