USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateSecurityQuestion]    Script Date: 6/22/2024 4:00:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:	 spUpdateSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for updating SecurityQuestion    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateSecurityQuestion]
	@ID int,
	@question nvarchar(150) = null,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[SecurityQuestion]
SET
	[question] = @question,
	[Description] = @Description
 WHERE 
	[ID] = @ID

GO

