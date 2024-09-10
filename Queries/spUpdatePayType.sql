USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdatePayType]    Script Date: 6/22/2024 4:00:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdatePayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for updating PayType    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdatePayType]
    @ID int,
    @PaymentType nvarchar(50) = null,
    @Description nvarchar(100) = null

AS

UPDATE [dbo].[PayType]
SET
    [PaymentType] = @PaymentType,
    [Description] = @Description
 WHERE 
    [ID] = @ID

GO

