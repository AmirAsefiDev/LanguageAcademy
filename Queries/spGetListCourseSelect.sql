USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListCourseSelect]    Script Date: 6/22/2024 3:54:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourseSelect
-- Author:		AmriAsefi
-- Create date: 1403/4/10
--Description:  This stored procedure is intended for selecting all rows from CourseSelect  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListCourseSelect]
AS

    SELECT top (10)
	      Student.Name+' '+Student.LastName as 'StudentName',Course.Title,Teacher.Name +' '+Teacher.LastName as 'teacherName'

         ,LevelCourse,CourseGroup.Tuition,[CourseSelect]. [ID],Year,Term, [ActivityScore], [FinalScore], [AttendScore],[ActivityScore]+ [FinalScore]+ [AttendScore] as 'Score', [ID_FK_CourseGroup], [ID_FK_Student]
		, ClassNumber,WeekPlan
		
    FROM [dbo].[CourseSelect] left join  Student 
	    on CourseSelect.ID_FK_Student =Student.ID join CourseGroup
		on CourseGroup.ID =CourseSelect.ID_FK_CourseGroup join Teacher
		on Teacher.ID=CourseGroup.ID_FK_Teacher join Course
		on CourseGroup.ID_FK_Course=Course.ID

		order by [CourseSelect]. [ID] desc
GO

