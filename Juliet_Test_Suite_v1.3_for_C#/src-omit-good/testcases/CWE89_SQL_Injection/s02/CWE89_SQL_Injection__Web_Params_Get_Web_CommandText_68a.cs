/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Params_Get_Web_CommandText_68a.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
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
class CWE89_SQL_Injection__Web_Params_Get_Web_CommandText_68a : AbstractTestCaseWeb
{

    public static string data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE89_SQL_Injection__Web_Params_Get_Web_CommandText_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
