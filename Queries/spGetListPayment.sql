USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListPayment]    Script Date: 6/22/2024 3:55:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for selecting all rows from Payment  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListPayment]
AS

    SELECT 
     Student.Name +' '+Student.LastName as  'StudentName', [Payment].[ID], [TracingID], [Amount], [PaymentDate], [DocNumber], [ID_FK_PayType], [ID_FK_Bank], [ID_FK_Student]
      , Bank.Name as 'Bank'
      , PayType.PaymentType , [Payment].[Description] 

    FROM [dbo].[Payment] left join   Student
	     on Payment.ID_FK_Student=Student.ID left join  Bank
		 on Payment.ID_FK_Bank=Bank.ID  left join PayType
		 on  Payment.ID_FK_PayType=PayType.ID

GO

