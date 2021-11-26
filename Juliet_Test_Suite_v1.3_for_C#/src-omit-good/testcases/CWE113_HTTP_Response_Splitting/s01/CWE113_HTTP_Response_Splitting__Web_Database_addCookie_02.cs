/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Database_addCookie_02.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: Database Read data from a database
* GoodSource: A hardcoded string
* Sinks: addCookie
*    GoodSink: URLEncode input
*    BadSink : querystring to AppendCookie()
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.Data.SqlClient;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Database_addCookie_02 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (true)
        {
            data = ""; /* Initialize data */
            /* Read data from a database */
            {
                try
                {
                    /* setup the connection */
                    using (SqlConnection connection = IO.GetDBConnection())
                    {
                        connection.Open();
                        /* prepare and execute a (hardcoded) query */
                        using (SqlCommand command = new SqlCommand(null, connection))
                        {
                            command.CommandText = "select name from users where id=0";
                            command.Prepare();
                            using (SqlDataReader dr = command.ExecuteReader())
                            {
                                /* POTENTIAL FLAW: Read data from a database query SqlDataReader */
                                data = dr.GetString(1);
                            }
                        }
                    }
                }
                catch (SqlException exceptSql)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error with SQL statement");
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
            if (data != null)
            {
                HttpCookie cookieSink = new HttpCookie("lang", data);
                /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
                resp.AppendCookie(cookieSink);
            }
        }
    }
#endif //omitbad

}
}
