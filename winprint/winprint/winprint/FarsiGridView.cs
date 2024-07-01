using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace winprint
{
    public class FarsiGridView
    {

        public static DataGridView reverse_DataGridView(DataGridView DgvSource)
        {
            DataGridView DGV = new DataGridView();

            Boolean bselect;

            for (int i = DgvSource.Columns.Count - 1; i >= 0; --i)
            {

                DGV.Columns.Add(i.ToString(), DgvSource.Columns[i].HeaderText);
                DGV.Columns[i.ToString()].Visible = DgvSource.Columns[i].Visible;
            }
            int index = 0;
            foreach (DataGridViewRow dr in DgvSource.Rows)
            {

                DataGridViewRow row = new DataGridViewRow();
                row = (DataGridViewRow)DGV.Rows[0].Clone();
                bselect = dr.Selected;
                index = 0;
                for (int i = DgvSource.Columns.Count - 1; i >= 0; --i)
                {
                    row.Cells[index].Value = dr.Cells[i].Value;

                    index++;
                }



                DGV.Rows.Add(row);

                if (bselect)
                {
                    DGV.Rows[DGV.RowCount - 2].Selected = true;

                }

            }
            DGV.AllowUserToAddRows = false;
            DGV.Refresh();





            return DGV;
        }

        public static string GetPertionDate()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return pc.GetYear(DateTime.Now) + " / " + pc.GetMonth(DateTime.Now) + " / " + pc.GetDayOfMonth(DateTime.Now);
        }

    }
}
