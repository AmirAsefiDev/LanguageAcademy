USE [Db_Zabansara]
GO

/****** Object:  StoredProcedure [dbo].[Bedehi]    Script Date: 6/22/2024 3:42:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER procedure [dbo].[Bedehi]
@StudentID  int
as

declare  @M   int  =0



set @M=(select SUM(CONVERT(int, Tuition)) 
        from CourseGroup 
		where ID  in (
                      select ID_FK_CourseGroup 
                      from CourseSelect 
	                  where ID_FK_Student=@StudentID
                      )
	    )

		return @M
GO

