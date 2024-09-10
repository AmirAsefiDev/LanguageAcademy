USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldUsers]    Script Date: 6/22/2024 3:51:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name: spDetailsByFieldUsers
-- Author:AmirAsefi
-- Create date:	1403/6/04
--Description: 	This stored procedure is intended for Select By Field  from Users  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldUsers]
	@FieldName nvarchar(100),
	@Value nvarchar(1000)
AS

	DECLARE @query nvarchar(2000);

	SET @query = 'SELECT 	[UserName],[Users].[ID], [Name], [LastName],Permission.UserState, [Answer], [Password],  [ID_FK_Permission], [ID_FK_SecurityQuestion]
                           ,SecurityQuestion.question FROM [dbo].[Users] inner join SecurityQuestion
	                       on  Users.ID_FK_SecurityQuestion=SecurityQuestion.ID inner join Permission
	                   	   on Permission.ID=Users.ID_FK_Permission WHERE ' + @FieldName  + ' like ''' + @Value + '%'''
	EXEC(@query)

GO

