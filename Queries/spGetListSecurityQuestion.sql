USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListSecurityQuestion]    Script Date: 6/22/2024 3:55:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spGetListSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01 
--Description:  This stored procedure is intended for selecting all rows from SecurityQuestion  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListSecurityQuestion]
AS

	SELECT 
[ID], [question], [Description]

	FROM [dbo].[SecurityQuestion]

GO

