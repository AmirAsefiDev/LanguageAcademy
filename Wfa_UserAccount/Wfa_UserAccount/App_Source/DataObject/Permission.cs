
     public class Permission
     {

	 private   int  _ID ;   
	 private   string  _UserState ;   
	 private   bool  _Adduser ;   
	 private   bool  _DeleteUser ;   
	 private   bool  _EditUser ;   
	 private   bool  _SelectUser ;   
	 private   bool  _PaymentManage ;   
	 private   bool  _CourseManage ;   
	 private   bool  _StudentManage ;   
	 private   bool  _TeacherManage ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  string   UserState {
		 get{  return _UserState; }
		 set{_UserState=  value;}
	}

 
	 public  bool   Adduser {
		 get{  return _Adduser; }
		 set{_Adduser=  value;}
	}

 
	 public  bool   DeleteUser {
		 get{  return _DeleteUser; }
		 set{_DeleteUser=  value;}
	}

 
	 public  bool   EditUser {
		 get{  return _EditUser; }
		 set{_EditUser=  value;}
	}

 
	 public  bool   SelectUser {
		 get{  return _SelectUser; }
		 set{_SelectUser=  value;}
	}

 
	 public  bool   PaymentManage {
		 get{  return _PaymentManage; }
		 set{_PaymentManage=  value;}
	}

 
	 public  bool   CourseManage {
		 get{  return _CourseManage; }
		 set{_CourseManage=  value;}
	}

 
	 public  bool   StudentManage {
		 get{  return _StudentManage; }
		 set{_StudentManage=  value;}
	}

 
	 public  bool   TeacherManage {
		 get{  return _TeacherManage; }
		 set{_TeacherManage=  value;}
	}


     }// End Class

