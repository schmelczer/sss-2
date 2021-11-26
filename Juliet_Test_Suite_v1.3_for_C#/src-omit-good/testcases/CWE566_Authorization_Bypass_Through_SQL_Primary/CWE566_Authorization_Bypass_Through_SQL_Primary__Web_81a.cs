/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE566_Authorization_Bypass_Through_SQL_Primary__Web_81a.cs
Label Definition File: CWE566_Authorization_Bypass_Through_SQL_Primary__Web.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 566 Authorization Bypass through SQL primary
 * BadSource:  user id taken from url parameter
 * GoodSource: hardcoded user id
 * Sinks: writeConsole
 *    BadSink : user authorization not checked
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE566_Authorization_Bypass_Through_SQL_Primary
{

class CWE566_Authorization_Bypass_Through_SQL_Primary__Web_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FLAW: Get the user ID from a URL parameter */
        data = req.Params.Get("id");
        CWE566_Authorization_Bypass_Through_SQL_Primary__Web_81_base baseObject = new CWE566_Authorization_Bypass_Through_SQL_Primary__Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
