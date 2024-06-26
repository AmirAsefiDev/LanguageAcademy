USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertTeacher]    Script Date: 6/22/2024 3:58:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:  This stored procedure is intended for inserting values to Teacher    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertTeacher]
    @ID int output,
    @NationalCode char(10) = null ,
    @Name nvarchar(50) = null ,
    @LastName nvarchar(50) = null ,
    @ID_FK_Degree int = null ,
    @DateOfBirth char(10) = null ,
    @Sex tinyint = null ,
    @Phone char(11) = null ,
    @Address nvarchar(200) = null 

AS

INSERT [dbo].[Teacher]
(
    [NationalCode],
    [Name],
    [LastName],
    [ID_FK_Degree],
    [DateOfBirth],
    [Sex],
    [Phone],
    [Address]

)
VALUES
(
    @NationalCode,
    @Name,
    @LastName,
    @ID_FK_Degree,
    @DateOfBirth,
    @Sex,
    @Phone,
    @Address

)
    SELECT @ID=SCOPE_IDENTITY();


GO

