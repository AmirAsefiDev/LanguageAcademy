USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertStudent]    Script Date: 6/22/2024 3:58:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertStudent
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for inserting values to Student    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertStudent]
    @ID int output,
    @NationalCode char(10) ,
    @Name nvarchar(50) ,
    @LastName nvarchar(50) ,
    @ID_FK_Degree int = null ,
    @Sex tinyint = null ,
    @DateofBirth char(10) = null ,
    @Address nvarchar(200) = null ,
    @Phone char(11) = null ,
    @Image varchar(100) = null 

AS

INSERT [dbo].[Student]
(
    [NationalCode],
    [Name],
    [LastName],
    [ID_FK_Degree],
    [Sex],
    [DateofBirth],
    [Address],
    [Phone],
    [Image]

)
VALUES
(
    @NationalCode,
    @Name,
    @LastName,
    @ID_FK_Degree,
    @Sex,
    @DateofBirth,
    @Address,
    @Phone,
    @Image

)
    SELECT @ID=SCOPE_IDENTITY();


GO

