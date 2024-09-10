using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class UserFunction
    {
        public static int App_open(string UserName,string Password)
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCon con = new SqlCon();
            SqlCmd.Connection = con.OpenCon();
            SqlCmd.CommandText = "App_Open";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@userName",UserName);
            SqlCmd.Parameters.AddWithValue("@password",Password);
            SqlCmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            SqlCmd.ExecuteNonQuery();
            int OpenCode =int.Parse( SqlCmd.Parameters["@r"].Value.ToString());
            con.CloseCon();
            return OpenCode;

        }

    }

