
using System.Data;


     public class UsersBusiness
     {

	public int Insert(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataInsertUsers(  objUsers.ID , objUsers.Name , objUsers.LastName , objUsers.Answer , objUsers.Password , objUsers.UserName , objUsers.ID_FK_Permission , objUsers.ID_FK_SecurityQuestion );
	}


	public int Update(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataUpdateUsers(  objUsers.ID , objUsers.Name , objUsers.LastName , objUsers.Answer , objUsers.Password , objUsers.UserName , objUsers.ID_FK_Permission , objUsers.ID_FK_SecurityQuestion );
	}


	public int Delete(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDeleteUsers( objUsers.ID );
	}


	public  DataTable Details(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDetailsUsers( objUsers.ID );
	}


	public  int DeleteByField(string FieldName,string  value) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDeleteByFieldUsers(FieldName,value);
	}

	public  DataTable GetList( ) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataGetListUsers();
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDetailsByFieldUsers(FieldName,value);
	}

     }// End Class

