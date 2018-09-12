using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.Services;
using TotalStaffingSolutions.Controllers;

namespace TotalStaffingSolutions
{
    /// <summary>
    /// Summary description for TSSWebServices
    /// </summary>
    [WebService(Namespace = "http://tss.viretechnologies.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TSSWebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable UpdateCustomersData()
        {
            DataTable dt = new DataTable();
            try
            {

                using (OdbcConnection conn = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBC;SourceDB=C:\\Users\\sazhar\\Desktop\\WindowsService1\\Employees_and_Customers tables\\QFS\\ULTRA.DBC;Exclusive=No;NULL=NO;Collate=Machine;BACKGROUNDFETCH=NO;DELETED=NO;"))
                {
                    conn.Open();
                    OdbcDataAdapter da = new OdbcDataAdapter("SELECT * from Cusmast", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return dt;
        }

        [WebMethod]
        public DataTable UpdateCustomerContacts()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conn = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBC;SourceDB=C:\\Users\\sazhar\\Desktop\\WindowsService1\\Employees_and_Customers tables\\QFS\\ULTRA.DBC;Exclusive=No;NULL=NO;Collate=Machine;BACKGROUNDFETCH=NO;DELETED=NO;"))
                {
                    conn.Open();
                    OdbcDataAdapter da = new OdbcDataAdapter("SELECT * from Cuscont", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return dt;
        }

        [WebMethod]
        public DataTable UpdateUsersData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conn = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBC;SourceDB=C:\\Users\\sazhar\\Desktop\\WindowsService1\\Employees_and_Customers tables\\QFS\\ULTRA.DBC;Exclusive=No;NULL=NO;Collate=Machine;BACKGROUNDFETCH=NO;DELETED=NO;"))
                {
                    conn.Open();
                    OdbcDataAdapter da = new OdbcDataAdapter("SELECT * from Empmast", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return dt;
        }
    }
}
