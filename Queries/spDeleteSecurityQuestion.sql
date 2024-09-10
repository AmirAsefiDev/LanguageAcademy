USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteSecurityQuestion]    Script Date: 6/22/2024 3:47:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeleteSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for deleting a specific row from SecurityQuestion  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteSecurityQuestion]
	@ID int
AS

DELETE FROM [dbo].[SecurityQuestion]
 WHERE 
	[ID] = @ID

GO

