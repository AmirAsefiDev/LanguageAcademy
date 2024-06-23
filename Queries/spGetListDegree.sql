USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListDegree]    Script Date: 6/22/2024 3:54:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[spGetListDegree]

as
select ID,title
from Degree
GO

