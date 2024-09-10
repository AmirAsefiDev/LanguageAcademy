USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteUsers]    Script Date: 6/22/2024 3:49:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDeleteUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for deleting a specific row from Users  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDeleteUsers]
	@ID int
AS

DELETE FROM [dbo].[Users]
 WHERE 
	[ID] = @ID

GO

