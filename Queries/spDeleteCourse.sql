USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteCourse]    Script Date: 6/22/2024 3:46:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteCourse
-- Author:      AmirAsefi
-- Create date: 1403/4/7
--Description:  This stored procedure is intended for deleting a specific row from Course  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteCourse]
    @ID int
AS

DELETE FROM [dbo].[Course]
 WHERE 
    [ID] = @ID

GO

