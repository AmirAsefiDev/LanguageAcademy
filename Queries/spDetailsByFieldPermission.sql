USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPermission]    Script Date: 6/22/2024 3:50:50 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldPermission]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT 	ROW_NUMBER() OVER (ORDER BY [ID]) AS '''+'RowNumber'+''',[ID], [UserState], [Adduser], [DeleteUser], [EditUser], [SelectUser], [paymentManage], [CourseManage], [StudentManage], [TeacherManage] FROM [dbo].[Permission] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO

