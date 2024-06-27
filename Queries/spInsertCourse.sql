USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertCourse]    Script Date: 6/22/2024 3:56:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for inserting values to Course    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertCourse]
    @ID int output,
    @Title nvarchar(50) = null ,
    @LevelCount tinyint = null ,
    @Tuition char(10) = null 

AS

INSERT [dbo].[Course]
(
    [Title],
    [LevelCount],
    [Tuition]

)
VALUES
(
    @Title,
    @LevelCount,
    @Tuition

)
    SELECT @ID=SCOPE_IDENTITY();


GO

