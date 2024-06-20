using System;
using System.Data;
using System.Data.SqlClient;


    public class SqlCon
    {
        private string Strcon;
        private SqlConnection con;

        public SqlConnection OpenCon()
        {
            Strcon = "Data Source=.;Initial Catalog=Db_Zabansara;Integrated Security=True;Encrypt=False;";

            con = new SqlConnection(Strcon);
            con.Open();
            return con;
        }

        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

