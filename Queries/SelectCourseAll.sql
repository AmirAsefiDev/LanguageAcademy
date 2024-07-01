USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[SelectCourseAll]    Script Date: 6/22/2024 3:42:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
--GO
--DROP TYPE Tbltype_SelectCourse;
GO
/*CREATE TYPE Tbltype_SelectCourse AS TABLE
(
	ID_SelectCourse INT NULL,
	ID_Student INT NULL
);*/
GO

CREATE OR ALTER PROCEDURE [dbo].[SelectCourseAll]

	@Tbl_Input AS Tbltype_SelectCourse READONLY
AS
BEGIN

 INSERT INTO CourseSelect(ActivityScore,AttendScore,FinalScore,ID_FK_CourseGroup,ID_FK_Student)
            SELECT 0,0,0,ID_SelectCourse ,ID_Student
			FROM @Tbl_Input
END
GO

