USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListPayType]    Script Date: 6/22/2024 3:55:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for selecting all rows from PayType  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListPayType]
AS

    SELECT 
[ID], [PaymentType], [Description]

    FROM [dbo].[PayType]

GO

