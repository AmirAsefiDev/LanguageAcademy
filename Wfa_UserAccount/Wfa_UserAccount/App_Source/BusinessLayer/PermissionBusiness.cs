
using System.Data;


     public class PermissionBusiness
     {

	public int Insert(Permission  objPermission) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataInsertPermission(  objPermission.ID , objPermission.UserState , objPermission.Adduser , objPermission.DeleteUser , objPermission.EditUser , objPermission.SelectUser , objPermission.PaymentManage , objPermission.CourseManage , objPermission.StudentManage , objPermission.TeacherManage );
	}


	public int Update(Permission  objPermission) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataUpdatePermission(  objPermission.ID , objPermission.UserState , objPermission.Adduser , objPermission.DeleteUser , objPermission.EditUser , objPermission.SelectUser , objPermission.PaymentManage , objPermission.CourseManage , objPermission.StudentManage , objPermission.TeacherManage );
	}


	public int Delete(Permission  objPermission) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataDeletePermission( objPermission.ID );
	}


	public  DataTable Details(Permission  objPermission) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataDetailsPermission( objPermission.ID );
	}


	public  int DeleteByField(string FieldName,string  value) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataDeleteByFieldPermission(FieldName,value);
	}

	public  DataTable GetList( ) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataGetListPermission();
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		PermissionData  objData = new PermissionData();
		return  objData.DataDetailsByFieldPermission(FieldName,value);
	}

     }// End Class

