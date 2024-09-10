USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeletePayment]    Script Date: 6/22/2024 3:47:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDeletePayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for deleting a specific row from Payment  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeletePayment]
    @ID int
AS

DELETE FROM [dbo].[Payment]
 WHERE 
    [ID] = @ID

GO

