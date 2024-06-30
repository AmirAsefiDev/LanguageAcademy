USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteCourseSelect]    Script Date: 6/22/2024 3:46:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for deleting a specific row from CourseSelect  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteCourseSelect]
    @ID int
AS

DELETE FROM [dbo].[CourseSelect]
 WHERE 
    [ID] = @ID

GO

