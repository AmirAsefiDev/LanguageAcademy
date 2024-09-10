
using System.Data;


     public class SecurityQuestionBusiness
     {

	public int Insert(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataInsertSecurityQuestion(  objSecurityQuestion.ID , objSecurityQuestion.question , objSecurityQuestion.Description );
	}


	public int Update(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataUpdateSecurityQuestion(  objSecurityQuestion.ID , objSecurityQuestion.question , objSecurityQuestion.Description );
	}


	public int Delete(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDeleteSecurityQuestion( objSecurityQuestion.ID );
	}


	public  DataTable Details(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDetailsSecurityQuestion( objSecurityQuestion.ID );
	}


	public  int DeleteByField(string FieldName,string  value) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDeleteByFieldSecurityQuestion(FieldName,value);
	}

	public  DataTable GetList( ) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataGetListSecurityQuestion();
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDetailsByFieldSecurityQuestion(FieldName,value);
	}

     }// End Class

