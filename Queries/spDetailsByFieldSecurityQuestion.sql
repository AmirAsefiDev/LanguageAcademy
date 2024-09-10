USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldSecurityQuestion]    Script Date: 6/22/2024 3:51:00 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldSecurityQuestion]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT [ID], [question], [Description] FROM [dbo].[SecurityQuestion] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO

