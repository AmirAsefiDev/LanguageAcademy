USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldCourseGroup]    Script Date: 6/22/2024 3:49:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for Select By Field  from CourseGroup  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldCourseGroup]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT top(100) Course.Title, Teacher.Name + '''+' '+ ''' +  Teacher.LastName as '''+'teacherName'+''',
       [CourseGroup].[ID], [Year], [Term], [LevelCourse], [CourseGroup].[Tuition], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
	   , [WeekPlan] FROM [dbo].[CourseGroup] right join Teacher 
	on  [CourseGroup].ID_FK_Teacher =Teacher.ID   join Course
	on Course.ID=CourseGroup.ID_FK_Course
	 WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	
    EXEC(@query)

GO

