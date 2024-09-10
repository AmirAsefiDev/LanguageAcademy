USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertSecurityQuestion]    Script Date: 6/22/2024 3:57:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spInsertSecurityQuestion
-- Author:	 AmirAsefi
-- Create date:	1403/06/01
--Description: 	This stored procedure is intended for inserting values to SecurityQuestion    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertSecurityQuestion]
	@ID int output,
	@question nvarchar(150) = null ,
	@Description nvarchar(MAX) = null 

AS

INSERT [dbo].[SecurityQuestion]
(
	[question],
	[Description]

)
VALUES
(
	@question,
	@Description

)
	SELECT @ID=SCOPE_IDENTITY();


GO

