USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertUsers]    Script Date: 6/22/2024 3:58:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spInsertUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for inserting values to Users    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertUsers]
	@ID int output,
	@Name nvarchar(50) = null ,
	@LastName nvarchar(50) = null ,
	@Answer nvarchar(50) = null ,
	@Password nvarchar(100) = null ,
	@UserName nvarchar(50) = null ,
	@ID_FK_Permission int = null ,
	@ID_FK_SecurityQuestion int = null 

AS

INSERT [dbo].[Users]
(
	[Name],
	[LastName],
	[Answer],
	[Password],
	[UserName],
	[ID_FK_Permission],
	[ID_FK_SecurityQuestion]

)
VALUES
(
	@Name,
	@LastName,
	@Answer,
	@Password,
	@UserName,
	@ID_FK_Permission,
	@ID_FK_SecurityQuestion

)
	SELECT @ID=SCOPE_IDENTITY();


GO

