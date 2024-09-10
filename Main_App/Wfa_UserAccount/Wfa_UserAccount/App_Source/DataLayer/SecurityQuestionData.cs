using System.Data;
using System.Data.SqlClient;

     public class SecurityQuestionData
     {

	 public int DataInsertSecurityQuestion(int ID ,string question ,string Description )
	{
        try
        {
            SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertSecurityQuestion";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@question",question);
		Sqlcom.Parameters.AddWithValue("@Description",Description);
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

	 public int DataDeleteSecurityQuestion(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteSecurityQuestion";
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

	 public int DataUpdateSecurityQuestion(int ID ,string question ,string Description )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateSecurityQuestion";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@question",question);
		Sqlcom.Parameters.AddWithValue("@Description",Description);
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

	 public DataTable DataDetailsSecurityQuestion(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsSecurityQuestion",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public int DataDeleteByFieldSecurityQuestion(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldSecurityQuestion";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
	}
	 public DataTable DataGetListSecurityQuestion()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListSecurityQuestion",Scon.OpenCon());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldSecurityQuestion(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldSecurityQuestion",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}


     }// End Class

