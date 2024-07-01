using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace winprint
{
 public   class Export_To_Excel
    {
        public void WriteToExcel(System.Data.DataTable dt, string location)
        {
            if (location.IndexOf("xls") == -1)
                location += ".xlsx";
            if (File.Exists(location))
            {
                try
                {
                    File.Delete(location);
                }
                catch
                {
                    ;
                }
            }
            //instantiate excel objects (application, workbook, worksheets)
            excel.Application XlObj = new excel.Application();
            XlObj.Visible = false;
            excel._Workbook WbObj = (excel.Workbook)(XlObj.Workbooks.Add(""));
            excel._Worksheet WsObj = (excel.Worksheet)WbObj.ActiveSheet;

            //run through datatable and assign cells to values of datatable
            try
            {
                int row = 1; int col = 1;
                foreach (DataColumn column in dt.Columns)
                {
                    //adding columns
                    WsObj.Cells[row, col] = column.ColumnName;
                    col++;
                }
                //reset column and row variables
                col = 1;
                row++;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //adding data
                    foreach (var cell in dt.Rows[i].ItemArray)
                    {
                        WsObj.Cells[row, col] = cell;
                        col++;
                    }
                    col = 1;
                    row++;
                }
                WbObj.SaveAs(location);
               // System.Diagnostics.Process.Start(location);
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ErrorHandler.Handle(ex);
            }
            finally
            {
                WbObj.Close();
                System.Diagnostics.Process.Start(location);
            }
        }
        public void WriteToExcel(DataGridView dt, string location)
        {
            if (location.IndexOf("xls") == -1)
                location += ".xlsx";
            if (File.Exists(location))
            {
                try
                {
                    File.Delete(location);
                }
                catch
                {
                    ;
                }
            }
            //instantiate excel objects (application, workbook, worksheets)
            excel.Application XlObj = new excel.Application();
            XlObj.Visible = false;
            excel._Workbook WbObj = (excel.Workbook)(XlObj.Workbooks.Add(""));
            excel._Worksheet WsObj = (excel.Worksheet)WbObj.ActiveSheet;

            //run through datatable and assign cells to values of datatable
            try
            {
                int row = 1; int col = 1;
                foreach (DataGridViewColumn column in dt.Columns)
                {
                    
                    WsObj.Cells[row, col] = column.HeaderText;
                    col++;
                }



                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    for (int j = 0; j < dt.ColumnCount; ++j)
                    {

                        WsObj.Cells[i + 2, j+1 ] = dt.Rows[i].Cells[j].Value;
                    }
                }


                WbObj.SaveAs(location);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                WbObj.Close();
                System.Diagnostics.Process.Start(location);
            }
        }

        public DataTable ImportExceltoDatatable(string filepath,string SheetName)
        {
            if (SheetName.IndexOf("$") == -1)
                SheetName += "$";
            // string sqlquery= "Select * From [SheetName$] Where YourCondition";
            string sqlquery = "Select * From ["+SheetName+"] ";
            DataSet ds = new DataSet();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
            OleDbConnection con = new OleDbConnection(constring + "");
            OleDbDataAdapter da = new OleDbDataAdapter(sqlquery, con);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
