
using System.Data;


     public class CourseSelectBusiness
     {

	public int Insert(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataInsertCourseSelect(  objCourseSelect.ID , objCourseSelect.ActivityScore , objCourseSelect.FinalScore , objCourseSelect.AttendScore , objCourseSelect.ID_FK_CourseGroup , objCourseSelect.ID_FK_Student );
	}


	public int Update(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataUpdateCourseSelect(  objCourseSelect.ID , objCourseSelect.ActivityScore , objCourseSelect.FinalScore , objCourseSelect.AttendScore , objCourseSelect.ID_FK_CourseGroup , objCourseSelect.ID_FK_Student );
	}


	public int Delete(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDeleteCourseSelect( objCourseSelect.ID );
	}


	public  DataTable Details(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDetailsCourseSelect( objCourseSelect.ID );
	}


	public  int DeleteByField(string FieldName,string  value) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDeleteByFieldCourseSelect(FieldName,value);
	}

	public  DataTable GetList( ) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataGetListCourseSelect();
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDetailsByFieldCourseSelect(FieldName,value);
	}

     }// End Class

