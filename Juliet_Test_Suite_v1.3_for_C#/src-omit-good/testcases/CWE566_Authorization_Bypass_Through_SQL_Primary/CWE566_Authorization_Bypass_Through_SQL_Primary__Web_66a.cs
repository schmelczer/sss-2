/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE566_Authorization_Bypass_Through_SQL_Primary__Web_66a.cs
Label Definition File: CWE566_Authorization_Bypass_Through_SQL_Primary__Web.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 566 Authorization Bypass through SQL primary
 * BadSource:  user id taken from url parameter
 * GoodSource: hardcoded user id
 * Sinks: writeConsole
 *    BadSink : user authorization not checked
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE566_Authorization_Bypass_Through_SQL_Primary
{

class CWE566_Authorization_Bypass_Through_SQL_Primary__Web_66a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override  void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FLAW: Get the user ID from a URL parameter */
        data = req.Params.Get("id");
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE566_Authorization_Bypass_Through_SQL_Primary__Web_66b.BadSink(dataArray , req, resp );
    }
#endif //omitbad

}
}
