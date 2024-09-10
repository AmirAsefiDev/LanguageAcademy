USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertPayType]    Script Date: 6/22/2024 3:57:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for inserting values to PayType    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertPayType]
    @ID int output,
    @PaymentType nvarchar(50) = null ,
    @Description nvarchar(100) = null 

AS

INSERT [dbo].[PayType]
(
    [PaymentType],
    [Description]

)
VALUES
(
    @PaymentType,
    @Description

)
    SELECT @ID=SCOPE_IDENTITY();


GO

