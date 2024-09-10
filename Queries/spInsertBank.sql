USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spInsertBank]    Script Date: 6/22/2024 3:56:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spInsertBank
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:  This stored procedure is intended for inserting values to Bank    Table
-- ==========================================================================================
CREATE OR ALTER PROCEDURE [dbo].[spInsertBank]
    @ID int output,
    @Name nvarchar(50) = null 

AS

INSERT [dbo].[Bank]
(
    [Name]

)
VALUES
(
    @Name

)
    SELECT @ID=SCOPE_IDENTITY();


GO

