USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldTeacher]    Script Date: 6/22/2024 3:45:18 PM ******/
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

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldTeacher]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Teacher] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

