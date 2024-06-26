USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[spDetailsTeacher]    Script Date: 6/22/2024 3:53:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:  spDetailsTeacher
-- Author:      AmirAsefi
-- Create date: 1403/4/6
--Description:      This stored procedure is intended for selecting a specific row from Teacher  Table
-- ==========================================================================================

CREATE OR ALTER PROCEDURE [dbo].[spDetailsTeacher]
    @ID int
AS

    SELECT 
        [ID], [NationalCode], [Name], [LastName], [ID_FK_Degree], [DateOfBirth], [Sex], [Phone], [Address]
    FROM [dbo].[Teacher]
    WHERE 
            [ID] = @ID

GO

