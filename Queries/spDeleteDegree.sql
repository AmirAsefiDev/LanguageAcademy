USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteDegree]    Script Date: 6/22/2024 3:47:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[spDeleteDegree]
@ID int
as

delete from Degree
where ID=@ID
GO

