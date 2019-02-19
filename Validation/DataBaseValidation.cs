using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace Validation
{
    namespace DataBase
    {
        public static class DataBaseValidation
        {
            public static bool CheckAvalibleServiceAgentSqlServer()
            {
                try
                {
                    ServiceController[] services = ServiceController.GetServices();
                    foreach (ServiceController service in services)
                    {
                        if (service.ServiceName.Contains("SQLSERVERAGENT"))
                        {
                            if (service.Status == ServiceControllerStatus.Running)
                                return true;
                            return false;
                        }
                    }
                    return false;
                }
                catch
                {
                    return false;
                }

            }
            public static bool CheckAvalibleServiceSqlWriterSqlServer()
            {
                try
                {
                    ServiceController[] services = ServiceController.GetServices();
                    foreach (ServiceController service in services)
                    {
                        if (service.ServiceName.Contains("SQLWriter"))
                        {
                            if (service.Status == ServiceControllerStatus.Running)
                                return true;
                            return false;
                        }
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public static bool CheckExistsTable(this SqlConnection con, string tblName)
            {
                if (con.State != ConnectionState.Open)
                {
                    return false;
                }
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd.Connection = con;
                cmd.CommandText = " SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME ='" + tblName + "'";
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            public static bool CheckEmptyTable(this SqlConnection con, string tblName)
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select count(*) from " + tblName + ""
                };
                if (con.State != ConnectionState.Open) con.Open();

                int cnt =(int)cmd.ExecuteScalar();

                if (con.State != ConnectionState.Closed) con.Close();
                if (cnt > 0)
                {
                    return false; 
                }

                return true; 

            }
        }

    }
}
