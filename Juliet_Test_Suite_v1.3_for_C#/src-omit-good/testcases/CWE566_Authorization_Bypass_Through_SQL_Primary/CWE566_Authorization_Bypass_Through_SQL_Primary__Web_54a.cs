/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54a.cs
Label Definition File: CWE566_Authorization_Bypass_Through_SQL_Primary__Web.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 566 Authorization Bypass through SQL primary
 * BadSource:  user id taken from url parameter
 * GoodSource: hardcoded user id
 * Sinks: writeConsole
 *    BadSink : user authorization not checked
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE566_Authorization_Bypass_Through_SQL_Primary
{

class CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FLAW: Get the user ID from a URL parameter */
        data = req.Params.Get("id");
        CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54b.BadSink(data , req, resp);
    }
#endif //omitbad

}
}
