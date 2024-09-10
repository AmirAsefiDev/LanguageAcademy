using System.Data;
using System.Data.SqlClient;

     public class PermissionData
     {

	 public int DataInsertPermission(int ID ,string UserState ,bool Adduser ,bool DeleteUser ,bool EditUser ,bool SelectUser ,bool PaymentMange ,bool CourseManage ,bool StudentManage ,bool TeacherManage )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertPermission";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@UserState",UserState);
		Sqlcom.Parameters.AddWithValue("@Adduser",Adduser);
		Sqlcom.Parameters.AddWithValue("@DeleteUser",DeleteUser);
		Sqlcom.Parameters.AddWithValue("@EditUser",EditUser);
		Sqlcom.Parameters.AddWithValue("@SelectUser",SelectUser);
		Sqlcom.Parameters.AddWithValue("@PaymentManage",PaymentMange);
		Sqlcom.Parameters.AddWithValue("@CourseManage",CourseManage);
		Sqlcom.Parameters.AddWithValue("@StudentManage",StudentManage);
		Sqlcom.Parameters.AddWithValue("@TeacherManage",TeacherManage);
		Sqlcom.Connection = Scon.OpenCon();
		int R=0;
		Sqlcom.ExecuteNonQuery();
		R = int.Parse(Sqlcom.Parameters["@ID"].Value.ToString());
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DataDeletePermission(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeletePermission";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DataUpdatePermission(int ID ,string UserState ,bool Adduser ,bool DeleteUser ,bool EditUser ,bool SelectUser ,bool PaymentManage ,bool CourseManage ,bool StudentManage ,bool TeacherManage )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdatePermission";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@UserState",UserState);
		Sqlcom.Parameters.AddWithValue("@Adduser",Adduser);
		Sqlcom.Parameters.AddWithValue("@DeleteUser",DeleteUser);
		Sqlcom.Parameters.AddWithValue("@EditUser",EditUser);
		Sqlcom.Parameters.AddWithValue("@SelectUser",SelectUser);
		Sqlcom.Parameters.AddWithValue("@PaymentManage",PaymentManage);
		Sqlcom.Parameters.AddWithValue("@CourseManage",CourseManage);
		Sqlcom.Parameters.AddWithValue("@StudentManage",StudentManage);
		Sqlcom.Parameters.AddWithValue("@TeacherManage",TeacherManage);
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public DataTable DataDetailsPermission(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsPermission",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public int DataDeleteByFieldPermission(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldPermission";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
	}
	 public DataTable DataGetListPermission()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListPermission",Scon.OpenCon());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldPermission(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldPermission",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}


     }// End Class

