/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_NetClient_ExecuteNonQuery_02.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 89 SQL Injection
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* Sinks: ExecuteNonQuery
*    GoodSink: Use prepared statement and ExecuteNonQuery (properly)
*    BadSink : data concatenated into SQL statement used in ExecuteNonQuery(), which could result in SQL Injection
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Data;
using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE89_SQL_Injection
{
class CWE89_SQL_Injection__Web_NetClient_ExecuteNonQuery_02 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (true)
        {
            data = ""; /* Initialize data */
            /* read input from WebClient */
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                        {
                            /* POTENTIAL FLAW: Read data from a web server with WebClient */
                            /* This will be reading the first "line" of the response body,
                            * which could be very long if there are no newlines in the HTML */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (true)
        {
            int? result = null;
            try
            {
                using (SqlConnection dbConnection = IO.GetDBConnection())
                {
                    dbConnection.Open();
                    using (SqlCommand badSqlCommand = new SqlCommand(null, dbConnection))
                    {
                        /* POTENTIAL FLAW: data concatenated into SQL statement used in ExecuteNonQuery(), which could result in SQL Injection */
                        badSqlCommand.CommandText = "insert into users (status) values ('updated') where name='" +data+"'";
                        result = badSqlCommand.ExecuteNonQuery();
                        if (result != null)
                        {
                            IO.WriteLine("Name, " + data +", updated successfully");
                        }
                        else
                        {
                            IO.WriteLine("Unable to update records for user: " + data);
                        }
                    }
                }
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error getting database connection", exceptSql);
            }
        }
    }
#endif //omitbad

}
}