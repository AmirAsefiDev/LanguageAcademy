USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListCourseGroup]    Script Date: 6/22/2024 3:54:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for selecting all rows from CourseGroup  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListCourseGroup]
AS

    SELECT top (10)
	   Course.Title, Teacher.Name +' '+Teacher.LastName as 'teacherName',
       [CourseGroup].[ID], [Year], [Term], [LevelCourse], [CourseGroup].[Tuition], [ClassNumber], [ID_FK_Teacher], [ID_FK_Course]
	   , [WeekPlan]
	 

    FROM [dbo].[CourseGroup] right join Teacher 
	on  [CourseGroup].ID_FK_Teacher =Teacher.ID   join Course
	on Course.ID=CourseGroup.ID_FK_Course
	order by  [CourseGroup].[ID] Desc


GO

