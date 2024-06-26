USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteTeacher]    Script Date: 6/22/2024 3:48:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for deleting a specific row from Teacher  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteTeacher]
    @ID int
AS

DELETE FROM [dbo].[Teacher]
 WHERE 
    [ID] = @ID

GO

