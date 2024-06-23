USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldStudent]    Script Date: 6/22/2024 3:44:45 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldStudent]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Student] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

