USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldPayType]    Script Date: 6/22/2024 3:50:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Select By Field  from PayType  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldPayType]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT [ID], [PaymentType], [Description] FROM [dbo].[PayType] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)

GO

