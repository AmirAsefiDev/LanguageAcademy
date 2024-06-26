USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spGetListTeacher]    Script Date: 6/22/2024 3:56:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for selecting all rows from Teacher  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListTeacher]
AS

    SELECT top(10)
 [Teacher].[ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth],  Degree.Title as 'Degree',
				case  [Sex] when 0 then 'زن' when 1 then 'مرد' end  as Sex , [Phone], [Address]

    FROM [dbo].[Teacher] join Degree
	     on [Teacher].ID_FK_Degree=Degree.ID
	order by [Teacher].ID Desc

GO

