using System.Data.SqlClient;
using System.Data;
namespace wfa_FinancialSystem.App_Source.BusinessLayer
{
    class UserFunction
    {
          public static string FreeCode()
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCon con = new SqlCon();
            SqlCmd.Connection = con.OpenCon();
            SqlCmd.CommandText = "FreeDocCode";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.Add("@r", SqlDbType.Int).Direction=ParameterDirection.ReturnValue;
            SqlCmd.ExecuteNonQuery();
           string StrCode=  SqlCmd.Parameters["@r"].Value.ToString();
            con.CloseCon();
            return StrCode;

        }
        public static string Bedehi(string StrStudentID)
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCon con = new SqlCon();
            SqlCmd.Connection = con.OpenCon();
            SqlCmd.CommandText = "Bedehi";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@StudentID",StrStudentID);
            SqlCmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            SqlCmd.ExecuteNonQuery();
            string StrCode = SqlCmd.Parameters["@r"].Value.ToString();
            con.CloseCon();
            return StrCode;

        }
    }
}
