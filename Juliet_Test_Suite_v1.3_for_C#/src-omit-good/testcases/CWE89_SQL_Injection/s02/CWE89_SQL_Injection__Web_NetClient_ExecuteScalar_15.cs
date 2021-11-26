/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_NetClient_ExecuteScalar_15.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 89 SQL Injection
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* Sinks: ExecuteScalar
*    GoodSink: Use prepared statement and ExecuteScalar() (properly)
*    BadSink : data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection
* Flow Variant: 15 Control flow: switch(6) and switch(7)
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
class CWE89_SQL_Injection__Web_NetClient_ExecuteScalar_15 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        switch (6)
        {
        case 6:
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
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            try
            {
                using (SqlConnection dbConnection = IO.GetDBConnection())
                {
                    dbConnection.Open();
                    using (SqlCommand badSqlCommand = new SqlCommand(null, dbConnection))
                    {
                        /* POTENTIAL FLAW: data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection */
                        badSqlCommand.CommandText = "select * from users where name='" +data+"'";
                        object firstCol = badSqlCommand.ExecuteScalar();
                        if (firstCol != null)
                        {
                            IO.WriteLine(firstCol.ToString()); /* Use ResultSet in some way */
                        }
                    }
                }
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error getting database connection", exceptSql);
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
