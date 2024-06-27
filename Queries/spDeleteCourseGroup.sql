USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteCourseGroup]    Script Date: 6/22/2024 3:46:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourseGroup
-- Author:      AmirAsefi
-- Create date: 1403/4/8
--Description:  This stored procedure is intended for deleting a specific row from CourseGroup  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteCourseGroup]
    @ID int
AS

DELETE FROM [dbo].[CourseGroup]
 WHERE 
    [ID] = @ID

GO

