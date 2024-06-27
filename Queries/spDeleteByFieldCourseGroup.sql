USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldCourseGroup]    Script Date: 6/22/2024 3:43:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for Delete By Field  from CourseGroup  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldCourseGroup]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[CourseGroup] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

