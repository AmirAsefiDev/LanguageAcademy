
using System.Data;


     public class PayTypeBusiness
     {

	public int Insert(PayType  objPayType) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataInsertPayType(  objPayType.ID , objPayType.PaymentType , objPayType.Description );
	}


	public int Update(PayType  objPayType) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataUpdatePayType(  objPayType.ID , objPayType.PaymentType , objPayType.Description );
	}


	public int Delete(PayType  objPayType) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataDeletePayType( objPayType.ID );
	}


	public  DataTable Details(PayType  objPayType) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataDetailsPayType( objPayType.ID );
	}


	public  int DeleteByField(string FieldName,string  value) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataDeleteByFieldPayType(FieldName,value);
	}

	public  DataTable GetList( ) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataGetListPayType();
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		PayTypeData  objData = new PayTypeData();
		return  objData.DataDetailsByFieldPayType(FieldName,value);
	}

     }// End Class

