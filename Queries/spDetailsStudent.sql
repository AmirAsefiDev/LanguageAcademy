USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsStudent]    Script Date: 6/22/2024 3:53:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsStudent
-- Author:      Rahim Lotfi
-- Create date: 1395/4/16
--Description:      This stored procedure is intended for selecting a specific row from Student  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsStudent]
    @ID int
AS

    SELECT 
        [ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [Sex], [DateofBirth], [Address], [Phone], [Image]
    FROM [dbo].[Student]
    WHERE 
            [ID] = @ID

GO

