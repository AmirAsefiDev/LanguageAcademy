
     public class CourseGroup
     {

	 private   int  _ID ;   
	 private   int  _Year ;   
	 private   byte  _Term ;   
	 private   byte  _LevelCourse ;   
	 private   string  _Tuition ;   
	 private   string  _WeekPaln ;   
	 private   byte  _ClassNumber ;   
	 private   int  _ID_FK_Teacher ;   
	 private   int  _ID_FK_Course ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public int Year {
		 get{  return _Year; }
		 set{_Year=  value;}
	}

 
	 public  byte   Term {
		 get{  return _Term; }
		 set{_Term=  value;}
	}

 
	 public  byte   LevelCourse {
		 get{  return _LevelCourse; }
		 set{_LevelCourse=  value;}
	}

 
	 public  string   Tuition {
		 get{  return _Tuition; }
		 set{_Tuition=  value;}
	}

 
	 public  string   WeekPaln {
		 get{  return _WeekPaln; }
		 set{_WeekPaln=  value;}
	}

 
	 public  byte   ClassNumber {
		 get{  return _ClassNumber; }
		 set{_ClassNumber=  value;}
	}

 
	 public  int   ID_FK_Teacher {
		 get{  return _ID_FK_Teacher; }
		 set{_ID_FK_Teacher=  value;}
	}

 
	 public  int   ID_FK_Course {
		 get{  return _ID_FK_Course; }
		 set{_ID_FK_Course=  value;}
	}


     }// End Class

