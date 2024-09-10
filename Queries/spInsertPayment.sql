USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertPayment]    Script Date: 6/22/2024 3:57:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for inserting values to Payment    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertPayment]
    @ID int output,
    @TracingID char(10) = null ,
    @Amount char(10) = null ,
    @PaymentDate char(10) = null ,
    @DocNumber char(15) = null ,
    @ID_FK_PayType int = null ,
    @ID_FK_Bank int = null ,
    @Description nvarchar(MAX) = null ,
    @ID_FK_Student int = null 

AS

INSERT [dbo].[Payment]
(
    [TracingID],
    [Amount],
    [PaymentDate],
    [DocNumber],
    [ID_FK_PayType],
    [ID_FK_Bank],
    [Description],
    [ID_FK_Student]

)
VALUES
(
    @TracingID,
    @Amount,
    @PaymentDate,
    @DocNumber,
    @ID_FK_PayType,
    @ID_FK_Bank,
    @Description,
    @ID_FK_Student

)
    SELECT @ID=SCOPE_IDENTITY();


GO

