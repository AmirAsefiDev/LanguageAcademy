USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsPayType]    Script Date: 6/22/2024 3:52:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:      This stored procedure is intended for selecting a specific row from PayType  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsPayType]
    @ID int
AS

    SELECT 
        [ID], [PaymentType], [Description]
    FROM [dbo].[PayType]
    WHERE 
            [ID] = @ID

GO

