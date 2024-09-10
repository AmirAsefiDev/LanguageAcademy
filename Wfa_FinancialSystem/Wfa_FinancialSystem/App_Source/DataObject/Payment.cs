
     public class Payment
     {

	 private   int  _ID ;   
	 private   string  _TracingID ;   
	 private   string  _Amount ;   
	 private   string  _PaymentDate ;   
	 private   string  _DocNumber ;   
	 private   int  _ID_FK_PayType ;   
	 private   int  _ID_FK_Bank ;   
	 private   string  _Description ;   
	 private   int  _ID_FK_Student ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  string   TracingID {
		 get{  return _TracingID; }
		 set{_TracingID=  value;}
	}

 
	 public  string   Amount {
		 get{  return _Amount; }
		 set{_Amount=  value;}
	}

 
	 public  string   PaymentDate {
		 get{  return _PaymentDate; }
		 set{_PaymentDate=  value;}
	}

 
	 public  string   DocNumber {
		 get{  return _DocNumber; }
		 set{_DocNumber=  value;}
	}

 
	 public  int   ID_FK_PayType {
		 get{  return _ID_FK_PayType; }
		 set{_ID_FK_PayType=  value;}
	}

 
	 public  int   ID_FK_Bank {
		 get{  return _ID_FK_Bank; }
		 set{_ID_FK_Bank=  value;}
	}

 
	 public  string   Description {
		 get{  return _Description; }
		 set{_Description=  value;}
	}

 
	 public  int   ID_FK_Student {
		 get{  return _ID_FK_Student; }
		 set{_ID_FK_Student=  value;}
	}


     }// End Class

