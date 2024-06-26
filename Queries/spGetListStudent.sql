 USE [Db_Zabansara]
GO
/****** Object:  StoredProcedure [dbo].[spGetListStudent]    Script Date: 6/23/2024 6:45:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spGetListStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/2
--Description:  This stored procedure is intended for selecting all rows from Student  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spGetListStudent]
AS

    SELECT top (10)
                Student.ID, [NationalCode], [Name] , ID_FK_Degree , [LastName],Degree.Title as 'Degree' ,
				CASE [Sex] WHEN 0 THEN 'زن' WHEN 1 THEN 'مرد' END AS Sex, [DateofBirth], [Phone], [Image], [Address]
    FROM [dbo].[Student] JOIN Degree
		ON Student.ID_FK_Degree = Degree.ID
	order by Student.ID Desc
