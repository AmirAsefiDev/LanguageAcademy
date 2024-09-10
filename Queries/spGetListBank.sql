USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListBank]    Script Date: 6/22/2024 3:53:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for selecting all rows from Bank  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListBank]
AS

    SELECT 
[ID], [Name]

    FROM [dbo].[Bank]

GO

