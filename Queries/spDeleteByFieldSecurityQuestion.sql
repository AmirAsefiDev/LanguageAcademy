USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldSecurityQuestion]    Script Date: 6/22/2024 3:44:23 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldSecurityQuestion]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[SecurityQuestion] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

