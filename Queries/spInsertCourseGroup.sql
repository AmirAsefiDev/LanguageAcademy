USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertCourseGroup]    Script Date: 6/22/2024 3:56:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for inserting values to CourseGroup    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertCourseGroup]
    @ID int output,
    @Year int = null ,
    @Term tinyint = null ,
    @LevelCourse tinyint = null ,
    @Tuition char(10) = null ,
    @WeekPlan nvarchar(100) = null ,
    @ClassNumber smallint = null ,
    @ID_FK_Teacher int = null ,
    @ID_FK_Course int = null 

AS

INSERT [dbo].[CourseGroup]
(
    [Year],
    [Term],
    [LevelCourse],
    [Tuition],
    [WeekPlan],
    [ClassNumber],
    [ID_FK_Teacher],
    [ID_FK_Course]

)
VALUES
(
    @Year,
    @Term,
    @LevelCourse,
    @Tuition,
    @WeekPlan,
    @ClassNumber,
    @ID_FK_Teacher,
    @ID_FK_Course

)
    SELECT @ID=SCOPE_IDENTITY();


GO

