/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_QueryString_Web_CommandText_68a.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: CommandText
 *    GoodSink: Use prepared statement and concatenate CommandText (properly)
 *    BadSink : data concatenated into SQL statement used in CommandText, which could result in SQL Injection
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Data;
using System.Web;


namespace testcases.CWE89_SQL_Injection
{
class CWE89_SQL_Injection__Web_QueryString_Web_CommandText_68a : AbstractTestCaseWeb
{

    public static string data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        CWE89_SQL_Injection__Web_QueryString_Web_CommandText_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
