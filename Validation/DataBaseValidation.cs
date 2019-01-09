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
                ServiceController[] services = ServiceController.GetServices();
                foreach (ServiceController service in services)
                {
                    if (service.ServiceName.Contains("SQLSERVERAGENT"))
                    {
                        if (service.Status == ServiceControllerStatus.Running)
                            return true;
                        else
                            return false;
                    }
                }
                return false;

            }
            public static bool CheckAvalibleServiceSqlBrowserSqlServer()
            {
                ServiceController[] services = ServiceController.GetServices();
                foreach (ServiceController service in services)
                {
                    if (service.ServiceName.Contains("SQLBrowser"))
                    {
                        if (service.Status == ServiceControllerStatus.Running)
                            return true;

                        return false;
                    }
                }
                return false;
            }
            public static bool CheckAvalibleServiceSqlWriterSqlServer()
            {
                ServiceController[] services = ServiceController.GetServices();
                foreach (ServiceController service in services)
                {
                    if (service.ServiceName.Contains("SQLWriter"))
                    {
                        if (service.Status == ServiceControllerStatus.Running)
                            return true;
                        else
                            return false;
                    }
                }
                return false;
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
            public static bool CheckStateConnection(this SqlConnection con, ConnectionState constate)
            {
                return con.State == constate;
            }
            public static bool CheckEmptyTable(this SqlConnection con, string tblName)
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from " + tblName + "";
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                    return true;
            }
            public static bool CheckServerConnectedSql(this string connectionString)
            {
                if (string.IsNullOrEmpty(connectionString)) { return false; }
                using (var lOConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        lOConnection.Open();
                        lOConnection.Close();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }

        }

    }
}
