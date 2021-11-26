/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Database_51a.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * BadSink: ErrorStatusCode XSS in StatusCode
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Database_51a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
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
        CWE81_XSS_Error_Message__Web_Database_51b.BadSink(data , req, resp );
    }
#endif //omitbad

}
}
