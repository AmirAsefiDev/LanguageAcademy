USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldUsers]    Script Date: 6/22/2024 3:45:28 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldUsers]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Users] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

