USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateDegree]    Script Date: 6/22/2024 3:59:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[spUpdateDegree]
@ID int ,
@Title nvarchar(50) 
as

if (select COUNT(ID) from Degree where ID=@ID)>0
begin
update Degree
set Title=@Title
where ID=@ID



return @ID
end
return 0
GO

