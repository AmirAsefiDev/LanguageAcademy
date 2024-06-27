USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsCourse]    Script Date: 6/22/2024 3:51:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:      This stored procedure is intended for selecting a specific row from Course  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsCourse]
    @ID int
AS

    SELECT 
        [ID], [Title], [LevelCount], [Tuition]
    FROM [dbo].[Course]
    WHERE 
            [ID] = @ID

GO

