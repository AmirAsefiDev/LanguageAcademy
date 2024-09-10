USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeletePayType]    Script Date: 6/22/2024 3:47:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeletePayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for deleting a specific row from PayType  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeletePayType]
    @ID int
AS

DELETE FROM [dbo].[PayType]
 WHERE 
    [ID] = @ID

GO

