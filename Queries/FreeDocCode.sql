USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[FreeDocCode]    Script Date: 6/22/2024 3:42:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[FreeDocCode]

as
declare @Code int  
set @Code=1
while   exists (select ID from  Payment where DocNumber=@Code)
begin
  set @Code =@Code+1 
end  
return  @code
GO

