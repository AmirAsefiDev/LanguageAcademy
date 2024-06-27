USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateCourseGroup]    Script Date: 6/22/2024 3:59:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for updating CourseGroup    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateCourseGroup]
    @ID int,
    @Year int = null,
    @Term tinyint = null,
    @LevelCourse tinyint = null,
    @Tuition char(10) = null,
    @WeekPlan nvarchar(100) = null,
    @ClassNumber smallint = null,
    @ID_FK_Teacher int = null,
    @ID_FK_Course int = null

AS

UPDATE [dbo].[CourseGroup]
SET
    [Year] = @Year,
    [Term] = @Term,
    [LevelCourse] = @LevelCourse,
    [Tuition] = @Tuition,
    [WeekPlan] = @WeekPlan,
    [ClassNumber] = @ClassNumber,
    [ID_FK_Teacher] = @ID_FK_Teacher,
    [ID_FK_Course] = @ID_FK_Course
 WHERE 
    [ID] = @ID

GO

