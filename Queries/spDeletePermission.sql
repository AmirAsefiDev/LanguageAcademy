USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeletePermission]    Script Date: 6/22/2024 3:47:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeletePermission
-- Author:		AmirAsefi
-- Create date:	1403/06/02
--Description: 	This stored procedure is intended for deleting a specific row from Permission  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeletePermission]
	@ID int
AS

DELETE FROM [dbo].[Permission]
 WHERE 
	[ID] = @ID

GO

