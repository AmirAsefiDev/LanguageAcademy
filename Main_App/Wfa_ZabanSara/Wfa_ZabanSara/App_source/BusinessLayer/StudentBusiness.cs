
using System.Data;


public class StudentBusiness
{

    public int Insert(Student objStudent)
    {
        StudentData objData = new();
        return objData.DataInsertStudent(objStudent.ID, objStudent.NationalCode, objStudent.Name, objStudent.LastName, objStudent.ID_FK_Degree, objStudent.Sex, objStudent.DateofBirth, objStudent.Address, objStudent.Phone, objStudent.Image);
    }


    public int Update(Student objStudent)
    {
        StudentData objData = new StudentData();
        return objData.DataUpdateStudent(objStudent.ID, objStudent.NationalCode, objStudent.Name, objStudent.LastName, objStudent.ID_FK_Degree, objStudent.Sex, objStudent.DateofBirth, objStudent.Address, objStudent.Phone, objStudent.Image);
    }


    public int Delete(Student objStudent)
    {
        StudentData objData = new StudentData();
        return objData.DataDeleteStudent(objStudent.ID);
    }


    public DataTable Details(Student objStudent)
    {
        StudentData objData = new StudentData();
        return objData.DataDetailsStudent(objStudent.ID);
    }


    public int DeleteByField(string FieldName, string value)
    {
        StudentData objData = new StudentData();
        return objData.DataDeleteByFieldStudent(FieldName, value);
    }

    public DataTable GetList()
    {
        StudentData objData = new StudentData();
        return objData.DataGetListStudent();
    }

    public DataTable DetailsByField(string FieldName, string value)
    {
        StudentData objData = new StudentData();
        return objData.DataDetailsByFieldStudent(FieldName, value);
    }

}// End Class

