USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPayment]    Script Date: 6/22/2024 3:50:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for Select By Field  from Payment  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldPayment]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT Student.Name +'' ''+Student.LastName as  ''StudentName'', [Payment].[ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [ID_FK_Student]
      , Bank.Name as ''Bank''   , PayType.PaymentType , [Payment].[Description]  FROM [dbo].[Payment] left join   Student
	     on Payment.ID_FK_Student=Student.ID left join  Bank
		 on Payment.ID_FK_Bank=Bank.ID  left join PayType
		 on  Payment.ID_FK_PayType=PayType.ID WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)

GO

