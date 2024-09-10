USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteByFieldPayment]    Script Date: 6/22/2024 3:43:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  DeleteByFieldSPPayment
-- Author:      AmirAsefi
-- Create date: 1403/06/01
--Description:  This stored procedure is intended for Delete By Field  from Payment  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteByFieldPayment]
    @FieldName varchar(100),
    @Value varchar(1000)
AS

    DECLARE @query varchar(2000);

    SET @query = 'DELETE FROM [dbo].[Payment] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
    EXEC(@query)

GO

