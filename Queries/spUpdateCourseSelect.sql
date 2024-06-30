USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateCourseSelect]    Script Date: 6/22/2024 3:59:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for updating CourseSelect    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateCourseSelect]
    @ID int,
    @ActivityScore decimal = null,
    @FinalScore decimal = null,
    @AttendScore decimal = null,
    @ID_FK_CourseGroup int = null,
    @ID_FK_Student int = null

AS

UPDATE [dbo].[CourseSelect]
SET
    [ActivityScore] = @ActivityScore,
    [FinalScore] = @FinalScore,
    [AttendScore] = @AttendScore,
    [ID_FK_CourseGroup] = @ID_FK_CourseGroup,
    [ID_FK_Student] = @ID_FK_Student
 WHERE 
    [ID] = @ID

GO

