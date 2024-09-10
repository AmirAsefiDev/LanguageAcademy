USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[App_Open]    Script Date: 6/22/2024 3:41:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[App_Open]
@userName  nvarchar(50),
@password nvarchar(100)
as
 if exists( select ID from Users where UserName=@userName  and Password=@password)
  return 1
  else
  return 0
GO

