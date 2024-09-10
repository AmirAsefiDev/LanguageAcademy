USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListUsers]    Script Date: 6/22/2024 3:56:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	 spGetListUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description:  This stored procedure is intended for selecting all rows from Users  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListUsers]
AS

	SELECT 

	 [UserName],[Users].[ID], [Name], [LastName],Permission.UserState, [Answer], [Password],  [ID_FK_Permission], [ID_FK_SecurityQuestion]
           ,SecurityQuestion.question
	FROM [dbo].[Users] inner join SecurityQuestion
	     on  Users.ID_FK_SecurityQuestion=SecurityQuestion.ID inner join Permission
		 on Permission.ID=Users.ID_FK_Permission

GO

