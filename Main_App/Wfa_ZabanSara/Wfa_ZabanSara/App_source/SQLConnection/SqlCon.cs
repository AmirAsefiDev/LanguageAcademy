﻿using System;
using System.Data;
using System.Data.SqlClient;


    public class SqlCon
    {
        private string Strcon;
        private SqlConnection con;

        public SqlConnection OpenCon()
        {
            //Strcon = "Data Source=DESKTOP-UCH34N1\\AMIR;Initial Catalog=Db_Zabansara;Integrated Security=True;Encrypt=False";
            Strcon = BaseControl.MainConnection.StrConnection;

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

