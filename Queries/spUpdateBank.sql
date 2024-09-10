USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateBank]    Script Date: 6/22/2024 3:58:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for updating Bank    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateBank]
    @ID int,
    @Name nvarchar(50) = null

AS

UPDATE [dbo].[Bank]
SET
    [Name] = @Name
 WHERE 
    [ID] = @ID

GO

