using System.Data;
using System.Data.SqlClient;

     public class StudentData
     {

	 public int DataInsertStudent(int ID ,string NationalCode ,string Name ,string LastName ,int ID_FK_Degree ,byte Sex ,string DateofBirth ,string Address ,string Phone ,string Image )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertStudent";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@ID_FK_Degree",ID_FK_Degree);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@DateofBirth",DateofBirth);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Image",Image);
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

	 public int DataDeleteStudent(int ID )
	{
        try
        {
            SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteStudent";
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

	 public int DataUpdateStudent(int ID ,string NationalCode ,string Name ,string LastName ,int ID_FK_Degree ,byte Sex ,string DateofBirth ,string Address ,string Phone ,string Image )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateStudent";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@ID_FK_Degree",ID_FK_Degree);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@DateofBirth",DateofBirth);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Image",Image);
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

	 public DataTable DataDetailsStudent(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsStudent",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public int DataDeleteByFieldStudent(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldStudent";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
	}
	 public DataTable DataGetListStudent()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListStudent",Scon.OpenCon());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldStudent(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldStudent",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}


     }// End Class

