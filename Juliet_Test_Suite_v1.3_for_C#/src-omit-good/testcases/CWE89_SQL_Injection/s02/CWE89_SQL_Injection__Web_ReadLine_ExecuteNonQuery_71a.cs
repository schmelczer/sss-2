/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_ReadLine_ExecuteNonQuery_71a.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: ExecuteNonQuery
 *    GoodSink: Use prepared statement and ExecuteNonQuery (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteNonQuery(), which could result in SQL Injection
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Data;
using System.Web;

using System.IO;

namespace testcases.CWE89_SQL_Injection
{
class CWE89_SQL_Injection__Web_ReadLine_ExecuteNonQuery_71a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        CWE89_SQL_Injection__Web_ReadLine_ExecuteNonQuery_71b.BadSink((Object)data , req, resp );
    }
#endif //omitbad

}
}
