USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldStudent]    Script Date: 6/22/2024 3:51:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for Select By Field  from Student  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldStudent]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT Student.ID, [NationalCode], [Name],ID_FK_Degree, [LastName], Degree.Title as '''+'Degree'+''',
				  case  [Sex] when 0 then '''+'مونث'+''' when 1 then '''+'مذکر'+''' end  as Sex ,
				  [DateofBirth], [Phone], [Image], [Address]  FROM [dbo].[Student] join Degree
	              on Student.ID_FK_Degree=Degree.ID  WHERE ' + @FieldName  + ' like ''%' + @Value + '%'''
    EXEC(@query)

GO

