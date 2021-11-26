/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_QueryString_Web_81a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_QueryString_Web_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        CWE601_Open_Redirect__Web_QueryString_Web_81_base baseObject = new CWE601_Open_Redirect__Web_QueryString_Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
