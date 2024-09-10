USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsUsers]    Script Date: 6/22/2024 3:53:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spDetailsUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description:  	This stored procedure is intended for selecting a specific row from Users  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsUsers]
	@ID int
AS

	SELECT 
		[ID], [Name], [LastName], [Answer], [Password], [UserName], [ID_FK_Permission], [ID_FK_SecurityQuestion]
	FROM [dbo].[Users]
	WHERE 
			[ID] = @ID

GO

