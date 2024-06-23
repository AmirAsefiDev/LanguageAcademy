USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateStudent]    Script Date: 6/22/2024 4:01:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==========================================================================================
-- Entity Name:  spUpdateStudent
-- Author:      AmirAsefi
-- Create date: 1403/4/3
--Description:  This stored procedure is intended for updating Student    Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spUpdateStudent]
    @ID int,
    @NationalCode char(10),
    @Name nvarchar(50),
    @LastName nvarchar(50),
    @ID_FK_Degree int = null,
    @Sex tinyint = null,
    @DateofBirth char(10) = null,
    @Address nvarchar(200) = null,
    @Phone char(11) = null,
    @Image varchar(100) = null

AS

UPDATE [dbo].[Student]
SET
    [NationalCode] = @NationalCode,
    [Name] = @Name,
    [LastName] = @LastName,
    [ID_FK_Degree] = @ID_FK_Degree,
    [Sex] = @Sex,
    [DateofBirth] = @DateofBirth,
    [Address] = @Address,
    [Phone] = @Phone,
    [Image] = @Image
 WHERE 
    [ID] = @ID

GO

