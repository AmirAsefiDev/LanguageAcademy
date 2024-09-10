using System.Data;
using System.Data.SqlClient;


namespace Wfa_ZabanSara.App_source.DataLayer
{
    class DegreeData
    {
        public DataTable GetListData()
        {
            SqlCon con = new SqlCon();
            SqlDataAdapter sqlDa = new SqlDataAdapter("spGetListDegree", con.OpenCon());
            DataTable Dtable = new DataTable();
            sqlDa.Fill(Dtable);
            return Dtable;
        }

        public int insertData(string Title)
        {
            SqlCon con = new SqlCon();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = "spInsertDegree";
            Sqlcmd.Parameters.AddWithValue("@title", Title);
            Sqlcmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            Sqlcmd.Connection = con.OpenCon();
            Sqlcmd.ExecuteNonQuery();
            int Result = int.Parse(Sqlcmd.Parameters["@ID"].Value.ToString());
            con.CloseCon();
            return Result;
        }

        public int UpdateData(int ID, string Title)
        {
            SqlCon con = new SqlCon();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = "spUpdateDegree";
            Sqlcmd.Parameters.AddWithValue("@title", Title);
            Sqlcmd.Parameters.AddWithValue("@ID", ID);
            Sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Sqlcmd.Connection = con.OpenCon();
            Sqlcmd.ExecuteNonQuery();
            int Result = int.Parse(Sqlcmd.Parameters["@r"].Value.ToString());
            con.CloseCon();
            return Result;
        }

        public void DeleteData(int ID)
        {
            SqlCon con = new SqlCon();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = "spDeleteDegree";
            Sqlcmd.Parameters.AddWithValue("@ID", ID);

            Sqlcmd.Connection = con.OpenCon();
            Sqlcmd.ExecuteNonQuery();

            con.CloseCon();

        }
    }
}
