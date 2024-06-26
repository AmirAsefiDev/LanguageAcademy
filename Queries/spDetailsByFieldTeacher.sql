USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsByFieldTeacher]    Script Date: 6/22/2024 3:51:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsByFieldTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for Select By Field  from Teacher  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsByFieldTeacher]
    @FieldName nvarchar(100),
    @Value nvarchar(1000)
AS

    DECLARE @query nvarchar(2000);

    SET @query = 'SELECT  top(200) 
 [Teacher].[ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth],  Degree.Title as '''+'Degree'+''',
				case  [Sex] when 0 then '''+'زن'+''' when 1 then '''+'مرد'+''' end  as Sex , [Phone], [Address] FROM [dbo].[Teacher] join Degree
	     on [Teacher].ID_FK_Degree=Degree.ID
	 WHERE ' + @FieldName  + ' like ''%' + @Value + '%'''
    EXEC(@query)

GO

