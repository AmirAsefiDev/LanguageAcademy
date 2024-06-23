USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertDegree]    Script Date: 6/22/2024 3:57:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[spInsertDegree]
@ID int output,
@Title nvarchar(50) 
as

insert into  Degree values(@Title)

select @ID=SCOPE_IDENTITY()

GO

