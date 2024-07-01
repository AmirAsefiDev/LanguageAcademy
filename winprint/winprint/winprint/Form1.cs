using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace winprint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "علی", "محمد");
            dataGridView1.Rows.Add("2", "محمد", "حسن");
            dataGridView1.Rows.Add("3", "حسن", "امیر");
            dataGridView1.Rows.Add("4", "عباس", "احمد");
            dataGridView1.Rows.Add("5", "امیر", "علی");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(dataGridView1));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Columns.Count-1; i >=0 ; --i)
                dataGridView2.Columns.Add(i.ToString(),dataGridView1.Columns[i].HeaderText);           
            int index = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
          
                DataGridViewRow row = new DataGridViewRow();
                row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                index = 0;
                for (int i = dataGridView1.Columns.Count - 1; i >= 0; --i)
                {
                    row.Cells[index].Value = dr.Cells[i].Value;
                    index++;
                }
              
                dataGridView2.Rows.Add(row);
            }
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Refresh();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = (DataGridViewRow)dataGridView1 .Rows[i].Clone();
                int intColIndex = dataGridView2.Columns.Count - 1; int ind = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    row.Cells[ind].Value = dataGridView1.Rows[i].Cells[intColIndex];
                    intColIndex--; ind++;
                }
                dataGridView2.Rows.Add(row);
            }
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Refresh();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                PrintDGV.Print_DataGridView(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                DataGridViewRow GridRow=dataGridView1.Rows[i];
                if (GridRow.Selected)
                {
                 
                    MessageBox.Show(i.ToString());
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Export_To_Word we = new Export_To_Word();
            we.Export_DataGridView_To_Word(dataGridView1, "عنوان گزارش", "FileName.docx");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ردیف", typeof(int));
            table.Columns.Add("نام", typeof(string));
            table.Columns.Add("فامیلی", typeof(string));
            table.Columns.Add("تاریخ", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(1, "رحیم", "لطفی", DateTime.Now);
            table.Rows.Add(2, "محمد", "امینی", DateTime.Now);
            table.Rows.Add(3, "علی","عباسی", DateTime.Now);
            table.Rows.Add(4, "عباس", "محسنی", DateTime.Now);
            table.Rows.Add(5, "حسن", "محمدی", DateTime.Now);
           

            //_________________________________________________

            Export_To_Word we = new Export_To_Word();
            we.Export_DataTable_To_Word(table,"عنوان گزارش", "FileNamesxss.docx");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ردیف", typeof(int));
            table.Columns.Add("نام", typeof(string));
            table.Columns.Add("فامیلی", typeof(string));
            table.Columns.Add("تاریخ", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(1, "رحیم", "لطفی", DateTime.Now);
            table.Rows.Add(2, "محمد", "امینی", DateTime.Now);
            table.Rows.Add(3, "علی", "عباسی", DateTime.Now);
            table.Rows.Add(4, "عباس", "محسنی", DateTime.Now);
            table.Rows.Add(5, "حسن", "محمدی", DateTime.Now);

            Export_To_Excel op = new Export_To_Excel();
            op.WriteToExcel(table,"d:\\TEXT.xls");
            //ex.ExportToExcel(table);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                Export_To_Excel op = new Export_To_Excel();
                dataGridView2.DataSource = op.ImportExceltoDatatable(o.FileName, "Sheet1");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Export_To_Excel op = new Export_To_Excel();
            op.WriteToExcel(dataGridView1, "d:\\TEXT.xls");
        }
    }
}
