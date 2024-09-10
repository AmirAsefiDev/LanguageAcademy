USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteBank]    Script Date: 6/22/2024 3:42:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeleteBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for deleting a specific row from Bank  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteBank]
    @ID int
AS

DELETE FROM [dbo].[Bank]
 WHERE 
    [ID] = @ID

GO

