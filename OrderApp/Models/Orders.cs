using static System.Net.Mime.MediaTypeNames;

namespace OrderApp.Models
{
    public class Orders
    {
    public string ORDER_NO     {get;set;}
	public string ORDER_DATE   {get;set;}
	public string DEPT_CODE	   {get;set;}
	public string CUST_CODE	   {get;set;}
	public int CUST_SUB_NO	{get;set;}
	public string EMP_CODE	   {get;set;}
	public string REQUIRED_DATE{get;set;}
	public string CUSTORDER_NO	{get;set;}
	public string WH_CODE	   {get;set;}
	public int CMP_TAX	   {get;set;}
    public string SLIP_COMMENT { get; set; }
    public string UPDATE_DATE	{get;set;}
	public string UPDATER { get; set; }
    }
}
