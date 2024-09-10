
     public class Users
     {

	 private   int  _ID ;   
	 private   string  _Name ;   
	 private   string  _LastName ;   
	 private   string  _Answer ;   
	 private   string  _Password ;   
	 private   string  _UserName ;   
	 private   int  _ID_FK_Permission ;   
	 private   int  _ID_FK_SecurityQuestion ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  string   Name {
		 get{  return _Name; }
		 set{_Name=  value;}
	}

 
	 public  string   LastName {
		 get{  return _LastName; }
		 set{_LastName=  value;}
	}

 
	 public  string   Answer {
		 get{  return _Answer; }
		 set{_Answer=  value;}
	}

 
	 public  string   Password {
		 get{  return _Password; }
		 set{_Password=  value;}
	}

 
	 public  string   UserName {
		 get{  return _UserName; }
		 set{_UserName=  value;}
	}

 
	 public  int   ID_FK_Permission {
		 get{  return _ID_FK_Permission; }
		 set{_ID_FK_Permission=  value;}
	}

 
	 public  int   ID_FK_SecurityQuestion {
		 get{  return _ID_FK_SecurityQuestion; }
		 set{_ID_FK_SecurityQuestion=  value;}
	}


     }// End Class

