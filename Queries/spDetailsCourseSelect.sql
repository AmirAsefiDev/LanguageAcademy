USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsCourseSelect]    Script Date: 6/22/2024 3:52:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:      This stored procedure is intended for selecting a specific row from CourseSelect  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsCourseSelect]
    @ID int
AS

    SELECT 
        [ID], [ActivityScore], [FinalScore], [AttendScore], [ID_FK_CourseGroup], [ID_FK_Student]
    FROM [dbo].[CourseSelect]
    WHERE 
            [ID] = @ID

GO

