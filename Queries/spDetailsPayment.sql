USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsPayment]    Script Date: 6/22/2024 3:52:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:      This stored procedure is intended for selecting a specific row from Payment  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsPayment]
    @ID int
AS

    SELECT 
        [ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [Description], [ID_FK_Student]
    FROM [dbo].[Payment]
    WHERE 
            [ID] = @ID

GO

