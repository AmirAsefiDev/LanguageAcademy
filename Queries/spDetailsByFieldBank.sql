USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldBank]    Script Date: 6/22/2024 3:49:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for Select By Field  from Bank  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldBank]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT [ID], [Name] FROM [dbo].[Bank] WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
    EXEC(@query)

GO

