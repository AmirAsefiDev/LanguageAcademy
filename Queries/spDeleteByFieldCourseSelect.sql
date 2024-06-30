USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourseSelect]    Script Date: 6/22/2024 3:43:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for Delete By Field  from CourseSelect  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldCourseSelect]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[CourseSelect] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

