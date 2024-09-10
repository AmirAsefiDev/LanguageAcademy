USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdatePayment]    Script Date: 6/22/2024 4:00:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdatePayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for updating Payment    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdatePayment]
    @ID int,
    @TracingID char(10) = null,
    @Amount char(10) = null,
    @PaymentDate char(10) = null,
    @DocNumber char(15) = null,
    @ID_FK_PayType int = null,
    @ID_FK_Bank int = null,
    @Description nvarchar(MAX) = null,
    @ID_FK_Student int = null

AS

UPDATE [dbo].[Payment]
SET
    [TracingID] = @TracingID,
    [Amount] = @Amount,
    [PaymentDate] = @PaymentDate,
    [DocNumber] = @DocNumber,
    [ID_FK_PayType] = @ID_FK_PayType,
    [ID_FK_Bank] = @ID_FK_Bank,
    [Description] = @Description,
    [ID_FK_Student] = @ID_FK_Student
 WHERE 
    [ID] = @ID

GO

