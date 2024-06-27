USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourse]    Script Date: 6/22/2024 3:43:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for Delete By Field  from Course  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldCourse]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Course] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

