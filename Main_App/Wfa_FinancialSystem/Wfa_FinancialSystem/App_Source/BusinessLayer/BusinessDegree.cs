using System.Data;
using Wfa_ZabanSara.App_source.DataLayer;
using Wfa_ZabanSara.App_source.DataObject;


namespace Wfa_ZabanSara.App_source.BusinessLayer
{
    class BusinessDegree
    {
        public DataTable GetList()
        {
            DataLayer.DegreeData ObjData = new DataLayer.DegreeData();
            return ObjData.GetListData();
        }

        public int Insert(Degree ObjData)
        {
            DegreeData d = new DegreeData();
            return d.insertData(ObjData.Title);
        }

        public int Update(Degree ObjData)
        {
            DegreeData d = new DegreeData();
            return d.UpdateData(ObjData.ID, ObjData.Title);
        }

        public void Delete(Degree ObjData)
        {
            DegreeData d = new DegreeData();
            d.DeleteData(ObjData.ID);
        }
    }
}
