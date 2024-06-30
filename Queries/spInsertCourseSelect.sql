USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertCourseSelect]    Script Date: 6/22/2024 3:56:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourseSelect
-- Author:      AmirAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for inserting values to CourseSelect    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertCourseSelect]
    @ID int output,
    @ActivityScore decimal = null ,
    @FinalScore decimal = null ,
    @AttendScore decimal = null ,
    @ID_FK_CourseGroup int = null ,
    @ID_FK_Student int = null 

AS

INSERT [dbo].[CourseSelect]
(
    [ActivityScore],
    [FinalScore],
    [AttendScore],
    [ID_FK_CourseGroup],
    [ID_FK_Student]

)
VALUES
(
    @ActivityScore,
    @FinalScore,
    @AttendScore,
    @ID_FK_CourseGroup,
    @ID_FK_Student

)
    SELECT @ID=SCOPE_IDENTITY();


GO

