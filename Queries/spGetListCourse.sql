USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListCourse]    Script Date: 6/22/2024 3:54:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for selecting all rows from Course  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListCourse]
AS

    SELECT top(10)
[ID], [Title], [LevelCount], [Tuition]

    FROM [dbo].[Course]

GO

