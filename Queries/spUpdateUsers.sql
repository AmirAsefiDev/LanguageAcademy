USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateUsers]    Script Date: 6/22/2024 4:01:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:	 spUpdateUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for updating Users    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateUsers]
	@ID int,
	@Name nvarchar(50) = null,
	@LastName nvarchar(50) = null,
	@Answer nvarchar(50) = null,
	@Password nvarchar(100) = null,
	@UserName nvarchar(50) = null,
	@ID_FK_Permission int = null,
	@ID_FK_SecurityQuestion int = null

AS

UPDATE [dbo].[Users]
SET
	[Name] = @Name,
	[LastName] = @LastName,
	[Answer] = @Answer,
	[Password] = @Password,
	[UserName] = @UserName,
	[ID_FK_Permission] = @ID_FK_Permission,
	[ID_FK_SecurityQuestion] = @ID_FK_SecurityQuestion
 WHERE 
	[ID] = @ID

GO

