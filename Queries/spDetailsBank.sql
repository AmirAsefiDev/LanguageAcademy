USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsBank]    Script Date: 6/22/2024 3:49:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:      This stored procedure is intended for selecting a specific row from Bank  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsBank]
    @ID int
AS

    SELECT 
        [ID], [Name]
    FROM [dbo].[Bank]
    WHERE 
            [ID] = @ID

GO

