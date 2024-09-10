USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldPayType]    Script Date: 6/22/2024 3:44:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPPayType
-- Author:      AmirAsefi
-- Create date: 1403/5/26
--Description:  This stored procedure is intended for Delete By Field  from PayType  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldPayType]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[PayType] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

