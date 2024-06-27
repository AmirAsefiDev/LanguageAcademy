USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateCourse]    Script Date: 6/22/2024 3:59:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for updating Course    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateCourse]
    @ID int,
    @Title nvarchar(50) = null,
    @LevelCount tinyint = null,
    @Tuition char(10) = null

AS

UPDATE [dbo].[Course]
SET
    [Title] = @Title,
    [LevelCount] = @LevelCount,
    [Tuition] = @Tuition
 WHERE 
    [ID] = @ID

GO

