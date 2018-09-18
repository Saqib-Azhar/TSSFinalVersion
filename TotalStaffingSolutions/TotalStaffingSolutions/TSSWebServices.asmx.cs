using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.Services;
using TotalStaffingSolutions.Controllers;
using TotalStaffingSolutions.Models;

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
        public List<Cusmast> UpdateCustomersData()
        {
            List<Cusmast> customerList = new List<Cusmast>();
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
                        var userobj = new Cusmast();
                        userobj.Cucname = dr["Cucname"].ToString();
                        userobj.Cuccustid = dr["Cuccustid"].ToString();
                        userobj.Cucaddr1 = dr["Cucaddr1"].ToString();
                        userobj.Cucaddr2 = dr["Cucaddr2"].ToString();
                        userobj.Cuccity = dr["Cuccity"].ToString();
                        userobj.Cucstate = dr["Cucstate"].ToString();
                        //userobj.CustomerAdded = DateTime.Now;
                        userobj.Cuczipcode = dr["Cuczipcode"].ToString();
                        userobj.Cuccountry = dr["Cuccountry"].ToString();
                        //userobj.Created_at = DateTime.Now;
                        userobj.Cucpono = dr["Cucpono"].ToString();
                        userobj.Cucstatus = dr["Cucstatus"].ToString();
                        customerList.Add(userobj);
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return customerList;
        }

        [WebMethod]
        public List<Customer_contact> UpdateCustomerContacts()
        {
            List<Customer_contact> customersContactsList = new List<Customer_contact>();
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
                        Customer_contact customerContactObj = new Customer_contact();
                        customerContactObj.Ccccontact = dr["Ccccontact"].ToString();
                        customerContactObj.Ccccontcde = dr["Ccccontcde"].ToString();
                        customerContactObj.Ccccontmsc = dr["Ccccontmsc"].ToString();
                        customerContactObj.Ccccuscont = dr["Ccccuscont"].ToString();
                        customerContactObj.Ccccusmast = dr["Ccccusmast"].ToString();
                        customerContactObj.Cccemail = dr["Cccemail"].ToString();
                        customerContactObj.Cccemlbody = dr["Cccemlbody"].ToString();
                        customerContactObj.Cccfname = dr["Cccfname"].ToString();
                        customerContactObj.Ccclname = dr["Ccclname"].ToString();
                        customerContactObj.Cccmname = dr["Cccmname"].ToString();
                        customerContactObj.Cccphone1 = dr["Cccphone1"].ToString();
                        customerContactObj.Cccphone2 = dr["Cccphone2"].ToString();
                        customerContactObj.Cccphone3 = dr["Cccphone3"].ToString();
                        customerContactObj.Cccsalcde = dr["Cccsalcde"].ToString();
                        customerContactObj.Ccmnotes = dr["Ccmnotes"].ToString();
                        customerContactObj.Customer_id = dr["CusmastCuccustid"].ToString();

                        customersContactsList.Add(customerContactObj);
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return customersContactsList;
        }

        [WebMethod]
        public List<Empmast> UpdateUsersData()
        {
            DataTable dt = new DataTable();
            List<Empmast> list = new List<Empmast>();
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
                        Empmast employeeObj = new Empmast();

                        employeeObj.Emcempid = dr["Emcempid"].ToString();
                        employeeObj.Emcfname = dr["Emcfname"].ToString();
                        employeeObj.Emclname = dr["Emclname"].ToString();
                        employeeObj.Emcmname = dr["Emcmname"].ToString();
                        //employeeObj.Created_at = DateTime.Now"].ToString();
                        employeeObj.Emcaddr1 = dr["Emcaddr1"].ToString();
                        employeeObj.Emcaddr2 = dr["Emcaddr2"].ToString();
                        employeeObj.Emccity = dr["Emccity"].ToString();
                        employeeObj.Emcstate = dr["Emcstate"].ToString();
                        employeeObj.Emczipcode = dr["Emczipcode"].ToString();
                        employeeObj.Emccountry = dr["Emccountry"].ToString();
                        employeeObj.Emcmarital = dr["Emcmarital"].ToString();
                        employeeObj.Emcsex = dr["Emcsex"].ToString();
                        employeeObj.Emtbirth = Convert.ToDateTime(dr["Emtbirth"]);
                        employeeObj.Emthire = Convert.ToDateTime(dr["Emthire"]);
                        employeeObj.Emtrehire = Convert.ToDateTime(dr["Emtrehire"]);
                        employeeObj.Emcemptype = Convert.ToString(dr["Emcemptype"]);
                        //employeeObj.Updated_at = DateTime.Now;
                        list.Add(employeeObj);
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionHandlerController.infoMessage(ex.Message);
                ExceptionHandlerController.writeErrorLog(ex);
            }
            return list;
        }
    }
}
