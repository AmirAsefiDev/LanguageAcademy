using System.Data;
using System.Data.SqlClient;

public class CourseSelectData
{

    public int DataInsertCourseSelect(int ID, decimal ActivityScore, decimal FinalScore, decimal AttendScore, int ID_FK_CourseGroup, int ID_FK_Student)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "spInsertCourseSelect";
            Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            Sqlcom.Parameters.AddWithValue("@ActivityScore", ActivityScore);
            Sqlcom.Parameters.AddWithValue("@FinalScore", FinalScore);
            Sqlcom.Parameters.AddWithValue("@AttendScore", AttendScore);
            Sqlcom.Parameters.AddWithValue("@ID_FK_CourseGroup", ID_FK_CourseGroup);
            Sqlcom.Parameters.AddWithValue("@ID_FK_Student", ID_FK_Student);
            Sqlcom.Connection = Scon.OpenCon();
            int R = 0;
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

    public int DataDeleteCourseSelect(int ID)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "spDeleteCourseSelect";
            Sqlcom.Parameters.AddWithValue("@ID", ID);
            Sqlcom.Connection = Scon.OpenCon();
            int R = Sqlcom.ExecuteNonQuery();
            Scon.CloseCon();
            return R;
        }
        catch
        {
            return 0;
        }
    }

    public int DataUpdateCourseSelect(int ID, decimal ActivityScore, decimal FinalScore, decimal AttendScore, int ID_FK_CourseGroup, int ID_FK_Student)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "spUpdateCourseSelect";
            Sqlcom.Parameters.AddWithValue("@ID", ID);
            Sqlcom.Parameters.AddWithValue("@ActivityScore", ActivityScore);
            Sqlcom.Parameters.AddWithValue("@FinalScore", FinalScore);
            Sqlcom.Parameters.AddWithValue("@AttendScore", AttendScore);
            Sqlcom.Parameters.AddWithValue("@ID_FK_CourseGroup", ID_FK_CourseGroup);
            Sqlcom.Parameters.AddWithValue("@ID_FK_Student", ID_FK_Student);
            Sqlcom.Connection = Scon.OpenCon();
            int R = Sqlcom.ExecuteNonQuery();
            Scon.CloseCon();
            return R;
        }
        catch
        {
            return 0;
        }
    }

    public DataTable DataDetailsCourseSelect(int ID)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsCourseSelect", Scon.OpenCon());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DTable = new DataTable();
        Sqlda.SelectCommand.Parameters.AddWithValue("@ID", ID);
        Sqlda.Fill(DTable);
        Scon.CloseCon();
        return DTable;
    }

    public int DataDeleteByFieldCourseSelect(string FieldName, string value)
    {
        SqlCommand Sqlcom = new SqlCommand();
        Sqlcom.CommandType = CommandType.StoredProcedure;
        Sqlcom.CommandText = "spDeleteByFieldCourseSelect";
        SqlCon Scon = new SqlCon();
        Sqlcom.Parameters.AddWithValue("@FieldName", FieldName);
        Sqlcom.Parameters.AddWithValue("@Value", value);
        Sqlcom.Connection = Scon.OpenCon();
        int R = Sqlcom.ExecuteNonQuery();
        Scon.CloseCon();
        return R;
    }
    public DataTable DataGetListCourseSelect()
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListCourseSelect", Scon.OpenCon());
        DataTable DTable = new DataTable();
        Sqlda.Fill(DTable);
        Scon.CloseCon();
        return DTable;
    }

    public DataTable DataDetailsByFieldCourseSelect(string FieldName, string value)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldCourseSelect", Scon.OpenCon());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName);
        Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value);
        DataTable DTable = new DataTable();
        Sqlda.Fill(DTable);
        Scon.CloseCon();
        return DTable;
    }


}// End Class

