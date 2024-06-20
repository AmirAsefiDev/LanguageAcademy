
     public class CourseSelect
     {

	 private   int  _ID ;   
	 private   decimal  _ActivityScore ;   
	 private   decimal  _FinalScore ;   
	 private   decimal  _AttendScore ;   
	 private   int  _ID_FK_CourseGroup ;   
	 private   int  _ID_FK_Student ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  decimal   ActivityScore {
		 get{  return _ActivityScore; }
		 set{_ActivityScore=  value;}
	}

 
	 public  decimal   FinalScore {
		 get{  return _FinalScore; }
		 set{_FinalScore=  value;}
	}

 
	 public  decimal   AttendScore {
		 get{  return _AttendScore; }
		 set{_AttendScore=  value;}
	}

 
	 public  int   ID_FK_CourseGroup {
		 get{  return _ID_FK_CourseGroup; }
		 set{_ID_FK_CourseGroup=  value;}
	}

 
	 public  int   ID_FK_Student {
		 get{  return _ID_FK_Student; }
		 set{_ID_FK_Student=  value;}
	}


     }// End Class

