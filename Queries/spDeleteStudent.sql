USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 6/22/2024 3:48:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteStudent
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for deleting a specific row from Student  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteStudent]
    @ID int
AS

DELETE FROM [dbo].[Student]
 WHERE 
    [ID] = @ID

GO

