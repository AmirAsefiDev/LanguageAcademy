USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateTeacher]    Script Date: 6/22/2024 4:01:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for updating Teacher    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateTeacher]
    @ID int,
    @NationalCode char(10) = null,
    @Name nvarchar(50) = null,
    @LastName nvarchar(50) = null,
    @ID_FK_Degree int = null,
    @DateOfBirth char(10) = null,
    @Sex tinyint = null,
    @Phone char(11) = null,
    @Address nvarchar(200) = null

AS

UPDATE [dbo].[Teacher]
SET
    [NationalCode] = @NationalCode,
    [Name] = @Name,
    [LastName] = @LastName,
    [ID_FK_Degree] = @ID_FK_Degree,
    [DateOfBirth] = @DateOfBirth,
    [Sex] = @Sex,
    [Phone] = @Phone,
    [Address] = @Address
 WHERE 
    [ID] = @ID

GO

