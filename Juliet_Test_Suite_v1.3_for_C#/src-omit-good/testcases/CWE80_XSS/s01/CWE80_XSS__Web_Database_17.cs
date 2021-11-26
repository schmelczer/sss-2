/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_Database_17.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 80 Cross Site Scripting (XSS)
* BadSource: Database Read data from a database
* GoodSource: A hardcoded string
* BadSink: Web Display of data in web page without any encoding or validation
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_Database_17 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
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
        for (int i = 0; i < 1; i++)
        {
            if (data != null)
            {
                /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
                resp.Write("<br>Bad(): data = " + data);
            }
        }
    }
#endif //omitbad

}
}
