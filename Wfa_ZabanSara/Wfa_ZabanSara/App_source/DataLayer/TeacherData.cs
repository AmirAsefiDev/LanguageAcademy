using System.Data;
using System.Data.SqlClient;

     public class TeacherData
     {

	 public int DataInsertTeacher(int ID ,string NationalCode ,string Name ,string LastName ,int ID_FK_Degree ,string DateOfBirth ,byte Sex ,string Phone ,string Address )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertTeacher";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@ID_FK_Degree",ID_FK_Degree);
		Sqlcom.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
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

	 public int DataDeleteTeacher(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteTeacher";
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

	 public int DataUpdateTeacher(int ID ,string NationalCode ,string Name ,string LastName ,int ID_FK_Degree ,string DateOfBirth ,byte Sex ,string Phone ,string Address )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateTeacher";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@ID_FK_Degree",ID_FK_Degree);
		Sqlcom.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
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

	 public DataTable DataDetailsTeacher(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsTeacher",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public int DataDeleteByFieldTeacher(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldTeacher";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
	}
	 public DataTable DataGetListTeacher()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListTeacher",Scon.OpenCon());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldTeacher(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldTeacher",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}


     }// End Class

