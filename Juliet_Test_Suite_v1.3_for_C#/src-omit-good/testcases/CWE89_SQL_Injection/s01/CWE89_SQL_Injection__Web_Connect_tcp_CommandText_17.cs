/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Connect_tcp_CommandText_17.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 89 SQL Injection
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded string
* Sinks: CommandText
*    GoodSink: Use prepared statement and concatenate CommandText (properly)
*    BadSink : data concatenated into SQL statement used in CommandText, which could result in SQL Injection
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Data;
using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE89_SQL_Injection
{
class CWE89_SQL_Injection__Web_Connect_tcp_CommandText_17 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        data = ""; /* Initialize data */
        /* Read data using an outbound tcp connection */
        {
            try
            {
                /* Read data using an outbound tcp connection */
                using (TcpClient tcpConn = new TcpClient("host.example.org", 39544))
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read data using an outbound tcp connection */
                        data = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        for (int j = 0; j < 1; j++)
        {
            if (data != null)
            {
                string[] names = data.Split('-');
                int successCount = 0;
                SqlCommand badSqlCommand = null;
                try
                {
                    using (SqlConnection dbConnection = IO.GetDBConnection())
                    {
                        badSqlCommand.Connection = dbConnection;
                        dbConnection.Open();
                        for (int i = 0; i < names.Length; i++)
                        {
                            /* POTENTIAL FLAW: data concatenated into SQL statement used in CommandText, which could result in SQL Injection */
                            badSqlCommand.CommandText += "update users set hitcount=hitcount+1 where name='" + names[i] + "';";
                        }
                        var affectedRows = badSqlCommand.ExecuteNonQuery();
                        successCount += affectedRows;
                        IO.WriteLine("Succeeded in " + successCount + " out of " + names.Length + " queries.");
                    }
                }
                catch (SqlException exceptSql)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error getting database connection", exceptSql);
                }
                finally
                {
                    try
                    {
                        if (badSqlCommand != null)
                        {
                            badSqlCommand.Dispose();
                        }
                    }
                    catch (SqlException exceptSql)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, "Error disposing SqlCommand", exceptSql);
                    }
                }
            }
        }
    }
#endif //omitbad

}
}
