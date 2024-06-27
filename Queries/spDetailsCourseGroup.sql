USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsCourseGroup]    Script Date: 6/22/2024 3:52:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:      This stored procedure is intended for selecting a specific row from CourseGroup  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsCourseGroup]
    @ID int
AS

    SELECT 
        [ID], [Year], [Term], [LevelCourse], [Tuition], [WeekPlan], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
    FROM [dbo].[CourseGroup]
    WHERE 
            [ID] = @ID

GO

