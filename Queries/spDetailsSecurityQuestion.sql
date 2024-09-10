USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsSecurityQuestion]    Script Date: 6/22/2024 3:52:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsSecurityQuestion
-- Author:		AmirAsefi
-- Create date:	1403/06/01
--Description:  	This stored procedure is intended for selecting a specific row from SecurityQuestion  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsSecurityQuestion]
	@ID int
AS

	SELECT 
		[ID], [question], [Description]
	FROM [dbo].[SecurityQuestion]
	WHERE 
			[ID] = @ID

GO

